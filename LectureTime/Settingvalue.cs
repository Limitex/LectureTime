using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTime
{
    static class SettingValue
    {
        public static int MAX_TIMETABLE = 6;
        public static readonly string DATA_FILE_PATH = @"lectureTime.ltdata";

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
    }

    public static class DefaultData
    {
        public static string Readfile = 
            "" +
            "";

    }
}
