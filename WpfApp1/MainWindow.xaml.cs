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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        bool burgerButtonVerif = false;
        bool TextBoxVerif = false;
        bool online = false;
        bool IfadeVerid = false;

        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
            WriteAMessage.Text = "Write a message...";
            scrolView.Visibility = Visibility.Hidden;
            stackPanelMesaj.Visibility = Visibility.Hidden;
            IfadeSlot.Visibility = Visibility.Hidden;
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            User.Text = "Ivan Williams";
            index = 1;
            
            scrolView.Visibility = Visibility.Visible;
            stackPanelMesaj.Visibility = Visibility.Visible;

            Random random = new Random();
            int rnd = random.Next(1, 3);
            if(rnd == 1)
            {
                onlieStat.Text = "online";
                onlieStat.Foreground = Brushes.Green;
                online = true;
            }
            else
            {
                onlieStat.Text = "ofline";
                onlieStat.Foreground = Brushes.Red;
                online = false;
            }
        }


        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            User.Text = "Isabel Walker";
            index = 2;

            scrolView.Visibility = Visibility.Visible;
            stackPanelMesaj.Visibility = Visibility.Visible;

            Random random = new Random();
            int rnd = random.Next(1, 3);
            if (rnd == 1)
            {
                onlieStat.Text = "online";
                onlieStat.Foreground = Brushes.Green;
                online = true;
            }
            else
            {
                onlieStat.Text = "ofline";
                onlieStat.Foreground = Brushes.Red;
                online = false;
            }
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            User.Text = "Tommy Gordon";
            index = 3;

            scrolView.Visibility = Visibility.Visible;
            stackPanelMesaj.Visibility = Visibility.Visible;

            Random random = new Random();
            int rnd = random.Next(1, 3);
            if (rnd == 1)
            {
                onlieStat.Text = "online";
                onlieStat.Foreground = Brushes.Green;
                online = true;
            }
            else
            {
                onlieStat.Text = "ofline";
                onlieStat.Foreground = Brushes.Red;
                online = false;
            }
        }


        private void StackPanel_MouseMove(object sender, MouseEventArgs e) 
        {
            Ivan.Background = Brushes.Black;
            IvanMesaj.Source = new BitmapImage(new Uri("Image/whiteTelegram.png", UriKind.Relative));
            IvanName.Foreground = Brushes.White;
            sonVaxt1.Foreground = Brushes.White;
            sonMesaj1.Foreground = Brushes.White;
        }

        private void Ivan_MouseLeave(object sender, MouseEventArgs e) 
        { 
            Ivan.Background = Brushes.White;
            IvanMesaj.Source = new BitmapImage(new Uri("Image/blackTelegram.png", UriKind.Relative));
            IvanName.Foreground = Brushes.Black;
            sonVaxt1.Foreground = Brushes.Black;
            sonMesaj1.Foreground = Brushes.Black;
        }

        private void Isabel_MouseMove(object sender, MouseEventArgs e)
        {
            Isabel.Background = Brushes.Black;
            IsabelMesaj.Source = new BitmapImage(new Uri("Image/whiteTelegram.png", UriKind.Relative));
            IsabelName.Foreground = Brushes.White;
            sonVaxt2.Foreground = Brushes.White;
            sonMesaj2.Foreground = Brushes.White;
        }

        private void Isabel_MouseLeave(object sender, MouseEventArgs e)
        {
            Isabel.Background = Brushes.White;
            IsabelMesaj.Source = new BitmapImage(new Uri("Image/blackTelegram.png", UriKind.Relative));
            IsabelName.Foreground = Brushes.Black;
            sonVaxt2.Foreground = Brushes.Black;
            sonMesaj2.Foreground = Brushes.Black;
        }

        private void Tommy_MouseMove(object sender, MouseEventArgs e)
        {
            Tommy.Background = Brushes.Black;
            TommyMesaj.Source = new BitmapImage(new Uri("Image/whiteTelegram.png", UriKind.Relative));
            TommyName.Foreground = Brushes.White;
            sonVaxt3.Foreground = Brushes.White;
            sonMesaj3.Foreground = Brushes.White;
        }

        private void Tommy_MouseLeave(object sender, MouseEventArgs e)
        {
            Tommy.Background = Brushes.White;
            TommyMesaj.Source = new BitmapImage(new Uri("Image/blackTelegram.png", UriKind.Relative));
            TommyName.Foreground = Brushes.Black;
            sonVaxt3.Foreground = Brushes.Black;
            sonMesaj3.Foreground = Brushes.Black;
        }

        private void burgerButton_Click(object sender, RoutedEventArgs e)
        {
            if(burgerButtonVerif == false) 
            {
                burgerCatagoriColor.Visibility = Visibility;
                burgerCatagoriColor.Background = Brushes.Black;

                Exit.Visibility = Visibility;

                burgerD.Source = new BitmapImage(new Uri("Image/back.png", UriKind.Relative));

                borderXet.Margin = new Thickness(64, 10, 0, 80);

                listBoxMargin.Margin = new Thickness(60, 20, 0, 0); 
                burgerButtonVerif = true;
                marginRest1.Margin = new Thickness(0, 0, 0, 0);
                sonVaxt1.Margin = new Thickness(18, 12, 0, 0);
                sonMesaj1.Width = 150;
                IvanMesaj.Margin = new Thickness(10,5,0,0);

                listBoxMargin.Margin = new Thickness(60, 20, 0, 0);
                burgerButtonVerif = true;
                marginRest2.Margin = new Thickness(0, 0, 0, 0);
                sonVaxt2.Margin = new Thickness(19, 12, 0, 0);
                sonMesaj2.Width = 150;
                IsabelMesaj.Margin = new Thickness(10, 5, 0, 0);

                listBoxMargin.Margin = new Thickness(60, 20, 0, 0);
                burgerButtonVerif = true;
                marginRest3.Margin = new Thickness(0, 0, 0, 0);
                sonVaxt3.Margin = new Thickness(0, 12, 0, 0);
                sonMesaj3.Width = 150;
                TommyMesaj.Margin = new Thickness(10, 5, 0, 0);
            }
            else 
            {

                burgerCatagoriColor.Visibility = Visibility.Hidden;
                
                Exit.Visibility = Visibility.Hidden;


                burgerD.Source = new BitmapImage(new Uri("Image/menuu.png", UriKind.Relative));


                borderXet.Margin = new Thickness(0, 10, 0, 80);

                listBoxMargin.Margin = new Thickness(0, 20, 0, 0); 
                burgerButtonVerif = false;
                marginRest1.Margin = new Thickness(20, 0, 0, 0);
                sonVaxt1.Margin = new Thickness(50, 12, 0, 0);
                sonMesaj1.Width = 175;
                IvanMesaj.Margin = new Thickness(20, 5, 0, 0);


                listBoxMargin.Margin = new Thickness(0, 20, 0, 0);
                burgerButtonVerif = false;
                marginRest2.Margin = new Thickness(20, 0, 0, 0);
                sonVaxt2.Margin = new Thickness(50, 12, 0, 0);
                sonMesaj2.Width = 175;
                IsabelMesaj.Margin = new Thickness(20, 5, 0, 0);

                listBoxMargin.Margin = new Thickness(0, 20, 0, 0);
                burgerButtonVerif = false;
                marginRest3.Margin = new Thickness(20, 0, 0, 0);
                sonVaxt3.Margin = new Thickness(30, 12, 0, 0);
                sonMesaj3.Width = 175;
                TommyMesaj.Margin = new Thickness(20, 5, 0, 0);
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try { DragMove(); }
            catch (Exception) { throw; }

        }


        private void WriteAMessage_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TextBoxVerif == false)
            {
                WriteAMessage.Text = "";
                TextBoxVerif = true;
            }
            
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if(WriteAMessage.Text != "Write a message..." && WriteAMessage.Text.Length != 0)
            {

                string mesaj = WriteAMessage.Text.ToString();


                UserControl1 userControl1 = new UserControl1
                {
                    Width = 350,

                };

                userControl1.textMsj.Text = mesaj;
                
                if(index == 1)
                {
                    sonVaxt1.Text = DateTime.Now.ToShortTimeString();
                    sonMesaj1.Text = mesaj;
                }
                else if(index == 2)
                {
                    sonVaxt2.Text = DateTime.Now.ToShortTimeString();
                    sonMesaj2.Text = mesaj;

                }
                else if (index == 3)
                {
                    sonVaxt3.Text = DateTime.Now.ToShortTimeString();
                    sonMesaj3.Text = mesaj;

                }


                userControl1.Vaxt.Text = DateTime.Now.ToShortTimeString();
                WriteAMessage.Text = null;
                ListBoxYouChat.Items.Add(userControl1);


                UserControl3 userControl3 = new UserControl3
                {
                    Width = 350,

                };

                userControl3.textMsj3.Text = mesaj;


                ListBoxBootChat.Items.Add(userControl3);

                bot();

            }

        }

        public void bot()
        {

            int[] lastNumber = new int[] { };
            string[] RamizKaraeski = new string[] { "Hesap görmek hesap etmekten zordur yeğenim.", "Teslim olunmadan sadık olunmaz.", "Herkes öldürür sevdiğini.", "Bir şey olmuyorsa ya daha iyisi olacağı için, ya da gerçekten de olmaması gerektiği için olmuyordur.",
            "Seni ölüme götürse de, Doğrudan asla şaşmayacaksın.", "Uykun gelmiyor diye gözlerini suçlama, Belkide o beklediğin uyku değildir.", "Dön bak arkana yeğen. Gitmez dediğin kaç kişi yanında?", "Cesurun bakışı korkağın kılıcından keskindir yeğen!",
            "Sadakat ya birine doğru koşmaktır ya birinden kaçmaktır.", "Değişmek zordur yeğenim ama bazen. Aynı adam olmak daha zordur.", "Oyunun sonuna geldiğinde, çoktan tükenmiştir gidecek olduğun yerlerin.", "Ölüm gibidir sadakat. Bir kere çizgiyi geçtin mi geri dönüş yoktur.",
            "Kaderimiz olan aşka değil de aşkıyla kaderimizi değiştirene içelim !", "Ne kadar değişirsen değiş nerede mutlu olduysan hep oraya çevirirsin kafanı.", "Çözemedim bazılarını. Uzaktan mı adamlar adamlıktan mı uzaklar?", "Bazen öyle acır ki için değiştin sanırsın şimdi dersin. Şimdi her şeyi yapabilirim.",
            "Oysa herkes öldürür sevdiğini; kulak verin bu dediklerime...", "Kadere inanan insan tesadüfe inanmaz. Tesadüfe inanan adamsa kaderini kendi elinde tutamaz",
            "Herkesin kimseye anlatamadığı gizli bir sırrı, herkesin kimseye gösteremediği gizli bir yüzü vardır yeğen..", "Ben her şeyi olan ve kaybedeceği hiçbir şey olmayan insanım.", "Geçmişe dönmek başka, geçmişi silmek başka. Bir kere aktı mı zamanın içinden suyun yolu değişmez."};

            if (online == true)
            {

                Random rnd = new Random();
                int selection = rnd.Next(1, 4);


                if(selection == 1)
                {

                    int random = rnd.Next(0, 21);

                    UserControl2 userControl2 = new UserControl2
                    {
                        Width = 350,
                    };

                    userControl2.BootMsj.Text = RamizKaraeski[random];
                    userControl2.BootMsjVaxt.Text = DateTime.Now.ToShortTimeString();

                    ListBoxBootChat.Items.Add(userControl2);

                    UserControl3 userControl3 = new UserControl3
                    {
                        Width = 350,
                    };

                    userControl3.textMsj3.Text = RamizKaraeski[random];

                    ListBoxYouChat.Items.Add(userControl3);
                }
                else if (selection == 2)
                {
                    Random image = new Random();

                    UserImageControl userImageControl = new UserImageControl
                    {
                        Width = 350,
                    };

                    userImageControl.Vaxt.Text = DateTime.Now.ToShortTimeString();
                    userImageControl.ImageChat.Source = new BitmapImage(new Uri("ImageRamiz/ramiz" + $"{image.Next(1, 6)}" + ".jpg", UriKind.Relative));
                    ListBoxBootChat.Items.Add(userImageControl);

                    UserImageControl userImageControlCopy = new UserImageControl
                    {
                        Width = 350,
                        Background = Brushes.Transparent
                    };

                    userImageControlCopy.Vaxt.Text = "";
                    userImageControlCopy.BordeName.Background = Brushes.Transparent;
                    ListBoxYouChat.Items.Add(userImageControlCopy);

                }
                else if (selection == 3)
                {
                    UserSoundControl userSoundControl = new UserSoundControl
                    {
                        Width = 350
                    };

                    userSoundControl.Vaxt.Text = DateTime.Now.ToShortTimeString();
                    ListBoxBootChat.Items.Add(userSoundControl);


                    UserSoundControl userSoundControlBoot = new UserSoundControl
                    {
                        Width = 350
                    };

                    userSoundControlBoot.Vaxt.Visibility = Visibility.Hidden;
                    userSoundControlBoot.stackPanel.Visibility = Visibility.Hidden;
                    userSoundControlBoot.BordeName.Background = Brushes.Transparent;

                    ListBoxYouChat.Items.Add(userSoundControlBoot);

                }
            }
        }

        private void Image(object sender, RoutedEventArgs e)
        {
            Random image = new Random();

            UserImageControl userImageControl = new UserImageControl
            {
                Width = 350,
            };

            userImageControl.Vaxt.Text = DateTime.Now.ToShortTimeString();
            userImageControl.ImageChat.Source = new BitmapImage(new Uri("ImageRamiz/ramiz" + $"{image.Next(1,6)}" + ".jpg", UriKind.Relative));
            ListBoxYouChat.Items.Add(userImageControl);

            if(index == 1)
            {
                sonVaxt1.Text = DateTime.Now.ToShortTimeString();
                sonMesaj1.Text = "Image";
            }
            else if(index == 2)
            {
                sonVaxt2.Text = DateTime.Now.ToShortTimeString();
                sonMesaj2.Text = "Image";
            }
            else if (index == 3)
            {
                sonVaxt3.Text = DateTime.Now.ToShortTimeString();
                sonMesaj3.Text = "Image";
            }

            UserImageControl userImageControlCopy = new UserImageControl
            {
                Width = 350,
                Background = Brushes.Transparent
            };

            userImageControlCopy.Vaxt.Text = "";
            userImageControlCopy.BordeName.Background = Brushes.Transparent;
            ListBoxBootChat.Items.Add(userImageControlCopy);


            bot();

        }

        private void Sound(object sender, RoutedEventArgs e)
        {
            UserSoundControl userSoundControl = new UserSoundControl
            {
                Width = 350
            };

            userSoundControl.Vaxt.Text = DateTime.Now.ToShortTimeString();
            ListBoxYouChat.Items.Add(userSoundControl);



            UserSoundControl userSoundControlBoot = new UserSoundControl
            {
                Width = 350
            };

            userSoundControlBoot.Vaxt.Visibility = Visibility.Hidden;
            userSoundControlBoot.stackPanel.Visibility = Visibility.Hidden;
            userSoundControlBoot.BordeName.Background = Brushes.Transparent;

            ListBoxBootChat.Items.Add(userSoundControlBoot);


            if (index == 1)
            {
                sonVaxt1.Text = DateTime.Now.ToShortTimeString();
                sonMesaj1.Text = "Sound";
            }
            else if (index == 2)
            {
                sonVaxt2.Text = DateTime.Now.ToShortTimeString();
                sonMesaj2.Text = "Sound";
            }
            else if (index == 3)
            {
                sonVaxt3.Text = DateTime.Now.ToShortTimeString();
                sonMesaj3.Text = "Sound";
            }

            UserImageControl userImageControlCopy = new UserImageControl
            {
                Width = 350,
                Background = Brushes.Transparent
            };

            bot();
        }

        private void Ifade(object sender, RoutedEventArgs e)
        {
            
            if(IfadeVerid == false)
            {
                scrolView.Margin = new Thickness(0, 12, 0, 120);
                IfadeSlot.Visibility = Visibility.Visible;
                IfadeVerid = true;
            }
            else
            {
                scrolView.Margin = new Thickness(0, 12, 0, 55);
                IfadeSlot.Visibility = Visibility.Hidden;
                IfadeVerid = false;
            }

        }


        private void ifade1_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😆 "; }

        private void ifade2_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😭 "; }

        private void ifade3_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 🤣 "; }

        private void ifade4_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 🥰 "; }

        private void ifade5_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😎 "; }

        private void ifade6_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😍 "; }

        private void ifade7_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😖 "; }

        private void ifade8_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😋 "; }

        private void ifade9_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 😉 "; }

        private void ifade10_Click(object sender, RoutedEventArgs e) { WriteAMessage.Text += " 💩 "; }

        
    }
}
