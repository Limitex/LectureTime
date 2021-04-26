﻿using System;
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
            //時間の設定の記述
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

            {
                periodEnableCheck1.Checked = SettingValue.MaxTimetable >= 1;
                periodEnableCheck2.Checked = SettingValue.MaxTimetable >= 2;
                periodEnableCheck3.Checked = SettingValue.MaxTimetable >= 3;
                periodEnableCheck4.Checked = SettingValue.MaxTimetable >= 4;
                periodEnableCheck5.Checked = SettingValue.MaxTimetable >= 5;
                periodEnableCheck6.Checked = SettingValue.MaxTimetable >= 6;
                periodEnableCheck7.Checked = SettingValue.MaxTimetable >= 7;
                periodEnableCheck8.Checked = SettingValue.MaxTimetable >= 8;
                periodEnableCheck9.Checked = SettingValue.MaxTimetable >= 9;
                periodEnableCheck10.Checked = SettingValue.MaxTimetable >= 10;

                PeriodGroup1.Enabled = periodEnableCheck1.Checked;
                PeriodGroup2.Enabled = periodEnableCheck2.Checked;
                PeriodGroup3.Enabled = periodEnableCheck3.Checked;
                PeriodGroup4.Enabled = periodEnableCheck4.Checked;
                PeriodGroup5.Enabled = periodEnableCheck5.Checked;
                PeriodGroup6.Enabled = periodEnableCheck6.Checked;
                PeriodGroup7.Enabled = periodEnableCheck7.Checked;
                PeriodGroup8.Enabled = periodEnableCheck8.Checked;
                PeriodGroup9.Enabled = periodEnableCheck9.Checked;
                PeriodGroup10.Enabled = periodEnableCheck10.Checked;
            } // チェックの準備と実行

            //チェックボックスに記述
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

            {
                checkBox_1st1.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd1.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd1.Enabled = periodEnableCheck3.Checked;
                checkBox_4th1.Enabled = periodEnableCheck4.Checked;
                checkBox_5th1.Enabled = periodEnableCheck5.Checked;
                checkBox_6th1.Enabled = periodEnableCheck6.Checked;
                checkBox_7th1.Enabled = periodEnableCheck7.Checked;
                checkBox_8th1.Enabled = periodEnableCheck8.Checked;
                checkBox_9th1.Enabled = periodEnableCheck9.Checked;
                checkBox_10th1.Enabled = periodEnableCheck10.Checked;

                checkBox_1st2.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd2.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd2.Enabled = periodEnableCheck3.Checked;
                checkBox_4th2.Enabled = periodEnableCheck4.Checked;
                checkBox_5th2.Enabled = periodEnableCheck5.Checked;
                checkBox_6th2.Enabled = periodEnableCheck6.Checked;
                checkBox_7th2.Enabled = periodEnableCheck7.Checked;
                checkBox_8th2.Enabled = periodEnableCheck8.Checked;
                checkBox_9th2.Enabled = periodEnableCheck9.Checked;
                checkBox_10th2.Enabled = periodEnableCheck10.Checked;

                checkBox_1st3.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd3.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd3.Enabled = periodEnableCheck3.Checked;
                checkBox_4th3.Enabled = periodEnableCheck4.Checked;
                checkBox_5th3.Enabled = periodEnableCheck5.Checked;
                checkBox_6th3.Enabled = periodEnableCheck6.Checked;
                checkBox_7th3.Enabled = periodEnableCheck7.Checked;
                checkBox_8th3.Enabled = periodEnableCheck8.Checked;
                checkBox_9th3.Enabled = periodEnableCheck9.Checked;
                checkBox_10th3.Enabled = periodEnableCheck10.Checked;

                checkBox_1st4.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd4.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd4.Enabled = periodEnableCheck3.Checked;
                checkBox_4th4.Enabled = periodEnableCheck4.Checked;
                checkBox_5th4.Enabled = periodEnableCheck5.Checked;
                checkBox_6th4.Enabled = periodEnableCheck6.Checked;
                checkBox_7th4.Enabled = periodEnableCheck7.Checked;
                checkBox_8th4.Enabled = periodEnableCheck8.Checked;
                checkBox_9th4.Enabled = periodEnableCheck9.Checked;
                checkBox_10th4.Enabled = periodEnableCheck10.Checked;

                checkBox_1st5.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd5.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd5.Enabled = periodEnableCheck3.Checked;
                checkBox_4th5.Enabled = periodEnableCheck4.Checked;
                checkBox_5th5.Enabled = periodEnableCheck5.Checked;
                checkBox_6th5.Enabled = periodEnableCheck6.Checked;
                checkBox_7th5.Enabled = periodEnableCheck7.Checked;
                checkBox_8th5.Enabled = periodEnableCheck8.Checked;
                checkBox_9th5.Enabled = periodEnableCheck9.Checked;
                checkBox_10th5.Enabled = periodEnableCheck10.Checked;

                checkBox_1st6.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd6.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd6.Enabled = periodEnableCheck3.Checked;
                checkBox_4th6.Enabled = periodEnableCheck4.Checked;
                checkBox_5th6.Enabled = periodEnableCheck5.Checked;
                checkBox_6th6.Enabled = periodEnableCheck6.Checked;
                checkBox_7th6.Enabled = periodEnableCheck7.Checked;
                checkBox_8th6.Enabled = periodEnableCheck8.Checked;
                checkBox_9th6.Enabled = periodEnableCheck9.Checked;
                checkBox_10th6.Enabled = periodEnableCheck10.Checked;

                checkBox_1st7.Enabled = periodEnableCheck1.Checked;
                checkBox_2nd7.Enabled = periodEnableCheck2.Checked;
                checkBox_3rd7.Enabled = periodEnableCheck3.Checked;
                checkBox_4th7.Enabled = periodEnableCheck4.Checked;
                checkBox_5th7.Enabled = periodEnableCheck5.Checked;
                checkBox_6th7.Enabled = periodEnableCheck6.Checked;
                checkBox_7th7.Enabled = periodEnableCheck7.Checked;
                checkBox_8th7.Enabled = periodEnableCheck8.Checked;
                checkBox_9th7.Enabled = periodEnableCheck9.Checked;
                checkBox_10th7.Enabled = periodEnableCheck10.Checked;
            } //Checkboxの正体 超絶頭悪い書き方

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
