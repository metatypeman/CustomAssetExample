using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
#endif

namespace Assets
{
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
}
