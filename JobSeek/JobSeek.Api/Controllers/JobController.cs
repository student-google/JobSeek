using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : IJobService
    {
        private readonly IJobService _JobService;

        public JobController(IJobService jobService)
        {
            this._JobService = jobService;
        }

        [HttpGet]
        public List<Job> GetAll()
        {
            return _JobService.GetAll();
        }

        [HttpGet("id")]
        public Job GetById(int id)
        {
            return _JobService.GetById(id);
        }

        [HttpPost]
        public Job Create(Job job)
        {
            return _JobService.Create(job);
        }

        [HttpPost]
        public bool Delete(int id)
        {
            return _JobService.Delete(id);
        }

    }
}
