using System;

namespace Calculadora
{
    public class Calculadora
    {

        private List<string> historicoOperacoes;

        public Calculadora()
        {
            historicoOperacoes = new();
        }

        public int Somar(int val1, int val2)
        {
            var retorno = val1 + val2;
            historicoOperacoes.Insert(0, $"Res: {retorno}");
            return retorno;
        }

        public int Multiplicar(int val1, int val2)
        {
            var retorno = val1 * val2;
            historicoOperacoes.Insert(0, $"Res: {retorno}");
            return retorno;
        }

        public int Subtrair(int val1, int val2)
        {
            var retorno = val1 - val2;
            historicoOperacoes.Insert(0, $"Res: {retorno}");
            return val1 - val2;
        }

        public int Dividir(int val1, int val2)
        {
            var retorno = val1 / val2;
            historicoOperacoes.Insert(0, $"Res: {retorno}");
            return val1 / val2;
        }

        public List<string> Historico()
        {
            if(historicoOperacoes.Count >= 3)
                historicoOperacoes.RemoveRange(3, historicoOperacoes.Count - 3);

            return historicoOperacoes;
        }

    }
}
