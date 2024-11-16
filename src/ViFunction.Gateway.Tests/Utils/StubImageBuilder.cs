using System.Net;
using Refit;
using ViFunction.Gateway.Application.Services;

namespace ViFunction.Gateway.Tests.Utils;

public class StubImageBuilder : IImageBuilder
{
    public Task<IApiResponse> BuildAsync(string imageName, string version, IEnumerable<StreamPart> files)
    {
        var response = new ApiResponse<string>(new HttpResponseMessage(HttpStatusCode.OK), "Build Successful",
            new RefitSettings());
        return Task.FromResult<IApiResponse>(response);
    }
}