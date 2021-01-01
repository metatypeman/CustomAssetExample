using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

namespace Assets
{
    //[CustomEditor(typeof(BooleanImporter))]
    //[CanEditMultipleObjects]
    //public class BooleanImporterEditor : ScriptedImporterEditor
    //{
    //    Property to show in the custom OnInspectorGUI.
    //   SerializedProperty m_BooleanProperty;

    //    override extraDataType to return the type that will be used in the Editor.
    //    protected override Type extraDataType => typeof(BooleanClass);

    //    override InitializeExtraDataInstance to set up the data.
    //    protected override void InitializeExtraDataInstance(UnityEngine.Object extraTarget, int targetIndex)
    //    {
    //        var boolean = (BooleanClass)extraTarget;
    //        // Read the boolean value from the text file and fill the extraTarget object with the data.
    //        string fileContent = File.ReadAllText(((AssetImporter)targets[targetIndex]).assetPath);
    //        if (!bool.TryParse(fileContent, out boolean.boolean))
    //        {
    //            boolean.boolean = false;
    //        }
    //    }

    //    protected override void Apply()
    //    {
    //        base.Apply();
    //        // After the Importer is applied, rewrite the file with the custom value.
    //        for (int i = 0; i < targets.Length; i++)
    //        {
    //            string path = ((AssetImporter)targets[i]).assetPath;
    //            File.WriteAllText(path, ((BooleanClass)extraDataTargets[i]).boolean.ToString());
    //        }
    //    }

    //    public override void OnEnable()
    //    {
    //        base.OnEnable();
    //        In OnEnable, retrieve the importerUserSerializedObject property and store it.
    //        m_BooleanProperty = extraDataSerializedObject.FindProperty("boolean");
    //    }

    //    protected override bool needsApplyRevert => false;

    //    public override void OnInspectorGUI()
    //    {
    //        Note: you don't need to call serializedObject.Update or serializedObject.ApplyModifiedProperties
    //         because you are not changing the target(serializedObject) itself.

    //         Update the importerUserSerializedObject in case it has been changed outside the Inspector.
    //        extraDataSerializedObject.Update();

    //        Draw the boolean property.
    //        EditorGUILayout.PropertyField(m_BooleanProperty);

    //        Apply the changes so Undo / Redo is working.
    //       extraDataSerializedObject.ApplyModifiedProperties();

    //        Call ApplyRevertGUI to show Apply and Revert buttons.
    //        ApplyRevertGUI();
    //    }
    //}

    //public class BooleanClass : ScriptableObject//TextAsset//UnityEngine.Object
    //{
    //    public bool boolean;
    //}

    //[ScriptedImporter(0, ".boolean")]
    //public class BooleanImporter : ScriptedImporter
    //{
    //    public override void OnImportAsset(AssetImportContext ctx)
    //    {
    //        string fileContent = File.ReadAllText(ctx.assetPath);
    //        var booleanObj = ObjectFactory.CreateInstance<BooleanClass>();
    //        if (!bool.TryParse(fileContent, out booleanObj.boolean))
    //        {
    //            booleanObj.boolean = false;
    //        }
    //        ctx.AddObjectToAsset("main", booleanObj);
    //        ctx.SetMainObject(booleanObj);
    //        Debug.Log("Imported Boolean value: " + booleanObj.boolean);
    //    }
    //}
}
