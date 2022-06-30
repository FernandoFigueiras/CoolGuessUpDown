using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGuessUpDown.Core.Entities
{
    public class Card : IEntity
    {
        public int Id { get; set; }

        public string? Suit { get; set; }

        public string? ValueRank { get; set; }
    }
}
