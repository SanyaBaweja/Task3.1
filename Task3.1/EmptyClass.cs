using System;
namespace Clock
{
    public class Clock
    {
        Counter _sec = new("Seconds");
        Counter _min = new("Minutes");
        Counter _hrs = new("Hours");

        public void IncrementClock()
        {
            _sec.Increment();
            if (_sec.Ticks == 60)
            {
                _sec.Reset();
                _min.Increment();

                if (_min.Ticks == 60)
                {
                    _min.Reset();
                    _hrs.Increment();

                    if (_hrs.Ticks == 24)
                    {
                        _hrs.Reset();

                    }
                }
            }
        }


        public string Output()
        {
            return $"{_hrs.Ticks:00} : {_min.Ticks:00} : {_sec.Ticks:00}";
        }

        //      public void ResetClock()
        //{
        //	_hrs.Reset();
        //	_min.Reset();
        //	_sec.Reset();
        //}
    }
}
