using System;

namespace StopWatchApp
{
    public class Stopwatch
    {
        private bool _isRunning = false;
        private DateTime _startingTime;
        private DateTime _endingTime;
        public void Start()
        {
            if (_isRunning == true)
            {
               throw new InvalidOperationException("Stopwatch is already started");
            }
           
                _startingTime = DateTime.Now;
                _isRunning = true;           
        }

        public void Stop()
        {
            _isRunning = false;
            _endingTime = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            return _endingTime - _startingTime;
        }
    }
}
