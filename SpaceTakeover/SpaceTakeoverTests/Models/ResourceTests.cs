using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;

namespace SpaceTakeoverTests
{
    public class ResourceTests
    {
        private Resource resource;

        [SetUp]
        public void Setup()
        {
            this.resource = new Resource();
        }

        [Test]
        public void GivenResourceNameGetAndSetMethodsReturnProperly()
        {
            string name = "Resource Name";
            resource.setName(name);
            string actual = resource.getName();
            Assert.AreEqual(name, actual);
        }

        [Test]
        public void GivenValueGetAndSetMethodsReturnProperly()
        {
            decimal value = 100.10m;
            resource.setValue(value);
            decimal actual = resource.getValue();
            Assert.AreEqual(value, actual);
        }

        [Test]
        public void GivenStrengthGetAndSetMethodsReturnProperly()
        {
            int strength = 10;
            resource.setStrength(strength);
            int actual = resource.getStrength();
            Assert.AreEqual(strength, actual);
        }
    }
}
