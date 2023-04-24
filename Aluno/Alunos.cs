using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecicioMensalidade.Aluno
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int RG;
        public bool bolsista;
        public double mediaFinal;
        public double valorMensalidade;

        public double VerMediaFinal(double mediaFinal)
        {
            return mediaFinal;
        }
        public double VerMensalidade(double valorMensalidade)
        {
            return valorMensalidade;
        }


    }
}