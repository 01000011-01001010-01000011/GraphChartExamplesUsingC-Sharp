namespace ProjectManagementPro
{
    partial class frmGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pieChartResources = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblName = new System.Windows.Forms.Label();
            this.stackedBarChartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStripGraph = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackedBarChartResources = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackedBarChartTasks)).BeginInit();
            this.menuStripGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackedBarChartResources)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 19);
            this.lblTitle.TabIndex = 0;
            // 
            // pieChartResources
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartResources.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartResources.Legends.Add(legend1);
            this.pieChartResources.Location = new System.Drawing.Point(16, 60);
            this.pieChartResources.Name = "pieChartResources";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartResources.Series.Add(series1);
            this.pieChartResources.Size = new System.Drawing.Size(505, 328);
            this.pieChartResources.TabIndex = 1;
            // 
            // pieChartTasks
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChartTasks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChartTasks.Legends.Add(legend2);
            this.pieChartTasks.Location = new System.Drawing.Point(567, 60);
            this.pieChartTasks.Name = "pieChartTasks";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChartTasks.Series.Add(series2);
            this.pieChartTasks.Size = new System.Drawing.Size(505, 328);
            this.pieChartTasks.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(563, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 19);
            this.lblName.TabIndex = 3;
            // 
            // stackedBarChartTasks
            // 
            chartArea3.Name = "ChartArea1";
            this.stackedBarChartTasks.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.stackedBarChartTasks.Legends.Add(legend3);
            this.stackedBarChartTasks.Location = new System.Drawing.Point(15, 687);
            this.stackedBarChartTasks.Name = "stackedBarChartTasks";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.stackedBarChartTasks.Series.Add(series3);
            this.stackedBarChartTasks.Series.Add(series4);
            this.stackedBarChartTasks.Size = new System.Drawing.Size(1457, 296);
            this.stackedBarChartTasks.TabIndex = 4;
            this.stackedBarChartTasks.Text = "Task Progress";
            // 
            // menuStripGraph
            // 
            this.menuStripGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripGraph.Location = new System.Drawing.Point(0, 0);
            this.menuStripGraph.Name = "menuStripGraph";
            this.menuStripGraph.Size = new System.Drawing.Size(1492, 24);
            this.menuStripGraph.TabIndex = 5;
            this.menuStripGraph.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // stackedBarChartResources
            // 
            chartArea4.Name = "ChartArea1";
            this.stackedBarChartResources.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.stackedBarChartResources.Legends.Add(legend4);
            this.stackedBarChartResources.Location = new System.Drawing.Point(16, 394);
            this.stackedBarChartResources.Name = "stackedBarChartResources";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series5.Legend = "Legend1";
            series5.Name = "Days To Receive";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series6.Legend = "Legend1";
            series6.Name = "Days Overdue";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.stackedBarChartResources.Series.Add(series5);
            this.stackedBarChartResources.Series.Add(series6);
            this.stackedBarChartResources.Size = new System.Drawing.Size(1456, 287);
            this.stackedBarChartResources.TabIndex = 6;
            this.stackedBarChartResources.Text = "Resource Acquisition Time";
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1492, 1006);
            this.Controls.Add(this.stackedBarChartResources);
            this.Controls.Add(this.stackedBarChartTasks);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pieChartTasks);
            this.Controls.Add(this.pieChartResources);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStripGraph);
            this.MainMenuStrip = this.menuStripGraph;
            this.Name = "frmGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pieChartResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackedBarChartTasks)).EndInit();
            this.menuStripGraph.ResumeLayout(false);
            this.menuStripGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackedBarChartResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartResources;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartTasks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataVisualization.Charting.Chart stackedBarChartTasks;
        private System.Windows.Forms.MenuStrip menuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart stackedBarChartResources;
    }
}