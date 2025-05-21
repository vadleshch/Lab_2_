using Lab_2_;

namespace Lab_2_tests
{
    [TestFixture]
    public class ProgramTests
    {
        private StringWriter _consoleOutput;
        private StringWriter _consoleError;

        [SetUp]
        public void SetUp()
        {
            _consoleOutput = new StringWriter();
            _consoleError = new StringWriter();
            Console.SetOut(_consoleOutput);
            Console.SetError(_consoleError);
        }

        [TearDown]
        public void TearDown()
        {
            _consoleOutput.Dispose();
            _consoleError.Dispose();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            Console.SetError(new StreamWriter(Console.OpenStandardError()) { AutoFlush = true });
            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        }

        [Test]
        public void olleh_test()
        {
            string result = Program.reve("hello");
            Assert.That(result, Is.EqualTo("olleh"));
        }

        [Test]
        public void _test()
        {
            string result = Program.reve("");
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void onetest()
        {
            string result = Program.reve("a");
            Assert.That(result, Is.EqualTo("a"));
        }

        [Test]
        public void noargtest()
        {
            int exitCode = Program.Main(new string[] { });
            string errorOutput = _consoleError.ToString().Trim();
            Assert.That(exitCode, Is.EqualTo(1));
            Assert.That(errorOutput, Is.EqualTo("no arguments provided."));
        }

        [Test]
        public void return0test()
        {
            int exitCode = Program.Main(new string[] { "test" });
            string consoleOutput = _consoleOutput.ToString().Trim();
            Assert.That(exitCode, Is.EqualTo(0));
            Assert.That(consoleOutput, Is.EqualTo("tset"));
        }
    }
}
