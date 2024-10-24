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
using System.Windows.Media.Animation;

namespace WpfApp2
{
    public partial class PulsarWindow : Window
    {
        public PulsarWindow()
        {
            InitializeComponent();
            AnimatePulsar();
        }

        private void AnimatePulsar()
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0,
                To = 0.5,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            InnerStop.BeginAnimation(GradientStop.OffsetProperty, animation);
        }
    }
}
