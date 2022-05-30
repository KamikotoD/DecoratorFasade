using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class RTransmission: ITransmission
    {
        public void SpeedSwitching()
        {
            Console.WriteLine("Задняя передача");
        }
    }
}
