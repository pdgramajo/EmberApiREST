﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class Question
    {
        public int id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public List<Answer> answers { get; set; }
    }
}
