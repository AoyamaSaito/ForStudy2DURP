using UnityEditor.Experimental.GraphView;

public class ExampleNode : Node
{
    public ExampleNode()
    {
        title = "Example";

        // ���͗p�̃|�[�g���쐬
        var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(float)); // ��O������Port.Capacity.Multiple�ɂ���ƕ����̃|�[�g�ւ̐ڑ����\�ɂȂ�
        inputPort.portName = "Input";
        inputContainer.Add(inputPort); // ���͗p�|�[�g��inputContainer�ɒǉ�����

        // �o�͗p�̃|�[�g�����
        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(float));
        outputPort.portName = "Value";
        outputContainer.Add(outputPort); // �o�͗p�|�[�g��outputContainer�ɒǉ�����
    }
}