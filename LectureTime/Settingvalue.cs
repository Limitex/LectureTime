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
        public static readonly string DATA_FILE_PATH = @"lectureTime.ltdata";
        public static readonly Encoding ENCODING = Encoding.GetEncoding("UTF-8");
        public static string[] StartTime;
        public static string[] EndedTime;

        public static void Setting(string inData)
        {
            string[] Data = inData.Split('\n');

            //使用時間と最大値の定義と配列の初期化
            MaxTimetable = int.Parse(Data[FindIndex(Data, DefaultData.CHECK_STR[1]) + 1]);
            StartTime = new string[MaxTimetable];
            EndedTime = new string[MaxTimetable];
            Form1.StartTimeValue = new int[MaxTimetable];
            Form1.EndedTimeValue = new int[MaxTimetable];
            Form1.LeftTimeValue = new int[MaxTimetable];

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
            "[EndedTimeEnd]\n";
        public static readonly string[] CHECK_STR = 
        { 
            "[LectureTimeData Version 1.0]",
            "[MaxTimetable]",
            "[MaxTimetableEnd]",
            "[StartTime]",
            "[StartTimeEnd]",
            "[EndedTime]",
            "[EndedTimeEnd]"
        };
    }
}
