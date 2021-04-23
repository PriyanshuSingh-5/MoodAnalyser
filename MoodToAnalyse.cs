using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodToAnalyse
    {
        //instance variable
        string message;

        //parameterized constructor
        public MoodToAnalyse(string message)
        {
            this.message = message;

        }

        //Analyser method to find mood
        public string Analyser()
        {
            //Exception
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                //return ex.Message;
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}

