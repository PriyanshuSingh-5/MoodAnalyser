using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodToAnalyse
    {
        string message;
        public MoodToAnalyse(string message)
        {
            this.message = message;

        }

        public string Analyser()
        {
            if(this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
