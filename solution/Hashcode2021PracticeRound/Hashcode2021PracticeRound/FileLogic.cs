using Hashcode2021PracticeRound.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hashcode2021PracticeRound
{
    public static class FileLogic
    {
        private static string _solutionsPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        public static InputViewModel LoadInput(string input)
        {
            var filePath = Path.Combine(_solutionsPath, "inputs", $"{input}.in");
            var file = new StreamReader(filePath);

            int numberOfPizzas, numberOf2PersonTeams, numberOf3PersonTeams, numberOf4PersonTeams;

            var firstLine = file.ReadLine();
            var firstLineSplited = firstLine.Split(' ');

            numberOfPizzas = Convert.ToInt32(firstLineSplited[0]);
            numberOf2PersonTeams = Convert.ToInt32(firstLineSplited[1]);
            numberOf3PersonTeams = Convert.ToInt32(firstLineSplited[2]);
            numberOf4PersonTeams = Convert.ToInt32(firstLineSplited[3]);

            string line = file.ReadLine();
            var i = 0;

            var pizzas = new Pizza[numberOfPizzas];

            while (!string.IsNullOrEmpty(line))
            {
                var splitedLine = line.Split(' ');
                var numberOfIngridients = Convert.ToInt32(splitedLine[0]);
                var ingridients = splitedLine.Skip(1).ToArray();

                pizzas[i] = new Pizza
                {
                    Position = i,
                    NumberOfIngridients = numberOfIngridients,
                    Ingridients = ingridients
                };

                i++;
                line = file.ReadLine();
            }

            file.Close();

            var twoPersonTeams = new Team[numberOf2PersonTeams];
            var threePersonTeams = new Team[numberOf3PersonTeams];
            var fourPersonTeams = new Team[numberOf4PersonTeams];

            CreateDefaultData(twoPersonTeams, 2);
            CreateDefaultData(threePersonTeams, 3);
            CreateDefaultData(fourPersonTeams, 4);

            return new InputViewModel
            {
                NumberOfPizzas = numberOfPizzas,
                TwoPersonTeams = twoPersonTeams,
                ThreePersonTeams = threePersonTeams,
                FourPersonTeams = fourPersonTeams,
                Pizzas = pizzas,
                InputFileName = input
            };
        }

        private static void CreateDefaultData(Team[] teams, int teamSize)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                teams[i] = new Team(teamSize);
            }
        }

        public static void LoadOutput(OutputViewModel output)
        {
            var filePath = Path.Combine(_solutionsPath, "outputs", $"{output.InputFileName}.out");
            var file = new StreamWriter(filePath);

            file.WriteLine(output.NumberOfPizzas);

            foreach (var deliveredPizza in output.DeliveredPizzas)
            {
                if (deliveredPizza.DeliveredPizzas[0] != null)
                {
                    file.WriteLine($"{deliveredPizza.TeamSize} {string.Join(' ', deliveredPizza.DeliveredPizzas)}");
                }
            }

            file.Close();
        }
    }
}
