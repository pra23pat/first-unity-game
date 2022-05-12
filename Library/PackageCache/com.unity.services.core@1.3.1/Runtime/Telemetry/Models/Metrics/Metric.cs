<<<<<<< HEAD
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    struct Metric : ITelemetryEvent
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("value")]
        public double Value;

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MetricType Type;

        [JsonProperty("tags")]
        public IDictionary<string, string> Tags;
    }
}
=======
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    struct Metric : ITelemetryEvent
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("value")]
        public double Value;

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MetricType Type;

        [JsonProperty("tags")]
        public IDictionary<string, string> Tags;
    }
}
>>>>>>> d6a5058d (added player animation with movement)
