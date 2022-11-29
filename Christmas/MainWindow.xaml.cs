using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace Christmas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        MediaPlayer musicPlayer = new MediaPlayer();
        public DispatcherTimer timer = new DispatcherTimer();
        CultureInfo culture = new CultureInfo("fi-FI");
        

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            me.Position = TimeSpan.FromMilliseconds(1);
        }

        //Luodaan käyttäjälle näyttö, josta ilmenee kappaleen kokonaispituus sekä senhetkinen kesto
        void Timer_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.Source != null)
            {
                if (musicPlayer.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", musicPlayer.Position.ToString(@"mm\:ss"), musicPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "Open up a new one!";
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //Tässä luodaan ehtolause, joka rajaa oikeuden avata luukkua ennen vaadittua päiväystä
            DateTime dt = new DateTime(2022, 12, 1);
            if (DateTime.Today >= dt)
            {
                btn1.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\1jingleBells.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
                        
        }
        
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 2);
            if (DateTime.Today >= dt)
            {
                btn2.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\2deckthehalls.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }  
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 3);
            if (DateTime.Today >= dt)
            {
                btn3.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\3epicxmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
      
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 4);
            if (DateTime.Today >= dt)
            {
                btn4.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\4happy-christmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
         
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 5);
            if (DateTime.Today >= dt)
            {
                btn5.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\5joyful-christmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 6);
            if (DateTime.Today >= dt)
            {
                btn6.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\6lastchristmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
             
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 7);
            if (DateTime.Today >= dt)
            {
                btn7.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\7ochristmastree.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 8);
            if (DateTime.Today >= dt)
            {
                btn8.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\8owls.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 9);
            if (DateTime.Today >= dt)
            {
                btn9.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\9our-first-snow.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
               
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 10);
            if (DateTime.Today >= dt)
            {
                btn10.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\10snowflakes.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }
           

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 11);
            if (DateTime.Today >= dt)
            {
                btn11.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\11silentnight.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }
            

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 12);
            if (DateTime.Today >= dt)
            {
                btn12.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\12wewish.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }
          
        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 13);
            if (DateTime.Today >= dt)
            {
                btn13.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\13uplifting.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 14);
            if (DateTime.Today >= dt)
            {
                btn14.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\14xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 15);
            if (DateTime.Today >= dt)
            {
                btn15.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\15xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
          
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 16);
            if (DateTime.Today >= dt)
            {
                btn16.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\16xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 17);
            if (DateTime.Today >= dt)
            {
                btn17.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\17xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
           
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 18);
            if (DateTime.Today >= dt)
            {
                btn18.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\18xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 19);
            if (DateTime.Today >= dt)
            {
                btn19.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\19xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
          
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 20);
            if (DateTime.Today >= dt)
            {
                btn20.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\20xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 21);
            if (DateTime.Today >= dt)
            {
                btn21.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\21xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 22);
            if (DateTime.Today >= dt)
            {
                btn22.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\22xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
        }
          

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 23);
            if (DateTime.Today >= dt)
            {
                btn23.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\23xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
            
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(2022, 12, 24);
            if (DateTime.Today >= dt)
            {
                btn24.Background = Brushes.Red;
                musicPlayer.Open(new Uri(@"C:\Users\jenni\source\repos\Christmas\Christmas\Music\24xmas.mp3", UriKind.RelativeOrAbsolute));
                musicPlayer.Play();
            }
             
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            musicPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            musicPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            musicPlayer.Stop();
        }
    }
}
