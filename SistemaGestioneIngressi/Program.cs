using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestioneIngressi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaOrari Lista = new ListaOrari();
            Lista.Add(new UscitaNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0)));
            Lista.Add(new UscitaNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)));
            Lista.Add(new IngressoNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0)));
            Lista.Add(new IngressoNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0)));
            Lista.Add(new IngressoNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0)));
            Lista.Add(new IngressoNodo(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0)));


            Lista.Remove(Lista[4]);

            Console.WriteLine(Lista.VisualizzaInfrazioni());

            Console.WriteLine("\n\n");
            StampaColorata(Lista);
            Console.ReadLine();
        }

        static void StampaColorata(ListaOrari Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if(Lista[i].FuoriOrario().Equals("Nessna infrazione"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Lista[i].StampaOrario());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Lista[i].StampaOrario() + " " + Lista[i].FuoriOrario());
                }
            }
        }
    }
}
