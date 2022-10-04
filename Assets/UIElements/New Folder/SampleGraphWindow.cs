using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

public class SampleGraphWindow : EditorWindow
{
    // �q��GraphView
    private SampleGraphView _graph;

    // Unity��̃��j���[��Sample��Open Window�Ƃ������ڂ�ǉ����ĊJ��
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
        // �q�̗v�f�̒ǉ��A�m�[�h��z�u����y��ƂȂ�GraphView��z�u����
        rootVisualElement.Add(_graph);
    }
}
