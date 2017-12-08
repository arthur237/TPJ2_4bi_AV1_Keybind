using UnityEditor;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

[CustomPropertyDrawer(typeof(TagAtributes))]
public class EdiKeys : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        base.OnGUI(position, property, label);
    }
}
