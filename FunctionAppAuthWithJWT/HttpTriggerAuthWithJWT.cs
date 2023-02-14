using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FunctionAppAuthWithJWT.Models;
using FunctionAppAuthWithJWT.Utility;

namespace FunctionAppAuthWithJWT
{
    public static class HttpTriggerAuthWithJWT
    {
        [FunctionName("HttpTriggerAuthWithJWT")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,"post", Route = "user/auth")] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            UserCredential userCredential = JsonConvert.DeserializeObject<UserCredential>(requestBody);
            
            log.LogInformation("C# HTTP trigger function processed a request.");
            bool authenticated=userCredential?.UserName.Equals("akog02",StringComparison.OrdinalIgnoreCase)??false;
            if (!authenticated)
            {
                return await Task.FromResult(new UnauthorizedResult()).ConfigureAwait(false);
            }
            else
            {
                var generateJWTToken=new GenerateJWTToken();
                string token = generateJWTToken.IssuingJWT(userCredential.UserName);
                return await Task.FromResult(new OkObjectResult(token)).ConfigureAwait(false);
            }   
            
        }
        [FunctionName(nameof(GetUser))]
        public static async Task<IActionResult> GetUser
            ([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "user/info")] HttpRequest req,ILogger log){
            // Check if we have authentication info.
            ValidateJWT auth = new ValidateJWT(req);
            if (!auth.IsValid)
                return new UnauthorizedResult(); // No authentication info.           
            string postData = await req.ReadAsStringAsync();
            return new OkObjectResult($"{postData}");

        }
    }
}
