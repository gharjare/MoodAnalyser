﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood(string message)
        {
            try
            {
                if (message.ToLower().Contains("Sad"))
                    return "Sad";
                return "Happy";
            }
            catch (MoodAnalyserException ex)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL, "");
            }
        }


    }
}