<<<<<<< HEAD
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class CachedPayload<TPayload>
        where TPayload : ITelemetryPayload
    {
        /// <summary>
        /// Time, in ticks, the first event of this payload was recorded.
        /// It uses <see cref="DateTime.UtcNow"/>.
        /// </summary>
        public long TimeOfOccurenceTicks;

        public TPayload Payload;
    }
}
=======
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class CachedPayload<TPayload>
        where TPayload : ITelemetryPayload
    {
        /// <summary>
        /// Time, in ticks, the first event of this payload was recorded.
        /// It uses <see cref="DateTime.UtcNow"/>.
        /// </summary>
        public long TimeOfOccurenceTicks;

        public TPayload Payload;
    }
}
>>>>>>> d6a5058d (added player animation with movement)
