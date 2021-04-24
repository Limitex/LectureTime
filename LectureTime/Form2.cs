using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureTime
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SettingValue.MaxTimetable; i++) 
            {
                var start = DateTime.Parse(SettingValue.StartTime[i]);
                var ended = DateTime.Parse(SettingValue.EndedTime[i]);
                switch (i)
                {
                    case 0:
                        date1PeriodStartTime.Value = start;
                        date1PeriodEndedTime.Value = ended;
                        break;
                    case 1:
                        date2PeriodStartTime.Value = start;
                        date2PeriodEndedTime.Value = ended;
                        break;
                    case 2:
                        date3PeriodStartTime.Value = start;
                        date3PeriodEndedTime.Value = ended;
                        break;
                    case 3:
                        date4PeriodStartTime.Value = start;
                        date4PeriodEndedTime.Value = ended;
                        break;
                    case 4:
                        date5PeriodStartTime.Value = start;
                        date5PeriodEndedTime.Value = ended;
                        break;
                    case 5:
                        date6PeriodStartTime.Value = start;
                        date6PeriodEndedTime.Value = ended;
                        break;
                    case 6:
                        date7PeriodStartTime.Value = start;
                        date7PeriodEndedTime.Value = ended;
                        break;
                    case 7:
                        date8PeriodStartTime.Value = start;
                        date8PeriodEndedTime.Value = ended;
                        break;
                    case 8:
                        date9PeriodStartTime.Value = start;
                        date9PeriodEndedTime.Value = ended;
                        break;
                    case 9:
                        date10PeriodStartTime.Value = start;
                        date10PeriodEndedTime.Value = ended;
                        break;
                }
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void App_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
