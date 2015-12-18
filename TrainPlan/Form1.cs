using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainPlan
{
    public partial class MainForm : Form
    {
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;

        public MainForm()
        {
            InitializeComponent();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            this.toolStrip1.Items.Add("Start:");
            this.toolStrip1.Items.Add(new ToolStripControlHost(dtpStart));
            this.toolStrip1.Items.Add("End:");
            this.toolStrip1.Items.Add(new ToolStripControlHost(dtpEnd));
            dtpStart.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;
            dtpEnd.Value = DateTime.Now.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day).Date;
            dtpStart.ValueChanged += new EventHandler(dtp_change);
            dtpEnd.ValueChanged += new EventHandler(dtp_change);
        }

        private void dtp_change(object sender, System.EventArgs e)
        {

            this.plan_trainerTableAdapter.Fill(this.StaffDataSet.plan_trainer, dtpStart.Value, dtpEnd.Value);
            this.plan_locationTableAdapter.Fill(this.StaffDataSet.plan_location, dtpStart.Value, dtpEnd.Value);
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StaffDataSet.plan_location' table. You can move, or remove it, as needed.
            this.plan_locationTableAdapter.Fill(this.StaffDataSet.plan_location, dtpStart.Value, dtpEnd.Value);
            // TODO: This line of code loads data into the 'StaffDataSet.plan_trainer' table. You can move, or remove it, as needed.
            this.plan_trainerTableAdapter.Fill(this.StaffDataSet.plan_trainer, dtpStart.Value, dtpEnd.Value);

            this.reportViewer1.RefreshReport();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;
            dtpEnd.Value = DateTime.Now.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day).Date;
            dtp_change(sender, e);
        }

        private void nextMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMonths(1);
            dtpEnd.Value = dtpEnd.Value.AddMonths(1);
            dtp_change(sender, e);
        }

        private void previousMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMonths(-1);
            dtpEnd.Value = dtpEnd.Value.AddMonths(-1);
            dtp_change(sender, e);
        }

        private void otherActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOtherAct addOtherAct = new AddOtherAct();
            addOtherAct.ShowDialog();
        }
    }
}
