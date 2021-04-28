using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// TIMETABLE 定数で時間割の最大値を設定する
// startTime授業開始時間
// endedTime授業狩猟時間
// それぞれ上から順に記述していく
namespace LectureTime
{
    public partial class Form1 : Form
    {
        Thread eventHandleThread;
        delegate void everySeconds();

        public Form1()
        {
            InitializeComponent();

            //設定と初期化
            SettingValue.OneTimeSetting(FileProccesing.FileRead());

            //1秒ごとに呼び出すイベントを作るスレッドの定義
            eventHandleThread = new Thread(() =>
            {
                DateTime dt, dtbf = DateTime.Now;
                while (true)
                {
                    dt = DateTime.Now;
                    if (dt != dtbf)
                    {
                        Invoke(new everySeconds(everySeconds_event));
                        dtbf = dt;
                    }
                    Thread.Sleep(1);
                }
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //１秒スレッドの開始
            eventHandleThread.Start();
        }
        private void setteiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //設定フォームの表示
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void FormClosing_event(object sender, FormClosingEventArgs e)
        {
            //１秒スレッドの破棄
            eventHandleThread.Abort();
        }

        /// <summary>
        /// 毎秒実行される関数
        /// </summary>
        private void everySeconds_event()
        {
            //ローカル変数の定義
            DateTime NowTimeRaw = DateTime.Now;
            string   NowTimeString = NowTimeRaw.ToString(SettingValue.DATE_ENCODING);
            int      NowTimeSeconds = ConvertToSeconds(NowTimeString);
            int      NowTimePeriod = CheckPeriodNumber(NowTimeRaw, SettingValue.MakeValue_StartTimeValue, SettingValue.MakeValue_EndedTimeValue);

            int[]    TodayPeriodData;
            string[] TodayStartTime;
            string[] TodayEndedTime;
            int[]    TodayStartTimeValue;
            int[]    TodayEndedTimeValue;
            int[]    TodayLeftTimeValue;
            int      TodayNowPeriod;
            int      TodayNowLeftPeriod;

            string   SettingFrontText;
            int[]    SettingProgressBar = new int[3];
            string[] SettingButtomText = new string[3];
            Color[]  SettingProgressBarColor = new Color[2];

            int count = 0;

            //今日の曜日の時間割データを読み込む
            TodayPeriodData = new int[SettingValue.MAX_PERIOD];
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++) 
            {
                TodayPeriodData[i] = SettingValue.ReadValue_DateSetData[i, SettingValue.ReadValue_TodayType];
                if (TodayPeriodData[i] == 1) count++;
            }
            TodayStartTime = new string[count];
            TodayEndedTime = new string[count];
            TodayStartTimeValue = new int[count];
            TodayEndedTimeValue = new int[count];
            count = 0;
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                if (TodayPeriodData[i] == 1)
                {
                    TodayStartTime[count] = SettingValue.ReadValue_StartTime[i];
                    TodayEndedTime[count] = SettingValue.ReadValue_EndedTime[i];
                    TodayStartTimeValue[count] = ConvertToSeconds(TodayStartTime[count]);
                    TodayEndedTimeValue[count] = ConvertToSeconds(TodayEndedTime[count]);
                    count++;
                }
            }

            TodayLeftTimeValue = new int[count];
            for (int i = 0; i < count; i++)
                TodayLeftTimeValue[i] = TodayStartTimeValue[i] - SettingValue.LEFT_DISPLAY_TIME;

            TodayNowPeriod = CheckPeriodNumber(NowTimeRaw, TodayStartTimeValue, TodayEndedTimeValue);
            TodayNowLeftPeriod = CheckPeriodNumber(NowTimeRaw, TodayLeftTimeValue, TodayStartTimeValue);

            if (NowTimePeriod != -1 && TodayNowPeriod != -1)
            {
                //授業時間中
                SettingProgressBar[0] = TodayStartTimeValue[TodayNowPeriod];
                SettingProgressBar[1] = TodayEndedTimeValue[TodayNowPeriod];
                SettingProgressBar[2] = NowTimeSeconds;
                SettingProgressBarColor[0] = SettingValue.BAR_BACK_COLOR_INTIME;
                SettingProgressBarColor[1] = SettingValue.BAR_FRONT_COLOR_INTIME;
                SettingButtomText[0] = TodayStartTime[TodayNowPeriod];
                SettingButtomText[1] = TodayEndedTime[TodayNowPeriod];
                SettingButtomText[2] = ConvertToReturnTime(TodayEndedTimeValue[TodayNowPeriod] - NowTimeSeconds);
                SettingFrontText = "During the " + (NowTimePeriod + 1).ToString() + " time period class!";
            }
            else
            {
                if (TodayNowLeftPeriod != -1)
                {
                    //授業まであと何分
                    string RemainingTime = ConvertToReturnTime(TodayStartTimeValue[TodayNowLeftPeriod] - NowTimeSeconds);
                    SettingProgressBar[0] = TodayLeftTimeValue[TodayNowLeftPeriod];
                    SettingProgressBar[1] = TodayStartTimeValue[TodayNowLeftPeriod];
                    SettingProgressBar[2] = NowTimeSeconds;
                    SettingProgressBarColor[0] = SettingValue.BAR_BACK_COLOR_LEFTTIME;
                    SettingProgressBarColor[1] = SettingValue.BAR_FRONT_COLOR_LEFTTIME;
                    SettingButtomText[0] = ConvertToReturnTime(TodayLeftTimeValue[TodayNowLeftPeriod]);
                    SettingButtomText[1] = TodayStartTime[TodayNowLeftPeriod];
                    SettingButtomText[2] = RemainingTime;
                    SettingFrontText = RemainingTime.Remove(0,3) + " times left for start class!";
                }
                else
                {
                    //授業時間外
                    SettingProgressBar[0] = 0;
                    SettingProgressBar[1] = 0;
                    SettingProgressBar[2] = 0;
                    SettingProgressBarColor[0] = SettingValue.BAR_BACK_COLOR_OUTTIME;
                    SettingProgressBarColor[1] = SettingValue.BAR_FRONT_COLOR_OUTTIME;
                    SettingFrontText = "Time without class!";
                    for (int i = 0; i < SettingButtomText.Length; i++) 
                        SettingButtomText[i] = string.Empty;
                }
                
            }
            //Formに反映
            progressBar1.Minimum = SettingProgressBar[0];
            progressBar1.Maximum = SettingProgressBar[1];
            progressBar1.Value = SettingProgressBar[2];
            progressBar1.BackColor = SettingProgressBarColor[0];
            progressBar1.ForeColor = SettingProgressBarColor[1];
            NowTimeStatusLabel.Text = SettingFrontText;
            NowTimeFormLabel.Text = NowTimeString;
            StartTimeLabel.Text = SettingButtomText[0];
            EndedTimeLabel.Text = SettingButtomText[1];
            leftTimeLabel.Text = SettingButtomText[2];
        }

        /// <summary>
        /// "00:00:00"から秒に変換
        /// </summary>
        /// <param 00:00:00の形式で入力="str"></param>
        /// <returns></returns>
        public static int ConvertToSeconds(string str)
        {
            string[] rawTime = str.Split(':');
            double allTime = 0;
            for (int i = 0; i < rawTime.Length; i++)
                allTime += int.Parse(rawTime[i]) * (i == 2 ? 1 : Math.Pow(60, 2 - i));
            return (int)allTime;
        }
        /// <summary>
        /// 秒時間を00:00:00形式に戻す
        /// </summary>
        /// <param 秒数時間="time"></param>
        /// <returns></returns>
        public static string ConvertToReturnTime(int time)
        {
            TimeSpan span = new TimeSpan(0, 0, time);
            return span.ToString(@"hh\:mm\:ss");
        }
        /// <summary>
        /// 時間割の時限を返すメソッド
        /// </summary>
        /// <param 今の時間="dt"></param>
        /// <param 判定初めの時間="s"></param>
        /// <param 判定終わりの時間="e"></param>
        /// <returns></returns>
        public int CheckPeriodNumber(DateTime dt, int[] s, int[] e)
        {
            int count = -1, Leng = (s.Length + e.Length) / 2;
            for (int i = 0; i < Leng; i++)
            {
                int j = ConvertToSeconds(dt.ToString(SettingValue.DATE_ENCODING));
                if (s[i] <= j && j <= e[i])
                {
                    count = i;
                    break;
                }
            }
            return count;
        }
    }
}
