using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Homework4.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Pages {

    public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
        where TClass : BasePage<IMeasuresRepository, Measure, MeasureView, MeasureData> {

        internal testRepository db; 
        internal class testClass : CommonPage<IMeasuresRepository, Measure, MeasureView, MeasureData> {

            protected internal testClass(IMeasuresRepository r) : base(r) {
                PageTitle = "Measures";
            }

            public override string ItemId => Item?.Id ?? string.Empty;

            protected internal override string getPageUrl() => "/Quantity/Measures";

            protected internal override Measure toObject(MeasureView view) => MeasureViewFactory.Create(view);

            protected internal override MeasureView toView(Measure obj) => MeasureViewFactory.Create(obj);

        }

        internal class testRepository : baseTestRepository<Measure, MeasureData>, IMeasuresRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            db = new testRepository();
        }

    }

}
