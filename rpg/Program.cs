using rpg.scr.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Heroi heroi = new Heroi("Arus", 23, "heroi", 15);
            Oponente oponente = new Oponente("pedro", 12, "magico ", 28);
            Conciliador conciliador = new Conciliador("joão", 15, "paz", 01);

            Console.WriteLine(heroi.Ataque());
            Console.WriteLine(oponente.Ataque());
            Console.WriteLine(conciliador.paz());
            
            Console.ReadKey();
        }
    }
}
