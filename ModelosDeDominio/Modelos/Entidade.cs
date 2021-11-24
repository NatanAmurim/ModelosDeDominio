using ModelosDeDominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.ModelosDeDominio
{
    public abstract class Entidade
    {
        protected Notificacoes notificacoes = new Notificacoes();
        public void Validar()
        {
            try
            {
                if (notificacoes.TemErros())
                {
                    string mensagemErro = "\n";
                    foreach (var erro in notificacoes.ListaErros)
                    {
                        mensagemErro += erro.ToString();
                    }

                    throw new ArgumentException(mensagemErro);
                }
            }
            finally
            {
                if (notificacoes != null)
                    notificacoes.Dispose();
            }

        }
    }
}
