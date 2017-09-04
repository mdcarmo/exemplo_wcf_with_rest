using System;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class InserirClienteSolicitacao
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
