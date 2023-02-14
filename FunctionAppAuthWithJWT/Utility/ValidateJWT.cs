using JWT;
using JWT.Algorithms;
using JWT.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace FunctionAppAuthWithJWT.Utility
{
    public class ValidateJWT
    {
        public bool IsValid { get; }
        public string Username { get; }
        public string Role { get; }
        public ValidateJWT(HttpRequest request)
        {
            // Check if we have a header.
            if (!request.Headers.ContainsKey("Authorization"))
            {
                IsValid = false;
                return;
            }
            string authorizationHeader = request.Headers["Authorization"];
            // Check if the value is empty.
            if (string.IsNullOrEmpty(authorizationHeader))
            {
                IsValid = false;
                return;
            }
            // Check if we can decode the header.
            IDictionary<string, object> claims = null;
            try
            {
                if (authorizationHeader.StartsWith("Bearer"))
                    authorizationHeader = authorizationHeader.Substring(7);

                // Validate the token and decode the claims.
                claims = new JwtBuilder()
                    .WithAlgorithm(new HMACSHA256Algorithm())
                    .WithSecret("akog02@101")
                    .MustVerifySignature()
                    .Decode<IDictionary<string, object>>(authorizationHeader);
            }
            catch (Exception e)
            {
                IsValid = false;
                Console.WriteLine(e.StackTrace);
                return;
            }

            // Check if we have user claim.
            if (!claims.ContainsKey("UserName"))
            {
                IsValid = false;
                return;
            }

            IsValid = true;
            Username = Convert.ToString(claims["UserName"]);
            Role = Convert.ToString(claims["role"]);
        }
    }
}
