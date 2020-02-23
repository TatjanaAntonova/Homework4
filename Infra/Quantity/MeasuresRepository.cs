using System.Collections.Generic;
using System.Threading.Tasks;
using Homework4.Domain.Quantity;

namespace Homework4.Infra.Quantity
{
    public class MeasuresRepository: IMeasuresRepository
    {
        public Task<List<Measure>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Measure> Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task Add(Measure obj)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Measure obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
