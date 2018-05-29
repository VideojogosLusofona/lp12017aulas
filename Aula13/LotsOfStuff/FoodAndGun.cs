namespace Aula13
{
    /// <summary>
    /// Classe que contém uma instância de Food e uma instância de Gun.
    /// </summary>
    public struct FoodAndGun
    {
        /// <summary>
        /// Variável de instância só de leitura que contém a comida.
        /// </summary>
        public readonly Food food;

        /// <summary>
        /// Variável de instância só de leitura que contém a arma.
        /// </summary>
        public readonly Gun gun;

        /// <summary>
        /// Construtor que guarda a food e a gun.
        /// </summary>
        /// <param name="food">Food a guardar.</param>
        /// <param name="gun">Gun a guardar.</param>
        public FoodAndGun(Food food, Gun gun)
        {
            this.food = food;
            this.gun = gun;
        }
    }
}