using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class GSMTest
    {
        public GSMTest()
        { 
        }

        public void Test()
        {
            GSM firstGSM = new GSM("C2-01", "Nokia INC", "100");

            Display secondDisplay = new Display(2.3, 16000000);
            GSM secondGSM = new GSM("C2-03", "Nokia INC", "200", "Me", null, secondDisplay);

            Battery thirdBattery = new Battery(BatteryType.LiIon, 240, 13);
            GSM thirdGSM = new GSM("IPhone", "Apple", "1200", "NotMe", thirdBattery, null);

            GSM[] gsms = new GSM[] { firstGSM, secondGSM, thirdGSM };

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
