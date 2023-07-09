using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace EighthTask.StepDefinitions
{
    [Binding]
    public class GithubAPIForReposStepDefinitions
    {
        private RestClient client;
        private RestRequest request;
        private RestResponse response;

        [Given(@"connect to github API")]
        public void GivenConnectToGithubAPI()
        {
            client = new RestClient("https://api.github.com/");
        }

        [Given(@"create get request")]
        public void GivenCreateGetRequest()
        {
            request = new RestRequest("users/Artona17/repos", Method.Get);
        }

        [When(@"send request")]
        public void WhenSendRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"response is success")]
        public void ThenResponseIsSuccess()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
