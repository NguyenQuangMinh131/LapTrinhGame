using UnityEditor;
using UnityEngine;

public static class ToggleActiveShortcut
{
    // Ctrl + E (Windows) hoặc Cmd + E (Mac)
    [MenuItem("Tools/Toggle Active %e")]
    private static void ToggleActive()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Undo.RecordObject(obj, "Toggle Active");
            obj.SetActive(!obj.activeSelf);
            EditorUtility.SetDirty(obj);
        }
    }
}
