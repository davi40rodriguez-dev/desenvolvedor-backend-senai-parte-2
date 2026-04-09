using Figuras.Classes.;
using Figuras.Classes.Enumeração;


namespace Figuras.Classes.Entidades
{
    abstract internal class Forma : IArea
    {
        /// </summary>
        /// Cores disponíveis Vermelho, Azul e Amerelo
        /// <summary>

        //Campo
        private Cor cor;


        //Propriedade
        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }
        //Construtor
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }
        //Método
        abstract public double Area();
        
    }
}