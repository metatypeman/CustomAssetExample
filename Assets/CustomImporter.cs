using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
#endif
using UnityEngine;

namespace Assets
{
    //public class MyComponent: Component
    //{
    //    public string Path { get; set; }
    //}

#if UNITY_EDITOR
    [ScriptedImporter(0, ".npc")]
    public class CustomImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            //Debug.Log($"OnImportAsset ctx.assetPath = {ctx.assetPath}");

            GameObject root = ObjectFactory.CreateGameObject(Path.GetFileNameWithoutExtension(ctx.assetPath));
            var myComponent = root.AddComponent<MyComponent>();
            myComponent.Path = ctx.assetPath;
            ctx.AddObjectToAsset("main", root);
            ctx.SetMainObject(root);
        }
    }
#endif
}
