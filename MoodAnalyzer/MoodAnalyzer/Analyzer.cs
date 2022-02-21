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
            try
            { 
                 if (this.Message.Equals(string.Empty))
            {
                throw new AnalyzerException(AnalyzerException.ExceptionsType.EMPTY_MESSAGE, "Message should not be Empty");
            }
            
                if (this.Message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new AnalyzerException(AnalyzerException.ExceptionsType.NULL_MESSAGE, "Message should not be Null");
            }
        }

    }
}
