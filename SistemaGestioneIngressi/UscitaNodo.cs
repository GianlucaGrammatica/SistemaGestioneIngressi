using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestioneIngressi
{
    internal class UscitaNodo : NodoOrario
    {
        public DateTime Orario { get; set; }
        public NodoOrario Next { get; set; }

        private DateTime DefaultTime =  new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);

        public UscitaNodo() { }
        public UscitaNodo(DateTime orario) : base(orario)
        {
            Orario = orario;
            Next = null;
        }
        public UscitaNodo(DateTime orario, NodoOrario next) : base(orario, next)
        {
            Orario = orario;
            Next = next;
        }

        public override string FuoriOrario()
        {
            if(Orario >= DefaultTime)
            {
                return "Nessna infrazione";
            }
            else
            {
                TimeSpan Difference = DefaultTime - Orario;
                return $"Infrazione di {Difference}";
            }
        }

        public override string StampaOrario()
        {
            return $"{Orario.ToString()} - Uscita";
        }
    }
}