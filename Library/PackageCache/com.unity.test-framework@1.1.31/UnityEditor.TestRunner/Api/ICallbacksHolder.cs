<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
=======
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
>>>>>>> d6a5058d (added player animation with movement)
}