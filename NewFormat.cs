using System;

namespace Library
{
    public class NewFormat
    {
        public static string AmericanOrder(String date)
        {
            return date.Substring(3, 2) + "-" + date.Substring(0,2) + "-" + date.Substring(6);
        }
    }
}