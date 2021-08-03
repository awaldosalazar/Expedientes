using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expediente
{
    class ArbolBinario
    {
        class NodoArbol
        {
            public int info;  //ES EL QUE HACE REFERENCIA AL DATO QUE TENDRA EL NODO
            public NodoArbol izq;
            public NodoArbol der;
            public NodoArbol raiz;
            public int altura;
            public int nivel;

            private ArbolBinario arbol;
            public NodoArbol()
            {
            }

            public ArbolBinario Arbol
            {
                get { return arbol; }
                set { arbol = value; }
            }

            public NodoArbol(int nueva_info, NodoArbol izq, NodoArbol der, NodoArbol raiz)
            {
                this.info = nueva_info;
                this.izq = izq;
                this.der = der;
                this.raiz = raiz;
                altura = 0;
            }

            public NodoArbol insertar(int dato, NodoArbol nodoDato, int level)
            {
                if (nodoDato == null)
                {
                    nodoDato = new NodoArbol(dato, null, null, null);
                    nodoDato.nivel = level;
                }else if (dato < nodoDato.info)
                {
                    level++;
                    
                }
                return nodoDato;
            }
        }
    }
}
