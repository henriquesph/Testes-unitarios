//namespace ContaTeste.NUnit
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void Test1()
//        {
//            Assert.Pass();
//        }
//    }
//}

using Principal;

namespace ContaTeste.Unit
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        public void testSacar()
        {
            Conta conta = new Conta("0009", 200);

            bool resultado = conta.Sacar(120);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void testSacarSemSaldo()
        {
            Conta conta = new Conta("0009", 200);

            bool resultado = conta.Sacar(250);

            Assert.IsFalse(resultado);
        }
    }
}