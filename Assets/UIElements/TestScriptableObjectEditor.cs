using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(TestScriptableObject))]
public class TestScriptableObjectEditor : Editor
{
    // UI Toolkit �̃J�X�^���G�f�B�^�� CreateInspectorGUI ���I�[�o�[���C�h���A
    // VisualElement��߂�l�Ƃ��ēn�����Ƃŕ\����ύX�ł��܂�
    public override VisualElement CreateInspectorGUI()
    {
        var treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UIElements/Test.uxml");
        var container = treeAsset.Instantiate();
        return container;
    }
}