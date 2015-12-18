namespace TrainPlan
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.currentMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.plan_trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StaffDataSet = new TrainPlan.StaffDataSet();
            this.plan_locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_trainerTableAdapter = new TrainPlan.StaffDataSetTableAdapters.plan_trainerTableAdapter();
            this.plan_locationTableAdapter = new TrainPlan.StaffDataSetTableAdapters.plan_locationTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.reportViewer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(893, 426);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(893, 475);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.plan_trainerBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.plan_locationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrainPlan.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshReportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.currentMonthToolStripMenuItem,
            this.nextMonthToolStripMenuItem,
            this.previousMonthToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // refreshReportToolStripMenuItem
            // 
            this.refreshReportToolStripMenuItem.Name = "refreshReportToolStripMenuItem";
            this.refreshReportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.refreshReportToolStripMenuItem.Text = "&Refresh Report";
            this.refreshReportToolStripMenuItem.Click += new System.EventHandler(this.dtp_change);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // currentMonthToolStripMenuItem
            // 
            this.currentMonthToolStripMenuItem.Name = "currentMonthToolStripMenuItem";
            this.currentMonthToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.currentMonthToolStripMenuItem.Text = "&Current Month";
            this.currentMonthToolStripMenuItem.Click += new System.EventHandler(this.currentMonthToolStripMenuItem_Click);
            // 
            // nextMonthToolStripMenuItem
            // 
            this.nextMonthToolStripMenuItem.Name = "nextMonthToolStripMenuItem";
            this.nextMonthToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nextMonthToolStripMenuItem.Text = "&Next Month";
            this.nextMonthToolStripMenuItem.Click += new System.EventHandler(this.nextMonthToolStripMenuItem_Click);
            // 
            // previousMonthToolStripMenuItem
            // 
            this.previousMonthToolStripMenuItem.Name = "previousMonthToolStripMenuItem";
            this.previousMonthToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.previousMonthToolStripMenuItem.Text = "&Previous Month";
            this.previousMonthToolStripMenuItem.Click += new System.EventHandler(this.previousMonthToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingCourseToolStripMenuItem,
            this.otherActivityToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "&Add";
            // 
            // trainingCourseToolStripMenuItem
            // 
            this.trainingCourseToolStripMenuItem.Name = "trainingCourseToolStripMenuItem";
            this.trainingCourseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.trainingCourseToolStripMenuItem.Text = "Training &Course";
            // 
            // otherActivityToolStripMenuItem
            // 
            this.otherActivityToolStripMenuItem.Name = "otherActivityToolStripMenuItem";
            this.otherActivityToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.otherActivityToolStripMenuItem.Text = "&Other Activity";
            this.otherActivityToolStripMenuItem.Click += new System.EventHandler(this.otherActivityToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // plan_trainerBindingSource
            // 
            this.plan_trainerBindingSource.DataMember = "plan_trainer";
            this.plan_trainerBindingSource.DataSource = this.StaffDataSet;
            // 
            // StaffDataSet
            // 
            this.StaffDataSet.DataSetName = "StaffDataSet";
            this.StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plan_locationBindingSource
            // 
            this.plan_locationBindingSource.DataMember = "plan_location";
            this.plan_locationBindingSource.DataSource = this.StaffDataSet;
            // 
            // plan_trainerTableAdapter
            // 
            this.plan_trainerTableAdapter.ClearBeforeFill = true;
            // 
            // plan_locationTableAdapter
            // 
            this.plan_locationTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 475);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Pennine Care IT Training Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_locationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource plan_trainerBindingSource;
        private StaffDataSet StaffDataSet;
        private StaffDataSetTableAdapters.plan_trainerTableAdapter plan_trainerTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource plan_locationBindingSource;
        private StaffDataSetTableAdapters.plan_locationTableAdapter plan_locationTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem refreshReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherActivityToolStripMenuItem;
    }
}

