﻿using App1.Model;
using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        [Obsolete]
        public CalendarPage()
        {
            InitializeComponent();
            calendar.ViewMode = ViewMode.MonthView;
            calendar.OnCalendarTapped += Calendar_OnCalendarTapped;
            calendar.ClearSelection();
            
        }

        [Obsolete]
        async void Calendar_OnCalendarTapped(object sender, CalendarTappedEventArgs e)
        {
            SfCalendar calendar = (sender as SfCalendar);
            DateTime date = e.datetime;
            Note result = await App.Database.GetNoteByDateAsync(date.ToString("MM/dd/yyyy"));
            if (result == null)
            {
                Note newnote = new Note();
                newnote.Date = date.ToString("dd/MM/yyyy");
                newnote.Day = date.ToString("dddd");
                newnote.Content = "";
                newnote.Activities = new List<Activity>();
                await Navigation.PushAsync(new NotePage(newnote, true));
            }
            else
            {
                Note oldnote = await App.Database.GetNoteWithChildren(result.Id);
                await Navigation.PushAsync(new NotePage(oldnote, false));
            }
        }
    }
}