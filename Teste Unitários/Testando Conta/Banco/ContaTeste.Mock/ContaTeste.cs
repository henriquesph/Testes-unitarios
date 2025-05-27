using Moq;
using Principal;

namespace ContaTeste.Mock
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        public void testSolicitarEmprestimo()
        {
            var conta = new Conta("0001", 100);

            var mock = new Mock<IValidadorCredito>();

            // Inje��o de depend�ncia
            mock.Setup(x => x.ValidarCredito("0001", 5000)).Returns(true); // o m�todo n�o foi criado em uma classe, quando tiver essas entradas a sa�da tem que true
            conta.SetValidadorCredito(mock.Object); // Object � um atributo em que o objeto vai ser trabalhado, ele implementa a interface n�o o objeto Mock em si - n�o precisamos implementar os m�todos da interface, para focar no m�todo que vc quer testar - Evita a cria��o de classes p/ implementa��o (projeto enxuto)
            int resultadoEsperado = 5100;

            conta.SolicitarEmprestimo(5000);

            Assert.IsTrue(conta.getSaldo() == resultadoEsperado);
        }
    }
}