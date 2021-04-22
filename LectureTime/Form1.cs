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
        //プログラムで使う変数類
        public int[] StartTimeValue;
        public int[] EndedTimeValue;
        public int[] LeftTimeValue;

        int PeriodNumber = -1;
        int PeriodLeftNumber = -1;
        Thread eventHandleThread;
        delegate void d();

        public Form1()
        {
            InitializeComponent();

            //ファイルが見つからなかった場合はファイルを作る処理
            if (!File.Exists(SettingValue.DATA_FILE_PATH))
            {
                MakeFile();
            }

            //ファイルが正しくなかったら作りなおす処理
            string DataFileData = ReadFile();
            foreach (string sr in DefaultData.CHECK_STR)
            {
                if (!DataFileData.Contains(sr))
                {
                    MakeFile();
                    DataFileData = ReadFile();
                    break;
                }
            }
            //ファイルデータをDataに分割していれる
            string[] Data = new string[CountChar(DataFileData,'\n')];
            Data = DataFileData.Split('\n');

            //使用時間と最大値の定義
            SettingValue.MaxTimetable = int.Parse(Data[FindIndex(Data, DefaultData.CHECK_STR[1]) + 1]);
            SettingValue.StartTime = new string[SettingValue.MaxTimetable];
            SettingValue.EndedTime = new string[SettingValue.MaxTimetable];
            StartTimeValue = new int[SettingValue.MaxTimetable];
            EndedTimeValue = new int[SettingValue.MaxTimetable];
            LeftTimeValue = new int[SettingValue.MaxTimetable];
            for (int i = 0;i < SettingValue.MaxTimetable; i++)
            {
                SettingValue.StartTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[3]) + 1 + i];
                SettingValue.EndedTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[5]) + 1 + i];
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
            for (int i = 0; i < SettingValue.MaxTimetable; i++)
            {
                int j = ConvertToSeconds(SettingValue.StartTime[i]);
                StartTimeValue[i] = j;
                EndedTimeValue[i] = ConvertToSeconds(SettingValue.EndedTime[i]);
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
            Form2 form2 = new Form2();
            form2.Show();
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
                ButtomLabelText[0] = SettingValue.StartTime[PeriodNumber];
                ButtomLabelText[1] = SettingValue.EndedTime[PeriodNumber];
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
                    ButtomLabelText[1] = SettingValue.StartTime[PeriodLeftNumber];
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
            for (int i = 0; i < SettingValue.MaxTimetable; i++)
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
        /// <summary>
        /// 文字の出現回数をカウント
        /// </summary>
        /// <param 対象文字列="s"></param>
        /// <param 探す文字="c"></param>
        /// <returns></returns>
        // 文字の出現回数をカウント
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }

        public static void MakeFile()
        {
            using (var sr = new StreamWriter(SettingValue.DATA_FILE_PATH, false, SettingValue.ENCODING))
            {
                sr.WriteLine(DefaultData.READ_FILE);
            }
        }
        public static string ReadFile()
        {
            string DataFileData;
            using (var sr = new StreamReader(SettingValue.DATA_FILE_PATH))
            {
                DataFileData = sr.ReadToEnd();
            }
            return DataFileData;
        }

        public static int FindIndex(string[] vs,string FindStr)
        {

            int index = -1;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i].Contains(FindStr))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
