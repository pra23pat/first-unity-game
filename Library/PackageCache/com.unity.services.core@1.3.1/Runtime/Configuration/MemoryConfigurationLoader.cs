<<<<<<< HEAD
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
    class MemoryConfigurationLoader : IConfigurationLoader
    {
        public SerializableProjectConfiguration Config { get; set; }

        Task<SerializableProjectConfiguration> IConfigurationLoader.GetConfigAsync()
        {
            var completionSource = new TaskCompletionSource<SerializableProjectConfiguration>();
            completionSource.SetResult(Config);
            return completionSource.Task;
        }
    }
}
=======
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
    class MemoryConfigurationLoader : IConfigurationLoader
    {
        public SerializableProjectConfiguration Config { get; set; }

        Task<SerializableProjectConfiguration> IConfigurationLoader.GetConfigAsync()
        {
            var completionSource = new TaskCompletionSource<SerializableProjectConfiguration>();
            completionSource.SetResult(Config);
            return completionSource.Task;
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
