﻿using System;

namespace Chat.Models
{
    public class Message
    {
        public Int64 destination { get; set; }
        public User sender { get; set; }
        public string message { get; set; }
    }
}