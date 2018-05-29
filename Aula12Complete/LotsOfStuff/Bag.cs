﻿using System.Collections.Generic;

namespace Aula12Complete
{
    /// <summary>
    /// Classe que representa uma mochila ou saco que contem itens
    /// </summary>
    public class Bag : List<IStuff>, IStuff, IHasKarma
    {

        /// <summary> 
        /// Propriedade Weight respeita o contrato com IHasWeight. No caso do
        /// Bag o peso vai corresponder ao peso total dos itens.
        /// </summary>
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IStuff aThing in this)
                {
                    totalWeight += aThing.Weight;
                }
                return totalWeight;
            }
        }

        /// <summary> 
        /// Propriedade Value respeita o contrato com IValuable. No caso do
        /// Bag o valor vai corresponder ao valor total dos itens.
        /// </summary>
        public float Value
        {
            get
            {
                float totalValue = 0;
                foreach (IStuff aThing in this)
                {
                    totalValue += aThing.Value;
                }
                return totalValue;
            }
        }

        /// <summary>
        /// Propriedade Karma, respeita o contrato com IHasKarma
        /// </summary>
        public float Karma
        {
            get
            {
                float totalKarma = 0;
                foreach (IStuff aThing in this)
                {
                    if (aThing is IHasKarma)
                    {
                        totalKarma += (aThing as IHasKarma).Karma;
                    }
                }
                return Count > 0 ? totalKarma / Count : 0;
            }
        }

        /// <summary>
        /// Construtor que cria uma nova instância de mochila
        /// </summary>
        /// <param name="bagSize">
        /// Número inicial de itens que é possível colocar na mochila
        /// </param>
        public Bag(int bagSize) : base(bagSize) { }

        /// <summary>
        /// Sobreposição do método ToString() para a classe Bag.
        /// </summary>
        /// <returns>
        /// Uma string contendo informação sobre a mochila e os seus conteúdos.
        /// </returns>
        public override string ToString()
        {
            return $"Mochila com {Count} itens e um peso e valor " +
                $"totais de {Weight:f2} Kg e {Value:c}, respetivamente " +
                $"(karma={Karma:f2})";
        }

        /// <summary>
        /// Indica se existem itens de determinado tipo na mochila.
        /// </summary>
        /// <typeparam name="T">
        /// Tipo a verificar se existe na mochila.
        /// </typeparam>
        /// <returns>
        /// True caso tipo exista na mochila, false caso contrário.
        /// </returns>
        public bool ContainsItemOfType<T>() where T : IStuff
        {
            foreach (IStuff aThing in this)
            {
                if (aThing is T) return true;
            }

            return false;
        }

        /// <summary>
        /// Retorna enumerável, sob a forma de coleção, contendo itens na
        /// mochila que sejam do tipo especificado.
        /// </summary>
        /// <typeparam name="T">
        /// Tipo dos itens a retornar.
        /// </typeparam>
        /// <returns>
        /// Enumerável contendo os itens do tipo especificado.
        /// </returns>
        public IEnumerable<T>  GetItemsOfType<T>() where T : class, IStuff
        {
            List<T> items = new List<T>();

            foreach (IStuff aThing in this)
            {
                if (aThing is T)
                {
                    items.Add(aThing as T);
                }
            }

            return items;
        }

        /// <summary>
        /// Retorna itens na mochila que sejam do tipo especificado sem criar
        /// uma coleção intermédia.
        /// </summary>
        /// <typeparam name="T">
        /// Tipo dos itens a retornar.
        /// </typeparam>
        /// <returns>
        /// Itens do tipo especificado.
        /// </returns>
        public IEnumerable<T> BetterGetItemsOfType<T>() where T : class, IStuff
        {
            foreach (IStuff aThing in this)
            {
                if (aThing is T)
                {
                   yield return aThing as T;
                }
            }
        }
    }
}
