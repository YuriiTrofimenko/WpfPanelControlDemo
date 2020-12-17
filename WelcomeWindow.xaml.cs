using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfPanelControlDemo
{
    /// <summary>
    /// Логика взаимодействия для WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
            var THIS = this;
            Timer t = new Timer(1000);
            t.Elapsed += (s, e) => {
                Console.WriteLine("1000");
                t.Stop();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Console.WriteLine(THIS);
                THIS.Close();
            };
            t.Start();
        }
    }
}
