using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpIntermediate.Classes_Exercises
{
    class StopwatchExercise
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _state;


            
        public void Start()
        {
            if (_state)
                throw new InvalidOperationException("Stopwatch is already running");

            _state = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_state)
                throw new InvalidOperationException("Stopwatch hasn't started yet");

            _state = false;
            _stopTime = DateTime.Now;
        }

        public TimeSpan ElapsedTime()
        {
            return _stopTime - _startTime;
        }
    }
}
