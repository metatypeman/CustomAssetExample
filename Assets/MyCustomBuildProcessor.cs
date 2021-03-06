﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
#endif
using UnityEngine;

namespace Assets
{
#if UNITY_EDITOR
    public class MyCustomBuildProcessor : IPostprocessBuildWithReport
    {
        public int callbackOrder => 0;

        /// <summary>
        /// This method is called after build (publish) game and before finish.
        /// You can write your code for copying target files here.
        /// </summary>
        /// <param name="report"></param>
        public void OnPostprocessBuild(BuildReport report)
        {
            Debug.Log($"report.summary.outputPath = {report.summary.outputPath}");
            Debug.Log($"Application.dataPath = {Application.dataPath}");
        }
    }
#endif
}
