//written by mahlet asmare
// 3/30/2021;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test22
{
    public class GoldenGlobe : Interface1
    {
        // class variables 
        private string year = "n/a";
        private string category = "n/a";
        private string winner = "n/a";
        private string country = "n/a";

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
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        // constructors 

        public GoldenGlobe( string yr, string cat, string win, string co)
        {
            this.Year = yr;
            this.Category = cat;
            this.Winner = win;
            this.Country = co;
        }

        // methods 

        public string DisplayAward()
        {
            return "this award is from the glden glolobes!!";
        }
        public override string ToString()
        {
            string msg = "";
            msg += DisplayAward() + "\n";
            return msg;

        }
    }
    }
