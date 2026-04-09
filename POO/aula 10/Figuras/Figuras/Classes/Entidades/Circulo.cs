
using Figuras.Classes.Enumeração;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
		//Campo
		private double raio;

		//Propriedades
		public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}
		public Circulo(Cor corDaForma, double raio) : base(corDaForma)
		{
			Raio = raio;
		}

        //Métodos
        public override double Area()
        {
			return Raio * Raio * 3.14;
        }
	}
}
