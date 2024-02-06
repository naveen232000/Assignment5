using System;
using System.Collections.Generic;

namespace Assignment5.Model
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public int JerseyNumber { get; set; }
        public string Position { get; set; } = null!;
        public string Team { get; set; } = null!;
    }
}
