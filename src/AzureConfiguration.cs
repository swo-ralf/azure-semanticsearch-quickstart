using System.ComponentModel.DataAnnotations;

namespace AzureSemanticSearchWebApi
{
    public class AzureConfiguration
    {
        public const string Key = "AzureConfiguration";

        [Required]
        public Uri ServiceEndpoint { get; set; } = null!;

        [Required]
        public string ApiKey { get; set; } = "";

        [Required]
        public string IndexName { get; set; } = "";
    }
}
