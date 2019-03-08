using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informacion_Arbol
{
    public class Informacion_Arbol<T> : ICollection<T>, IEnumerable<T>
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

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
        /// <summary>
        ///  Primera opcion
        /// </summary>
        /// <param name="item"></param>
        public void Add(Nodo item)
        {
            if(Raiz != null)
            {
            }
        }

        /// <summary>
        /// Segunda opcion
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Nodo nodo = (Nodo)(Object)item;
            nodo.Derecho = null;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
