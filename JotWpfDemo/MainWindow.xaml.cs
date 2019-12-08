using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JotWpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //set up tracking and apply state to the application settings object
            Services.Tracker.Track(App.Settings);

            // in addition to tracking standard window properties, also track selected tab for MainWindow instances
            Services.Tracker.Configure<MainWindow>().Property(w => w.tabControl.SelectedIndex, "SelectedTab");

            //set up tracking and apply state for the main window
            Services.Tracker.Track(this);

            this.DataContext = App.Settings;
        }
    }
}
