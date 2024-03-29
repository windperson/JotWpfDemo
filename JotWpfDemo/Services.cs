﻿using Jot;
using System.Windows;

namespace JotWpfDemo
{
    //this class can be replaced by the use of an IOC container
    static class Services
    {
        public static Tracker Tracker = new Tracker();

        static Services()
        {
            Tracker
                .Configure<Window>()
                .Id(w => w.Title, $"{SystemParameters.VirtualScreenWidth:F0}x{SystemParameters.VirtualScreenHeight:F0}")
                .Properties(w => new { w.Top, w.Width, w.Height, w.Left, w.WindowState })
                .PersistOn(nameof(Window.Closing))
                .StopTrackingOn(nameof(Window.Closing));
        }
    }
}
