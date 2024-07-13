using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace infra_for_devs
{
    public class ProcessUpload
    {
        private readonly ILogger<ProcessUpload> _logger;

        public ProcessUpload(ILogger<ProcessUpload> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ProcessUpload))]
        public async Task Run([BlobTrigger("samples-workitems/{name}", Connection = "")] Stream stream, string name)
        {
            using var blobStreamReader = new StreamReader(stream);
            var content = await blobStreamReader.ReadToEndAsync();
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {content}");
        }
    }
}