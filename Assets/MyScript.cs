using Assets;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[AddComponentMenu("SymOntoClay/MyScript")]//This attribute adds 'MyScript' to component menu. And also It removes '(Srtipt)' from title in object inspector.
public class MyScript : MonoBehaviour
{
#if UNITY_EDITOR
    public SomeObject SomeObject;
#endif
    public GameObject App;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(MyScript))]
[CanEditMultipleObjects]
public class MyScriptEditor : Editor
{
    //protected override void OnHeaderGUI()
    //{

    //}

    //public override void OnInspectorGUI()
    //{
    //    var myTarget = (MyScript)target;

    //    GUILayout.BeginVertical();

        

    //    GUILayout.EndVertical();
    //}
}
#endif
