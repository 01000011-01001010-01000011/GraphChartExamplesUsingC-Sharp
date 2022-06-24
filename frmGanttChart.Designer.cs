namespace ProjectManagementPro
{
    partial class frmGanttChart
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
            this.dgvGanttChart = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGanttChart
            // 
            this.dgvGanttChart.AllowUserToAddRows = false;
            this.dgvGanttChart.AllowUserToDeleteRows = false;
            this.dgvGanttChart.AllowUserToResizeColumns = false;
            this.dgvGanttChart.AllowUserToResizeRows = false;
            this.dgvGanttChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanttChart.Location = new System.Drawing.Point(414, 65);
            this.dgvGanttChart.MultiSelect = false;
            this.dgvGanttChart.Name = "dgvGanttChart";
            this.dgvGanttChart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGanttChart.Size = new System.Drawing.Size(2138, 780);
            this.dgvGanttChart.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::ProjectManagementPro.Properties.Resources.Magnifying_Small;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(343, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvProjectDetails
            // 
            this.dgvProjectDetails.AllowUserToAddRows = false;
            this.dgvProjectDetails.AllowUserToDeleteRows = false;
            this.dgvProjectDetails.AllowUserToResizeColumns = false;
            this.dgvProjectDetails.AllowUserToResizeRows = false;
            this.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDetails.Location = new System.Drawing.Point(12, 65);
            this.dgvProjectDetails.MultiSelect = false;
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDetails.Size = new System.Drawing.Size(404, 780);
            this.dgvProjectDetails.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(392, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmGanttChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 917);
            this.Controls.Add(this.dgvProjectDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvGanttChart);
            this.Name = "frmGanttChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJECT OVERVIEW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGanttChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGanttChart;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.Button btnClose;
    }
}