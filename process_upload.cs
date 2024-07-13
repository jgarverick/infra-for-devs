using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace infra_for_devs
{
    public class process_upload
    {
        private readonly ILogger<process_upload> _logger;

        public process_upload(ILogger<process_upload> logger)
        {
            _logger = logger;
        }

        [Function(nameof(process_upload))]
        public async Task Run([BlobTrigger("samples-workitems/{name}", Connection = "")] Stream stream, string name)
        {
            using var blobStreamReader = new StreamReader(stream);
            var content = await blobStreamReader.ReadToEndAsync();
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {content}");
        }
    }
}
