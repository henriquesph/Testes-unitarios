using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class ValidadorCredito : IValidadorCredito
    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            bool StatusSerasa = VerificarSituacaoSerasa(cpf);
            bool StatusSPC = VerificarSituacaoSPC(cpf);

            return (StatusSerasa && StatusSPC);
        }

        private bool VerificarSituacaoSPC(string cpf)
        {
            // chamada a um webservice para verificar a situação SPC
            return true;
        }

        private bool VerificarSituacaoSerasa(string cpf)
        {
            // Chamada a um webService para verificar a situação do Serasa
            return true;
        }
    }
}
