using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzerException : Exception
    {        
            public enum ExceptionsType
            {
                NULL_MESSAGE, EMPTY_MESSAGE,
            }
           
            public ExceptionsType type;        
            public AnalyzerException(ExceptionsType Type, string message) : base(message)
            {
                this.type = Type;
            }
        
    }
}
