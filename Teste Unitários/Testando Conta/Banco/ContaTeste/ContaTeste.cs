using Principal;
using System.Security.Cryptography;

namespace ContaTeste
{
    class ContaTeste
    {
        static void Main(string[] args)
        {
            testContaSacar();
            testContaSacarSemSaldo();
        }

        private static void testContaSacarSemSaldo()
        {
            // Arrange
            string cpf = "11111111111";
            decimal valor = 100;
            var conta = new Conta(cpf, valor);
            bool resultadoEsperado = false;

            // Act
            bool resultado = conta.Sacar(120);

            // Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("TestContaSacarSemSaldo: ok");
            }
            else
            {
                Console.WriteLine("TestContaSacarSemSaldo: falhou");
            }
        }

        private static void testContaSacar()
        {
            string cpf = "11111111111";
            decimal valor = 100;

            var conta = new Conta(cpf, valor);
            bool resultadoEsperado = true;

            bool resultado = conta.Sacar(50);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("TestContaSacar: ok");
            }
            else
            {
                Console.WriteLine("TestContaSacar: falhou");
            }
        }
    }
}