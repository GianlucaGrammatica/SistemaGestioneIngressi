using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestioneIngressi
{
    internal class IngressoNodo : NodoOrario
    {
        public DateTime Orario { get; set; }
        public NodoOrario Next { get; set; }

        private DateTime DefaultTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);

        public IngressoNodo() { }
        public IngressoNodo(DateTime orario) : base(orario)
        {
            Orario = orario;
            Next = null;
        }
        public IngressoNodo(DateTime orario, NodoOrario next) : base(orario, next)
        {
            Orario = orario;
            Next = next;
        }

        public override string FuoriOrario()
        {
            if (Orario > DefaultTime)
            {
                TimeSpan Difference = Orario - DefaultTime;
                return $"Infrazione di {Difference}";
            }
            else
            {
                return "Nessna infrazione";
            }
        }

        public override string StampaOrario()
        {
            return $"{Orario.ToString()} - Ingresso";
        }
    }
}