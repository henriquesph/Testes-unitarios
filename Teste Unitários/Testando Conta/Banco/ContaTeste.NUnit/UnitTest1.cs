using Principal;

namespace ContaTeste.Unit
{
    [TestFixture]
    public class ContaTeste
    {
        //[OneTimeSetUp]
        //[OneTimeTearDown] - executado apenas 1 vez

        Conta conta;
        [SetUp] // executado ANTES DE CADA teste
        public void SetUp()
        {
            conta = new Conta("001", 200);
        }

        [TearDown] // executado após a CADA teste
        public void TearDown()
        {
            conta = null;
        }


        [Test]
        [Category("Principal")]
        [TestCase(120, true)]
        [TestCase(-120, false)]
        public void testSacar(int valor, bool resultadoEsperado)
        {

            bool resultado = conta.Sacar(valor);

            Assert.IsTrue(resultado == resultadoEsperado);
        }

        [Test]
        [Category("Principal")]
        public void testSacarSemSaldo()
        {
            bool resultado = conta.Sacar(250);

            Assert.IsFalse(resultado);
        }

        [Test]
        //[Ignore("Pendência de implementação da Regra de negócio 02")]
        [Category("Valores Inválidos")]
        [TestCase(-100)] //passa vários valores como atributo do teste (int valor)
        [TestCase(-9)]
        [TestCase(-920)]
        [TestCase(-4715)]
        public void testSacarValorNegativo(int valor)
        {
            bool resultado = conta.Sacar(valor);
            Assert.IsFalse(resultado);

            //Assert.Throws<ArgumentOutOfRangeException>(delegate { conta.Sacar(-100); }); // Teste de Exception

            //Assert.Catch<Exception>(delegate { conta.Sacar(-100); });
        }

        [Test]
        [Category("Valores Inválidos")]
        public void testSacarValorZero()
        {
            bool resultado = conta.Sacar(0);
            Assert.IsFalse(resultado);

        }

        [Test]
        [Timeout(4000)]
        public void testMetodoLento()
        {
            bool resultado = conta.Sacar(0);
            Assert.IsFalse(resultado);

        }
    }
}