﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeNote.Model
{
    public class ActivityCounter
    {
        public string Name { get; set; }
        public int Counter { get; set; }

        public ActivityCounter(string name)
        {
            Name = name;
        }
    }
}
