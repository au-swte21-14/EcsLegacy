using System.IO;
using NUnit.Framework;
using Ecs.Legacy;
using ECS.Legacy;
using ECS = ECS.Legacy.ECS;

namespace Ecs.Legacy.Test.Unit
{
    public class EcsLegacyTests
    {
        private global::ECS.Legacy.ECS uut;
        private FakeHeater _fakeHeater = new FakeHeater();
        private FakeTempSensor _fakeTempSensor = new FakeTempSensor();
        [SetUp]
        public void Setup()
        {
            uut = new global::ECS.Legacy.ECS(23, _fakeTempSensor, _fakeHeater);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}