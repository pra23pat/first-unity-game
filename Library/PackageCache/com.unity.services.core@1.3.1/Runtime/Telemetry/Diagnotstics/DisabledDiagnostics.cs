<<<<<<< HEAD
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnostics : IDiagnostics
    {
        void IDiagnostics.SendDiagnostic(string name, string message, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
=======
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
    class DisabledDiagnostics : IDiagnostics
    {
        void IDiagnostics.SendDiagnostic(string name, string message, IDictionary<string, string> tags)
        {
            // Do nothing since it's disabled.
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
