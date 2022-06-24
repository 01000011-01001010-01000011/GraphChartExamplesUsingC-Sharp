using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementPro
{
    public partial class frmGanttChart : Form
    {



        GanttChart newGanttChart = new GanttChart();

        List<string> columnDetailNames = new List<string>();
        List<string> monthsOfYear = new List<string>();
        List<string> daysOfTheWeek = new List<string>();


        public frmGanttChart()
        {
            InitializeComponent();

            columnDetailNames = newGanttChart.GetProjectDetailsColumnNames();

            monthsOfYear = newGanttChart.GetMonths();

            daysOfTheWeek = newGanttChart.GetDays();

            dgvProjectDetails.RowHeadersVisible = false;
            dgvGanttChart.RowHeadersVisible = false;

        }

        private void FrmGanttChart_Load(object sender, EventArgs e)
        {

            LoadProjectDetails();
            LoadCalendar();

            // GetProjectData();
            // LoadDataIntoGrid();

           // string day = newGanttChart.GetStartDayForCalendar();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Closes the form

            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        
        private void LoadProjectDetails()
        {
            // Loads the datagridview with the column names

            dgvProjectDetails.ColumnCount = columnDetailNames.Count;

            for (int i = 0; i < columnDetailNames.Count; i++)
            {

                dgvProjectDetails.Columns[i].Name = columnDetailNames[i].ToString();
                 
            }
                        
            dgvProjectDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgvProjectDetails.Rows[0].Cells[0].Value = "Number";
            dgvProjectDetails.Rows[0].Cells[1].Value = "Phase";
            dgvProjectDetails.Rows[0].Cells[2].Value = "Status";
            dgvProjectDetails.Rows[0].Cells[3].Value = "Date";
            dgvProjectDetails.Rows[0].Cells[4].Value = "End Date";
            dgvProjectDetails.Rows[0].Cells[5].Value = "End Date";
            
        }

        private void LoadCalendar()
        {
            // Loads the datagridview column names

            dgvGanttChart.ColumnCount = daysOfTheWeek.Count;

            for(int i = 0; i < monthsOfYear.Count; i++)
            {

                dgvGanttChart.Columns[i].Name = monthsOfYear[i].ToString();
                
            }

            for (int j = 0; j < daysOfTheWeek.Count; j++)
            {

                dgvGanttChart.Rows[0].Cells[j].Value = daysOfTheWeek[j].ToString();

            }

            dgvGanttChart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvGanttChart.RowCount = dgvGanttChart.Rows.Count;

        }

    }
    
}
