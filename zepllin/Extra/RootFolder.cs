using System.IO;

namespace zepllin.Extra
{
    public static class RootFolder
    {
        public static string RootFolderName = $@"C:{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}";

        public static string RootFolderWithSubFolder = $@"C:{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}Images";

        public static string RootFolderWithSubFolderAndSlash = $@"C:{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}Images{Path.DirectorySeparatorChar}";
    }
}
