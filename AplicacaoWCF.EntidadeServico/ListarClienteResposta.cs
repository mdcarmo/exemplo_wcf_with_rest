using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class ListarClienteResposta
    {
        public ListarClienteResposta()
        {
            Clientes = new List<Cliente>();
        }

        [DataMember]
        public List<Cliente> Clientes { get; set; }
    }
}
