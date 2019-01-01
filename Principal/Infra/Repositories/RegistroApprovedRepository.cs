using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Repositories
{
    public class RegistroApprovedRepository : IRegistroApprovedRepository
    {
        private IRestClient _restClient;
        private IRestRequest _restRequest;

        public RegistroApprovedRepository(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
            _restRequest.Parameters.Clear();
        }

        public void SalvarApproved(RegistroApproved approved)
        {
            try
            {
                var client = new RestClient("http://projetocontratos.gear.host");
                var request = new RestRequest("/api/Approveds", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(approved);
                client.Execute(request);
            }
            catch (Exception e)
            {

            }            
        }
    }
}
