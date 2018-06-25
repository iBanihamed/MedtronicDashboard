﻿using System;
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
using System.Diagnostics;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            curTime.Text = DateTime.Now.ToString();
            //curDate.Text = Date.Now>ToString()
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOutlook_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "OUTLOOK";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonTasks_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "OUTLOOK";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonExcel_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "EXCEL";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonWord_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "WINWORD";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonChrome_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "chrome";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonVisualStudio_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "devenv";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        private void ButtonJabber_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "CiscoJabber";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }
    }
}