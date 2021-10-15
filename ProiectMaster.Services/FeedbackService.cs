using AutoMapper;
using ProiectMaster.DataAccess.Interfaces;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback, int> feedbackRep;
        private readonly IMapper mapper;

        public FeedbackService(IRepository<Feedback, int> feedbackRep, IMapper mapper)
        {
            this.feedbackRep = feedbackRep;
            this.mapper = mapper;
        }

        public void AddReview(FeedbackVM dto)
        {
            var entity = mapper.Map<Feedback>(dto); //din dto creeeaza o noua entitate
            feedbackRep.Add(entity);
        }

        public void DeleteReview(int id)
        {
            var entity = feedbackRep.GetInstance(id);
            if (entity == null)
            {
                return;
            }
            feedbackRep.Delete(entity);
        }

        public IEnumerable<FeedbackVM> GetAllReviews()
        {
            var products = feedbackRep.GetAll();
            return mapper.Map<List<FeedbackVM>>(products);
        }

        public FeedbackVM GetReview(int id)
        {
            var entity = feedbackRep.GetInstance(id);
            return mapper.Map<FeedbackVM>(entity);
        }

        public void UpdateReview(int id, FeedbackVM dto)
        {
            var entity = feedbackRep.GetInstance(id);
            if (entity == null)
                return;

            mapper.Map(dto, entity);
            feedbackRep.Update(entity);
        }
    }
}
