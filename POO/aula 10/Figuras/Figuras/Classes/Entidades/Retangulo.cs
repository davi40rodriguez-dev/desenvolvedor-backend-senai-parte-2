using Figuras.Classes.Enumeração;
namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//Campos
		private double largura;
		private double altura;

        public Retangulo(Cor corDaForma, double largura, double ) : base(corDaForma)
        {
        }

        //Propriedas
        public double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
		protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}
        /// <summary>
        /// Calcula  área da forma usando as dimensões atuais.
        /// </summary>
        /// <returns>O valor da área calculando com base na largura 
        /// e altura do retângulo.</returns>
        public override double Area() => largura * Altura;
    }
}
