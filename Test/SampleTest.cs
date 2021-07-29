using NUnit.Framework;

namespace Test
{
    public class SampleTest
    {
        [Test]
        public void ShouldBeTrue()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}