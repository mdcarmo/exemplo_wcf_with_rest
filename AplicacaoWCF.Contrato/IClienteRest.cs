using AplicacaoWCF.EntidadeServico;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace AplicacaoWCF.Contrato
{
    [ServiceContract]
    public interface IClienteRest
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            UriTemplate = "/get/{id}", 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json)]
      
        ListarClienteResposta Listar(string id);
    }
}
