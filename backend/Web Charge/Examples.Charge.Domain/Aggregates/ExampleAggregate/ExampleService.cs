﻿using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate
{
    public class ExampleService : IExampleService
    {
        private IExampleRepository _exampleRepository;
        public ExampleService(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }

        public async Task<List<Example>> FindAllAsync() => (await _exampleRepository.FindAllAsync()).ToList();
    }
}
