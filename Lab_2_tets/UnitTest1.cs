using Lab_2_;

namespace Lab_2_tets
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public void ollehTest()
        {
            string res = Program.reve("hello");
            Assert.That(res, Is.EqualTo("olleh"));
        }

        [Test]
        public void EmptyTest()
        {
            string res = Program.reve("");
            Assert.That(res, Is.EqualTo(""));
        }

        [Test]
        public void oneTest()
        {
            string res = Program.reve("a");
            Assert.That(res, Is.EqualTo("a"));
        }
    }
}
