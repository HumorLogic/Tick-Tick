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
        private int millisec,secend, minute, hour;
        private string millisecStr,secendStr, minuteStr, hourStr;


        public StopWatch()
        {
            isRun = false;
            timeStr = "00:00:00;";
            millisec = 0;
            secend = 45;
            minute = 58;
            hour = 2;
            secendStr = "00";
            minuteStr = "00";
            hourStr = "00";
            millisecStr = "00";
        }

        public void Start()
        {
            isRun = true;
        }

        public void Pause()
        {
            isRun = false;
        }

        public async void GetTime(TextBlock textBlock,TextBlock millisecText)
        {
            while (isRun)
            {
               await Task.Delay(10);
                millisec += 1;

                if (millisec > 9) {
                    if (millisec > 99) { millisec = 0; secend += 1; }
                    millisecText.Text = "."+millisec.ToString();
                  
                }
                else { millisecText.Text = ".0" + millisec.ToString(); }
              

                //calculate secend
                if (secend > 9)
                {
                    secendStr = secend.ToString();
                    if (secend == 60) { minute += 1; secend = 0; }
                }
                else { secendStr = "0" + secend.ToString(); }

                //calcutate minute
                if (minute > 9) 
                { 
                    minuteStr = minute.ToString();
                    if (minute == 60) { hour += 1; minute = 0; }
                }
                else { minuteStr = "0" + minute.ToString(); }

                //calculate hour
                if (hour > 9) { hourStr = hour.ToString(); }
                else { hourStr = "0" + hour.ToString(); }
             

                timeStr = $"{hourStr}:{minuteStr}:{secendStr}";
                textBlock.Text = timeStr;
            }

        }
    }
}
