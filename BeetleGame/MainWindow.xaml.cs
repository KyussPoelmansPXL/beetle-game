using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Beetle _beetle;
        private DispatcherTimer _dispatcher;
      
        public MainWindow()
        {
            InitializeComponent();

            _beetle = new Beetle(paperCanvas, 30, 40, 10);
            _dispatcher = new DispatcherTimer();
            _dispatcher.Interval = TimeSpan.FromMilliseconds(2);
            //_dispatcher.Tick += MoveBeetle
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.ChangePosition();
        }
    }
};

