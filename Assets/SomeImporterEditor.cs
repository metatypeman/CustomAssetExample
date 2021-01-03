using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
#endif

namespace Assets
{
#if UNITY_EDITOR
    [CustomEditor(typeof(SomeScriptedImporter))]
    [CanEditMultipleObjects]
    public class SomeImporterEditor : ScriptedImporterEditor
    {
        protected override bool needsApplyRevert => false;
        //public override bool showImportedObject => false;

        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("Hi", EditorStyles.boldLabel);
        }
    }
#endif
}
