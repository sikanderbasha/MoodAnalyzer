using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
   public class Analyzer
    {
        private string Message;

        public Analyzer(string message)
        {

            this.Message = message;
        }

        public string AnalyzeMood()
        {

            if (this.Message.Contains("Sad"))

                return "Sad";
            else

                return "Happy";
        }

    }
}
