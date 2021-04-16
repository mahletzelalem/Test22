// written by mahlet zelalem 
// 3/30/2021
using System;
using System.Collections.Generic;
using System.Text;

namespace Test22
{
    class Oscar : Interface1
    {

        // class variables 
        private string year = "n/a";
        private string category = "n/a";
        private string winner = "n/a";
       

        //gets and sets
        public string Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
        public string Winner
        {
            get { return this.winner; }
            set { this.winner = value; }
        }

        // constructors 

        public Oscar (string yr, string cat, string win)
        {
            this.Year = yr;
            this.Category = cat;
            this.Winner = win;
            
        }
        // method from the interface
        public string DisplayAward()
        {
            return "this award is from the oscars!!";
        }
        public override string ToString()
        {
            string msg = "";
            msg += DisplayAward() + "\n";
            return msg;

        }
    
    }
}
