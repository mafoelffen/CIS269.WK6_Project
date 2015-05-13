using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace _42dayrange
{
    public partial class Form1 : Form
    {
        /* 
         * Proposed Plan of Attack
         * 
         * Create a workingWeekList previous to this function 
         * Find the  the passed day in workingweekList and return the indexOf
         * Set loop to a while count is less than 6
         * Use that index to add that index value to the first in the list
         * in loop -- after index of 6, set index to 0
         * 
         * set the checkBox text for controls populated from a loop throught the currentWeekFormat
         * 
         * edit the GetCheckboxDays() to get the checkkbox text from each CheckBox...
         * 
         * Why that logic, because the logic of this works from the order of the if's in GetCheckboxDays.
         * 
         * This would take another form dialog to set this as an option
         * In that form is comboxbox that sets the parameter to pass SetWeekOrder()
         * Button calls SetWeekOrder then closes the dialog.
         * 
         * Default would be to set the text in the checkboxs with the desired Day as the first checkbox.
         * Then add a menu with an item "Options" to start of that dialog form as a popup.
         */

        public Form1()
        {
            InitializeComponent();
        }
      

        /* 1. Create a function which looks at the checkboxes
         * on the form and returns a sequence (array/list/etc) of the days
         * selected.  The return must be a sequence of enumeration
         * values.  The return sequence must be in day-sorted order,
         * e.g. Sunday, Monday, ..., Friday, Saturday
         * 
         */

        public List<Day> weekdayList = new List<Day>(); // doing this here so it has a place in memory accessible and only has to be instantiated once.

        public List<Day> currentWeekFormat = new List<Day>();
        private void SetWeekOrder(String startDay)
        {
            currentWeekFormat.Clear(); // clear the using list
            int counter = 0; // init a counter
            // ToDo
             
        }

        private IEnumerable<Day> GetCheckboxDays() 
        {

            // YOU FILL IN HERE
            // Create an array/list/etc of enum values
            // based on the checkboxes on the form.

            // added maf2015.4.9
            weekdayList.Clear(); // empty all items and parse through the form to set fresh.
            if ( chkSunday.Checked == true )
            {
                weekdayList.Add(Day.Sunday);
            }
            if ( chkMonday.Checked == true )
            {
                weekdayList.Add(Day.Monday);
            }
            if ( chkTuesday.Checked == true )
            {
                weekdayList.Add(Day.Tuesday);
            }
            if ( chkWednesday.Checked == true )
            {
                weekdayList.Add(Day.Wednesday);
            }
            if ( chkThursday.Checked == true )
            {
                weekdayList.Add(Day.Thursday);
            }
            if ( chkFriday.Checked == true )
            {
                weekdayList.Add(Day.Friday);
            }
            if ( chkSaturday.Checked == true )
            {
                weekdayList.Add(Day.Saturday);
            }
            return weekdayList;
           
        }

        /* 2. and 3. 
         * Here is a BROKEN! function which accepts a collection
         * of enumerated day values and calculates the
         * date range.  Fix this function!
         * 
         * There is ONE bug in this function.
         * 
         * You may assume the input will
         * be in sorted order.   
         * Reference only the parameter days, not
         * the checkboxes.
         * 
         * The date range is a string which lists the
         * names of each selected day, separated by
         * a comma.  If three or more consecutive days
         * are selected, however, use a dash to specify the range
         * from the first to the last.
         * 
         */
        private string ToDayRange(Day[] days)
        {
            // YOU FIX STARTING HERE
            
            // result string
            string r = "";

            // start at the first day
            int pos = 0;

            
            

            // look through all the days
            while (pos < days.Length)
            {
                // find a sequence!
                // offset (next value in sequence)
                int off = 1;
                // start of sequence is always current day
                string seq = days[pos].ToString();

                // increase the offset as long as the offset
                // does not exceed the number of days
                // and the days are sequential
                while (pos + off < days.Length && days[pos + off] == days[pos] + off)
                    off++;

                // if the offset is three or more days
                if (off > 2)
                {
                    // use a dash to separate the first and last
                    seq += "-" + days[pos + off - 1];
                    // skip over the intermediate days
                    pos+=off; // add instead of just assigning... maf2015.4.9
                }
                else pos++; // otherwise move one step

                // add a comma if needed
                if (r.Length > 0) r += ", ";
                r += seq;
            }
            return r;

            // END FIXING HERE

            
        }

        // no need to change this.
        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            txtDays.Text = ToDayRange(GetCheckboxDays().ToArray());
        }
    }
}