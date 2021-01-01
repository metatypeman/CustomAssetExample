using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[AddComponentMenu("SymOntoClay/MyScript")]//This attribute adds 'MyScript' to component menu. And also It removes '(Srtipt)' from title in object inspector.
public class MyScript : MonoBehaviour
{
    public SomeObject SomeObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[CustomEditor(typeof(MyScript))]
[CanEditMultipleObjects]
public class MyScriptEditor : Editor
{
    //protected override void OnHeaderGUI()
    //{

    //}

    //public override void OnInspectorGUI()
    //{
    //    GUILayout.BeginVertical();

    //    GUILayout.EndVertical();
    //}
}
