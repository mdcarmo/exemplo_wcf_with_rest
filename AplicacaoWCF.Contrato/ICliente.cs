using AplicacaoWCF.EntidadeServico;
using System.ServiceModel;

namespace AplicacaoWCF.Contrato
{
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        InserirClienteResposta InserirCliente(InserirClienteSolicitacao solicitacao);
    }
}
