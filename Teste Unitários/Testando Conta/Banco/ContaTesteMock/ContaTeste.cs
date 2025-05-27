using Principal;

namespace ContaTesteMock
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        public void testSolicitarEmprestimo()
        {
            var conta = new Conta("0001", 100);
            conta.SetValidadorCredito(new ValidadorCreditoFake()); // injetou o mock

            bool resultado = conta.SolicitarEmprestimo(5000);

            Assert.IsTrue(resultado);

        }
    }
}