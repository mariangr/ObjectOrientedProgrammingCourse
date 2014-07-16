using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._07_Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            TimerCallback tcb = PrintCurrentTime;
            Console.WriteLine("{0} Creating timer.\n", DateTime.Now.ToString("hh:mm:ss"));
            Timer stateTimer = new Timer(tcb, autoEvent, 1000, 1000); 
            while (true)
            {
                autoEvent.Set();
            }
        }
        static void PrintCurrentTime(Object stateInfo)
        {
            Console.WriteLine("{0}", DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}
