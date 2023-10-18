using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_session6.Models
{
    public static class Calculate
    {
        public static void CalculateNumber(out int randomnumber0)
        {
            Random random0 = new Random();
             randomnumber0 = random0.Next(1, 4000);
            
        }




    }

}
