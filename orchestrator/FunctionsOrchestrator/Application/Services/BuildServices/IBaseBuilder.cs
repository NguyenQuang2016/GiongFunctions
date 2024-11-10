using Refit;

namespace FunctionsOrchestrator.Application.Services.BuildServices;

public interface IBaseBuilder
{
    [Multipart]
    [Post("/build")]
    Task<IApiResponse> BuildAsync([AliasAs("image_name")] string functionName,
        [AliasAs("files")] IEnumerable<StreamPart> files);
}