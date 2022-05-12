<<<<<<< HEAD
using System.Collections.Generic;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Internal
{
    interface IComponentRegistry
    {
        void RegisterServiceComponent<TComponent>(
            [NotNull] TComponent component)
            where TComponent : IServiceComponent;

        TComponent GetServiceComponent<TComponent>()
            where TComponent : IServiceComponent;

        void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
    }
}
=======
using System.Collections.Generic;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Internal
{
    interface IComponentRegistry
    {
        void RegisterServiceComponent<TComponent>(
            [NotNull] TComponent component)
            where TComponent : IServiceComponent;

        TComponent GetServiceComponent<TComponent>()
            where TComponent : IServiceComponent;

        void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
    }
}
>>>>>>> d6a5058d (added player animation with movement)
