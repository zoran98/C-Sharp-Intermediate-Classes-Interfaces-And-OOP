using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    public class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime DateTime { get; set; }

        private int Vote {  get; set; }


        public Post(string title, string description, DateTime dateTime)
        {
            this.Title = title;
            this.Description = description;
            this.DateTime = dateTime;
            this.Vote = 0;
        }

        public void Up_Vote()
        {
            Vote++;
        }

        public void Down_Vote()
        {
            if(Vote == 0)
            {
                Vote = 0;
            } else 
            Vote--;
        }

        public int ShowVote()
        {
            return Vote;
        }
    }
}
