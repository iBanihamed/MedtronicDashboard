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
            curTime.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            curTime.Visibility = Visibility.Collapsed;
        }

        private void ButtonOutlook_Click(object sender, RoutedEventArgs e)
        {
            Process newProcess = new Process();

            newProcess.StartInfo.FileName = "OUTLOOK";
            newProcess.StartInfo.Arguments = "";

            bool result = newProcess.Start();
        }

        //Tasks Page
        private void ButtonTasks_Click(object sender, RoutedEventArgs e)
        {
            GridAccount.Visibility = Visibility.Collapsed;
            GridSettings.Visibility = Visibility.Collapsed;
            GridHelp.Visibility = Visibility.Collapsed;
            GridTasks.Visibility = Visibility.Visible;
        }
        private void ButtonAddTasks_Click(object sender, RoutedEventArgs e)
        {
            ListViewTasks.Items.Add(TextBoxAddTask.Text);
            ListViewTasks.ItemTemplate.LoadContent();
        }
        private void ButtonDeleteTasks_Click(object sender, RoutedEventArgs e)
        {

            ListViewTasks.Items.RemoveAt(ListViewTasks.SelectedIndex); //need to fix, doesn't work
      
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

        //preferences buttons
        private void ButtonAccount_Click(object sender, RoutedEventArgs e)
        {
            GridAccount.Visibility = Visibility.Visible;
            GridSettings.Visibility = Visibility.Collapsed;
            GridHelp.Visibility = Visibility.Collapsed;
            GridTasks.Visibility = Visibility.Collapsed;
        }

        //Account PAge ACtions
        private void ButtonApplyAccount_Click(object sender, RoutedEventArgs e)
        {
            //Creating Brushes for Custom Colors
            SolidColorBrush MedBlue = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF09173C"));
            SolidColorBrush BabyBlue = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF48B1F9"));

            UsernameDisplay.Text = textboxUsername.Text;
            String themeCase = ComboBoxThemeColor.SelectedIndex.ToString();
            switch(themeCase)
            {

                case "0":
                    ChangeThemeColor(MedBlue);
                    break;
                case "1":
                    ChangeThemeColor(Brushes.Black);
                    break;
                case "2":
                    ChangeThemeColor(BabyBlue);
                    break;
                case "3":
                    ChangeThemeColor(Brushes.Crimson);
                    break;
                case "4":
                    ChangeThemeColor(Brushes.DarkSlateBlue);
                    break;
                default:
                    ChangeThemeColor(Brushes.Navy);
                    break;
            }
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            GridAccount.Visibility = Visibility.Collapsed;
            GridSettings.Visibility = Visibility.Visible;
            GridHelp.Visibility = Visibility.Collapsed;
        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            GridAccount.Visibility = Visibility.Collapsed;
            GridSettings.Visibility = Visibility.Collapsed;
            GridHelp.Visibility = Visibility.Visible;
        }

        //Change Color Theme method
        private void ChangeThemeColor(Brush themeColor)
        {
            TopGrid.Background = themeColor;
            ListViewSideBar.Background = themeColor;
            TasksOpen.Background = themeColor;
            ExcelOpen.Background = themeColor;
            WordOpen.Background = themeColor;
            JabberOpen.Background = themeColor;
            VisualStudioOpen.Background = themeColor;
            ChromeOpen.Background = themeColor;
            OutlookOpen.Background = themeColor;
        }

    
       
    }
}
