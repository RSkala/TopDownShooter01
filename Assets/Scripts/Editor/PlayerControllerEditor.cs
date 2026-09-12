using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerController))]
public class PlayerControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        // Draw the default Inspector fields first (Note the base calls this function as well)
        DrawDefaultInspector();

        PlayerController playerController = target as PlayerController;

        // Everything inside this block becomes grayed out and read-only
        using (new EditorGUI.DisabledGroupScope(true))
        {
            EditorGUILayout.Vector2Field("Move Input", playerController.MoveInput);
        }
    }
}
