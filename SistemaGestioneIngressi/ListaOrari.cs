using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaGestioneIngressi
{
    internal class ListaOrari
    {
        public int Count { get; set; }
        
        public NodoOrario Head { get; set; }
        public NodoOrario Last { get; set; }

        public ListaOrari()
        {
            Count = 0;
            Head = null;
            Last = null;
        }

        public NodoOrario this[int index]
        {
            get
            {
                var current = Head;
                for (var i = 0; i < Count; i++)
                {
                    if (i == index)
                    {
                        return current;
                    }
                    current = current.Next;
                }
                return null;
            }
            set
            {           }
        }

        public NodoOrario Find(DateTime Time)
        {
            NodoOrario current = Head;
            for (int i = 0; i < Count; i++) {
                if (current.Orario.Equals(Time))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public NodoOrario Find(NodoOrario Node)
        {
            NodoOrario current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Orario == Node.Orario)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public void Add(NodoOrario ToAdd)
        {
            if(Head == null)
            {
                ToAdd.Next = null;
                Head = ToAdd;
                Last = Head;                
                Count++;
                return;
            }

            Last.Next = ToAdd;
            ToAdd.Next = null;
            Last = ToAdd;
            Count++;
        }

        public void Remove(NodoOrario ToRemove)
        {
            NodoOrario current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Next == ToRemove)
                {
                    current.Next = ToRemove.Next;
                    ToRemove = null;
                    Count--;
                    return;
                }
                current = current.Next;
            }
            throw new Exception("Not found");
        }

        public string VisualizzaInfrazioni()
        {
            string ToReturn = "";
            NodoOrario current = Head;
            for (int i = 0; i < Count; i++)
            {
                ToReturn += $"{current.StampaOrario()} - {current.FuoriOrario()}\n";
                current = current.Next;
            }

            return ToReturn;
        }
    }
}
