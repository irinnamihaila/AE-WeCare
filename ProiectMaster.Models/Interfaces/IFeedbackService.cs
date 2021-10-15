using ProiectMaster.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.Interfaces
{
    public interface IFeedbackService
    {
        IEnumerable<FeedbackVM> GetAllReviews();
        FeedbackVM GetReview(int id);
        void AddReview(FeedbackVM dto);
        void UpdateReview(int id, FeedbackVM dto);
        void DeleteReview(int id);

    }
}
