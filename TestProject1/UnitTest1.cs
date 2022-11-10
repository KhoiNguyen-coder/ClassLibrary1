using StudentServiceLib;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenScoreIs8()
        {
            Student s = new Student();
            s.Score = 8.0;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void WhenScoreIs71()
        {
            Student s = new Student();
            s.Score = 7.1;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void WhenScoreIs6()
        {
            Student s = new Student();
            s.Score = 6.0;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void WhenScoreIs3()
        {
            Student s = new Student();
            s.Score = 3.0;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
        [TestMethod]
        public void WhenScoreover10()
        {
            Student s = new Student();
            bool thrown = false;
            try
            {
                s.Score = 11;
            }
            catch(SystemException e)
            {
                thrown = true;
            }
            Assert.IsTrue(thrown);
        }
        [TestMethod]
        public void WhenScoreunder0()
        {
            Student s = new Student();
            bool thrown = false;
            try
            {
                s.Score = -10 ;
            }
            catch (SystemException e)
            {
                thrown = true;
            }
            Assert.IsTrue(thrown);
        }

    }
}