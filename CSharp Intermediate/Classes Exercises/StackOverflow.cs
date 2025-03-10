using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Classes_Exercises
{
    class StackOverflow
    {
        private string _title, _description;
        private DateTime _dateTime;
        private int _voteCount;

        public StackOverflow(string title)
        {
            _title = title;
            _dateTime = DateTime.Now;
        }

        public StackOverflow(string title, string description, DateTime dateTime) 
            : this(title)
        {
            _description = description;
        }

        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public int ShowVotes()
        {
            return _voteCount;
        }
    }
}
