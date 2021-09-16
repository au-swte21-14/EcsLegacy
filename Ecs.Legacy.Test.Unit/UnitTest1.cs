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

        [TestCase(5,5)]
        [TestCase(10,10)]
        [TestCase(20,20)]
        public void SetThreshholdTest(int input, int output)
        {
            uut.SetThreshold(input);
            Assert.That(uut.GetThreshold().Equals(input));
        }
        
        [TestCase(5,5)]
        [TestCase(10,10)]
        [TestCase(20,20)]
        public void GetThreshholdTest(int input, int output)
        {
            uut.SetThreshold(input);
            Assert.That(uut.GetThreshold().Equals(output));
        }
    }
}