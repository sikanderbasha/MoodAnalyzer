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

    }
}