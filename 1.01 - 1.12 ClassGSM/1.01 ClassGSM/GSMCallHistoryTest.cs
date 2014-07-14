using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class GSMCallHistoryTest
    {
        public GSMCallHistoryTest()
        {}

        public void Test()
        {



            GSM myGsm = new GSM("WTF-5610", "Samsung", "0", "Me");
            Battery myGsmBattery = new Battery(BatteryType.LiIon, 5, 10);
            Display mygGsmDisplay = new Display(5, 256);
            myGsm.DisplayProperties = mygGsmDisplay;

            Call call1 = new Call(DateTime.Now, "+35911111111", 50);
            Call call2 = new Call(DateTime.Now, "+35922222222", 123);
            Call call3 = new Call(DateTime.Now, "+35933333333", 30);

            myGsm.AddCall(call1);
            myGsm.AddCall(call2);
            myGsm.AddCall(call3);

            foreach (var item in myGsm.callHistory)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Cost of all calls: " + myGsm.CostOfAllCalls());

            Call longestCall = myGsm.callHistory[0];
            int br = 0;
            int index = 0;
            foreach (var item in myGsm.callHistory)
            {
                if (item.Duration > longestCall.Duration)
                {
                    longestCall = item;
                    index = br;
                }
                br++;
            }

            myGsm.DeleteCall(index);
            Console.WriteLine("After deletion of longest call: ");

            Console.WriteLine("Cost of all calls: " + myGsm.CostOfAllCalls());

            myGsm.DeleteAllCallHistory();
            foreach (var item in myGsm.callHistory)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
