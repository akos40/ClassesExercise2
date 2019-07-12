using System;

namespace ClassesExercise2
{
    public class Post
    {
        private string title;
        private string description;
        private DateTime date;
        private int votes = 0;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Votes
        {
            get { return votes; }
        }

        public void upVote()
        {
            votes++;
        }

        public void downVote()
        {
            votes--;
        }
    }
}
