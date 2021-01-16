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
            var inputs = new string[5] { A, B, C, D, E };

            for (int i = 0; i < inputs.Length; i++)
            {
                //load input
                var input = FileLogic.LoadInput(inputs[i]);
                //process input
                var output = MainLogic.GetOutputV1(input);
                //load output
                FileLogic.LoadOutput(output);
            }

            //var inputFile = GetInputFile();
            ////load input
            //var input = FileLogic.LoadInput(inputFile);
            ////process input
            //var output = MainLogic.GetOutputV1(input);
            ////load output
            //FileLogic.LoadOutput(output);
        }

        private static string GetInputFile()
        {
            var validInputs = "ABCDE";
            string inputFile;
            do
            {
                Console.Write("Select input file (A, B, C, D, E): ");
                inputFile = Console.ReadLine();
            }
            while (!validInputs.Contains(inputFile));

            switch (inputFile)
            {
                case "A":
                    inputFile = A;
                    break;
                case "B":
                    inputFile = B;
                    break;
                case "C":
                    inputFile = C;
                    break;
                case "D":
                    inputFile = D;
                    break;
                case "E":
                    inputFile = E;
                    break;
                default:
                    break;
            }

            return inputFile;
        }
    }
}
