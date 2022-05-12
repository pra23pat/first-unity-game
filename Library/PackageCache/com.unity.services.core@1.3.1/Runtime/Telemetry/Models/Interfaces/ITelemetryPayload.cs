<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    interface ITelemetryPayload
    {
        Dictionary<string, string> CommonTags { get; }

        int Count { get; }

        void Add(ITelemetryEvent telemetryEvent);
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    interface ITelemetryPayload
    {
        Dictionary<string, string> CommonTags { get; }

        int Count { get; }

        void Add(ITelemetryEvent telemetryEvent);
    }
}
>>>>>>> d6a5058d (added player animation with movement)
