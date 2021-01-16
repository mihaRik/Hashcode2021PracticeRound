using System;
using System.Collections.Generic;
using System.Text;

namespace Hashcode2021PracticeRound.Models
{
    public class Pizza
    {
        public int Position { get; set; }
        public int NumberOfIngridients { get; set; }
        public string[] Ingridients { get; set; }
        public bool IsDelivered { get; set; }
    }
}
