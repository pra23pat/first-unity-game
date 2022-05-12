<<<<<<< HEAD
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unity.Services.Core.Configuration
{
    class StreamingAssetsConfigurationLoader : IConfigurationLoader
    {
        public async Task<SerializableProjectConfiguration> GetConfigAsync()
        {
            var jsonConfig = await StreamingAssetsUtils.GetFileTextFromStreamingAssetsAsync(
                ConfigurationUtils.ConfigFileName);
            var config = JsonConvert.DeserializeObject<SerializableProjectConfiguration>(jsonConfig);
            return config;
        }
    }
}
=======
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unity.Services.Core.Configuration
{
    class StreamingAssetsConfigurationLoader : IConfigurationLoader
    {
        public async Task<SerializableProjectConfiguration> GetConfigAsync()
        {
            var jsonConfig = await StreamingAssetsUtils.GetFileTextFromStreamingAssetsAsync(
                ConfigurationUtils.ConfigFileName);
            var config = JsonConvert.DeserializeObject<SerializableProjectConfiguration>(jsonConfig);
            return config;
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
