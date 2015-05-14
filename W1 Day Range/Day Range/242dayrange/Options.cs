using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _42dayrange
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private int SelectedStart = -1;

        private void Options_Load(object sender, EventArgs e)
        {
            // fill the ComboBox from the StaticDayList in the main Class...
            foreach (Day day in Form1.StaticDayList)
            {
                cboStartDay.Items.Add(day);
            }
        }

        private void cboStartDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get/store the index from the selcteditem and hold on to it.
            SelectedStart = cboStartDay.SelectedIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // pass the selected to a mthod back in the parent form
            Form1.InitWeek(SelectedStart);
            //Form1.SetupForm();
            Form1.calledInt = 0;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
