using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery(BatteryType.LiIon, 240, 13);
            Display display = new Display(2.3, 16000000);


            GSM Nokia = new GSM("C2-01", "Nokia INC", "100");
            Nokia.Owner = "Marian";
            Nokia.BatteryHaracteristics = battery;
            Nokia.DisplayProperties = display;

            Console.WriteLine(Nokia.ToString());

            //GSMTest gsmTest = new GSMTest();
            //gsmTest.Test();

            GSMCallHistoryTest callHistoryTest = new GSMCallHistoryTest();
            callHistoryTest.Test();
        }
    }
}
