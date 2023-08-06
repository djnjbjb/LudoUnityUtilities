using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class OpenFolderTool_HalfDown

{
    [OnOpenAsset(0)]
    public static bool OnOpenAsset(int instanceId)
    {
        Object obj = EditorUtility.InstanceIDToObject(instanceId);
        string path = AssetDatabase.GetAssetPath(obj);
        //Debug.Log($"OnOpenAsset {path}"); return false;
        /*
        Event e = Event.current;
        if (e == null || !e.shift) return false;
        Object obj = EditorUtility.InstanceIDToObject(instanceId);
        string path = AssetDatabase.GetAssetPath(obj);
        if (AssetDatabase.IsValidFolder(path))
        {
            EditorUtility.RevealInFinder(path);
        }
        return true;
        */
    }
}
