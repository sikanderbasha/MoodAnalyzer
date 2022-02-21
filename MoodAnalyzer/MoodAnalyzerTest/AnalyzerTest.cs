using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class AnalyzerTest
    {
       [TestMethod]
       
        public void Sad()
        {
            string expected = "Sad";
            Analyzer Analyzer = new Analyzer("I am Sad");
            Assert.AreEqual(expected, Analyzer.AnalyzeMood());
        }

        [TestMethod]
        public void Happy()
        {
            string expected = "Happy";
            Analyzer Analyzer = new Analyzer("I am Happy");
            Assert.AreEqual(expected, Analyzer.AnalyzeMood());
        }

        [TestMethod]
        public void Happy_Null()
        {            
            string expected = "Happy";          
            Analyzer Analyzer = new Analyzer(null);         
            Assert.AreEqual(expected, Analyzer.AnalyzeMood());
        }

        [TestMethod]
       
        public void EmptyTypeException()
        {
            try
            {
                string expected = "Happy";
                string message = " ";
                Analyzer Analyzer = new Analyzer(message);
                Assert.AreEqual(expected, Analyzer.AnalyzeMood());
            }
            catch (AnalyzerException e)
            {
                Assert.AreEqual("Message should not be Empty", e.Message);
            }
        }
        [TestMethod]
      
        public void NullTypeException()
        {
            try
            {
                string expected = "Happy";
                string message = null;
                Analyzer Analyzer = new Analyzer(message);
                Assert.AreEqual(expected, Analyzer.AnalyzeMood());
            }
            catch (AnalyzerException e)
            {
                Assert.AreEqual("Message should not be Null", e.Message);
            }
        }

    }
}