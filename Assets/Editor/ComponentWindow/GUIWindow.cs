using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIHandleWindow : ComponentWindow<GUIHandle>
{
    //���t���N�V����
    [MenuItem("Editor/GUIHandleWindow")]
    private static void Create()
    {
        GUIHandleWindow window = GetWindow<GUIHandleWindow>("GUIHandleWindow");
    }
}
