using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class OpenFolderTool
{
    [MenuItem("Assets/OpenFolder %q")]
    static void DoSomething()
    {
        
        Object[] objs = Selection.GetFiltered<Object>(SelectionMode.Assets);
        if (objs.Length != 1) return;
        string path = AssetDatabase.GetAssetPath(objs[0]);
        Debug.Log($"{path}");
        if (AssetDatabase.IsValidFolder(path))
        {
            ShowExplorer(path);
        }
        else
        {
            EditorUtility.RevealInFinder(path);
        }
    }

    static void ShowExplorer(string itemPath)
    {
        itemPath = itemPath.Replace(@"/", @"\");   // explorer doesn't like front slashes
        System.Diagnostics.Process.Start("explorer.exe",  itemPath);
    }
}
