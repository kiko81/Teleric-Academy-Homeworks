namespace GSM
{
    using System;

    public class Call
    {
        private DateTime date;
        private int duration;
        private string dialedPhone;

        public Call(DateTime callDateTime, int seconds, string phoneNumber)
        {
            this.Date = callDateTime;
            this.Duration = seconds;
            this.DialedPhone = phoneNumber;
        }

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            private set { this.duration = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }



        public override string ToString()
        {
            return string.Format("Date and time: {0:G} \nDuration: {1} seconds \nDialed number: {2}",
                this.Date, this.Duration, this.DialedPhone);
        }
    }
}