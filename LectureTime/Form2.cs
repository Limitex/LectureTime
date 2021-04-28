using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureTime
{
    public partial class Form2 : Form
    {
        private CheckBox[,]      FormControlCheckBoxGraphSet = new CheckBox[SettingValue.MAX_PERIOD, SettingValue.MAX_WEEK];
        private CheckBox[]       FormControlCheckBoxWeekSet = new CheckBox[SettingValue.MAX_PERIOD];
        private GroupBox[]       FormControlGroupBoxTimeSet = new GroupBox[SettingValue.MAX_PERIOD];
        private DateTimePicker[] FormControlDateTimePickerStartTime = new DateTimePicker[SettingValue.MAX_PERIOD];
        private DateTimePicker[] FormControlDateTimePickerEndedTime = new DateTimePicker[SettingValue.MAX_PERIOD];
        
        public Form2()
        {
            InitializeComponent();
            InValue();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //時間の設定の記述
            for (int i = 0; i < SettingValue.ReadValue_MaxTimeTable; i++)
            {
                FormControlDateTimePickerStartTime[i].Value = DateTime.Parse(SettingValue.ReadValue_StartTime[i]);
                FormControlDateTimePickerEndedTime[i].Value = DateTime.Parse(SettingValue.ReadValue_EndedTime[i]);
            }

            //チェックボックス類の設定
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                FormControlCheckBoxWeekSet[i].Checked = SettingValue.ReadValue_MaxTimeTable >= i + 1;
                FormControlGroupBoxTimeSet[i].Enabled = FormControlCheckBoxWeekSet[i].Checked;

                for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                {
                    FormControlCheckBoxGraphSet[i, j].Checked = SettingValue.ReadValue_DateSetData[i, j] == 1;
                    FormControlCheckBoxGraphSet[i, j].Enabled = FormControlCheckBoxWeekSet[i].Checked;
                }
            }
        }

        /// <summary>
        /// フォームの情報をグローバル変数に代入する
        /// </summary>
        private void InValue()
        {
            {
                FormControlCheckBoxGraphSet[0, 0] = checkBox_1st1;
                FormControlCheckBoxGraphSet[0, 1] = checkBox_1st2;
                FormControlCheckBoxGraphSet[0, 2] = checkBox_1st3;
                FormControlCheckBoxGraphSet[0, 3] = checkBox_1st4;
                FormControlCheckBoxGraphSet[0, 4] = checkBox_1st5;
                FormControlCheckBoxGraphSet[0, 5] = checkBox_1st6;
                FormControlCheckBoxGraphSet[0, 6] = checkBox_1st7;

                FormControlCheckBoxGraphSet[1, 0] = checkBox_2nd1;
                FormControlCheckBoxGraphSet[1, 1] = checkBox_2nd2;
                FormControlCheckBoxGraphSet[1, 2] = checkBox_2nd3;
                FormControlCheckBoxGraphSet[1, 3] = checkBox_2nd4;
                FormControlCheckBoxGraphSet[1, 4] = checkBox_2nd5;
                FormControlCheckBoxGraphSet[1, 5] = checkBox_2nd6;
                FormControlCheckBoxGraphSet[1, 6] = checkBox_2nd7;

                FormControlCheckBoxGraphSet[2, 0] = checkBox_3rd1;
                FormControlCheckBoxGraphSet[2, 1] = checkBox_3rd2;
                FormControlCheckBoxGraphSet[2, 2] = checkBox_3rd3;
                FormControlCheckBoxGraphSet[2, 3] = checkBox_3rd4;
                FormControlCheckBoxGraphSet[2, 4] = checkBox_3rd5;
                FormControlCheckBoxGraphSet[2, 5] = checkBox_3rd6;
                FormControlCheckBoxGraphSet[2, 6] = checkBox_3rd7;

                FormControlCheckBoxGraphSet[3, 0] = checkBox_4th1;
                FormControlCheckBoxGraphSet[3, 1] = checkBox_4th2;
                FormControlCheckBoxGraphSet[3, 2] = checkBox_4th3;
                FormControlCheckBoxGraphSet[3, 3] = checkBox_4th4;
                FormControlCheckBoxGraphSet[3, 4] = checkBox_4th5;
                FormControlCheckBoxGraphSet[3, 5] = checkBox_4th6;
                FormControlCheckBoxGraphSet[3, 6] = checkBox_4th7;

                FormControlCheckBoxGraphSet[4, 0] = checkBox_5th1;
                FormControlCheckBoxGraphSet[4, 1] = checkBox_5th2;
                FormControlCheckBoxGraphSet[4, 2] = checkBox_5th3;
                FormControlCheckBoxGraphSet[4, 3] = checkBox_5th4;
                FormControlCheckBoxGraphSet[4, 4] = checkBox_5th5;
                FormControlCheckBoxGraphSet[4, 5] = checkBox_5th6;
                FormControlCheckBoxGraphSet[4, 6] = checkBox_5th7;

                FormControlCheckBoxGraphSet[5, 0] = checkBox_6th1;
                FormControlCheckBoxGraphSet[5, 1] = checkBox_6th2;
                FormControlCheckBoxGraphSet[5, 2] = checkBox_6th3;
                FormControlCheckBoxGraphSet[5, 3] = checkBox_6th4;
                FormControlCheckBoxGraphSet[5, 4] = checkBox_6th5;
                FormControlCheckBoxGraphSet[5, 5] = checkBox_6th6;
                FormControlCheckBoxGraphSet[5, 6] = checkBox_6th7;

                FormControlCheckBoxGraphSet[6, 0] = checkBox_7th1;
                FormControlCheckBoxGraphSet[6, 1] = checkBox_7th2;
                FormControlCheckBoxGraphSet[6, 2] = checkBox_7th3;
                FormControlCheckBoxGraphSet[6, 3] = checkBox_7th4;
                FormControlCheckBoxGraphSet[6, 4] = checkBox_7th5;
                FormControlCheckBoxGraphSet[6, 5] = checkBox_7th6;
                FormControlCheckBoxGraphSet[6, 6] = checkBox_7th7;

                FormControlCheckBoxGraphSet[7, 0] = checkBox_8th1;
                FormControlCheckBoxGraphSet[7, 1] = checkBox_8th2;
                FormControlCheckBoxGraphSet[7, 2] = checkBox_8th3;
                FormControlCheckBoxGraphSet[7, 3] = checkBox_8th4;
                FormControlCheckBoxGraphSet[7, 4] = checkBox_8th5;
                FormControlCheckBoxGraphSet[7, 5] = checkBox_8th6;
                FormControlCheckBoxGraphSet[7, 6] = checkBox_8th7;

                FormControlCheckBoxGraphSet[8, 0] = checkBox_9th1;
                FormControlCheckBoxGraphSet[8, 1] = checkBox_9th2;
                FormControlCheckBoxGraphSet[8, 2] = checkBox_9th3;
                FormControlCheckBoxGraphSet[8, 3] = checkBox_9th4;
                FormControlCheckBoxGraphSet[8, 4] = checkBox_9th5;
                FormControlCheckBoxGraphSet[8, 5] = checkBox_9th6;
                FormControlCheckBoxGraphSet[8, 6] = checkBox_9th7;

                FormControlCheckBoxGraphSet[9, 0] = checkBox_10th1;
                FormControlCheckBoxGraphSet[9, 1] = checkBox_10th2;
                FormControlCheckBoxGraphSet[9, 2] = checkBox_10th3;
                FormControlCheckBoxGraphSet[9, 3] = checkBox_10th4;
                FormControlCheckBoxGraphSet[9, 4] = checkBox_10th5;
                FormControlCheckBoxGraphSet[9, 5] = checkBox_10th6;
                FormControlCheckBoxGraphSet[9, 6] = checkBox_10th7;
            } //右上のチェックボックスを配列に入れる
            {
                FormControlCheckBoxWeekSet[0] = periodEnableCheck1;
                FormControlCheckBoxWeekSet[1] = periodEnableCheck2;
                FormControlCheckBoxWeekSet[2] = periodEnableCheck3;
                FormControlCheckBoxWeekSet[3] = periodEnableCheck4;
                FormControlCheckBoxWeekSet[4] = periodEnableCheck5;
                FormControlCheckBoxWeekSet[5] = periodEnableCheck6;
                FormControlCheckBoxWeekSet[6] = periodEnableCheck7;
                FormControlCheckBoxWeekSet[7] = periodEnableCheck8;
                FormControlCheckBoxWeekSet[8] = periodEnableCheck9;
                FormControlCheckBoxWeekSet[9] = periodEnableCheck10;
            } //右下のチェックボックスを配列に入れる
            {
                FormControlGroupBoxTimeSet[0] = PeriodGroup1;
                FormControlGroupBoxTimeSet[1] = PeriodGroup2;
                FormControlGroupBoxTimeSet[2] = PeriodGroup3;
                FormControlGroupBoxTimeSet[3] = PeriodGroup4;
                FormControlGroupBoxTimeSet[4] = PeriodGroup5;
                FormControlGroupBoxTimeSet[5] = PeriodGroup6;
                FormControlGroupBoxTimeSet[6] = PeriodGroup7;
                FormControlGroupBoxTimeSet[7] = PeriodGroup8;
                FormControlGroupBoxTimeSet[8] = PeriodGroup9;
                FormControlGroupBoxTimeSet[9] = PeriodGroup10;
            } //左のグループボックスを配列に入れる
            {
                {
                    FormControlDateTimePickerStartTime[0] = date1PeriodStartTime;
                    FormControlDateTimePickerStartTime[1] = date2PeriodStartTime;
                    FormControlDateTimePickerStartTime[2] = date3PeriodStartTime;
                    FormControlDateTimePickerStartTime[3] = date4PeriodStartTime;
                    FormControlDateTimePickerStartTime[4] = date5PeriodStartTime;
                    FormControlDateTimePickerStartTime[5] = date6PeriodStartTime;
                    FormControlDateTimePickerStartTime[6] = date7PeriodStartTime;
                    FormControlDateTimePickerStartTime[7] = date8PeriodStartTime;
                    FormControlDateTimePickerStartTime[8] = date9PeriodStartTime;
                    FormControlDateTimePickerStartTime[9] = date10PeriodStartTime;
                } //StartTiimeを配列に入れる
                {
                    FormControlDateTimePickerEndedTime[0] = date1PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[1] = date2PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[2] = date3PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[3] = date4PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[4] = date5PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[5] = date6PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[6] = date7PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[7] = date8PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[8] = date9PeriodEndedTime;
                    FormControlDateTimePickerEndedTime[9] = date10PeriodEndedTime;
                } //EndedTimeを配列に入れる
            } //左の各時間設定を配列に入れる
        }
        /// <summary>
        /// セーブ処理
        /// </summary>
        /// <param name="close"></param>
        /// <returns></returns>
        private bool Save()
        {
            InValue();

            int Value_MaxPeriod;
            string[] SaveDateData_Start;
            string[] SaveDateData_Ended;
            string[] periodGraph = new string[SettingValue.MAX_PERIOD];
            string saveData = string.Empty;

            //右下チェックボックスを調べて代入、失敗したらfalseを返す
            {
                //後ろからFalseにどこから変わるか調べる
                int checkFromFront = 10, checkFromButtom = -1;
                for (int i = SettingValue.MAX_PERIOD; i > 0; i--)
                {
                    if (FormControlCheckBoxWeekSet[i - 1].Checked)
                    {
                        checkFromButtom = i;
                        break;
                    }
                }
                //前からTureにどこから変わるか調べる
                for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
                {
                    if (!FormControlCheckBoxWeekSet[i].Checked)
                    {
                        checkFromFront = i;
                        break;
                    }
                }
                //1からつけてなかったり間が空いていたら警告してFlaseを返す
                if (checkFromButtom == checkFromFront)
                {
                    Value_MaxPeriod = checkFromButtom;
                }
                else
                {
                    string waringText;
                    if (checkFromButtom == -1)
                        waringText = "Please select one or more.";
                    else
                        waringText = "Please do not leave during the check.";
                    MessageBox.Show(waringText, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            //時間が昇順か調べて代入処理、失敗したらFalseを返す
            {
                SaveDateData_Start = new string[Value_MaxPeriod];
                SaveDateData_Ended = new string[Value_MaxPeriod];
                int MaxPeriodSum = Value_MaxPeriod * 2;
                int[] check = new int[MaxPeriodSum];
                for (int i = 0; i < MaxPeriodSum; i++)
                {
                    if (i % 2 == 0)
                        check[i] = Form1.ConvertToSeconds(FormControlDateTimePickerStartTime[i / 2].Value.ToString(SettingValue.DATE_ENCODING));
                    else
                        check[i] = Form1.ConvertToSeconds(FormControlDateTimePickerEndedTime[(i - 1) / 2].Value.ToString(SettingValue.DATE_ENCODING));
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
                    SaveDateData_Start[i] = FormControlDateTimePickerStartTime[i].Value.ToString(SettingValue.DATE_ENCODING);
                    SaveDateData_Ended[i] = FormControlDateTimePickerEndedTime[i].Value.ToString(SettingValue.DATE_ENCODING);
                }
            }
            //グラフデータをまとめる
            {
                for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
                {
                    for (int j = 0; j < SettingValue.MAX_WEEK; j++)
                    {
                        periodGraph[i] += 
                            FormControlCheckBoxGraphSet[i, j].Enabled ? FormControlCheckBoxGraphSet[i, j].Checked ? "1" : "0" : "2";
                    }
                }
            }
            //ファイル書き出せる形に成形
            {
                for (int i = 0; i < DefaultData.CHECK_STR.Length; i++) 
                {
                    string sum = DefaultData.CHECK_STR[i] + "\n";

                    switch (i)
                    {
                        case 0:
                        case 2:
                        case 4:
                        case 6:
                            sum += "\n";
                            break;

                        case 1:
                            sum += Value_MaxPeriod.ToString() + "\n";
                            break;

                        case 3:
                            sum += StringSum(SaveDateData_Start);
                            break;
                        case 5:
                            sum += StringSum(SaveDateData_Ended);
                            break;
                        case 7:
                            sum += StringSum(periodGraph);
                            break;

                        case 8:
                        case 9:
                            break;
                    }
                    saveData += sum;
                }
            }
            //ファイルに上書き
            {
                if (MessageBox.Show("Do you want to save?", "Infomation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var sr = new StreamWriter(SettingValue.DATA_FILE_PATH, false, SettingValue.ENCODING))
                    {
                        sr.Write(saveData);
                    }
                    SettingValue.OneTimeSetting(FileProccesing.FileRead());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 表を有効、無効かする
        /// </summary>
        /// <param name="num"></param>
        void GraphsChecks(int num)
        {
            int val = num - 1;
            bool checkd = FormControlCheckBoxWeekSet[val].Checked;
            FormControlGroupBoxTimeSet[val].Enabled = checkd;
            for (int i = 0; i < SettingValue.MAX_WEEK; i++) 
                FormControlCheckBoxGraphSet[val,i].Enabled = checkd;
        }
        /// <summary>
        /// 渡された配列を一つの文字列にまとめる関数
        /// </summary>
        /// <param 文字列の配列="strs"></param>
        /// <returns></returns>
        string StringSum(string[] str)
        {
            string sum = string.Empty;
            foreach (string i in str)
            {
                sum += i + "\n";
            }
            return sum;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void App_Button_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void pec1_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(1);
        }
        private void pec2_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(2);
        }
        private void pec3_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(3);
        }
        private void pec4_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(4);
        }
        private void pec5_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(5);
        }
        private void pec6_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(6);
        }
        private void pec7_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(7);
        }
        private void pec8_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(8);
        }
        private void pec9_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(9);
        }
        private void pec10_CheckdChanged_event(object sender, EventArgs e)
        {
            GraphsChecks(10);
        }
    }
}
