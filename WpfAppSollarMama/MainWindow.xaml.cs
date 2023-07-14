using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Shell;
using System.Windows.Threading;


namespace WpfAppSollarMama
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double centerX;
        private double centerY;
        private double mercuryRadius;
        private double venusRadius;
        private double eathRadius;
        private double marsRadius;
        private double jupiterRadius;
        private double saturnRadius;
        private double uranusRadius;
        private double neptunRadius;
        private double angle;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();


            // Получение центра холста
            centerX = canvas.ActualWidth / 2 ;
            centerY = canvas.ActualHeight / 2 ;

            // Задание радиуса окружности
            mercuryRadius = 150;
            venusRadius = 150;
            eathRadius = 200;
            marsRadius = 250;
            jupiterRadius = 300;
            saturnRadius = 370;
            uranusRadius = 470;
            neptunRadius = 470;

           // Задание начального угла
           angle = 2000;

            // Создание и настройка таймера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
       }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Вычисление новых координат объекта

            double mercuryX = centerX + mercuryRadius * Math.Cos(5);
            double mercuryY = centerY + mercuryRadius * Math.Sin(5);
            double venusX = centerX + venusRadius * Math.Cos(5);
            double venusY = centerY + venusRadius * Math.Sin(5);
            double marsX = centerX + marsRadius * Math.Cos(5);
            double marsY = centerY + marsRadius * Math.Sin(5);
            double eathX = centerX + eathRadius * Math.Cos(5);
            double eathY = centerY + eathRadius * Math.Sin(5);
            double jupiterX = centerX + jupiterRadius * Math.Cos(5);
            double jupiterY = centerY + jupiterRadius * Math.Sin(5);
            double saturnX = centerX + saturnRadius * Math.Cos(5);
            double saturnY = centerY + saturnRadius * Math.Sin(5);
            double uranusX = centerX + uranusRadius * Math.Cos(5);
            double uranusY = centerY + uranusRadius * Math.Sin(5);
            double neptunX = centerX + neptunRadius * Math.Cos(5);
            double neptunY = centerY + neptunRadius * Math.Sin(5);

            // Установка новых координат объекта
            RotateTransform mercuryTrans = new RotateTransform();
            mercuryTrans.CenterX = mercuryX - Mercury.Width / 2;
            mercuryTrans.CenterY = mercuryY - Mercury.Height / 2;
            mercuryTrans.Angle = angle;

            Mercury.RenderTransform = mercuryTrans;

            RotateTransform venusTrans = new RotateTransform();
            venusTrans.CenterX = venusX - Venus.Width / 2;
            venusTrans.CenterY = venusY - Venus.Height / 2;
            venusTrans.Angle = angle;

            Venus.RenderTransform = mercuryTrans;

            RotateTransform eathTrans = new RotateTransform();
            eathTrans.CenterX = eathX - Eath.Width / 2;
            eathTrans.CenterY = eathY - Eath.Height / 2;
            eathTrans.Angle = angle;

            Eath.RenderTransform = eathTrans;

            RotateTransform marsTrans = new RotateTransform();
            marsTrans.CenterX = marsX - Mars.Width / 2;
            marsTrans.CenterY = marsY - Mars.Height / 2;
            marsTrans.Angle = angle;

            Mars.RenderTransform = marsTrans;

            RotateTransform jupiterTrans = new RotateTransform();
            jupiterTrans.CenterX = jupiterX - Jupiter.Width / 2;
            jupiterTrans.CenterY = jupiterY - Jupiter.Height / 2;
            jupiterTrans.Angle = angle;

            Jupiter.RenderTransform = jupiterTrans;

            RotateTransform saturnTrans = new RotateTransform();
            saturnTrans.CenterX = saturnX - Saturn.Width / 2;
            saturnTrans.CenterY = saturnY - Saturn.Height / 2;
            saturnTrans.Angle = angle;

            Saturn.RenderTransform = saturnTrans;

            RotateTransform uranusTrans = new RotateTransform();
            uranusTrans.CenterX = uranusX - Uranus.Width / 2;
            uranusTrans.CenterY = uranusY - Uranus.Height / 2;
            uranusTrans.Angle = angle;

            Uranus.RenderTransform = uranusTrans;

            RotateTransform neptunTrans = new RotateTransform();
            neptunTrans.CenterX = neptunX - Mercury.Width / 2;
            neptunTrans.CenterY = neptunY - Mercury.Height / 2;
            neptunTrans.Angle = angle;

            Neptun.RenderTransform = neptunTrans;

            // Проверка, чтобы угол не вышел за пределы 2*pi
            if (angle > 2 * Math.PI)
            {
                angle -= 2 * Math.PI;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
