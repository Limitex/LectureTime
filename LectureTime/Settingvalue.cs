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
        public static string[] StartTime/* =
        {
            "8:30:00",
            "10:10:00",
            "13:10:00",
            "14:50:00",
            "16:30:00",
            "18:10:00"
        }*/;
        public static string[] EndedTime/* =
        {
            "10:00:00",
            "11:40:00",
            "14:40:00",
            "16:20:00",
            "18:00:00",
            "19:40:00",
        }*/;
    }

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

        //変更不可
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
