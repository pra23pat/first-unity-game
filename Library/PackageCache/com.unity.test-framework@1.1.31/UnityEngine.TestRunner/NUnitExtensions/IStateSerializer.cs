<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
=======
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
>>>>>>> d6a5058d (added player animation with movement)
