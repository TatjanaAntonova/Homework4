using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Infra
{
    [TestClass]
    public class BaseRepositoryTests: AbstractClassTests<BaseRepository<Measure, MeasureData>, object>
    {
    }
}
