using Hashcode2021PracticeRound.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound
{
    public abstract class Helper
    {
        protected static Pizza[] _pizzasBackup;

        protected static void CalculateTeam(Team[] teams, Pizza[] pizzas)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                var deliveredPizzasForTeam = teams[i].DeliveredPizzas;

                for (int j = 0; j < deliveredPizzasForTeam.Length; j++)
                {
                    var pizzaIndex = GetPizzaIndex(pizzas, deliveredPizzasForTeam);

                    if (pizzaIndex != pizzas.Length)
                    {
                        deliveredPizzasForTeam[j] = pizzaIndex;
                    }
                    else
                    {
                        for (int d = 0; d < deliveredPizzasForTeam.Length; d++)
                        {
                            if (deliveredPizzasForTeam[d].HasValue)
                            {
                                pizzas[deliveredPizzasForTeam[d].Value].IsDelivered = false;
                                deliveredPizzasForTeam[d] = null;
                            }
                        }

                        break;
                    }
                }
            }
        }

        protected static IEnumerable<DeliveredPizza> GetTeamPizza(Team[] teams)
        {
            var deliveredPizzas = new List<DeliveredPizza>();

            for (int i = 0; i < teams.Length; i++)
            {
                var deliveredPizzasForTeam = teams[i].DeliveredPizzas;

                if (deliveredPizzasForTeam[0] is null) continue;

                deliveredPizzas.Add(new DeliveredPizza
                {
                    DeliveredPizzas = deliveredPizzasForTeam,
                    TeamSize = teams[i].TeamSize
                });
            }

            return deliveredPizzas;
        }

        protected static int HowManyIngridientsAreSame(string[] pizza1, string[] pizza2)
        {
            var count = 0;

            for (int i = 0; i < pizza1.Length; i++)
            {
                for (int j = 0; j < pizza2.Length; j++)
                {
                    if (pizza1[i] == pizza2[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        protected static int GetPizzaIndex(Pizza[] pizzas, int?[] deliveredPizzasIndex)
        {
            var deliveredPizzasIngridients = GetIngridientsByPizzaIndexes(deliveredPizzasIndex);

            for (int i = 0; i < pizzas.Length; i++)
            {
                if (pizzas[i].IsDelivered) continue;

                var sameIngridientsCount = HowManyIngridientsAreSame(pizzas[i].Ingridients, deliveredPizzasIngridients);

                if (sameIngridientsCount <= deliveredPizzasIngridients.Length / 2)
                {
                    pizzas[i].IsDelivered = true;
                    return i;
                }
            }

            return pizzas.Length;
        }

        protected static string[] GetIngridientsByPizzaIndex(int index)
        {
            return _pizzasBackup[index].Ingridients;
        }

        protected static string[] GetIngridientsByPizzaIndexes(int?[] indexes)
        {
            var ingridients = new List<string>();

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] is null) continue;

                ingridients.AddRange(GetIngridientsByPizzaIndex(indexes[i].Value));
            }

            return ingridients.ToArray();
        }
    }
}
