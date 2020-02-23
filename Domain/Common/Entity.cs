using Homework4.Data.Common;

namespace Homework4.Domain.Common
{
    public abstract class Entity<T> where T: PeriodData
    {
        public T Data { get; }

        protected Entity(T data)
        {
            Data = data;
        }
    }
}