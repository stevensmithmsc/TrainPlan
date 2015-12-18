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
    public partial class AddOtherAct : Form
    {
        public AddOtherAct()
        {
            InitializeComponent();
        }

        private void otherActivityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otherActivityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staffDataSet);

        }

        private void AddOtherAct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataSet1.Staff);
            // TODO: This line of code loads data into the 'staffDataSet1.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.staffDataSet1.Locations);
            // TODO: This line of code loads data into the 'staffDataSet.OtherActivity' table. You can move, or remove it, as needed.
            this.otherActivityTableAdapter.Fill(this.staffDataSet.OtherActivity);
            // TODO: This line of code loads data into the 'staffDataSet1.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.staffDataSet1.category);
            // TODO: This line of code loads data into the 'staffDataSet.OtherActivity' table. You can move, or remove it, as needed.
            this.otherActivityTableAdapter.Fill(this.staffDataSet.OtherActivity);

        }
    }
}
