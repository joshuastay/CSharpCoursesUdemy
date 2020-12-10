using System;

namespace StackOvermimic
{
    public class Post
    {
        private int _voteValue;
        private string _title;
        private string _description;
        private DateTime _dateTime;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _dateTime = DateTime.Now;
            _voteValue = 1;
        }

        public void UpVote()
        {
            _voteValue += 1;
        }
        public void DownVote()
        {
            _voteValue -= 1;
        }
        public int Votes
        {
            get
            {
                return _voteValue;
            }
        }

    }
}
