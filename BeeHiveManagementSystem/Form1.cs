using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagementSystem
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            Queen queen = new Queen(workers);
        }

        private void btnAssingJobToBee_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(combxJobList.Text, (int)numudShifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + combxJobList.Text + "'", "The bee queen says...");
            else
                MessageBox.Show("The job '" + combxJobList.Text + "' will be done in " + numudShifts.Value + " shift(s)", "The bee queen says...");
        }

        private void btnWorkNextShift_Click(object sender, EventArgs e)
        {
            tbxReport.Text = queen.WorkNextSHift();
        }
    }
}
