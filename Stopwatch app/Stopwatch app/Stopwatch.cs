using System;

namespace Stopwatch_app
{
    public class Stopwatch
    {
        private DateTime _startTime = new DateTime();
        private DateTime _stopTime = new DateTime();
        private TimeSpan _duration = new TimeSpan();
        private bool _started = false;

        public void Start()
        {
            if (!_started)
            {
                _startTime = DateTime.Now;
                _started = true;
            }
            else
            {
                Console.WriteLine("Timer already running!");
            }
        }

        public void Stop()
        {
            if (_started)
            {
                _stopTime = DateTime.Now;
                _started = false;
            }
            else
            {
                Console.WriteLine("Timer never started!");
            }
        }

        public string Duration()
        {
            if (_started)
            {
                _duration = DateTime.Now - _startTime;
            }
            else
            {
                _duration = _stopTime - _startTime;
            }

            // Console.WriteLine("{0}:{1}:{2}:{3}", _duration.Hours, _duration.Minutes, _duration.Seconds, _duration.Milliseconds);
            return String.Format("{0}:{1}:{2}:{3}", _duration.Hours, _duration.Minutes, _duration.Seconds, _duration.Milliseconds);

        }
    }
}
