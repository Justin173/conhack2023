//justin
using System;
using System.Reflection.Metadata.Ecma335;

namespace conhack2023
{
    internal class comment
    {
        public comment()
        {
            string account;
            string paragraph;
            DateTime datePosted;
            bool hasTimeStamp;
            uint timeStamp;
        }



        public string commentToSQL()
        {
            return "";
        }


        //getters
        public string getCommentName()
        {
            return account;
        }
        public string getCommentParagraph()
        {
            return "";
        }
        public DateTime getCommentDate()
        {
            DateTime date = new DateTime();
            return date;
        }

    }
    
}
