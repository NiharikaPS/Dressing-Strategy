using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pajamas.Pajamas pajamas = new Pajamas.Pajamas(Pajamas.Enums.TemperatureTypes.HOT, "8,6,4,2,1, 7");
            pajamas.ProcessCommands();
            Console.WriteLine(pajamas._output);
        }
    }
}
