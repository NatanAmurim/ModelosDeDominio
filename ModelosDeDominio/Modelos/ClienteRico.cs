using ModelosDeDominio.Enums;

namespace Modelos.ModelosDeDominio
{
    //Modelo de dominio rico, onde é aplicado o encapsulamento das propriedades e validações.
    //Este modelo tem alta coesão, uma vez que ele garante a integridade dos dados e a classe torna-se responsável por si.
 
    internal class ClienteRico: Entidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }        

        public ClienteRico(int id, string nome, string cpf) : base()
        {
            notificacoes.AdicionarNotificacao(id < 0, nameof(id), "Não pode ser menor que zero.", 1, TipoValidacao.MenorQueZero);
            notificacoes.AdicionarNotificacao(string.IsNullOrEmpty(nome), nameof(nome), "", 2, TipoValidacao.TextoNuloOuVazio);
            notificacoes.AdicionarNotificacao(string.IsNullOrEmpty(nome), nameof(cpf), "Não pode ser vazio.", 3, TipoValidacao.Nenhum);
            Validar();
        }

        public override string ToString() 
        {
            return $"{nameof(Id)}: {Id}\n " +
                $"{nameof(Nome)}: {Nome}\n " +
                $"{nameof(CPF)}: {CPF}";
        }
    }


}
