using ModelosDeDominio.Enums;
using System;
using System.Collections.Generic;


namespace ModelosDeDominio.Notificacoes
{
    public class Notificacoes : IDisposable
    {        
        public List<Erro> ListaErros { get; private set; }
        public Notificacoes() 
        {
            ListaErros = new List<Erro>();
        }
        public void AdicionarNotificacao(bool temErro,string nomePropriedade, string mensagem, int codigo, TipoValidacao tipoValidacao = TipoValidacao.Nenhum) 
        {
            if (temErro) 
            {
                string mensagemErro = MontarMensagemNotificacao(mensagem, nomePropriedade, tipoValidacao);
                ListaErros.Add(new Erro(nomePropriedade, mensagemErro, codigo));
            }
        }

        private string MontarMensagemNotificacao(string mensagem, string nomePropriedade, TipoValidacao tipoValidacao) 
        {
            string mensagemErro;

            switch (tipoValidacao)
            {
                case TipoValidacao.MenorQueZero:
                    mensagemErro = $"{nomePropriedade} não pode ser menor que zero.";
                        break;
                case TipoValidacao.MaiorQueZero:
                    mensagemErro = $"{nomePropriedade} não pode ser maior que zero.";
                    break;
                case TipoValidacao.TextoNuloOuVazio:
                    mensagemErro = $"{nomePropriedade} não pode ser nulo ou vazio.";
                    break;
                default:
                    mensagemErro = mensagem;
                    break;
            }

            return mensagemErro;
        }

        public void Dispose()
        {
            if (ListaErros != null) 
            {
                ListaErros.Clear();
                ListaErros = null;
            }            
        }

        public bool TemErros() 
        {
            return (ListaErros.Count > 0);
        }

    }
}
