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

namespace WPF_Task_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int index = 1;
        static string source = "Data/Picture1.jpg";

        public MainWindow()
        {
            InitializeComponent();
            myImage.Width = 200;
            myImage.Height = 260;
            reflectionImage.Width = 200;
            reflectionImage.Height = 250;
            scaleTr.CenterY = 130;

            var uriImageSource = new Uri(source, UriKind.RelativeOrAbsolute);
            myImage.Source = new BitmapImage(uriImageSource);
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            int a = e.Delta;

            if (a > 0)
                index += 1;
            else
                index -= 1;

            if (index == 9)
                index = 1;
            else if (index == 0)
                index = 8;

            source = "Data/Picture" + index + ".jpg";
            var uriImageSource = new Uri(source, UriKind.RelativeOrAbsolute);
            myImage.Source = new BitmapImage(uriImageSource);
        }

        private void myImage_MouseEnter(object sender, MouseEventArgs e)
        {
            myImage.Width = 300;
            myImage.Height = 390;
            reflectionImage.Width = 300;
            reflectionImage.Height = 375;
            scaleTr.CenterY = 200;
        }

        private void myImage_MouseLeave(object sender, MouseEventArgs e)
        {
            myImage.Width = 200;
            myImage.Height = 260;
            reflectionImage.Width = 200;
            reflectionImage.Height = 250;
            scaleTr.CenterY = 130;
        }
    }
}
