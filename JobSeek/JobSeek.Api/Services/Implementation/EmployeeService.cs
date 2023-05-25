﻿using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Validations;
using Mapster;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployeeService : BaseService<Employee, EmployeeInput>
    {
        private readonly IBaseRepository<Employee> _repository;

        public EmployeeService(IBaseRepository<Employee> repository) : base(repository)
        {
            _repository = repository;
        }

        public override SingleResponse<Employee> Create(EmployeeInput input)
        {
            var isEmailExist = Get().Where(x => x.Email == input.Email).Any();
            if (isEmailExist)
                return ResponseStatus.AlreadyExist;

            var isPhoneNumberExist = Get().Where(x => x.PhoneNumber == input.PhoneNumber).Any();
            if (isPhoneNumberExist)
                return ResponseStatus.AlreadyExist;

            var isNationalcodeExist = Get().Where(x => x.NatioanlCode == input.NatioanlCode).Any();
            if (isNationalcodeExist)
                return ResponseStatus.AlreadyExist;

            var employee = input.Adapt<Employee>();
            _repository.Create(employee);

            return employee;
        }

        public SingleResponse<Employee> Update(int id, EmployeeInput input)
        {
            var isPhoneExist = Get()
                .Where(x => x.PhoneNumber == input.PhoneNumber && x.Id != id)
                .Any();
            if (isPhoneExist)
                return ResponseStatus.AlreadyExist;

            var isEmailExist = Get()
                .Where(x => x.Email == input.Email && x.Id != id)
                .Any();
            if (isEmailExist)
                return ResponseStatus.AlreadyExist;

            var isNationalcodeExist = Get()
                .Where(x => x.NatioanlCode == input.NatioanlCode)
                .Any();
            if (isNationalcodeExist)
                return ResponseStatus.AlreadyExist;

            var employee = input.Adapt<Employee>();
            _repository.Update(id, employee);

            return employee; 
        }
        public bool Delete(int id)
        {
            var EmployeeExist = Get<JobEmployee>().Where(x => x.EmployeeId == id).Any();

            if (EmployeeExist) throw new Exception("alredy in use");
            return Delete(id);
        }
    }
}
