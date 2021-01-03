using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

//public class CustomAssetPreprocessor : AssetPostprocessor
//{
//    //[InitializeOnLoadMethod]
//    //static void InitPresetDependencies()
//    //{
//    //    var allAssetPaths = AssetDatabase.GetAllAssetPaths();

//    //    foreach(var path in allAssetPaths)
//    //    {
//    //        if(path.EndsWith(".someFile"))
//    //        {
//    //            AssetDatabase.LoadAssetAtPath(path, typeof(Object));
//    //        }
//    //    }
//    //}

//    //void OnPreprocessAsset()
//    //{
//    //    Debug.Log($"OnPreprocessAsset assetPath = {assetPath}");

//    //    //var obj = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Object));

//    //    //Debug.Log($"OnPreprocessAsset: {obj?.GetType()?.FullName}");

//    //    if(assetPath.EndsWith(".npc"))
//    //    {
//    //        var text = new TextAsset();

//    //        context.AddObjectToAsset(assetPath, text);
//    //        context.SetMainObject(text);

//    //        //AssetDatabase.CreateAsset(text, assetPath);
//    //    }
//    //}

//    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
//    {
//        foreach (string str in importedAssets)
//        {
//            Debug.Log($"Reimported Asset: {str}");

//            var obj = AssetDatabase.LoadAssetAtPath(str, typeof(Object));

//            Debug.Log($"Reimported Asset: {obj?.GetType()?.FullName}");
//        }
//        foreach (string str in deletedAssets)
//        {
//            Debug.Log("Deleted Asset: " + str);
//        }

//        for (int i = 0; i < movedAssets.Length; i++)
//        {
//            Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
//        }
//    }
//}
