using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Mover))]
public class MoverEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("click here"))
        {
            //  Debug.Log("clickeado");
            var castedTarget = target as Mover;
            castedTarget.Move();
        }
    }
}
