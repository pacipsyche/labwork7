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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class ButtonWindow : Window
    {
        private Random random = new Random();

        public ButtonWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            double newLeft = random.Next(0, (int)(this.ActualWidth - Button.ActualWidth));
            double newTop = random.Next(0, (int)(this.ActualHeight - Button.ActualHeight));

            DoubleAnimation leftAnimation = new DoubleAnimation
            {
                To = newLeft,
                Duration = TimeSpan.FromMilliseconds(300)
            };

            DoubleAnimation topAnimation = new DoubleAnimation
            {
                To = newTop,
                Duration = TimeSpan.FromMilliseconds(300)
            };

            Button.BeginAnimation(Canvas.LeftProperty, leftAnimation);
            Button.BeginAnimation(Canvas.TopProperty, topAnimation);
        }
    }
}