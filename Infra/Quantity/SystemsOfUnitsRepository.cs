using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Infra.Quantity {

    public sealed class SystemsOfUnitsRepository : UniqueEntityRepository<SystemOfUnits, SystemOfUnitsData>,
        ISystemsOfUnitsRepository {

        public SystemsOfUnitsRepository() : this(null) { }
        public SystemsOfUnitsRepository(QuantityDbContext c) : base(c, c?.SystemsOfUnits) { }

        protected internal override SystemOfUnits toDomainObject(SystemOfUnitsData d) => new SystemOfUnits(d);


    }

}

