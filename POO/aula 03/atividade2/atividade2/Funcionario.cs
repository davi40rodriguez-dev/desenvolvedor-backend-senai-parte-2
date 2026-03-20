using System;
using System.Collections.Generic;
using System.Text;

namespace atividade2
{
    internal class Funcionario
    {
            public string Nome;
            public double SalarioBruto;
            public double Imposto;

            public double SalarioLiquido()
            {
                return SalarioBruto - Imposto;
            }

            public void AumentarSalario(double porcentagem)
            {
                double liquido = SalarioBruto - Imposto;
                double aumento = liquido * porcentagem / 100;
                SalarioBruto = SalarioBruto + aumento;
            }
        }
    }

