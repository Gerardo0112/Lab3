using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informacion_Arbol
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; set; }
        public Nodo SubarbolIzq { get; set; }
        public Nodo SubarbolDer { get; set; }

        public bool EsVacio()
        {
            if (Raiz == null)
                return true;
            return false;
        }

        public void Add(Nodo item)
        {
            Nodo news = item;

            if (Raiz == null)
            {
                Raiz = news;
            }
            else
            {
                int medicamento = news.Medicamento.nombre.CompareTo(Raiz.Medicamento.nombre);
                if(medicamento > 0 || medicamento == 0)
                {
                    AddAux(news, Raiz, true);
                }
                else if(medicamento < 0)
                {
                    AddAux(news, Raiz, false);
                }
            }
        }
        public void AddAux(Nodo nuevo, Nodo padre, bool derecho)
        {
            if(derecho)
            {
                if(padre.Derecho == null)
                {
                    padre.Derecho = nuevo;
                }
                else
                {
                    int medicamento = nuevo.Medicamento.nombre.CompareTo(padre.Derecho.Medicamento.nombre);
                    if(medicamento > 0 || medicamento == 0)
                    {
                        AddAux(nuevo, padre.Derecho, true);
                    }
                    else if(medicamento < 0)
                    {
                        AddAux(nuevo, padre.Derecho, false);
                    }
                }
               
            }
            else
            {
                if (padre.Izquierdo == null)
                {
                    padre.Izquierdo = nuevo;
                }
                else
                {
                    int medicamento = nuevo.Medicamento.nombre.CompareTo(padre.Izquierdo.Medicamento.nombre);
                    if (medicamento > 0 || medicamento == 0)
                    {
                        AddAux(nuevo, padre.Izquierdo, true);
                    }
                    else if (medicamento < 0)
                    {
                        AddAux(nuevo, padre.Izquierdo, false);
                    }
                }
            }
        }
    }
}
