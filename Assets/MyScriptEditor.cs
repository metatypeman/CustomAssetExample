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
        private MyScript _target;

        private void OnEnable()
        {
            _target = (MyScript)target;
        }

        //protected override void OnHeaderGUI()
        //{

        //}

        public override void OnInspectorGUI()
        {
            GUILayout.BeginVertical();
            _target.SomeObject = (SomeObject)EditorGUILayout.ObjectField("SomeObject", _target.SomeObject, typeof(SomeObject), false);
            _target.App = (GameObject)EditorGUILayout.ObjectField("App", _target.App, typeof(GameObject), false);
            GUILayout.EndVertical();
        }
    }
#endif
}
