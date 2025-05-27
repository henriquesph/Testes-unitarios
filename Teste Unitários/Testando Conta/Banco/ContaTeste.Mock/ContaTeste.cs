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

            // Injeção de dependência
            mock.Setup(x => x.ValidarCredito("0001", 5000)).Returns(true); // o método não foi criado em uma classe, quando tiver essas entradas a saída tem que true
            conta.SetValidadorCredito(mock.Object); // Object é um atributo em que o objeto vai ser trabalhado, ele implementa a interface não o objeto Mock em si - não precisamos implementar os métodos da interface, para focar no método que vc quer testar - Evita a criação de classes p/ implementação (projeto enxuto)
            int resultadoEsperado = 5100;

            conta.SolicitarEmprestimo(5000);

            Assert.IsTrue(conta.getSaldo() == resultadoEsperado);
        }
    }
}