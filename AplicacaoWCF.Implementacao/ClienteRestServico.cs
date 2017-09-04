using AplicacaoWCF.Contrato;
using AplicacaoWCF.EntidadeServico;
using System;

namespace AplicacaoWCF.Implementacao
{
    public class ClienteRestServico : IClienteRest
    {
        public ListarClienteResposta Listar(string id)
        {
            ListarClienteResposta resposta = new ListarClienteResposta();

            if (!string.IsNullOrEmpty(id)){

                if(Convert.ToInt32(id) == 0)
                    resposta.Clientes.Add(new Cliente() { Id = Convert.ToInt32(id), Nome = "Cliente Nome 1" });
                else
                {
                    resposta.Clientes.Add(new Cliente() { Id = 1, Nome = "Cliente Nome 1" });
                    resposta.Clientes.Add(new Cliente() { Id = 2, Nome = "Cliente Nome 2" });
                    resposta.Clientes.Add(new Cliente() { Id = 3, Nome = "Cliente Nome 3" });
                    resposta.Clientes.Add(new Cliente() { Id = 4, Nome = "Cliente Nome 4" });
                }
            }   

            return resposta;
        }
    }
}
