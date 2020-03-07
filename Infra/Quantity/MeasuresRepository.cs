﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Homework4.Infra.Quantity
{
    public class MeasuresRepository: UniqueEntityRepository<Measure, MeasureData>, IMeasuresRepository
    {
        public MeasuresRepository(QuantityDbContext c) : base(c, c.Measures) { }


        public override async Task<List<Measure>> Get()
        {
            var l = await createPaged(createFiltered(createSorted()));
            HasNextPage = l.HasNextPage;
            HasPreviousPage = l.HasPreviousPage;
            return l.Select(e => new Measure(e)).ToList();
        }

        private async Task<PaginatedList<MeasureData>> createPaged(IQueryable<MeasureData> dataSet)
        {
            return await PaginatedList<MeasureData>.CreateAsync(
                dataSet, PageIndex, PageSize);
        }

        private IQueryable<MeasureData> createFiltered(IQueryable<MeasureData> set)
        {
            if (string.IsNullOrEmpty(SearchString)) return set;
            return set.Where(s => s.Name.Contains(SearchString)
                                  || s.Code.Contains(SearchString)
                                  || s.Id.Contains(SearchString)
                                  || s.Definition.Contains(SearchString)
                                  || s.ValidFrom.ToString().Contains(SearchString)
                                  || s.ValidTo.ToString().Contains(SearchString));
        }

        private IQueryable<MeasureData> createSorted()
        {
            IQueryable<MeasureData> measures = from s in dbSet select s;

            measures = setSorting(measures);
            return measures.AsNoTracking();
        }
    }
}
