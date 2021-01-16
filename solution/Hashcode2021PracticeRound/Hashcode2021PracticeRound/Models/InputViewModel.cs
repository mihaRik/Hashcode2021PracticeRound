using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound.Models
{
    public class InputViewModel
    {
        public int NumberOfPizzas { get; set; }
        public Team[] TwoPersonTeams { get; set; }
        public Team[] ThreePersonTeams { get; set; }
        public Team[] FourPersonTeams { get; set; }
        public Pizza[] Pizzas { get; set; }
        public string InputFileName { get; set; }
    }
}
