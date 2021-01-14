using System;

namespace Hashcode2021PracticeRound
{
    class Program
    {
        public const string A = "a_example";
        public const string B = "b_little_bit_of_everything";
        public const string C = "c_many_ingredients";
        public const string D = "d_many_pizzas";
        public const string E = "e_many_teams";

        static void Main(string[] args)
        {
            //load input
            var input = FileLogic.LoadInput(D);
            //process input
            var output = MainLogic.GetOutputV1(input);
            //load output
            FileLogic.LoadOutput(output);
        }
    }
}
