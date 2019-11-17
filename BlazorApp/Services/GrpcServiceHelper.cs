using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class GrpcServiceHelper
    {
        public static GrpcChannel CreateAuthenticatedChannel(string address, IHttpContextAccessor httpContext)
        {
            var credentials = CallCredentials.FromInterceptor(async (context, metadata) =>
            {
                var accessToken = await httpContext.HttpContext.GetTokenAsync("access_token");
                if (!string.IsNullOrEmpty(accessToken))
                {
                    metadata.Add("Authorization", $"Bearer {accessToken}");
                }
            });

            // SslCredentials is used here because this channel is using TLS.
            // Channels that aren't using TLS should use ChannelCredentials.Insecure instead.
            var channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                Credentials = ChannelCredentials.Create(new SslCredentials(), credentials)
            });
            return channel;
        }
    }
}
