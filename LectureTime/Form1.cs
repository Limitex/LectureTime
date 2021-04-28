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
        public static int[] StartTimeValue;
        public static int[] EndedTimeValue;

        int PeriodNumber = -1;
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
            
            SettingValue.Setting(DataFileData);

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
            string dtstr = dt.ToString(SettingValue.DATE_ENCODING), StatusLabelStr;
            int ConvertedSeconds = ConvertToSeconds(dtstr);
            PeriodNumber = CheckPeriodNumber(dt, StartTimeValue, EndedTimeValue);

            int[] progSet = new int[3];
            string[] ButtomLabelText = new string[3];
            Color[] plogColor = new Color[2];


            int count = 0;
            int[] todyaPeroidEnable = new int[SettingValue.MAX_PERIOD];
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++) 
            {
                todyaPeroidEnable[i] = SettingValue.periodCheckData[i, SettingValue.todayType];
                if (todyaPeroidEnable[i] == 1)
                {
                    count++;
                }
            }

            int[] todayStartTimeValue = new int[count];
            int[] todayEndedTimeValue = new int[count];
            count = 0;
            for (int i = 0; i < SettingValue.MAX_PERIOD; i++)
            {
                if (todyaPeroidEnable[i] == 1)
                {
                    todayStartTimeValue[count] = StartTimeValue[i];
                    todayEndedTimeValue[count] = EndedTimeValue[i];
                    count++;
                }
            }
            string[] todayStartTime = new string[count];
            string[] todayEndedTime = new string[count];
            for (int i = 0; i < count; i++)
            {
                todayStartTime[i] = ConvertToReturnTime(todayStartTimeValue[i]);
                todayEndedTime[i] = ConvertToReturnTime(todayEndedTimeValue[i]);
            }

            int nowPeriodNumber = CheckPeriodNumber(dt, todayStartTimeValue, todayEndedTimeValue);

            int[] todayLeftTimeValue = new int[count];

            for (int i = 0; i < count; i++)
            {
                todayLeftTimeValue[i] = todayStartTimeValue[i] - 600;
            }

            int todayPeriodLeftNumber = CheckPeriodNumber(dt, todayLeftTimeValue, todayStartTimeValue);

            if (PeriodNumber != -1 && nowPeriodNumber != -1)
            {
                //授業時間中
                progSet[0] = todayStartTimeValue[nowPeriodNumber];
                progSet[1] = todayEndedTimeValue[nowPeriodNumber];
                progSet[2] = ConvertedSeconds;
                plogColor[0] = Color.Black;
                plogColor[1] = Color.Red;
                ButtomLabelText[0] = todayStartTime[nowPeriodNumber];
                ButtomLabelText[1] = todayEndedTime[nowPeriodNumber];
                ButtomLabelText[2] = ConvertToReturnTime(todayEndedTimeValue[nowPeriodNumber] - ConvertedSeconds);
                StatusLabelStr = "During the " + (PeriodNumber + 1).ToString() + " time period class!";
            }
            else
            {
                if (todayPeriodLeftNumber != -1)
                {
                    //授業まであと何分
                    int i = todayLeftTimeValue[todayPeriodLeftNumber];
                    string str = ConvertToReturnTime(todayStartTimeValue[todayPeriodLeftNumber] - ConvertedSeconds);
                    progSet[0] = todayLeftTimeValue[todayPeriodLeftNumber];
                    progSet[1] = todayStartTimeValue[todayPeriodLeftNumber];
                    progSet[2] = ConvertedSeconds;
                    plogColor[0] = Color.Black;
                    plogColor[1] = Color.Yellow;
                    ButtomLabelText[0] = ConvertToReturnTime(i);
                    ButtomLabelText[1] = todayStartTime[todayPeriodLeftNumber];
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
        /// From1の使用変数の設定
        /// </summary>
        public static void HereSetting()
        {
            //値に変換するときに使う配列の初期化
            StartTimeValue = new int[SettingValue.MaxTimetable];
            EndedTimeValue = new int[SettingValue.MaxTimetable];

            //文字列表記の時間を秒数に直してValueつき配列に格納
            for (int i = 0; i < SettingValue.MaxTimetable; i++)
            {
                int j = ConvertToSeconds(SettingValue.StartTime[i]);
                StartTimeValue[i] = j;
                EndedTimeValue[i] = ConvertToSeconds(SettingValue.EndedTime[i]);
            }
        }

        /// <summary>
        /// strから秒に変換するメソッド
        /// 
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
        /// 時間割の時限を出すメソッド
        /// </summary>
        /// <param 今の時間="dt"></param>
        /// <param 判定初めの時間="s"></param>
        /// <param 判定終わりの時間="e"></param>
        /// <returns></returns>
        public int CheckPeriodNumber(DateTime dt, int[] s, int[] e)
        {
            int buf = -1;
            for (int i = 0; i < s.Length; i++)
            {
                int j = ConvertToSeconds(dt.ToString(SettingValue.DATE_ENCODING));
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
        public static string ConvertToReturnTime(int time)
        {
            TimeSpan span = new TimeSpan(0, 0, time);
            return span.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// 新しいデータファイルを作る
        /// </summary>
        public static void MakeFile()
        {
            using (var sr = new StreamWriter(SettingValue.DATA_FILE_PATH, false, SettingValue.ENCODING))
            {
                sr.WriteLine(DefaultData.READ_FILE);
            }
        }

        /// <summary>
        /// 既存のデータファイルを読み込む
        /// </summary>
        /// <returns></returns>
        public static string ReadFile()
        {
            string DataFileData;
            using (var sr = new StreamReader(SettingValue.DATA_FILE_PATH))
            {
                DataFileData = sr.ReadToEnd();
            }
            return DataFileData;
        }
    }
}
