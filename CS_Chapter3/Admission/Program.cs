using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double mingpa = 3.0;
            double lowScore = 60;
            double highScore = 80;
            string gpaString;
            string scoreString;
            double gpa;
            double score;

            //USER PROMPT -- GPA
            Console.WriteLine("What is your GPA?");
            gpaString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaString);

            //USER PROMPT -- TEST SCORE
            Console.WriteLine("What was your test score?");
            scoreString = Console.ReadLine();
            score = Convert.ToDouble(scoreString);

            //RESULTS
            if (gpa >= mingpa && score >= lowScore || gpa < mingpa && score >= highScore)
                Console.WriteLine("Accepted");
            else 
                Console.WriteLine("Denied");
        }
    }
}
