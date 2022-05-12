<<<<<<< HEAD
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
=======
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
>>>>>>> d6a5058d (added player animation with movement)
}