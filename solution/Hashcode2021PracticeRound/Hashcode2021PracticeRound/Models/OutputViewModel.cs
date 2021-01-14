using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound.Models
{
    public class OutputViewModel
    {
        public int NumberOfPizzas { get; set; }
        public DeliveredPizza[] DeliveredPizzas { get; set; }
        public string InputFileName { get; set; }
    }
}
