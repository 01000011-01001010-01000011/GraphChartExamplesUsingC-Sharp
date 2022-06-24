// Created by Christopher Clarke
// Copyright CJCSoft

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectManagementPro
{
    public partial class GraphForm : Form
    {
        int resourcesCount;

        int tasksCount;

        string strChartName;

        CompleteProjectDetails projectToAnalyze = new CompleteProjectDetails();

        ProjectAnalysis currentProject = new ProjectAnalysis();

        public GraphForm(ProjectAnalysis projectAnalysis, CompleteProjectDetails completeProject)
        {

            InitializeComponent();

            strChartName = projectAnalysis.ProjectNumber.ToUpper();

            lblTitle.Text = "PROJECT NUMBER: " + projectAnalysis.ProjectNumber.ToUpper();

            lblName.Text = "PROJECT NAME: " + projectAnalysis.ProjectName.ToUpper();

            currentProject = projectAnalysis;

            projectToAnalyze = completeProject;

            FillInPieCharts();
            FillInResourcesLineChart();
            FillInTasksLineCharts();

        }

        // *** BUTTONS ***

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        // *** END OF BUTTONS ***

        // *** VOID PROCEDURES ***

        private void FillInPieCharts()
        {
            // Fills in the pie chart

            resourcesCount = currentProject.ResourcesRequired;
            tasksCount = currentProject.TasksRequired;

            double dblResourcesRequired = currentProject.ResourcesRequired * 100;
            double dblResourcesAcquired = ((currentProject.ResourcesRequired - currentProject.ResourcesNeeded) * 100) / 2; //currentProject.ResourcesAcquired * 100) / 2;
            double dblResourcesNeeded = ((currentProject.ResourcesRequired - currentProject.ResourcesAcquired) * 100) / 2; //(currentProject.ResourcesNeeded * 100) / 2;

            double dblTasksRequired = currentProject.TasksRequired * 100;
            double dblTasksCompleted = ((currentProject.TasksRequired - currentProject.TasksNeeded) * 100) / 2; //(currentProject.TasksCompleted * 100) / 2;
            double dblTasksNeeded = ((currentProject.TasksRequired - currentProject.TasksCompleted) * 100) / 2; //(currentProject.TasksNeeded * 100) / 2;
            
            // Series

            string name = strChartName;

            //Series chartSeries = new Series("Project: " + strChartName);

            //pieChart.Series[0].Points.AddXY("Resources Required", dblResourcesRequired);
            pieChartResources.Series[0].Points.AddXY("Resources Acquired", dblResourcesAcquired);
            pieChartResources.Series[0].Points.AddXY("Resources Needed", dblResourcesNeeded);
            //pieChart.Series[0].Points.AddXY("Tasks Required", dblTasksRequired);
            pieChartTasks.Series[0].Points.AddXY("Tasks Completed", dblTasksCompleted);
            pieChartTasks.Series[0].Points.AddXY("Tasks Needed", dblTasksNeeded);

            //pieChart.Series.Add(chartSeries);

            pieChartResources.ChartAreas[0].Area3DStyle.Enable3D = true;

            pieChartTasks.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

        private void FillInResourcesLineChart()
        {
            // Fills in the resources line chart data                   

            bool boolArrived = false;

            double dblEstimatedDaysToReceive = 0;
            double dblActualDaysToReceive = 0;
            double dblDaysOverdue = 0;

            string resourceName = "";

            DateTime orderedDate, estimatedArrivalDate, actualArrivalDate;

            stackedBarChartResources.Titles.Add("Amount Of Time To Receive Resources");

            if (projectToAnalyze.ProjectResources != null && projectToAnalyze.ProjectResources.Count > 0)
            {

                double[] dblMaximumDays = new double[projectToAnalyze.ProjectResources.Count];

                // Set the minimum days to display on the graph 
                stackedBarChartResources.ChartAreas["ChartArea1"].AxisY.Minimum = 0;

                for (int i = 0; i < projectToAnalyze.ProjectResources.Count; i++)
                {                                

                    resourceName = projectToAnalyze.ProjectResources[i].Description.ToString().ToUpper();

                    orderedDate = projectToAnalyze.ProjectResources[i].OrderDate;

                    estimatedArrivalDate = projectToAnalyze.ProjectResources[i].ETADate;

                    actualArrivalDate = projectToAnalyze.ProjectResources[i].DateReceived;

                    dblEstimatedDaysToReceive = Math.Round((estimatedArrivalDate - orderedDate).TotalDays);

                    //dblActualTimeToReceive = Math.Round((completedTime - startTime).TotalDays);

                    // Check for the greatest arrival date
                    if (actualArrivalDate != null)
                    {                                               

                        dblActualDaysToReceive = Math.Round((actualArrivalDate - orderedDate).TotalDays);

                        boolArrived = true;

                    }                    
                                       
                    if(boolArrived)
                    {

                        if (actualArrivalDate > estimatedArrivalDate)
                        {

                            dblDaysOverdue = dblActualDaysToReceive - dblEstimatedDaysToReceive;

                            dblMaximumDays[i] = dblActualDaysToReceive;

                        }
                        else
                        {

                            dblDaysOverdue = 0;

                            dblMaximumDays[i] = 0;

                        }

                    }
                    else
                    {

                        dblDaysOverdue = 0;

                        dblMaximumDays[i] = dblEstimatedDaysToReceive;

                    }

                    stackedBarChartResources.Series["Days To Receive"].Points.AddXY(resourceName, dblEstimatedDaysToReceive);  //AddXY(resourceName, dblEstimatedDaysToReceive);
                    
                    stackedBarChartResources.Series["Days Overdue"].Points.AddXY(resourceName, dblDaysOverdue);  //AddXY("", dblDaysOverdue);

                    //  if (dblDaysOverdue > 0)
                    //{



                    //}
                    //else
                    //{

                    //stackedBarChartResources.Series["Days Overdue"].Points.AddXY(resourceName, 0);

                    //}

                }

                // Set the maximum days to display on the graph
                stackedBarChartResources.ChartAreas["ChartArea1"].AxisX.Maximum = GetMaximumDays(dblMaximumDays) + 5;
                
            }

        }

        private void FillInTasksLineCharts()
        {
            // Fills in the tasks line chart data

            double dblEstimatedTimeToComplete = 0;
            double dblActualTimeToComplete = 0;

            string taskName = "";

            DateTime startTime, estimatedCompletionTime, completedTime;

            if (projectToAnalyze.ProjectTasks != null && projectToAnalyze.ProjectTasks.Count > 0)
            {

                for (int i = 0; i < projectToAnalyze.ProjectTasks.Count; i++)
                {

                    taskName = projectToAnalyze.ProjectTasks[i].Task.ToString().ToUpper();

                    startTime = projectToAnalyze.ProjectTasks[i].TaskStarted;
                    estimatedCompletionTime = projectToAnalyze.ProjectTasks[i].ETTC;
                    completedTime = projectToAnalyze.ProjectTasks[i].DateTaskCompleted;

                    dblEstimatedTimeToComplete = Math.Round((estimatedCompletionTime - startTime).TotalDays);
                    dblActualTimeToComplete = Math.Round((completedTime - startTime).TotalDays);

                    stackedBarChartTasks.ChartAreas[0].AxisY.Minimum = 0;

                    if (dblActualTimeToComplete > 0)
                    {

                        stackedBarChartTasks.ChartAreas[0].AxisY.Maximum = Math.Round(dblActualTimeToComplete + 10);

                    }
                    else
                    {

                        stackedBarChartTasks.ChartAreas[0].AxisY.Maximum = Math.Round(dblEstimatedTimeToComplete + 10);

                    }


                    stackedBarChartTasks.Series["Series1"].Points.AddXY(taskName, dblEstimatedTimeToComplete);

                }

                

            }

        }

        private double GetMaximumDays(double[] numResourcesToSearch)
        {
            // Returns the maximum number of days to graph

            double dblMaximumDays = numResourcesToSearch.Max();

            return dblMaximumDays;
            
        }

    }

}
