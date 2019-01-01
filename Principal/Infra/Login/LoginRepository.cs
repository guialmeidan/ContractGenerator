using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra
{
    public class LoginRepository : ILoginRepository
    {
        private IRestClient _restClient;
        private IRestRequest _restRequest;

        public LoginRepository(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
            _restRequest.Parameters.Clear();
        }

        public Login ObterPorId(int id)
        {
            var restClient = new RestClient("http://projetocontratos.gear.host");
            var restRequest = new RestRequest($"/api/Usuarios/" + 1, Method.GET);
            var result = restClient.Execute<Login>(restRequest);
            return result.Data;
        }

        public bool IsAuthenticated { get; set; }
    }
}
