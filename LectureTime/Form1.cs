using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
//

namespace LectureTime
{
    public partial class Form1 : Form
    {
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

        public int[] StartTimeValue = new int[MAX_TIMETABLE];
        public int[] EndedTimeValue = new int[MAX_TIMETABLE];

        public int[] LeftTimeValue = new int[MAX_TIMETABLE];

        int PeriodNumber = -1;
        int PeriodLeftNumber = -1;
        Thread eventHandleThread;
        delegate void d();

        public Form1()
        {
            InitializeComponent();

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
            eventHandleThread.Start();
        }

        private void FormClosing_event(object sender, FormClosingEventArgs e)
        {
            eventHandleThread.Abort();
        }

        private void everySeconds_event()
        {
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
                StatusLabelStr = "During the " + (PeriodNumber + 1).ToString() + " time period class!";
                ButtomLabelText[0] = StartTime[PeriodNumber];
                ButtomLabelText[1] = EndedTime[PeriodNumber];
                ButtomLabelText[2] = ConvertToReturnTime(EndedTimeValue[PeriodNumber] - ConvertedSeconds);
            }
            else
            {
                if (PeriodLeftNumber != -1)
                {
                    //授業まであと何分
                    progSet[0] = LeftTimeValue[PeriodLeftNumber];
                    progSet[1] = StartTimeValue[PeriodLeftNumber];
                    progSet[2] = ConvertedSeconds;
                    plogColor[0] = Color.Black;
                    plogColor[1] = Color.Yellow;
                    StatusLabelStr = (StartTimeValue[PeriodLeftNumber] - ConvertedSeconds).ToString() + " Seconds left for start class!";
                }
                else
                {
                    //授業時間外
                    progSet[0] = 0;
                    progSet[1] = 0;
                    progSet[2] = 0;
                    plogColor[0] = Color.Blue;
                    plogColor[1] = Color.Red;
                    StatusLabelStr = "Time without class!";
                }
                for (int i = 0; i < ButtomLabelText.Length; i++) 
                    ButtomLabelText[i] = "";
            }
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

        private int ConvertToSeconds(string str)
        {
            string[] rawTime = str.Split(':');
            double allTime = 0;
            for (int i = 0; i < rawTime.Length; i++)
                allTime += int.Parse(rawTime[i]) * (i == 2 ? 1 : Math.Pow(60, 2 - i));
            return (int)allTime;
        }

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

        public string ConvertToReturnTime(int time)
        {
            TimeSpan span = new TimeSpan(0, 0, time);
            return span.ToString(@"hh\:mm\:ss");
        }
    }
}
