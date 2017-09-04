using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract] 
    public class Cliente
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }
    }
}
