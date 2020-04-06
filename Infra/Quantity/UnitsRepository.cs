﻿using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Infra.Quantity
{
    public sealed class UnitsRepository: UniqueEntityRepository<Unit, UnitData>, IUnitsRepository
    {
    public UnitsRepository(QuantityDbContext c) : base(c, c.Units) { }

    protected internal override Unit toDomainObject(UnitData d) => new Unit(d);
    }
}
