using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("5,1:hello",Program.Prefix("hello"));
        }
		
		[Test]
        public void Test2()
        {
            Assert.AreEqual("0,0:",Program.Prefix(""));
        }
		
		[Test]
        public void Test3()
        {
            Assert.AreEqual("27,5:what  ...   did you say??  ",Program.Prefix("what  ...   did you say??  "));
        }
		
	
    }
}