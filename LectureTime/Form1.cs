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
        //授業時間の最大値の設定と時間の配列
        public const int MAX_TIMETABLE = 6;
        public static string[] StartTime =
        {
            "8:30:00",
            "10:10:00",
            "13:10:00",
            "14:50:00",
            "16:30:00",
            "18:10:00"
        };
        public static string[] EndedTime =
        {
            "10:00:00",
            "11:40:00",
            "14:40:00",
            "16:20:00",
            "18:00:00",
            "19:40:00",
        };

        //プログラムで使う変数類
        public int[] StartTimeValue = new int[MAX_TIMETABLE];
        public int[] EndedTimeValue = new int[MAX_TIMETABLE];
        public int[] LeftTimeValue = new int[MAX_TIMETABLE];

        public string dataFilePath = @"lectureTime.ltdata";

        int PeriodNumber = -1;
        int PeriodLeftNumber = -1;
        Thread eventHandleThread;
        delegate void d();

        public Form1()
        {
            InitializeComponent();

            //ファイルを読み込む処理と見つからなかった場合はファイルを作る処理
            if (File.Exists(dataFilePath))
            {
                //ファイル見つかった
            }
            else
            {
                //ファイルみつからん
            }
            
            //1秒ごとに呼び出すイベントを作るスレッドの定義
            eventHandleThread = new Thread(() =>
            {
                DateTime dt, dtbf = DateTime.Now;
                while (true)
                {
                    dt = DateTime.Now;
                    if (dt != dtbf)
                    {
                        Invoke(new d(everySeconds_event));
                        dtbf = dt;
                    }
                    Thread.Sleep(1);
                }
            });

            //文字列表記の時間を秒数に直してValueつき配列に格納
            for (int i = 0; i < MAX_TIMETABLE; i++)
            {
                int j = ConvertToSeconds(StartTime[i]);
                StartTimeValue[i] = j;
                EndedTimeValue[i] = ConvertToSeconds(EndedTime[i]);
                LeftTimeValue[i] = j - 600;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //１秒スレッドの開始
            eventHandleThread.Start();
        }

        private void setteiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormClosing_event(object sender, FormClosingEventArgs e)
        {
            //１秒スレッドの破棄
            eventHandleThread.Abort();
        }

        private void everySeconds_event()
        {
            //ローカル変数の定義
            DateTime dt = DateTime.Now;
            string dtstr = dt.ToString("HH:mm:ss"), StatusLabelStr;
            int ConvertedSeconds = ConvertToSeconds(dtstr);
            PeriodNumber = CheckPeriodNumber(dt, StartTimeValue, EndedTimeValue);
            PeriodLeftNumber = CheckPeriodNumber(dt, LeftTimeValue, StartTimeValue);
            int[] progSet = new int[3];
            string[] ButtomLabelText = new string[3];
            Color[] plogColor = new Color[2];

            if (PeriodNumber != -1)
            {
                //授業時間中
                progSet[0] = StartTimeValue[PeriodNumber];
                progSet[1] = EndedTimeValue[PeriodNumber];
                progSet[2] = ConvertedSeconds;
                plogColor[0] = Color.Black;
                plogColor[1] = Color.Red;
                ButtomLabelText[0] = StartTime[PeriodNumber];
                ButtomLabelText[1] = EndedTime[PeriodNumber];
                ButtomLabelText[2] = ConvertToReturnTime(EndedTimeValue[PeriodNumber] - ConvertedSeconds);
                StatusLabelStr = "During the " + (PeriodNumber + 1).ToString() + " time period class!";
            }
            else
            {
                if (PeriodLeftNumber != -1)
                {
                    //授業まであと何分
                    int i = LeftTimeValue[PeriodLeftNumber];
                    string str = ConvertToReturnTime(StartTimeValue[PeriodLeftNumber] - ConvertedSeconds);
                    progSet[0] = LeftTimeValue[PeriodLeftNumber];
                    progSet[1] = StartTimeValue[PeriodLeftNumber];
                    progSet[2] = ConvertedSeconds;
                    plogColor[0] = Color.Black;
                    plogColor[1] = Color.Yellow;
                    ButtomLabelText[0] = ConvertToReturnTime(i);
                    ButtomLabelText[1] = StartTime[PeriodLeftNumber];
                    ButtomLabelText[2] = str;
                    StatusLabelStr = str.Remove(0,3) + " times left for start class!";
                }
                else
                {
                    //授業時間外
                    progSet[0] = 0;
                    progSet[1] = 0;
                    progSet[2] = 0;
                    plogColor[0] = Color.Blue;
                    plogColor[1] = Color.Red;
                    for (int i = 0; i < ButtomLabelText.Length; i++)
                        ButtomLabelText[i] = string.Empty;
                    StatusLabelStr = "Time without class!";
                }
                
            }
            //Formに反映
            progressBar1.Minimum = progSet[0];
            progressBar1.Maximum = progSet[1];
            progressBar1.Value = progSet[2];
            progressBar1.BackColor = plogColor[0];
            progressBar1.ForeColor = plogColor[1];
            NowTimeStatusLabel.Text = StatusLabelStr;
            NowTimeFormLabel.Text = dtstr;
            StartTimeLabel.Text = ButtomLabelText[0];
            EndedTimeLabel.Text = ButtomLabelText[1];
            leftTimeLabel.Text = ButtomLabelText[2];
        }

        /// <summary>
        /// strから秒に変換するメソッド
        /// 
        /// </summary>
        /// <param 00:00:00の形式で入力="str"></param>
        /// <returns></returns>
        private int ConvertToSeconds(string str)
        {
            string[] rawTime = str.Split(':');
            double allTime = 0;
            for (int i = 0; i < rawTime.Length; i++)
                allTime += int.Parse(rawTime[i]) * (i == 2 ? 1 : Math.Pow(60, 2 - i));
            return (int)allTime;
        }

        /// <summary>
        /// 時間割の時限を出すメソッド
        /// </summary>
        /// <param 今の時間="dt"></param>
        /// <param 判定初めの時間="s"></param>
        /// <param 判定終わりの時間="e"></param>
        /// <returns></returns>
        public int CheckPeriodNumber(DateTime dt, int[] s, int[] e)
        {
            int buf = -1;
            for (int i = 0; i < MAX_TIMETABLE; i++)
            {
                int j = ConvertToSeconds(dt.ToString("HH:mm:ss"));
                if (s[i] <= j && j <= e[i])
                {
                    buf = i;
                    break;
                }
            }
            return buf;
        }

        /// <summary>
        /// 秒時間を00:00:00形式に戻す
        /// </summary>
        /// <param 秒数時間="time"></param>
        /// <returns></returns>
        public string ConvertToReturnTime(int time)
        {
            TimeSpan span = new TimeSpan(0, 0, time);
            return span.ToString(@"hh\:mm\:ss");
        }
    }
}
