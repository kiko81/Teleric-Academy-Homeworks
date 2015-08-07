namespace SolarSystem
{
    using System;
    using System.ComponentModel;
    using System.Windows.Threading;

    class OrbitsCalculator : INotifyPropertyChanged
    {
        private DateTime startTime;
        private DispatcherTimer timer;

        const double EarthYear = 365.25;
        const double EarthRotationPeriod = 1.0;
        const double SunRotationPeriod = 25.0;

        private double daysPerSecond = 2;
        public double DaysPerSecond
        {
            get { return daysPerSecond; }
            set { daysPerSecond = value; Update("DaysPerSecond"); }
        }

        public double EarthOrbitRadius { get { return 40; } set { } }
        public double Days { get; set; }
        public double EarthRotationAngle { get; set; }
        public double SunRotationAngle { get; set; }
        public double EarthOrbitPositionX { get; set; }
        public double EarthOrbitPositionY { get; set; }
        public bool ReverseTime { get; set; }

        public OrbitsCalculator()
        {
            EarthOrbitPositionX = EarthOrbitRadius;
            DaysPerSecond = 2;
        }

        public void StartTimer()
        {
            startTime = DateTime.Now;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void StopTimer()
        {
            timer.Stop();
            timer.Tick -= OnTimerTick;
            timer = null;
        }

        public void Pause(bool doPause)
        {
            if (doPause)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            Days += (now-startTime).TotalMilliseconds * DaysPerSecond / 1000.0 * (ReverseTime?-1:1);
            startTime = now;
            Update("Days");
            OnTimeChanged();
        }

        private void OnTimeChanged()
        {
            EarthPosition();
            EarthRotation();
            SunRotation();
        }

        private void EarthPosition()
        {
            double angle = 2 * Math.PI * Days / EarthYear;
            EarthOrbitPositionX = EarthOrbitRadius * Math.Cos(angle);
            EarthOrbitPositionY = EarthOrbitRadius * Math.Sin(angle);
            Update("EarthOrbitPositionX");
            Update("EarthOrbitPositionY");
        }

        private void EarthRotation()
        {
            //for (decimal step = 0; step <= 360; step+=0.00005m)
            //{
            //    EarthRotationAngle = ((double)step) * Days / EarthRotationPeriod;
            //}

            EarthRotationAngle = 360 * Days / EarthRotationPeriod;

            Update("EarthRotationAngle");
        }

        private void SunRotation()
        {
            SunRotationAngle = 360 * Days / SunRotationPeriod;
            Update("SunRotationAngle");
        }

        private void Update(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
