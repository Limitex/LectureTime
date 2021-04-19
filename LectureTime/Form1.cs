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

        int PeriodNumber = -1;
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
                StartTimeValue[i] = ConvertToSeconds(StartTime[i]);
                EndedTimeValue[i] = ConvertToSeconds(EndedTime[i]);
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
            PeriodNumber = CheckPeriodNumber(dt);

            if (PeriodNumber != -1)
            {
                progressBar1.Minimum = StartTimeValue[PeriodNumber];
                progressBar1.Maximum = EndedTimeValue[PeriodNumber];
                progressBar1.Value = ConvertedSeconds;
                StatusLabelStr = "During the " + (PeriodNumber + 1).ToString() + " time period class!";
                progressBar1.BackColor = Color.Black;
            }
            else
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 0;
                progressBar1.Value = 0;
                StatusLabelStr = "Time without class!";
                progressBar1.BackColor = Color.Blue;
            }
            NowTimeStatusLabel.Text = StatusLabelStr;
            NowTimeFormLabel.Text = dtstr;
        }

        private int ConvertToSeconds(string str)
        {
            string[] rawTime = str.Split(':');
            double allTime = 0;
            for (int i = 0; i < rawTime.Length; i++)
                allTime += int.Parse(rawTime[i]) * (i == 2 ? 1 : Math.Pow(60, 2 - i));
            return (int)allTime;
        }

        public int CheckPeriodNumber(DateTime dt)
        {
            int buf = -1;
            for (int i = 0; i < MAX_TIMETABLE; i++)
            {
                int j = ConvertToSeconds(dt.ToString("HH:mm:ss"));
                if (StartTimeValue[i] <= j && j <= EndedTimeValue[i])
                {
                    buf = i;
                    break;
                }
            }
            return buf;
        }
    }
}
