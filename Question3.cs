using System;
using static System.Console;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[9];
            array[0] = GetNameGender("What is your name? ");
            array[1] = GetNameGender("\nWhat is your gender('F' or 'M')? ");
            questions questions = new questions();

            WriteLine("\nanswer all questions with 'y' for yes, or 'n' for no");
            array[2] = questions.question1("Did the person being evaluated travel from China or Korea?");
            if (array[2] == "y")
            {
                array[3] = questions.question1("Did the person travel from Hubei, China specifically? ");
                if (array[3] == "y")
                {
                    WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                    WriteLine(array[0] + " is a high risk.");
                }
                else if (array[3] == "n")
                {
                    array[4] = questions.question1("Were all recommended precautions for home care and isolation followed consistently? ");
                    if (array[4] == "y")
                    {
                        WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                        WriteLine(array[0] + " is a medium risk.");
                    }
                    else if (array[4] == "n")
                    {
                        WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                        WriteLine(array[0] + " is a high risk.");
                    }
                }
            }
            else if (array[2] == "n")
            {
                array[5] = questions.question1("Did the person have any contact with a lab confirmed case of COVID-19? ");
                if (array[5] == "y")
                {
                    array[6] = questions.question1("Wan contact with the context of living, being intimate partner of, or caring for a person with COVID-19 outside of a healthcare facility? ");
                    {
                        if (array[6] == "y")
                        {
                            array[7] = questions.question1("Were all recommended precautions for home care and isolation followed consistently? ");
                            if (array[7] == "y")
                            {
                                WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                                WriteLine(array[0] + " is a medium risk.");
                            }
                            else if (array[7] == "n")
                            {
                                WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                                WriteLine(array[0] + " is a high risk.");
                            }

                        }
                        else if (array[6] == "n")
                        {
                            array[8] = questions.question1("Did the person contact respiratory secretions or was the person within 6 feet of a case for a prolonged period? ");
                            if (array[8] == "y")
                            {
                                WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                                WriteLine(array[0] + " is a medium risk.");
                            }
                            else if (array[8] == "n")
                            {
                                WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                                WriteLine(array[0] + " is a low risk or no risk.");
                            }
                        }
                    }
                }
                else if (array[5] == "n")
                {
                    WriteLine("Name: " + array[0] + "     Gender: " + array[1]);
                    WriteLine(array[0] + " is a low risk or no risk.");
                }

            }

        }
        static string GetNameGender(string val)
        {
            string input;
            WriteLine(val);
            input = ReadLine();
            return input;
        }
    }
}




using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace problem3
{
    class questions
    {
        string input;
        public questions()
        {
            input = "";
        }
        public string question1(string val)
        {
            WriteLine(val);
            input = ReadLine();
            return input;
        }

    }
   

}

