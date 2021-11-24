using System;
using System.Collections.Generic;
using System.Text;

namespace ModelosDeDominio.Notificacoes
{
    public class Erro
    {
        public string NomePropriedade { get; private set; }
        public string MensagemErro { get; private set; }
        public int CodigoErro { get; private set; }

        public Erro(string nomePropriedade, string mensagemErro, int codigoErro)
        {
            NomePropriedade = nomePropriedade;
            MensagemErro = mensagemErro;
            CodigoErro = codigoErro;
        }

        public override string ToString() 
        {
            return $"{nameof(NomePropriedade)}: {NomePropriedade}\n" +
                $"{nameof(MensagemErro)}: {MensagemErro}\n" +
                $"{nameof(CodigoErro)}: {CodigoErro}\n\n";
        }
    }
}
