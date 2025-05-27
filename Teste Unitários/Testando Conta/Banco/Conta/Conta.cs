namespace Principal
{
    public class Conta
    {
        private String cpf;
        private Decimal saldo;
        private IValidadorCredito validadorCredito; // receber qualquer objeto que implemente a interface

        public Conta(String cpf, decimal valor)
        {
            this.cpf = cpf;
            this.saldo = valor;
        }
        
        // injeção por método, poderia fazer também por construtor
        public void SetValidadorCredito(IValidadorCredito validador)
        {
            this.validadorCredito = validador;
        }


        public decimal getSaldo()
        {
            return saldo;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            //Thread.Sleep(5000);

            if(valor <= 0)
            {
                return false;

                //throw new ArgumentOutOfRangeException();
            }
            if (saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public bool SolicitarEmprestimo(decimal valor)
        {
            bool resultado = validadorCredito.ValidarCredito(this.cpf, valor);

            if (resultado)
            {
                this.saldo += valor; 
            }
            return resultado;
        }
    }
}