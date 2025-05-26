namespace Principal
{
    public class Conta
    {
        private String cpf;
        private Decimal saldo;

        public Conta(String cpf, decimal valor)
        {
            this.cpf = cpf;
            this.saldo = valor;
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
    }
}