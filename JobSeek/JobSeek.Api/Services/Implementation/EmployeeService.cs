﻿using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Mapster;
using Microsoft.CodeAnalysis.Differencing;
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
        public Employee Create (EmployeeInput input)
        {
            //Validate Email
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match EmailMatch = regex.Match(input.Email);
            if (EmailMatch.Success != true)
                throw new Exception("Your email is incorrect!");

            //Validate Phone Number
            Regex PhoneNumRegex = new Regex(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            Match PhoneMatch = PhoneNumRegex.Match(input.PhoneNumber);
            if (input.PhoneNumber != null && PhoneMatch.Success != true)
                throw new Exception("Your Phone number is incorrect!");


            var email = GetAll().Where(x => x.Email == input.Email).Any();
            if (email) throw new Exception("email already exist");

            var phoneNumber = GetAll().Where(x => x.PhoneNumber == input.PhoneNumber).Any();
            if (phoneNumber) throw new Exception("Phone Number already exists");

            var employee = input.Adapt<Employee>();
            return _repository.Create(employee);

        }

        public Employee Update(int id,EmployeeInput input) 
        {
            var isPhoneExist = GetAll()
                .Where(x => x.PhoneNumber == input.PhoneNumber && x.Id != id)
                .Any(); 
        }
    }
}