using Hashcode2021PracticeRound.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound
{
    public static class MainLogic
    {
        public static OutputViewModel GetOutputV1(InputViewModel input)
        {

            return new OutputViewModel
            {
                DeliveredPizzas = new DeliveredPizza[1] { new DeliveredPizza { DeliveredPizzas = new int[1] { 0 }, TeamSize = 1 } },
                InputFileName = input.InputFileName,
                NumberOfPizzas = 2
            };
        }
    }
}
