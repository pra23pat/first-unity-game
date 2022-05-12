<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
