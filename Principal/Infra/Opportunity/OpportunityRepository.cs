using Principal.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Principal.Domain.Entities;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using static Principal.Domain.Entities.Opportunity;

namespace Principal.Infra.Opportunity
{
    public class OpportunityRepository : IOpportunityRepository
    {
        private IRestClient _restClient;
        private IRestRequest _restRequest;

        public OpportunityRepository(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
            _restRequest.Parameters.Clear();
        }

        public MainOpportunity ObterPorId(int id, string token)
        {
                var restClient = new RestClient("https://gis-api.aiesec.org");
                var restRequest = new RestRequest($"/v2/opportunities/{id}?access_token=" + token, Method.GET);
                var result = restClient.Execute<MainOpportunity>(restRequest);
                return result.Data;          
        }
    }
}
