using System;
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
using Tick_Tick;
using Windows.UI.Xaml.Media.Imaging;


// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Tick_Tick
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool isStart;
        private StopWatch stopWatch;
        private ImageSource imageStart;
        private ImageSource imagePause;


        public MainPage()
        {
            

            this.InitializeComponent();
            imageStart = LoadImage("ms-appx:///Assets/start.png");
            imagePause = LoadImage("ms-appx:///Assets/pause.png");

        }

        private void startPauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch == null) { stopWatch = new StopWatch(); }

            if (!isStart)
            {
                stopWatch.Start();
                isStart = !isStart;
                stopWatch.GetTime(timeText,millisecText);
                startPauseIcon.Source = imagePause;
            }
            else
            {
                stopWatch.Pause();
                isStart = !isStart;
                startPauseIcon.Source = imageStart;
            }
            
        }

       private ImageSource LoadImage(string url)
        {
                Image img = new Image();
           
                BitmapImage bitmapImage = new BitmapImage();
                //img.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri(url);
                img.Source = bitmapImage;
                return img.Source;
        }
    }
}
