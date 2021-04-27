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

        private CheckBox[,] checkBox_Graph = new CheckBox[SettingValue.MAX_PERIOD, SettingValue.MAX_WEEK];
        private CheckBox[] checkBox_PeriodEnableCheck = new CheckBox[SettingValue.MAX_PERIOD];
        private GroupBox[] groupBox_PeriodGroup = new GroupBox[SettingValue.MAX_PERIOD];
        private DateTimePicker[] dateTimePickersStartTime = new DateTimePicker[SettingValue.MAX_PERIOD];
        private DateTimePicker[] dateTimePickersEndedTime = new DateTimePicker[SettingValue.MAX_PERIOD];

        private void Form2_Load(object sender, EventArgs e)
        {
            InValue();

            //時間の設定の記述
            for (int i = 0; i < SettingValue.MaxTimetable; i++)
            {
                dateTimePickersStartTime[i].Value = DateTime.Parse(SettingValue.StartTime[i]);
                dateTimePickersEndedTime[i].Value = DateTime.Parse(SettingValue.EndedTime[i]);
            }

            //チェックボックス類の設定
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                checkBox_PeriodEnableCheck[i].Checked = SettingValue.MaxTimetable >= i + 1;
                groupBox_PeriodGroup[i].Enabled = checkBox_PeriodEnableCheck[i].Checked;

                for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                {
                    checkBox_Graph[i, j].Checked = SettingValue.periodCheckData[i, j] == 1;
                    checkBox_Graph[i, j].Enabled = checkBox_PeriodEnableCheck[i].Checked;
                }
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Save(true))
            {
                Close();
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void App_Button_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void InValue()
        {
            {
                checkBox_Graph[0, 0] = checkBox_1st1;
                checkBox_Graph[0, 1] = checkBox_1st2;
                checkBox_Graph[0, 2] = checkBox_1st3;
                checkBox_Graph[0, 3] = checkBox_1st4;
                checkBox_Graph[0, 4] = checkBox_1st5;
                checkBox_Graph[0, 5] = checkBox_1st6;
                checkBox_Graph[0, 6] = checkBox_1st7;

                checkBox_Graph[1, 0] = checkBox_2nd1;
                checkBox_Graph[1, 1] = checkBox_2nd2;
                checkBox_Graph[1, 2] = checkBox_2nd3;
                checkBox_Graph[1, 3] = checkBox_2nd4;
                checkBox_Graph[1, 4] = checkBox_2nd5;
                checkBox_Graph[1, 5] = checkBox_2nd6;
                checkBox_Graph[1, 6] = checkBox_2nd7;

                checkBox_Graph[2, 0] = checkBox_3rd1;
                checkBox_Graph[2, 1] = checkBox_3rd2;
                checkBox_Graph[2, 2] = checkBox_3rd3;
                checkBox_Graph[2, 3] = checkBox_3rd4;
                checkBox_Graph[2, 4] = checkBox_3rd5;
                checkBox_Graph[2, 5] = checkBox_3rd6;
                checkBox_Graph[2, 6] = checkBox_3rd7;

                checkBox_Graph[3, 0] = checkBox_4th1;
                checkBox_Graph[3, 1] = checkBox_4th2;
                checkBox_Graph[3, 2] = checkBox_4th3;
                checkBox_Graph[3, 3] = checkBox_4th4;
                checkBox_Graph[3, 4] = checkBox_4th5;
                checkBox_Graph[3, 5] = checkBox_4th6;
                checkBox_Graph[3, 6] = checkBox_4th7;

                checkBox_Graph[4, 0] = checkBox_5th1;
                checkBox_Graph[4, 1] = checkBox_5th2;
                checkBox_Graph[4, 2] = checkBox_5th3;
                checkBox_Graph[4, 3] = checkBox_5th4;
                checkBox_Graph[4, 4] = checkBox_5th5;
                checkBox_Graph[4, 5] = checkBox_5th6;
                checkBox_Graph[4, 6] = checkBox_5th7;

                checkBox_Graph[5, 0] = checkBox_6th1;
                checkBox_Graph[5, 1] = checkBox_6th2;
                checkBox_Graph[5, 2] = checkBox_6th3;
                checkBox_Graph[5, 3] = checkBox_6th4;
                checkBox_Graph[5, 4] = checkBox_6th5;
                checkBox_Graph[5, 5] = checkBox_6th6;
                checkBox_Graph[5, 6] = checkBox_6th7;

                checkBox_Graph[6, 0] = checkBox_7th1;
                checkBox_Graph[6, 1] = checkBox_7th2;
                checkBox_Graph[6, 2] = checkBox_7th3;
                checkBox_Graph[6, 3] = checkBox_7th4;
                checkBox_Graph[6, 4] = checkBox_7th5;
                checkBox_Graph[6, 5] = checkBox_7th6;
                checkBox_Graph[6, 6] = checkBox_7th7;

                checkBox_Graph[7, 0] = checkBox_8th1;
                checkBox_Graph[7, 1] = checkBox_8th2;
                checkBox_Graph[7, 2] = checkBox_8th3;
                checkBox_Graph[7, 3] = checkBox_8th4;
                checkBox_Graph[7, 4] = checkBox_8th5;
                checkBox_Graph[7, 5] = checkBox_8th6;
                checkBox_Graph[7, 6] = checkBox_8th7;

                checkBox_Graph[8, 0] = checkBox_9th1;
                checkBox_Graph[8, 1] = checkBox_9th2;
                checkBox_Graph[8, 2] = checkBox_9th3;
                checkBox_Graph[8, 3] = checkBox_9th4;
                checkBox_Graph[8, 4] = checkBox_9th5;
                checkBox_Graph[8, 5] = checkBox_9th6;
                checkBox_Graph[8, 6] = checkBox_9th7;

                checkBox_Graph[9, 0] = checkBox_10th1;
                checkBox_Graph[9, 1] = checkBox_10th2;
                checkBox_Graph[9, 2] = checkBox_10th3;
                checkBox_Graph[9, 3] = checkBox_10th4;
                checkBox_Graph[9, 4] = checkBox_10th5;
                checkBox_Graph[9, 5] = checkBox_10th6;
                checkBox_Graph[9, 6] = checkBox_10th7;
            } //右上のチェックボックスを配列に入れる
            {
                checkBox_PeriodEnableCheck[0] = periodEnableCheck1;
                checkBox_PeriodEnableCheck[1] = periodEnableCheck2;
                checkBox_PeriodEnableCheck[2] = periodEnableCheck3;
                checkBox_PeriodEnableCheck[3] = periodEnableCheck4;
                checkBox_PeriodEnableCheck[4] = periodEnableCheck5;
                checkBox_PeriodEnableCheck[5] = periodEnableCheck6;
                checkBox_PeriodEnableCheck[6] = periodEnableCheck7;
                checkBox_PeriodEnableCheck[7] = periodEnableCheck8;
                checkBox_PeriodEnableCheck[8] = periodEnableCheck9;
                checkBox_PeriodEnableCheck[9] = periodEnableCheck10;
            } //右下のチェックボックスを配列に入れる
            {
                groupBox_PeriodGroup[0] = PeriodGroup1;
                groupBox_PeriodGroup[1] = PeriodGroup2;
                groupBox_PeriodGroup[2] = PeriodGroup3;
                groupBox_PeriodGroup[3] = PeriodGroup4;
                groupBox_PeriodGroup[4] = PeriodGroup5;
                groupBox_PeriodGroup[5] = PeriodGroup6;
                groupBox_PeriodGroup[6] = PeriodGroup7;
                groupBox_PeriodGroup[7] = PeriodGroup8;
                groupBox_PeriodGroup[8] = PeriodGroup9;
                groupBox_PeriodGroup[9] = PeriodGroup10;
            } //左のグループボックスを配列に入れる
            {
                {
                    dateTimePickersStartTime[0] = date1PeriodStartTime;
                    dateTimePickersStartTime[1] = date2PeriodStartTime;
                    dateTimePickersStartTime[2] = date3PeriodStartTime;
                    dateTimePickersStartTime[3] = date4PeriodStartTime;
                    dateTimePickersStartTime[4] = date5PeriodStartTime;
                    dateTimePickersStartTime[5] = date6PeriodStartTime;
                    dateTimePickersStartTime[6] = date7PeriodStartTime;
                    dateTimePickersStartTime[7] = date8PeriodStartTime;
                    dateTimePickersStartTime[8] = date9PeriodStartTime;
                    dateTimePickersStartTime[9] = date10PeriodStartTime;
                } //StartTiimeを配列に入れる
                {
                    dateTimePickersEndedTime[0] = date1PeriodEndedTime;
                    dateTimePickersEndedTime[1] = date2PeriodEndedTime;
                    dateTimePickersEndedTime[2] = date3PeriodEndedTime;
                    dateTimePickersEndedTime[3] = date4PeriodEndedTime;
                    dateTimePickersEndedTime[4] = date5PeriodEndedTime;
                    dateTimePickersEndedTime[5] = date6PeriodEndedTime;
                    dateTimePickersEndedTime[6] = date7PeriodEndedTime;
                    dateTimePickersEndedTime[7] = date8PeriodEndedTime;
                    dateTimePickersEndedTime[8] = date9PeriodEndedTime;
                    dateTimePickersEndedTime[9] = date10PeriodEndedTime;
                } //EndedTimeを配列に入れる
            } //左の各時間設定を配列に入れる
        }

        private bool Save(bool close)
        {
            InValue();

            int Value_MaxPeriod;
            {
                int val1 = -1, val2 = 10;
                //後ろからFalseにどこから変わるか調べる
                for (int i = SettingValue.MAX_PERIOD; i > 0; i--)
                {
                    if (checkBox_PeriodEnableCheck[i - 1].Checked)
                    {
                        val1 = i;
                        break;
                    }
                }

                //前からTureにどこから変わるか調べる
                for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
                {
                    if (!checkBox_PeriodEnableCheck[i].Checked)
                    {
                        val2 = i;
                        break;
                    }
                }

                //1からつけてなかったり間が空いていたら警告してFlaseを返す
                if (val1 == val2)
                {
                    Value_MaxPeriod = val1;
                }
                else
                {
                    string waringText;
                    if (val1 == -1)
                        waringText = "Please select one or more.";
                    else
                        waringText = "Please do not leave during the check.";
                    MessageBox.Show(waringText, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } //右下チェックボックスを調べて代入、失敗したらfalseを返す

            string[] SaveDateData_Start = new string[Value_MaxPeriod];
            string[] SaveDateData_Ended = new string[Value_MaxPeriod];
            {
                int MaxPeriodSum = Value_MaxPeriod * 2;
                int[] check = new int[MaxPeriodSum];
                for (int i = 0; i < MaxPeriodSum; i++)
                {
                    if (i % 2 == 0)
                        check[i] = Form1.ConvertToSeconds(dateTimePickersStartTime[i / 2].Value.ToString(SettingValue.DATE_ENCODING));
                    else
                        check[i] = Form1.ConvertToSeconds(dateTimePickersEndedTime[(i - 1) / 2].Value.ToString(SettingValue.DATE_ENCODING));
                }

                var j = check[0];
                for (int i = 1; i < MaxPeriodSum; i++)
                {
                    if (j >= check[i] - 1)
                    {
                        MessageBox.Show("Set the time in ascending order. and leave at least 10 seconds", 
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    j = check[i];
                }

                for (int i = 0; i < Value_MaxPeriod; i++)
                {
                    SaveDateData_Start[i] = dateTimePickersStartTime[i].Value.ToString(SettingValue.DATE_ENCODING);
                    SaveDateData_Ended[i] = dateTimePickersEndedTime[i].Value.ToString(SettingValue.DATE_ENCODING);
                }
            }　//時間が昇順か調べて代入処理、失敗したらFalseを返す

            string[] periodGraph = new string[SettingValue.MAX_PERIOD];
            {
                for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
                {
                    for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                    {
                        periodGraph[i] += 
                            checkBox_Graph[i, j].Enabled ? checkBox_Graph[i, j].Checked ? "1" : "0" : "2";
                    }
                }
            } //グラフデータにまとめる

            //ファイル書き出せる形に成形

            if (MessageBox.Show("Do you want to save?", "Infomation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //ファイルに上書き
                return true;
            }
            else
            {
                return false;
            }
        }

        void checks(int num)
        {
            int val = num - 1;
            bool checkd = checkBox_PeriodEnableCheck[val].Checked;
            groupBox_PeriodGroup[val].Enabled = checkd;
            for (int i = 0; i < SettingValue.MAX_WEEK; i++) 
            {
                checkBox_Graph[val,i].Enabled = checkd;
            }
        }

        private void pec1_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(1);
        }

        private void pec2_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(2);
        }

        private void pec3_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(3);
        }

        private void pec4_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(4);
        }

        private void pec5_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(5);
        }

        private void pec6_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(6);
        }

        private void pec7_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(7);
        }

        private void pec8_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(8);
        }

        private void pec9_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(9);
        }

        private void pec10_CheckdChanged_event(object sender, EventArgs e)
        {
            checks(10);
        }
    }
}
