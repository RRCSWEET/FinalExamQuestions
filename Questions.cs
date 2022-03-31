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