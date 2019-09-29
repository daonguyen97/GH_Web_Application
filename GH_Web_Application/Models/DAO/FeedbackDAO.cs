using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace GH_Web_Application.Models.DAO
{
    public class FeedbackDAO
    {
        public static Feedback GetFeedback(int? id)
        {
            return new Feedback();
        }
        public static IEnumerable<Feedback> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            string commandstr = "SELECT * FROM GH_FEEDBACK";
            DataTable data = DbAccess.ExecuteQuery(commandstr);
            foreach (DataRow item in data.Rows)
            {
                Feedback feedback = new Feedback(item);
                feedbacks.Add(feedback);
            }

            return feedbacks;
        }
    }
}
