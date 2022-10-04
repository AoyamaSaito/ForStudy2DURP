using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

public class SampleGraphWindow : EditorWindow
{
    // 子のGraphView
    private SampleGraphView _graph;

    // Unity上のメニューにSample→Open Windowという項目を追加して開く
    [MenuItem("Sample/Open Window")]
    public static void Open()
    {
        GetWindow<SampleGraphWindow>(ObjectNames.NicifyVariableName(nameof(SampleGraphWindow)));
    }

    private void OnEnable()
    {
        CreateGraphView();
    }

    private void CreateGraphView()
    {
        _graph = new SampleGraphView(this);
        // 子の要素の追加、ノードを配置する土台となるGraphViewを配置する
        rootVisualElement.Add(_graph);
    }
}
