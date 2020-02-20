﻿using System;
using System.Collections.Generic;
using System.Text;
using PropertyChanged;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace App1.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string Content { get; set; }
        public int Points { get; set; }
        [TextBlob("activitiesBlobbed")]
        public List<Activity> Activities { get; set; }
        public string activitiesBlobbed { get; set; }
    }
}