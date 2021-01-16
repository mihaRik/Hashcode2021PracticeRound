using System;
using System.Collections.Generic;

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
            var inputs = GetInputFile();
            for (int i = 0; i < inputs.Length; i++)
            {
                //load input
                var input = FileLogic.LoadInput(inputs[i]);
                //process input
                var output = MainLogic.GetOutputV1(input);
                //load output
                FileLogic.LoadOutput(output);
            }
        }

        private static string[] GetInputFile()
        {
            var inputs = new List<string>();
            var validInputs = "ABCDE";
            string inputFile;
            do
            {
                Console.Write("Select input file (A, B, C, D, E, ALL): ");
                inputFile = Console.ReadLine();
            }
            while (!validInputs.Contains(inputFile) && inputFile != "ALL");

            switch (inputFile)
            {
                case "A":
                    inputs.Add(A);
                    break;
                case "B":
                    inputs.Add(B);
                    break;
                case "C":
                    inputs.Add(C);
                    break;
                case "D":
                    inputs.Add(D);
                    break;
                case "E":
                    inputs.Add(E);
                    break;
                case "ALL":
                    inputs.AddRange(new string[5] { A, B, C, D, E });
                    break;
                default:
                    break;
            }

            return inputs.ToArray();
        }
    }
}
