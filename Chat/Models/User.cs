using System;

namespace Chat.Models
{
    public class User
    {
        public string name { get; set; }
        public Int64 key { get; set; }
        public DateTime dtConnection { get; set; }
    }
}