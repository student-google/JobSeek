using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository;
using JobSeek.Api.Repository.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class JobService : iJobRepositort
    {
        private readonly iJobRepositort _repository;

        public JobService(iJobRepositort repository)
        {
            this._repository = repository;
        }
        public Job Create(JobInput input)
        {
            return _repository.Create(input);
        }

        public bool Delete(int id)
        {
           return _repository.Delete(id);
        }

        public List<Job> GetAll()
        {
           return _repository.GetAll();
        }

        public Job GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
