using System;
using System.Threading.Tasks;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Homework4.Infra.Quantity {

    public sealed class MeasureTermsRepository : PaginatedRepository<MeasureTerm, MeasureTermData>, IMeasureTermsRepository {

        public MeasureTermsRepository() : this(null) { }

        public MeasureTermsRepository(QuantityDbContext c) : base(c, c?.MeasureTerms) { }

        protected internal override MeasureTerm toDomainObject(MeasureTermData d) => new MeasureTerm(d);

        protected override async Task<MeasureTermData> getData(string id) {
            var masterId = GetString.Head(id);
            var termId = GetString.Tail(id);
            return await dbSet.SingleOrDefaultAsync(x => x.TermId == termId && x.MasterId == masterId);
        }

        protected override string getId(MeasureTerm obj) {
            return obj?.Data is null ? string.Empty : $"{obj.Data.MasterId}:{obj.Data.TermId}";
        }
    }
}
