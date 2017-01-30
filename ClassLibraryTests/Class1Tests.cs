using ClassLibrary1;
using Moq;
using NUnit.Framework;

namespace 
{
    [TestFixture]
    public class Class1Tests
    {
        private MockRepository mockRepository;

        [SetUp]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        [TearDown]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void TestMethod1()
        {
            
            
            Class1 class1 = this.CreateClass1();
            
            
        }

        private Class1 CreateClass1()
        {
            return new Class1();
        }
    }
}
