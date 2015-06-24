namespace GSM
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd,
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryTypes = type;
        }

        public Battery(){ }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryTypes { get; set; }

        public override string ToString()
        {
            return string.Format("Model: {0}, Hour idle: {1}, Hours talk {2}, Type: {3}", this.model, this.hoursIdle, this.hoursTalk, this.BatteryTypes);
        }


    }
}
