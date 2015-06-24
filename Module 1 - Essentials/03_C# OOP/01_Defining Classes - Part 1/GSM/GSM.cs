namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        //private static GSM Iphone4S = new GSM("Iphone", "4S", 1000, "owner", new Battery("noname", 20, 5, Battery.BatteryType.NiMH), new Display(5, 16000));
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string manifacturer, string model)
        {  
            this.Manifacturer = manifacturer;
            this.Model = model;
            this.CallHistory = new List<Call>();
        }
        public GSM(string model, string manifacturer, decimal price, string owner, Battery battery, Display display) : this(manifacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            private set
            {
                if (value.Length > 1)
                {
                    this.manifacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Manifacturer name should not be empty");
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length > 1)
                {
                    this.model = value;                    
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Model name should should not be empty");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price should be > 0");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner; 
            }
            private set
            {
                this.owner = value;    
            }
        }

        public static GSM Iphone4S
        {
            get
            {
                return new GSM("Iphone", "4S", 1000, "owner", new Battery("noname", 20, 5, Battery.BatteryType.NiMH), new Display(5, 16000));
            }
            
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; }
        }


        public override string ToString()
        {
            return string.Format(@"Manifacturer: {0}
Model: {1}
Price: {2:f2}
Owner: {3}
Battery: {4}
Display: {5}",
             this.manifacturer, this.model, this.price, this.owner, this.Battery, this.Display);
        }

        public void AddCalls(Call call)
        {
            this.CallHistory.Add(call);
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }

        public decimal CalculateTotalCallsPrice(decimal price)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            decimal totalPrice = totalDuration * price / 60;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Call history:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }


    }
}
