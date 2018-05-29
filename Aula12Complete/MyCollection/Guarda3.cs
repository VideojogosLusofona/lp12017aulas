using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula12Complete
{
    /// <summary>
    /// Esta classe é uma coleção que guarda três coisas de qualquer tipo.
    /// </summary>
    /// <typeparam name="T">
    /// Tipo das coisas a serem guardadas nesta coleção.
    /// </typeparam>
    public class Guarda3<T> : IEnumerable<T>
    {
        /// <summary>
        /// Variáveis de instância onde esta coleção guarda os seus itens.
        /// </summary>
        private T v1, v2, v3;

        /// <summary>
        /// Construtor que inicializa os três itens com o seu valor por omissão. 
        /// </summary>
        public Guarda3()
        {
            v1 = default(T);
            v2 = default(T);
            v3 = default(T);
        }

        /// <summary>
        /// A interface IEnumerable<T> obriga à implementação deste método de
        /// modo a que a classe seja iterável.
        /// </summary>
        /// <returns>
        /// Um enumerador, que permite à classe ser iterável.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            // Retornamos um item de cada vez sem necessidade de criar uma
            // coleção intermédia
            yield return v1;
            yield return v2;
            yield return v3;
        }

        /// <summary>
        /// Retorna o item solicitado.
        /// </summary>
        /// <param name="i">Índice do item solicitado.</param>
        /// <returns>Item solicitado.</returns>
        public T GetItem(int i)
        {
            switch (i)
            {
                case 1:
                    return v1;
                case 2:
                    return v2;
                case 3:
                    return v3; 
                default:
                    // Lançamos uma excepção se índice estiver fora dos limites 
                    throw new ArgumentOutOfRangeException(
                        "This collection only keeps items from 1 to 3");
            }
        }

        /// <summary>
        /// Guarda um item no índice especificado.
        /// </summary>
        /// <param name="i">Índice onde guardar o item.</param>
        /// <param name="item">Item a guardar.</param>
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 1:
                    v1 = item;
                    break;
                case 2:
                    v2 = item;
                    break;
                case 3:
                    v3 = item;
                    break;
                default:
                    // Lançamos uma excepção se índice estiver fora dos limites 
                    throw new ArgumentOutOfRangeException(
                        "This collection only keeps items from 1 to 3");
            }
        }

        /// <summary>
        /// Adiciona um item à coleção, lança uma excepção caso não exista
        /// espaço.
        /// </summary>
        /// <param name="item">Item a adicionar à coleção.</param>
        public void Add(T item)
        {
            if (Equals(v1, default(T)))
            {
                v1 = item;
            }
            else if (Equals(v2, default(T)))
            {
                v2 = item;
            }
            else if (Equals(v3, default(T)))
            {
                v3 = item;
            }
            else
            {
                throw new ArgumentException("Colletion is full");
            }
        }

        /// <summary>
        /// Este método é necessário para que a classe Guarda3 implemente a
        /// interface IEnumerable não-genérica (pois IEnumerable<T> estende
        /// IEnumerable).
        /// </summary>
        /// <returns>
        /// Simplesmente retorna o que a versão genérica deste método retorna.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
