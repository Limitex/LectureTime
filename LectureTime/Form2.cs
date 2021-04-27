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

        private CheckBox[,] checkBoxGraph = new CheckBox[SettingValue.MAX_PERIOD, SettingValue.MAX_WEEK];
        private CheckBox[] checkBoxEnablePeriod = new CheckBox[SettingValue.MAX_PERIOD];
        private GroupBox[] groupBoxPeriodGroup = new GroupBox[SettingValue.MAX_PERIOD];
        private DateTimePicker[] dateTimePickersStartTime = new DateTimePicker[SettingValue.MAX_PERIOD];
        private DateTimePicker[] dateTimePickersEndedTime = new DateTimePicker[SettingValue.MAX_PERIOD];

        private void Form2_Load(object sender, EventArgs e)
        {
            {
                checkBoxGraph[0, 0] = checkBox_1st1;
                checkBoxGraph[0, 1] = checkBox_1st2;
                checkBoxGraph[0, 2] = checkBox_1st3;
                checkBoxGraph[0, 3] = checkBox_1st4;
                checkBoxGraph[0, 4] = checkBox_1st5;
                checkBoxGraph[0, 5] = checkBox_1st6;
                checkBoxGraph[0, 6] = checkBox_1st7;

                checkBoxGraph[1, 0] = checkBox_2nd1;
                checkBoxGraph[1, 1] = checkBox_2nd2;
                checkBoxGraph[1, 2] = checkBox_2nd3;
                checkBoxGraph[1, 3] = checkBox_2nd4;
                checkBoxGraph[1, 4] = checkBox_2nd5;
                checkBoxGraph[1, 5] = checkBox_2nd6;
                checkBoxGraph[1, 6] = checkBox_2nd7;

                checkBoxGraph[2, 0] = checkBox_3rd1;
                checkBoxGraph[2, 1] = checkBox_3rd2;
                checkBoxGraph[2, 2] = checkBox_3rd3;
                checkBoxGraph[2, 3] = checkBox_3rd4;
                checkBoxGraph[2, 4] = checkBox_3rd5;
                checkBoxGraph[2, 5] = checkBox_3rd6;
                checkBoxGraph[2, 6] = checkBox_3rd7;

                checkBoxGraph[3, 0] = checkBox_4th1;
                checkBoxGraph[3, 1] = checkBox_4th2;
                checkBoxGraph[3, 2] = checkBox_4th3;
                checkBoxGraph[3, 3] = checkBox_4th4;
                checkBoxGraph[3, 4] = checkBox_4th5;
                checkBoxGraph[3, 5] = checkBox_4th6;
                checkBoxGraph[3, 6] = checkBox_4th7;

                checkBoxGraph[4, 0] = checkBox_5th1;
                checkBoxGraph[4, 1] = checkBox_5th2;
                checkBoxGraph[4, 2] = checkBox_5th3;
                checkBoxGraph[4, 3] = checkBox_5th4;
                checkBoxGraph[4, 4] = checkBox_5th5;
                checkBoxGraph[4, 5] = checkBox_5th6;
                checkBoxGraph[4, 6] = checkBox_5th7;

                checkBoxGraph[5, 0] = checkBox_6th1;
                checkBoxGraph[5, 1] = checkBox_6th2;
                checkBoxGraph[5, 2] = checkBox_6th3;
                checkBoxGraph[5, 3] = checkBox_6th4;
                checkBoxGraph[5, 4] = checkBox_6th5;
                checkBoxGraph[5, 5] = checkBox_6th6;
                checkBoxGraph[5, 6] = checkBox_6th7;

                checkBoxGraph[6, 0] = checkBox_7th1;
                checkBoxGraph[6, 1] = checkBox_7th2;
                checkBoxGraph[6, 2] = checkBox_7th3;
                checkBoxGraph[6, 3] = checkBox_7th4;
                checkBoxGraph[6, 4] = checkBox_7th5;
                checkBoxGraph[6, 5] = checkBox_7th6;
                checkBoxGraph[6, 6] = checkBox_7th7;

                checkBoxGraph[7, 0] = checkBox_8th1;
                checkBoxGraph[7, 1] = checkBox_8th2;
                checkBoxGraph[7, 2] = checkBox_8th3;
                checkBoxGraph[7, 3] = checkBox_8th4;
                checkBoxGraph[7, 4] = checkBox_8th5;
                checkBoxGraph[7, 5] = checkBox_8th6;
                checkBoxGraph[7, 6] = checkBox_8th7;

                checkBoxGraph[8, 0] = checkBox_9th1;
                checkBoxGraph[8, 1] = checkBox_9th2;
                checkBoxGraph[8, 2] = checkBox_9th3;
                checkBoxGraph[8, 3] = checkBox_9th4;
                checkBoxGraph[8, 4] = checkBox_9th5;
                checkBoxGraph[8, 5] = checkBox_9th6;
                checkBoxGraph[8, 6] = checkBox_9th7;

                checkBoxGraph[9, 0] = checkBox_10th1;
                checkBoxGraph[9, 1] = checkBox_10th2;
                checkBoxGraph[9, 2] = checkBox_10th3;
                checkBoxGraph[9, 3] = checkBox_10th4;
                checkBoxGraph[9, 4] = checkBox_10th5;
                checkBoxGraph[9, 5] = checkBox_10th6;
                checkBoxGraph[9, 6] = checkBox_10th7;
            } //チェックボックスグラフを配列に入れる 冗長なのは仕方がない
            {
                checkBoxEnablePeriod[0] = periodEnableCheck1;
                checkBoxEnablePeriod[1] = periodEnableCheck2;
                checkBoxEnablePeriod[2] = periodEnableCheck3;
                checkBoxEnablePeriod[3] = periodEnableCheck4;
                checkBoxEnablePeriod[4] = periodEnableCheck5;
                checkBoxEnablePeriod[5] = periodEnableCheck6;
                checkBoxEnablePeriod[6] = periodEnableCheck7;
                checkBoxEnablePeriod[7] = periodEnableCheck8;
                checkBoxEnablePeriod[8] = periodEnableCheck9;
                checkBoxEnablePeriod[9] = periodEnableCheck10;
            } //下のチェックボックスを配列に入れる 冗長なのは仕方がない
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
                } //StartTiimeを配列に入れる 冗長なのは仕方がない
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
                } //EndedTimeを配列に入れる 冗長ナノは仕方がない
            } //時間設定を配列に入れる
            {
                groupBoxPeriodGroup[0] = PeriodGroup1;
                groupBoxPeriodGroup[1] = PeriodGroup2;
                groupBoxPeriodGroup[2] = PeriodGroup3;
                groupBoxPeriodGroup[3] = PeriodGroup4;
                groupBoxPeriodGroup[4] = PeriodGroup5;
                groupBoxPeriodGroup[5] = PeriodGroup6;
                groupBoxPeriodGroup[6] = PeriodGroup7;
                groupBoxPeriodGroup[7] = PeriodGroup8;
                groupBoxPeriodGroup[8] = PeriodGroup9;
                groupBoxPeriodGroup[9] = PeriodGroup10;
            } //グループボックスを配列に入れる

            //時間の設定の記述
            for (int i = 0; i < SettingValue.MaxTimetable; i++)
            {
                dateTimePickersStartTime[i].Value = DateTime.Parse(SettingValue.StartTime[i]);
                dateTimePickersEndedTime[i].Value = DateTime.Parse(SettingValue.EndedTime[i]);
            }

            //チェックボックス類の設定
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                checkBoxEnablePeriod[i].Checked = SettingValue.MaxTimetable >= i + 1;
                groupBoxPeriodGroup[i].Enabled = checkBoxEnablePeriod[i].Checked;

                for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                {
                    checkBoxGraph[i, j].Checked = SettingValue.periodCheckData[i, j] == 1;
                    checkBoxGraph[i, j].Enabled = checkBoxEnablePeriod[i].Checked;
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

        private bool Save(bool close)
        {
            int Value_MaxPeriod;
            {
                //扱いづらいから配列にする
                bool[] chekcPeriod = new bool[SettingValue.MAX_PERIOD];
                {
                    chekcPeriod[0] = periodEnableCheck1.Checked;
                    chekcPeriod[1] = periodEnableCheck2.Checked;
                    chekcPeriod[2] = periodEnableCheck3.Checked;
                    chekcPeriod[3] = periodEnableCheck4.Checked;
                    chekcPeriod[4] = periodEnableCheck5.Checked;
                    chekcPeriod[5] = periodEnableCheck6.Checked;
                    chekcPeriod[6] = periodEnableCheck7.Checked;
                    chekcPeriod[7] = periodEnableCheck8.Checked;
                    chekcPeriod[8] = periodEnableCheck9.Checked;
                    chekcPeriod[9] = periodEnableCheck10.Checked;
                } //Boolに代入

                int val1 = -1, val2 = 10;
                //後ろからFalseにどこから変わるか調べる
                for (int i = SettingValue.MAX_PERIOD; i > 0; i--)
                {
                    if (chekcPeriod[i - 1])
                    {
                        val1 = i;
                        break;
                    }
                }
                //前からTureにどこから変わるか調べる
                for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
                {
                    if (!chekcPeriod[i])
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
            } //右下チェックボックスを調べる

            string[] SaveDateData_Start = new string[Value_MaxPeriod];
            string[] SaveDateData_Ended = new string[Value_MaxPeriod];
            {
                //扱いづらいから配列に代入
                string[] startData = new string[SettingValue.MAX_PERIOD];
                string[] endedData = new string[SettingValue.MAX_PERIOD];
                {
                    startData[0] = date1PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[1] = date2PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[2] = date3PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[3] = date4PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[4] = date5PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[5] = date6PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[6] = date7PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[7] = date8PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[8] = date9PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    startData[9] = date10PeriodStartTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[0] = date1PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[1] = date2PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[2] = date3PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[3] = date4PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[4] = date5PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[5] = date6PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[6] = date7PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[7] = date8PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[8] = date9PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                    endedData[9] = date10PeriodEndedTime.Value.ToString(SettingValue.DATE_ENCODING);
                }

                //昇順か調べる失敗したらfalseを返す
                int MaxPeriodSum = Value_MaxPeriod * 2;
                int[] check = new int[MaxPeriodSum];
                for (int i = 0; i < MaxPeriodSum; i++)
                {
                    if (i % 2 == 0)
                        check[i] = Form1.ConvertToSeconds(startData[i / 2]);
                    else
                        check[i] = Form1.ConvertToSeconds(endedData[(i - 1) / 2]);
                }

                var j = check[0];
                for (int i = 1; i < MaxPeriodSum; i++)
                {
                    if (j >= check[i])
                    {
                        MessageBox.Show("Please set the time in ascending order.");
                        return false;
                    }
                    j = check[i];
                }

                for (int i = 0; i < Value_MaxPeriod; i++)
                {
                    SaveDateData_Start[i] = startData[i];
                    SaveDateData_Ended[i] = endedData[i];
                }
            }//時間が昇順か調べて代入処理、失敗したらFalseを返す

            int[,] periodGraph = new int[SettingValue.MAX_PERIOD, SettingValue.MAX_WEEK];

            //途中 優先順位最上

            //4.時間割表のチェックボックスでデータを作る。データがない場合は0

            //ファイル書き出せる形に成形


            //int[] date = new int[];
            //int a = Form1.ConvertToSeconds(date1PeriodStartTime.Value.ToString("HH:mm:ss"));

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

        private void pec1_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck1.Checked;
            PeriodGroup1.Enabled = checkd;

            checkBox_1st1.Enabled = checkd;
            checkBox_1st2.Enabled = checkd;
            checkBox_1st3.Enabled = checkd;
            checkBox_1st4.Enabled = checkd;
            checkBox_1st5.Enabled = checkd;
            checkBox_1st6.Enabled = checkd;
            checkBox_1st7.Enabled = checkd;
        }

        private void pec2_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck2.Checked;
            PeriodGroup2.Enabled = checkd;

            checkBox_2nd1.Enabled = checkd;
            checkBox_2nd2.Enabled = checkd;
            checkBox_2nd3.Enabled = checkd;
            checkBox_2nd4.Enabled = checkd;
            checkBox_2nd5.Enabled = checkd;
            checkBox_2nd6.Enabled = checkd;
            checkBox_2nd7.Enabled = checkd;
        }

        private void pec3_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck3.Checked;
            PeriodGroup3.Enabled = checkd;

            checkBox_3rd1.Enabled = checkd;
            checkBox_3rd2.Enabled = checkd;
            checkBox_3rd3.Enabled = checkd;
            checkBox_3rd4.Enabled = checkd;
            checkBox_3rd5.Enabled = checkd;
            checkBox_3rd6.Enabled = checkd;
            checkBox_3rd7.Enabled = checkd;
        }

        private void pec4_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck4.Checked;
            PeriodGroup4.Enabled = checkd;

            checkBox_4th1.Enabled = checkd;
            checkBox_4th2.Enabled = checkd;
            checkBox_4th3.Enabled = checkd;
            checkBox_4th4.Enabled = checkd;
            checkBox_4th5.Enabled = checkd;
            checkBox_4th6.Enabled = checkd;
            checkBox_4th7.Enabled = checkd;
        }

        private void pec5_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck5.Checked;
            PeriodGroup5.Enabled = checkd;

            checkBox_5th1.Enabled = checkd;
            checkBox_5th2.Enabled = checkd;
            checkBox_5th3.Enabled = checkd;
            checkBox_5th4.Enabled = checkd;
            checkBox_5th5.Enabled = checkd;
            checkBox_5th6.Enabled = checkd;
            checkBox_5th7.Enabled = checkd;
        }

        private void pec6_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck6.Checked;
            PeriodGroup6.Enabled = checkd;

            checkBox_6th1.Enabled = checkd;
            checkBox_6th2.Enabled = checkd;
            checkBox_6th3.Enabled = checkd;
            checkBox_6th4.Enabled = checkd;
            checkBox_6th5.Enabled = checkd;
            checkBox_6th6.Enabled = checkd;
            checkBox_6th7.Enabled = checkd;
        }

        private void pec7_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck7.Checked;
            PeriodGroup7.Enabled = checkd;

            checkBox_7th1.Enabled = checkd;
            checkBox_7th2.Enabled = checkd;
            checkBox_7th3.Enabled = checkd;
            checkBox_7th4.Enabled = checkd;
            checkBox_7th5.Enabled = checkd;
            checkBox_7th6.Enabled = checkd;
            checkBox_7th7.Enabled = checkd;
        }

        private void pec8_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck8.Checked;
            PeriodGroup8.Enabled = checkd;

            checkBox_8th1.Enabled = checkd;
            checkBox_8th2.Enabled = checkd;
            checkBox_8th3.Enabled = checkd;
            checkBox_8th4.Enabled = checkd;
            checkBox_8th5.Enabled = checkd;
            checkBox_8th6.Enabled = checkd;
            checkBox_8th7.Enabled = checkd;
        }

        private void pec9_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck9.Checked;
            PeriodGroup9.Enabled = checkd;

            checkBox_9th1.Enabled = checkd;
            checkBox_9th2.Enabled = checkd;
            checkBox_9th3.Enabled = checkd;
            checkBox_9th4.Enabled = checkd;
            checkBox_9th5.Enabled = checkd;
            checkBox_9th6.Enabled = checkd;
            checkBox_9th7.Enabled = checkd;
        }

        private void pec10_CheckdChanged_event(object sender, EventArgs e)
        {
            bool checkd = periodEnableCheck10.Checked;
            PeriodGroup10.Enabled = checkd;

            checkBox_10th1.Enabled = checkd;
            checkBox_10th2.Enabled = checkd;
            checkBox_10th3.Enabled = checkd;
            checkBox_10th4.Enabled = checkd;
            checkBox_10th5.Enabled = checkd;
            checkBox_10th6.Enabled = checkd;
            checkBox_10th7.Enabled = checkd;
        }
    }
}
