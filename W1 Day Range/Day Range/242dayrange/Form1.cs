using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

/* 
 * Mike Ferreira and Max Potter.
 * 242DayRange Project
 * 
 * Make sure to use Edit > Share in the Main menu to change the week format, to what you want!!!
 */

namespace _42dayrange
{
    public partial class Form1 : Form
    {
        public static List<Day> StaticDayList = new List<Day>(); // this is the static week used to reset the order of what a week is

        public Form1()
        {
            InitializeComponent();
        }
      
        public List<Day> weekdayList = new List<Day>(); // doing this here so it has a place in memory accessible and only has to be instantiated once.

        public static List<Day> currentWeekList = new List<Day>();

        private IEnumerable<Day> GetCheckboxDays() 
        {
            // Create an array/list/etc of enum values, based on the checkboxes on the form.
            weekdayList.Clear(); // empty all items and parse through the form to set fresh.
            if ( chkDay0.Checked == true )
            {
                weekdayList.Add(currentWeekList[0]);
            }
            if ( chkDay1.Checked == true )
            {
                weekdayList.Add(currentWeekList[1]);
            }
            if ( chkDay2.Checked == true )
            {
                weekdayList.Add(currentWeekList[2]);
            }
            if ( chkDay3.Checked == true )
            {
                weekdayList.Add(currentWeekList[3]);
            }
            if ( chkDay4.Checked == true )
            {
                weekdayList.Add(currentWeekList[4]);
            }
            if ( chkDay5.Checked == true )
            {
                weekdayList.Add(currentWeekList[5]);
            }
            if ( chkDay6.Checked == true )
            {
                weekdayList.Add(currentWeekList[6]);
            }
            return weekdayList;
           
        }

        private string ToDayRange(Day[] days)
        {
            string r = ""; // result string
            int pos = 0; // start at the first day
            
            while (pos < days.Length) // look through all the days
            { // 0 < 7
                // find a sequence, by...
                // instead of using the Day enum value, read the correspding  
                // index from the currentWeeList and use thoat as it's value
                 
                // offset (next value in sequence)
                int off = 1; // offset = 1

                // start of sequence is always current day
                string seq = days[pos].ToString();

                // increase the offset as long as the offset
                // does not exceed the number of days
                // and the days are sequential
                while (pos + off < days.Length) // && days[pos + off] == days[pos] + off)
                {
                    // currentEnumValue && taht there is a next 
                    off++; // if there is a next icrement the counter
                }

                if (off > 2)
                {
                    // use a dash to separate the first and last
                    seq += "-" + days[pos + off - 1];
                    // skip over the intermediate days
                    pos += off; // add instead of just assigning
                }
                else pos++; // otherwise move one step

                // add a comma if needed
                if (r.Length > 0) r += ", ";
                r += seq;
            }
        
            return r;
        }

        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            txtDays.Text = ToDayRange(GetCheckboxDays().ToArray());
        }

        public static void InitWeek(int current) 
        {
            currentWeekList.Clear();
            int counter = 0;

            while (counter < 7)
            {
                currentWeekList.Add(StaticDayList[current]);
                counter++;
                current++;
                if (current == 7)
                {
                    current = 0;
                }
            }
        }

        public void SetupForm()
        {
            // take the current starting day and setup the form
            chkDay0.Text = currentWeekList[0].ToString();
            chkDay1.Text = currentWeekList[1].ToString();
            chkDay2.Text = currentWeekList[2].ToString();
            chkDay3.Text = currentWeekList[3].ToString();
            chkDay4.Text = currentWeekList[4].ToString();
            chkDay5.Text = currentWeekList[5].ToString();
            chkDay6.Text = currentWeekList[6].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StaticDayList.Add(Day.Sunday);
            StaticDayList.Add(Day.Monday);
            StaticDayList.Add(Day.Tuesday);
            StaticDayList.Add(Day.Wednesday);
            StaticDayList.Add(Day.Thursday);
            StaticDayList.Add(Day.Friday);
            StaticDayList.Add(Day.Saturday);

            InitWeek(3);
            SetupForm();
        }

        public static int calledInt = -1;

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calledInt = -1;
            // Open Options form as a modal dialog
            Options setOptions = new Options();
            setOptions.ShowDialog();
            if (calledInt != -1)
            {
                SetupForm();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}