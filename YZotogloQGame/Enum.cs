using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZotogloQGame
{
   public class Enum
    {
        [Flags]
        public enum Tool 
        {
            GreenBox = 0,
            GreenDoor = 1,
            None = 2,
            RedBox = 3,
            RedDoor = 4,
            Wall = 5
        }
            
           
       
    }
}
