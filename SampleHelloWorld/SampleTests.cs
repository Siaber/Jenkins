namespace SampleHelloWorld
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void HelloTest()
        {
            var actualHello = new HelloClass().SayHelloWorld();
            var expectedHello = "Hello world!";

            Assert.AreEqual(expectedHello, actualHello);
        }
    }
}