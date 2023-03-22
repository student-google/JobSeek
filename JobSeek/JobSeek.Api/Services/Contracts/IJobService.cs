using JobSeek.Api.Models.Entities;

namespace JobSeek.Api.Services.Contracts
{
    public interface IJobService
    {
        List<Job> GetAll();
        Job GetById(int id);
        Job Create(Job job);
        bool Delete(int id);
    }
}
