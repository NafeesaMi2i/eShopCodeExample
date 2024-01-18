using NUnit.Framework;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class BaseEntityTests
    {
        [Test]
        public void TestIdProperty()
        {
            var baseEntity = new BaseEntity();
            baseEntity.Id = 1;
            Assert.AreEqual(1, baseEntity.Id);

            baseEntity.Id = int.MaxValue;
            Assert.AreEqual(int.MaxValue, baseEntity.Id);

            baseEntity.Id = int.MinValue;
            Assert.AreEqual(int.MinValue, baseEntity.Id);
        }
    }
}
