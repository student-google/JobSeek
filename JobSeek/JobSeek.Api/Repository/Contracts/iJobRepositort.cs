using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Repository.Contracts
{
    public interface iJobRepositort
    {
        List<Job> GetAll();
        Job GetById(int id);
        Job Create (JobInput input);
        bool Delete (int id);

    }
}
