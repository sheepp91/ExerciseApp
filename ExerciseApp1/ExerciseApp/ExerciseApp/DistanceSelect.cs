using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseApp
{

        public class DistanceSelect
        {
            public string Name { get; set; }
        public string Level { get; set; }

        public override string ToString()
            {
                return Name;
#pragma warning disable CS0162 // Unreachable code detected
            return Level;
#pragma warning restore CS0162 // Unreachable code detected
        }
        }
}
