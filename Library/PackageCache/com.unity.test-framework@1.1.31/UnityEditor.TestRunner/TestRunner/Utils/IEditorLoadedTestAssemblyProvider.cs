<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
=======
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
>>>>>>> d6a5058d (added player animation with movement)
}