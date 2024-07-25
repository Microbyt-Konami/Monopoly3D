using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AvenueController))]
public class AvenueControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (target is AvenueController avenueController)
        {
            if (GUILayout.Button("SetAvenue"))
                avenueController.SetAvenueCurrent();
        }
    }
}
