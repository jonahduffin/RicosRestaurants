using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RicosRestaurants.Models
{
    public class SubmissionStorage
    {
        private static List<RestaurantSubmission> submissions = new List<RestaurantSubmission>();

        public static IEnumerable<RestaurantSubmission> Submissions => submissions;

        public static void AddSubmission(RestaurantSubmission newSubmission)
        {
            submissions.Add(newSubmission);
        }
    }
}
