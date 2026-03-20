using System;
using System.Collections.Generic;
using System.Text;

namespace atividade3
{
    internal class Aluno
    {
            public string NomeDoAluno;
            public double Nota1;
            public double Nota2;
            public double Nota3;

            public double NotaFinal()
            {
                return Nota1 + Nota2 + Nota3;
            }

            public bool AprovadoOuReprovado()
            {
                if (NotaFinal() >= 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public double Ponto()
            {
                if (NotaFinal() < 60)
                {
                    return 60 - NotaFinal();
                }
                else
                {
                    return 0;
                }
            }
        }
    }

