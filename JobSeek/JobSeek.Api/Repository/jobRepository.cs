using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class jobRepository : iJobRepositort
    {
        private readonly DataContext _Context;
        public jobRepository(DataContext context)
        {
            _Context = context;
        }
        public List<Job> GetAll()
        {
            return _Context.Jobs.ToList();
        }

        public Job GetById(int id)
        {
            var job = _Context.Jobs.Where(j => j.Id == id).SingleOrDefault();
            return job;
        }
        public Job Create(Job job)
        {
            _Context.Jobs.Add(job);
            _Context.SaveChanges();
            return job;
        }

        public bool Delete(int id)
        {
            var job = _Context.Jobs.Where(j => j.Id == id).SingleOrDefault();
            
            _Context.Jobs.Remove(job);
            _Context.SaveChanges();
            if (job == null) return false;
            return true;
            
        }

    }
}
