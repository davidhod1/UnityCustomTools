using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace customtools
{
    public static class FolderCreator
    {
        [MenuItem("Custom tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Dir("_Project", "Scripts", "Art", "Scenes", "Audio", "Prefabs");
            Refresh();
        }

        public static void Dir(string root, params string[] dir)
        {
            var fullpath = Combine(dataPath, root);
            foreach (var newDirectory in dir)
                CreateDirectory(Combine(fullpath, newDirectory));
        }
    }
}
