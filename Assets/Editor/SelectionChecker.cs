using UnityEngine;
using UnityEditor;

public class SelectionChecker : MonoBehaviour
{
    [MenuItem("Tools/Check Selected Objects")]
    private static void CheckSelected()
    {
        // 選択されているオブジェクトの数を取得
        int selectedCount = Selection.gameObjects.Length;
        Debug.Log("選択しているオブジェクト数: " + selectedCount);
    }
}