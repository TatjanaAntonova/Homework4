﻿using System;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Infra;
using Homework4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Infra.Quantity
{
    [TestClass]
    public class MeasureTermsRepositoryTests : RepositoryTests<MeasureTermsRepository, MeasureTerm, MeasureTermData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).MeasureTerms;
            obj = new MeasureTermsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }


        protected override Type getBaseType()
        {
            return typeof(PaginatedRepository<MeasureTerm, MeasureTermData>);
        }

        protected override string getId(MeasureTermData d) => $"{d.MasterId}.{d.TermId}";

        protected override MeasureTerm getObject(MeasureTermData d) => new MeasureTerm(d);

        protected override void setId(MeasureTermData d, string id)
        {
            var masterId = GetString.Head(id);
            var termId = GetString.Tail(id);
            d.MasterId = masterId;
            d.TermId = termId;

        }
    }
}

