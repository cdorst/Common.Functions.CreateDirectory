using Common.Functions.ResolveRelativePath;
using System.IO;

namespace Common.Functions.CreateDirectory
{
    public static class DirectoryCreator
    {
        public static void Create(string path) => Directory.CreateDirectory(path);

        public static void CreateSubdirectories(string pathRelativeToCurrent)
            => Create(RelativePathResolver.GetPath(pathRelativeToCurrent));
    }
}
