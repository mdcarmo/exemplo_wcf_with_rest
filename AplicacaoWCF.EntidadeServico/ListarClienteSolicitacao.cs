using System;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class ListarClienteSolicitacao
    {
        [DataMember]
        public int Id { get; set; }
    }
}
