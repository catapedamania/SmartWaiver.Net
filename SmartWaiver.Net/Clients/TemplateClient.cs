using RestSharp;
using SmartWaiver.Net.Exceptions;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Objects;
using System.Collections.Generic;

namespace SmartWaiver.Net.Clients
{
    public class TemplateClient : ITemplateClient
    {
        private readonly RestClient _client;

        public TemplateClient(RestClient client)
        {
            _client = client;
        }
        public TemplatesResponse GetTemplates()
        {
            var request = new RestRequest("v4/templates");

            var response = _client.ExecuteAsync<TemplatesResponse>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch templates list",response.ErrorException);
            ex.AddWebTrace(response.Content);
            throw ex;
        }

        public TemplateResponse GetTemplate(string templateId)
        {
            var request = new RestRequest("v4/templates/{templateId}");
            request.AddUrlSegment("templateId", templateId);

            var response = _client.ExecuteAsync<TemplateResponse>(request).Result;

            if (response.IsSuccessful)
            {
                return response.Data;
            }

            var ex = new FailedToFetchFromAPIException($"Failed to fetch template {templateId}",response.ErrorException);
            ex.Data.Add("Template Id", templateId);
            ex.AddWebTrace(response.Content);
            throw ex;
        }
    }
}
