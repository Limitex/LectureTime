using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTime
{
    static class SettingValue
    {
        public static readonly int      MAX_PERIOD = 10;
        public static readonly int      MAX_WEEK = 7;
        public static readonly int      LEFT_DISPLAY_TIME = 600;
        public static readonly string   DATA_FILE_PATH = @"lectureTime.ltdata";
        public static readonly string   DATE_ENCODING = "HH:mm:ss";
        public static readonly Color BAR_FRONT_COLOR_INTIME = Color.Red;
        public static readonly Color BAR_FRONT_COLOR_LEFTTIME = Color.Yellow;
        public static readonly Color BAR_FRONT_COLOR_OUTTIME = Color.Blue;
        public static readonly Color BAR_BACK_COLOR_INTIME = Color.Black;
        public static readonly Color BAR_BACK_COLOR_LEFTTIME = Color.Black;
        public static readonly Color BAR_BACK_COLOR_OUTTIME = Color.Black;
        public static readonly Encoding ENCODING = Encoding.GetEncoding("UTF-8");

        public static int      ReadValue_MaxTimeTable = -1;
        public static string[] ReadValue_StartTime;
        public static string[] ReadValue_EndedTime;
        public static int[,]   ReadValue_DateSetData = new int[MAX_PERIOD, MAX_WEEK];

        public static int[] MakeValue_StartTimeValue;
        public static int[] MakeValue_EndedTimeValue;
        public static int   MakeValue_TodayType;

        /// <summary>
        /// 静的な設定
        /// </summary>
        /// <param 読み込んだファイルデータ="inData"></param>
        public static void OneTimeSetting(string inData)
        {
            string[] Data = inData.Split('\n');

            //使用時間と最大値の定義と配列の初期化
            ReadValue_MaxTimeTable = int.Parse(Data[FindIndex(Data, DefaultData.CHECK_STR[1]) + 1]);
            ReadValue_StartTime = new string[ReadValue_MaxTimeTable];
            ReadValue_EndedTime = new string[ReadValue_MaxTimeTable];
            MakeValue_StartTimeValue = new int[ReadValue_MaxTimeTable];
            MakeValue_EndedTimeValue = new int[ReadValue_MaxTimeTable];

            //使用時間の定義
            for (int i = 0; i < ReadValue_MaxTimeTable; i++)
            {
                ReadValue_StartTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[3]) + 1 + i];
                ReadValue_EndedTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[5]) + 1 + i];
            }

            //チェックデータの作成
            int x = FindIndex(Data, DefaultData.CHECK_STR[7]) + 1;
            for (int i = 0; i < MAX_PERIOD; i++)
            {
                string weekData = Data[x + i];

                for (int j = 0; j < MAX_WEEK; j++)
                {
                    int val = int.Parse(weekData[j].ToString());
                    if (val == 0)
                    {
                        ReadValue_DateSetData[i, j] = 0;
                    }
                    if (val == 1)
                    {
                        ReadValue_DateSetData[i, j] = 1;
                    }
                    if (ReadValue_MaxTimeTable <= i)
                    {
                        ReadValue_DateSetData[i, j] = 2;
                    }
                }
            }

            //文字列表記の時間を秒数に直して配列に格納
            for (int i = 0; i < ReadValue_MaxTimeTable; i++)
            {
                int j = Form1.ConvertToSeconds(ReadValue_StartTime[i]);
                MakeValue_StartTimeValue[i] = j;
                MakeValue_EndedTimeValue[i] = Form1.ConvertToSeconds(ReadValue_EndedTime[i]);
            }

            MoreTimeSetting();
        }
        /// <summary>
        /// 動的な設定
        /// </summary>
        public static void MoreTimeSetting()
        {
            //今日の曜日を設定
            MakeValue_TodayType = (int)DateTime.Now.DayOfWeek;
        }

        /// <summary>
        /// 文字列が配列のどこに入っているかを調べる
        /// 見つからなかった場合は-1を返す
        /// </summary>
        /// <param 対象の文字列="vs"></param>
        /// <param 探す文字列="FindStr"></param>
        /// <returns></returns>
        private static int FindIndex(string[] vs, string FindStr)
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

    /// <summary>
    /// ファイルをチェックして読み込む
    /// </summary>
    public static class FileProccesing
    {
        /// <summary>
        /// ファイルを読み込む処理
        /// </summary>
        /// <returns></returns>
        public static string FileRead()
        {
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
            return DataFileData;
        }
        /// <summary>
        /// 新しいデータファイルを作る
        /// </summary>
        private static void MakeFile()
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
        private static string ReadFile()
        {
            string DataFileData;
            using (var sr = new StreamReader(SettingValue.DATA_FILE_PATH))
            {
                DataFileData = sr.ReadToEnd();
            }
            return DataFileData;
        }
    }
    /// <summary>
    /// ファイル定数ー変更不可
    /// </summary>
    public static class DefaultData
    {

        public static readonly string READ_FILE =
            "[LectureTimeData Version 1.0]\n\n" +
            "[MaxTimetable]\n" +
            "6\n" +
            "[MaxTimetableEnd]\n\n" +
            "[StartTime]\n" +
            "08:30:00\n" +
            "10:10:00\n" +
            "13:10:00\n" +
            "14:50:00\n" +
            "16:30:00\n" +
            "18:10:00\n" +
            "[StartTimeEnd]\n\n" +
            "[EndedTime]\n" +
            "10:00:00\n" +
            "11:40:00\n" +
            "14:40:00\n" +
            "16:20:00\n" +
            "18:00:00\n" +
            "19:40:00\n" +
            "[EndedTimeEnd]\n\n" +
            "[DateSetData]\n" +
            "1111111\n" +
            "1111111\n" +
            "1111111\n" +
            "1111111\n" +
            "1111111\n" +
            "1111111\n" +
            "2222222\n" +
            "2222222\n" +
            "2222222\n" +
            "2222222\n" +
            "[DateSetDataEnd]";

        //変更する場合は最後尾にくっつけてForm2の３００行めあたりのSwitch文をチェックする
        public static readonly string[] CHECK_STR = 
        { 
            "[LectureTimeData Version 1.0]",
            "[MaxTimetable]",
            "[MaxTimetableEnd]",
            "[StartTime]",
            "[StartTimeEnd]",
            "[EndedTime]",
            "[EndedTimeEnd]",
            "[DateSetData]",
            "[DateSetDataEnd]"
        };
    }
}
