using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class GSM
    {
        private static GSM iPhone4S = new GSM("IPhone", "Apple");
        public List<Call> callHistory = new List<Call>();
        public const double pricePerMinute = 0.37;


        public GSM(string model, string manufacturer, string price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryHaracteristics = battery;
            this.DisplayProperties = display;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public string Model { set; get; }
        public string Manufacturer { set; get; }
        public string Price { set; get; }
        public string Owner { set; get; }
        public Battery BatteryHaracteristics { set; get; }
        public Display DisplayProperties { set; get; }

        public static GSM IPhone4S
        { 
            get {return iPhone4S;}
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int number)
        {
            this.callHistory.RemoveAt(number);
        }

        public void DeleteAllCallHistory()
        {
            this.callHistory.Clear();    
        }

        public double CostOfAllCalls()
        {
            double time = 0;
            foreach (var call in callHistory)
            {
                time += call.Duration;
            }
            double price = (time/60)*(pricePerMinute);

            return price;
        }

        public override string ToString ()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Model:" + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);
            if (this.Price != null)
            {
                result.AppendLine("Price: " + this.Price);
            }
            if (this.Owner != null)
            {
                result.AppendLine("Owner: " + this.Owner);
            }
            if (this.BatteryHaracteristics != null)
            {
                result.AppendLine(this.BatteryHaracteristics.ToString());
            }
            if (this.DisplayProperties != null)
            {
                result.AppendLine(this.DisplayProperties.ToString());
            }
            return result.ToString();
        }
    }
}
