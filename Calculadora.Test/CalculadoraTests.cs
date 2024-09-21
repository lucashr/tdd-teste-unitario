using Calculadora;

namespace Calculadora.Test
{
    public class CalculadoraTests
    {
        [Fact]
        public void DeveSomar2e3Eretornar5()
        {
            
            var c = new Calculadora();
            
            var retorno = c.Somar(2, 3);

            Assert.Equal(5, retorno);
        }

        [Fact]
        public void DeveSubtrair10e7Eretornar3()
        {

            var c = new Calculadora();

            var retorno = c.Subtrair(10, 7);

            Assert.Equal(3, retorno);
        }

        [Fact]
        public void DeveMultiplicar10e7Eretornar70()
        {

            var c = new Calculadora();

            var retorno = c.Multiplicar(10, 7);

            Assert.Equal(70, retorno);
        }

        [Fact]
        public void DeveDividir100Por4Eretornar25()
        {

            var c = new Calculadora();

            var retorno = c.Dividir(100, 4);

            Assert.Equal(25, retorno);
        }

        [Fact]
        public void DevRetornarExcecaoDivisaoPorZero()
        {

            var c = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => c.Dividir(100, 0));
        }

        [Fact]
        public void DeveRetornarHistoricoZerado()
        {

            var c = new Calculadora();

            var retorno = c.Historico();

            Assert.Empty(retorno);
        }

        [Fact]
        public void DeveRetornar2Historicos()
        {

            var c = new Calculadora();

            c.Somar(1, 2);
            c.Somar(1, 3);

            var retorno = c.Historico();

            Assert.Equal(2, retorno.Count);
        }

        [Fact]
        public void DeveRetornar3Historicos()
        {

            var c = new Calculadora();

            c.Somar(1, 2);
            c.Somar(1, 3);
            c.Somar(1, 7);
            c.Somar(10, 2);
            c.Somar(2, 3);
            c.Somar(12, 7);

            var retorno = c.Historico();

            Assert.Equal(3, retorno.Count);
        }

        [Fact]
        public void DeveConter35NaPosicaoZeroDoHistorico()
        {

            var c = new Calculadora();

            c.Somar(1, 2);
            c.Somar(1, 3);
            c.Somar(1, 7);
            c.Somar(10, 2);
            c.Somar(2, 3);
            c.Somar(12, 7);
            c.Somar(28, 7);

            var retorno = c.Historico();

            Assert.Contains("35", retorno[0]);
        }
    }
}