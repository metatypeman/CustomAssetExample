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
    public SomeObject SomeObject;
    public GameObject App;

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        Debug.Log($"Application.dataPath = {Application.dataPath}");

        Debug.Log($"SomeObject == null = {SomeObject == null}");
        Debug.Log($"SomeObject?.FullName = {SomeObject?.FullName}");
        Debug.Log($"Path = {App?.GetComponent<MyComponent>()?.Path}");
        Debug.Log($"App?.name = {App?.name}");
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
