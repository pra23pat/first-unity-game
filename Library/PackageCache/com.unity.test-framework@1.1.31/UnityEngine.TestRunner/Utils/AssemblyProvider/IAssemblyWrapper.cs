<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
>>>>>>> d6a5058d (added player animation with movement)
