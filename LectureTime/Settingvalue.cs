using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTime
{
    static class SettingValue
    {
        public static int MaxTimetable = -1;
        public static readonly int MAX_PERIOD = 10;
        public static readonly int MAX_WEEK = 7;
        public static readonly string DATA_FILE_PATH = @"lectureTime.ltdata";
        public static readonly Encoding ENCODING = Encoding.GetEncoding("UTF-8");
        public static readonly string DATE_ENCODING = "HH:mm:ss";
        public static string[] StartTime;
        public static string[] EndedTime;
        public static int[,] periodCheckData = new int[MAX_PERIOD, MAX_WEEK];

        public static void Setting(string inData)
        {

            string[] Data = inData.Split('\n');

            //使用時間と最大値の定義と配列の初期化
            MaxTimetable = int.Parse(Data[FindIndex(Data, DefaultData.CHECK_STR[1]) + 1]);
            StartTime = new string[MaxTimetable];
            EndedTime = new string[MaxTimetable];

            //値に変換するときに使う配列の初期化
            Form1.StartTimeValue = new int[MaxTimetable];
            Form1.EndedTimeValue = new int[MaxTimetable];
            Form1.LeftTimeValue = new int[MaxTimetable];

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
                        periodCheckData[i, j] = 0;
                    }
                    if (val == 1)
                    {
                        periodCheckData[i, j] = 1;
                    }
                    if (MaxTimetable <= i)
                    {
                        periodCheckData[i, j] = -1;
                    }
                }
            }

            //使用時間の定義
            for (int i = 0; i < MaxTimetable; i++)
            {
                StartTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[3]) + 1 + i];
                EndedTime[i] = Data[FindIndex(Data, DefaultData.CHECK_STR[5]) + 1 + i];
            }
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

    //変更不可
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
            "0000000\n" +
            "0000000\n" +
            "0000000\n" +
            "0000000\n" +
            "[DateSetDataEnd]";

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
