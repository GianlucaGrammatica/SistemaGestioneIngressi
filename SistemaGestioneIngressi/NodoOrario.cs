using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestioneIngressi
{
    internal abstract class NodoOrario
    {
        /*
            - Contenere un orario in formato DateTime protetto
            - Il riferimento all'OrarioNodo successivo
            - Il metodo astratto FuoriOrario() che restituisce una stringa con l'infrazione
            - Il metodo astratto StampaOrario() che restituisce la stampa dell'orario e il suo tipo
        */

        // Proprietà
        public DateTime Orario { get; set; }
        public NodoOrario Next { get; set; }


        // Costruttori
        public NodoOrario() { }
        public NodoOrario(DateTime orario)
        {
            Orario = orario;
            Next = null;
        }
        public NodoOrario(DateTime orario, NodoOrario next)
        {
            Orario = orario;
            Next = next;
        }



        // Metodi
        public abstract string FuoriOrario();
        public abstract string StampaOrario();
    }
}