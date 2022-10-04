using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SampleGraphView : GraphView
{
    public SampleGraphView(EditorWindow editorWindow)
    {
        AddElement(new ValueNode());

        this.StretchToParentSize();

        SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());

        // �E�N���b�N���j���[��ǉ�
        var menuWindowProvider = ScriptableObject.CreateInstance<SearchMenuWindowProvider>();
        menuWindowProvider.Initialize(this, editorWindow);
        nodeCreationRequest += context =>
        {
            SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), menuWindowProvider);
        };
    }

    // GetCompatiblePorts���I�[�o�[���C�h����
    public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
    {
        var compatiblePorts = new List<Port>();

        compatiblePorts.AddRange(ports.ToList().Where(port =>
        {
            // �����m�[�h�ɂ͌q���Ȃ�
            if (startPort.node == port.node)
                return false;

            // Input���m�AOutput���m�͌q���Ȃ�
            if (port.direction == startPort.direction)
                return false;

            // �|�[�g�̌^����v���Ă��Ȃ��ꍇ�͌q���Ȃ�
            if (port.portType != startPort.portType)
                return false;

            return true;
        }));

        return compatiblePorts;
    }
}