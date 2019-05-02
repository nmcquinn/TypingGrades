using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace TypingGrades
{
    class Program
    {
        static void Main()
        {
            string inputString;
            int wordsTyped;

            Write("Enter the number of words typed per minute: ");
            inputString = ReadLine();
            wordsTyped = Convert.ToInt32(inputString);


            int[] gradesLowRange = { 0, 16, 31, 51, 76 };

            string[] letterGrade = { "F", "D", "C", "B", "A" };

            for (int i = 0; i < gradesLowRange.Length; i++)
            {
                if (wordsTyped >= gradesLowRange[i] && wordsTyped < gradesLowRange[i + 1])
                {

                    WriteLine("Typing {0} words per minute: Grade {1}", wordsTyped, letterGrade[i]);
                    ReadKey();
                }
            }
        }
    }
}

    