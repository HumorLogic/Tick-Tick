using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Tick_Tick
{
    class StopWatch
    {
        private bool isRun;
        private string timeStr;
        private int secend;
        private string secendStr;
        private string minuteStr;
        private string hourStr;



        public StopWatch()
        {
            isRun = false;
            timeStr = "00:00:00;";
            secend=0;
            secendStr = "00";
            minuteStr = "00";
            hourStr = "00";
        }
        
        public void  Start()
        {
            isRun = true;
        }

        public void Pause()
        {
            isRun = false;
        }

        public async void GetTime(TextBlock textBlock)
        {
            while (isRun)
            {
                await Task.Delay(1000);
                secend += 1;
                if (secend > 9) { secendStr = secend.ToString(); }
                else { secendStr = "0" + secend.ToString(); }

                timeStr = $"{hourStr}:{minuteStr}:{secendStr}";
                textBlock.Text = timeStr;
            }


        }
    }
}
