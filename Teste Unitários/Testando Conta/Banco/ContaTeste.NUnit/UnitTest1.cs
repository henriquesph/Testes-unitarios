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

        [TearDown] // executado ap�s a CADA teste
        public void TearDown()
        {
            conta = null;
        }


        [Test]
        public void testSacar()
        {

            bool resultado = conta.Sacar(120);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void testSacarSemSaldo()
        {
            bool resultado = conta.Sacar(250);

            Assert.IsFalse(resultado);
        }

        //[Test]
        //[Ignore("Pend�ncia de implementa��o da Regra de neg�cio 02")]
        public void testSacarValorNegativo()
        {
            bool resultado = conta.Sacar(-100);

            Assert.IsFalse(resultado);
        }
    }
}