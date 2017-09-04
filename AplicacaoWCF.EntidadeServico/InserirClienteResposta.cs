using System;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class InserirClienteResposta
    {
        [DataMember]
        public int Identificador { get; set; }
    }
}
