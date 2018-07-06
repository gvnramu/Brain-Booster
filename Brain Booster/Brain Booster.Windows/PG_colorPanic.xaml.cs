using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Brain_Booster
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PG_colorPanic : Page
    {
        private int score = 0, i = 0;
        private DispatcherTimer timer;

        public PG_colorPanic()
        {

            this.InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, object e)
        {

            txtBlock_timer.Text = Convert.ToString(i);
            i++;
            if (i == 11)
                timer.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (Convert.ToString(b.Content) == txtBlock_C_T.Text || Convert.ToString(b.Background).Equals(txtBlock_C_T) )
            {
                int n = RandomGenerator();

                
                txtBlock_scoreVal.Text = Convert.ToString(score + 200);
                switch (n)
                {
                    case 1:
                        txtBlock_Color_Text.Text = "Text :";
                        txtBlock_C_T.Text = "Yellow";
                        btn_green.Background = new SolidColorBrush(Colors.Blue);
                        btn_red.Background = new SolidColorBrush(Colors.Yellow);
                        btn_blue.Background = new SolidColorBrush(Colors.Green);
                        btn_yellow.Background = new SolidColorBrush(Colors.Red);
                        btn_green.Content = "Blue";
                        btn_blue.Content = "Yellow";
                        btn_red.Content = "Green";
                        btn_yellow.Content = "Red";
                        break;
                    case 2:
                        
                        txtBlock_Color_Text.Text = "Color :";
                        txtBlock_C_T.Text = "Blue";
                        btn_green.Background = new SolidColorBrush(Colors.Yellow); //Color color = Color.FromArgb(rnd.Next(128), rnd.Next(255));
                        btn_red.Background = new SolidColorBrush(Colors.Green);
                        btn_blue.Background = new SolidColorBrush(Colors.Red);
                        btn_yellow.Background = new SolidColorBrush(Colors.Blue);
                        btn_green.Content = "Yellow";
                        btn_blue.Content = "Red";
                        btn_red.Content = "Blue";
                        btn_yellow.Content = "Green";
                        break;
                    case 3:
                        txtBlock_Color_Text.Text = "Text :";
                        txtBlock_C_T.Text = "Green";
                        btn_green.Background = new SolidColorBrush(Colors.Blue);
                        btn_red.Background = new SolidColorBrush(Colors.Red);
                        btn_blue.Background = new SolidColorBrush(Colors.Yellow);
                        btn_yellow.Background = new SolidColorBrush(Colors.Green);
                        btn_green.Content = "Blue";
                        btn_blue.Content = "Red";
                        btn_red.Content = "Yellow";
                        btn_yellow.Content = "Green";
                        break;
                    case 4:
                        txtBlock_Color_Text.Text = "Color :";
                        txtBlock_C_T.Text = "Red";
                        btn_green.Background = new SolidColorBrush(Colors.Blue);
                        btn_red.Background = new SolidColorBrush(Colors.Red);
                        btn_blue.Background = new SolidColorBrush(Colors.Yellow);
                        btn_yellow.Background = new SolidColorBrush(Colors.Green);
                        btn_green.Content = "Blue";
                        btn_blue.Content = "Red";
                        btn_red.Content = "Green";
                        btn_yellow.Content = "Yellow";
                        break;
                }

            }
           

        }
        Random rnd = new Random();
        private int RandomGenerator()
        {
            return rnd.Next(1, 5);
        }
    }
   
}
