using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        static string iPhone4S;
        private List<Call> callHistory;

        Battery battery = new Battery();
        Display display = new Display();

        public GSM()
        {
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        private List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public static string IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public override string ToString()
        {
            string model = Model.ToString();
            return "Model: " + model;
            string manufacturer = Manufacturer.ToString();
            return "Manufacturer: " + manufacturer;
            string price = Price.ToString();
            return "Pwner: " + price;
            string owner = Owner.ToString();
            return "Owner: " + owner;
        }
                
        public void PrintInfo()
        {
            Console.WriteLine();
        }

        public void AddCall()
        {
            Call addCall = new Call();
            this.callHistory.Add(addCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void TotalPrice(double price)
        {
            uint total = 0;

            for (int i = 0; i < this.callHistory.Count; i++ )
            {
                total += callHistory[i].CallDurationSec;
            }
        }
    }
}
