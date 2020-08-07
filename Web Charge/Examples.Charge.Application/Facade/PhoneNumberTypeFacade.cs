using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using PersonPhones.Charge.Application.Interfaces;

namespace Examples.Charge.Application.Facade
{
    public class PhoneNumberTypeFacadeFacade : IPhoneNumberTypeFacade
    {
        private readonly IPhoneNumberTypeService _phoneNumberTypeService;
        private readonly IMapper _mapper;

        public PhoneNumberTypeFacadeFacade(IPhoneNumberTypeService PhoneNumberTypeFacadeService, IMapper mapper)
        {
            _phoneNumberTypeService = PhoneNumberTypeFacadeService;
            _mapper = mapper;
        }

        public Task<object> AddPhoneNumberTypeFacadeAsync(PhoneNumberType phoneNumberType)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PhoneNumberTypeResponse> FindAllAsync()
        {
            var result = await _phoneNumberTypeService.FindAllAsync();
            var response = new PhoneNumberTypeResponse();
            response.PhoneNumberTypeObjects = new List<PhoneNumberTypeDto>();
            response.PhoneNumberTypeObjects.AddRange(result.Select(x => _mapper.Map<PhoneNumberTypeDto>(x)));
            return response;
        }
    }
}
