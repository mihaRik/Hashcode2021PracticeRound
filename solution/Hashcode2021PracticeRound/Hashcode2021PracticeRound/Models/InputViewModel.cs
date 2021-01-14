using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound.Models
{
    public class InputViewModel
    {
        public int NumberOfPizzas { get; set; }
        public int NumberOf2PersonTeams { get; set; }
        public int NumberOf3PersonTeams { get; set; }
        public int NumberOf4PersonTeams { get; set; }
        public Pizza[] Pizzas { get; set; }
        public string InputFileName { get; set; }
    }
}
