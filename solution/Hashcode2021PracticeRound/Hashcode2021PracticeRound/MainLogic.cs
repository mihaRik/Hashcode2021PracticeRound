using Hashcode2021PracticeRound.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound
{
    public class MainLogic : Helper
    {
        public static OutputViewModel GetOutputV1(InputViewModel input)
        {
            var deliveredPizzas = new List<DeliveredPizza>();
            var pizzas = input.Pizzas;
            _pizzasBackup = new Pizza[pizzas.Length];
            pizzas.CopyTo(_pizzasBackup, 0);

            CalculateTeam(input.TwoPersonTeams, pizzas);
            CalculateTeam(input.ThreePersonTeams, pizzas);
            CalculateTeam(input.FourPersonTeams, pizzas);

            deliveredPizzas.AddRange(GetTeamPizza(input.TwoPersonTeams));
            deliveredPizzas.AddRange(GetTeamPizza(input.ThreePersonTeams));
            deliveredPizzas.AddRange(GetTeamPizza(input.FourPersonTeams));

            return new OutputViewModel
            {
                DeliveredPizzas = deliveredPizzas.ToArray(),
                InputFileName = input.InputFileName,
                NumberOfPizzas = deliveredPizzas.Count
            };
        }
    }
}
