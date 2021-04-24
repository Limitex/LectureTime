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
            checkBox_2nd1.Checked = true;
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
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                {
                    //MessageBox.Show(i + " " + j + " : " + SettingValue.periodCheckData[i, j]);
                }
            }
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                {
                    int d = SettingValue.periodCheckData[i, j];
                    {
                        if (i == 0 && j == 0) checkBox_1st1.Checked = d == 1;
                        if (i == 1 && j == 0) checkBox_2nd1.Checked = d == 1;
                        if (i == 2 && j == 0) checkBox_3rd1.Checked = d == 1;
                        if (i == 3 && j == 0) checkBox_4th1.Checked = d == 1;
                        if (i == 4 && j == 0) checkBox_5th1.Checked = d == 1;
                        if (i == 5 && j == 0) checkBox_6th1.Checked = d == 1;
                        if (i == 6 && j == 0) checkBox_7th1.Checked = d == 1;
                        if (i == 7 && j == 0) checkBox_8th1.Checked = d == 1;
                        if (i == 8 && j == 0) checkBox_9th1.Checked = d == 1;
                        if (i == 9 && j == 0) checkBox_10th1.Checked = d == 1;

                        if (i == 0 && j == 1) checkBox_1st2.Checked = d == 1;
                        if (i == 1 && j == 1) checkBox_2nd2.Checked = d == 1;
                        if (i == 2 && j == 1) checkBox_3rd2.Checked = d == 1;
                        if (i == 3 && j == 1) checkBox_4th2.Checked = d == 1;
                        if (i == 4 && j == 1) checkBox_5th2.Checked = d == 1;
                        if (i == 5 && j == 1) checkBox_6th2.Checked = d == 1;
                        if (i == 6 && j == 1) checkBox_7th2.Checked = d == 1;
                        if (i == 7 && j == 1) checkBox_8th2.Checked = d == 1;
                        if (i == 8 && j == 1) checkBox_9th2.Checked = d == 1;
                        if (i == 9 && j == 1) checkBox_10th2.Checked = d == 1;

                        if (i == 0 && j == 2) checkBox_1st3.Checked = d == 1;
                        if (i == 1 && j == 2) checkBox_2nd3.Checked = d == 1;
                        if (i == 2 && j == 2) checkBox_3rd3.Checked = d == 1;
                        if (i == 3 && j == 2) checkBox_4th3.Checked = d == 1;
                        if (i == 4 && j == 2) checkBox_5th3.Checked = d == 1;
                        if (i == 5 && j == 2) checkBox_6th3.Checked = d == 1;
                        if (i == 6 && j == 2) checkBox_7th3.Checked = d == 1;
                        if (i == 7 && j == 2) checkBox_8th3.Checked = d == 1;
                        if (i == 8 && j == 2) checkBox_9th3.Checked = d == 1;
                        if (i == 9 && j == 2) checkBox_10th3.Checked = d == 1;

                        if (i == 0 && j == 3) checkBox_1st4.Checked = d == 1;
                        if (i == 1 && j == 3) checkBox_2nd4.Checked = d == 1;
                        if (i == 2 && j == 3) checkBox_3rd4.Checked = d == 1;
                        if (i == 3 && j == 3) checkBox_4th4.Checked = d == 1;
                        if (i == 4 && j == 3) checkBox_5th4.Checked = d == 1;
                        if (i == 5 && j == 3) checkBox_6th4.Checked = d == 1;
                        if (i == 6 && j == 3) checkBox_7th4.Checked = d == 1;
                        if (i == 7 && j == 3) checkBox_8th4.Checked = d == 1;
                        if (i == 8 && j == 3) checkBox_9th4.Checked = d == 1;
                        if (i == 9 && j == 3) checkBox_10th4.Checked = d == 1;

                        if (i == 0 && j == 4) checkBox_1st5.Checked = d == 1;
                        if (i == 1 && j == 4) checkBox_2nd5.Checked = d == 1;
                        if (i == 2 && j == 4) checkBox_3rd5.Checked = d == 1;
                        if (i == 3 && j == 4) checkBox_4th5.Checked = d == 1;
                        if (i == 4 && j == 4) checkBox_5th5.Checked = d == 1;
                        if (i == 5 && j == 4) checkBox_6th5.Checked = d == 1;
                        if (i == 6 && j == 4) checkBox_7th5.Checked = d == 1;
                        if (i == 7 && j == 4) checkBox_8th5.Checked = d == 1;
                        if (i == 8 && j == 4) checkBox_9th5.Checked = d == 1;
                        if (i == 9 && j == 4) checkBox_10th5.Checked = d == 1;

                        if (i == 0 && j == 5) checkBox_1st6.Checked = d == 1;
                        if (i == 1 && j == 5) checkBox_2nd6.Checked = d == 1;
                        if (i == 2 && j == 5) checkBox_3rd6.Checked = d == 1;
                        if (i == 3 && j == 5) checkBox_4th6.Checked = d == 1;
                        if (i == 4 && j == 5) checkBox_5th6.Checked = d == 1;
                        if (i == 5 && j == 5) checkBox_6th6.Checked = d == 1;
                        if (i == 6 && j == 5) checkBox_7th6.Checked = d == 1;
                        if (i == 7 && j == 5) checkBox_8th6.Checked = d == 1;
                        if (i == 8 && j == 5) checkBox_9th6.Checked = d == 1;
                        if (i == 9 && j == 5) checkBox_10th6.Checked = d == 1;

                        if (i == 0 && j == 6) checkBox_1st7.Checked = d == 1;
                        if (i == 1 && j == 6) checkBox_2nd7.Checked = d == 1;
                        if (i == 2 && j == 6) checkBox_3rd7.Checked = d == 1;
                        if (i == 3 && j == 6) checkBox_4th7.Checked = d == 1;
                        if (i == 4 && j == 6) checkBox_5th7.Checked = d == 1;
                        if (i == 5 && j == 6) checkBox_6th7.Checked = d == 1;
                        if (i == 6 && j == 6) checkBox_7th7.Checked = d == 1;
                        if (i == 7 && j == 6) checkBox_8th7.Checked = d == 1;
                        if (i == 8 && j == 6) checkBox_9th7.Checked = d == 1;
                        if (i == 9 && j == 6) checkBox_10th7.Checked = d == 1;
                    } // CheckBox の値の設定
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
