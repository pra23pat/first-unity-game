<<<<<<< HEAD
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class TelemetryConfig
    {
        public string TargetUrl;

        public string ServicePath;

        public double PayloadExpirationSeconds;

        public double PayloadSendingMaxIntervalSeconds;

        public double SafetyPersistenceIntervalSeconds;

        public int MaxMetricCountPerPayload;
    }
}
=======
using System;

namespace Unity.Services.Core.Telemetry.Internal
{
    [Serializable]
    class TelemetryConfig
    {
        public string TargetUrl;

        public string ServicePath;

        public double PayloadExpirationSeconds;

        public double PayloadSendingMaxIntervalSeconds;

        public double SafetyPersistenceIntervalSeconds;

        public int MaxMetricCountPerPayload;
    }
}
>>>>>>> d6a5058d (added player animation with movement)
