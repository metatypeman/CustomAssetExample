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
#if UNITY_EDITOR
    [CustomEditor(typeof(CustomImporter))]
    [CanEditMultipleObjects]
    public class CustomImporterEditor : ScriptedImporterEditor
    {
        //Let the parent class know that the Apply/Revert mechanism is skipped.
        protected override bool needsApplyRevert => false;

        public override void OnInspectorGUI()
        {
            // Draw some information
            EditorGUILayout.HelpBox("Because this Importer doesn't have any settings, the Apply/Revert buttons are hidden.", MessageType.None);
        }
    }

    [ScriptedImporter(0, ".npc")]
    public class CustomImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            //Debug.Log($"OnImportAsset ctx.assetPath = {ctx.assetPath}");

            GameObject root = ObjectFactory.CreateGameObject(Path.GetFileNameWithoutExtension(ctx.assetPath));
            ctx.AddObjectToAsset("main", root);
            ctx.SetMainObject(root);
        }
    }
#endif
}
