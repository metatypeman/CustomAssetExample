using System.IO;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
#endif
using UnityEngine;

namespace Assets
{
#if UNITY_EDITOR
    [ScriptedImporter(0, ".someFile", AutoSelect = true)]
    public class SomeScriptedImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            //Debug.Log($"OnImportAsset ctx.assetPath = {ctx.assetPath}");

            var obj = ObjectFactory.CreateInstance<SomeObject>();
            obj.name = Path.GetFileNameWithoutExtension(ctx.assetPath);
            obj.FullName = ctx.assetPath;
            ctx.AddObjectToAsset("main", obj);
            ctx.SetMainObject(obj);
        }
    }
#endif
}
