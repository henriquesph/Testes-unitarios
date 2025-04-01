using Principal;

namespace CalculadoraTeste
{
    // função do teste unitário: caso algum bug seja adicionado futuramente no método, o teste falhará
    class CalculadoraTeste
    {
        static void Main(string[] args)
        {
            testSomar();
            testSomarNumerosNegativos();
        }

        private static void testSomarNumerosNegativos()
        {
            var calculadora = new Calculadora();
            int resutadoEsperado = -100;

            int resultado = calculadora.Somar(-20, -80);

            if(resultado == resutadoEsperado)
            {
                Console.WriteLine("TestSomarNumerosNegativos: OK");
            }
            else
            {
                Console.WriteLine("TestSomarNumerosNegativos: Falhou");
            }
        }

        private static void testSomar()
        {
            var calculadora = new Calculadora();
            int resultadoEsperado = 350;

            int resultado = calculadora.Somar(100, 250);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("testeSomar: OK");
            }
            else
            {
                Console.WriteLine("testeSomar: Falhou");
            }
        }
    }
}