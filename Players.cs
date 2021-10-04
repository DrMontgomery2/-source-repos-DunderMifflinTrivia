using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflinTrivia
{
    class Players
    {
        public string Name;//field
        public int Score;
        public Players(string playerName)
            //passing in a parameter... name with lower case "n." Whatever is passed in this method is stored in the field.
        {
            Name = playerName;
            Score = 0;
            // input come from here then stored in the field.
            
            //if you hit ctrl R while hovering over a variable you can rename the variable.
           
        
        }
    }
}
