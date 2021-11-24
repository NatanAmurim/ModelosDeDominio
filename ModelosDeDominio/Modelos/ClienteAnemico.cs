
namespace Modelos.ModelosDeDominio
{
    //Modelo de dominio anemico, onde por falta de regras e validações, a classe encontra-se com baixa coesão
    //assim permitindo atribuições incoerentes.
    internal class ClienteAnemico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}\n " +
                $"{nameof(Nome)}: {Nome}\n " +
                $"{nameof(CPF)}: {CPF}";
        }
    }
}
