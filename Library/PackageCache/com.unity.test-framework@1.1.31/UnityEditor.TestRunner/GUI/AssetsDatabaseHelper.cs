<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
>>>>>>> d6a5058d (added player animation with movement)
