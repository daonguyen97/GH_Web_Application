using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace GH_Web_Application.Models
{
    public class Feedback
    {
        public string FeedbackID { get; set; }
        public string UserID { get; set; }
        public string FeedbackDetails { get; set; }
        public DateTime DateTime { get; set; }

        //Constructor
        public Feedback()
        {

        }
        public Feedback(DataRow row)
        {
            FeedbackID = row["FEEDBACKID"].ToString();
            UserID = row["USERID"].ToString();
            FeedbackDetails = row["FEEDBACKDETAILS"].ToString();
            this.DateTime= Convert.ToDateTime(row["DATETIME"].ToString());
        }
    }
}
