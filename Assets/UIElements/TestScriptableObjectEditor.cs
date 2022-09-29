using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(TestScriptableObject))]
public class TestScriptableObjectEditor : Editor
{
    // UI Toolkit のカスタムエディタは CreateInspectorGUI をオーバーライドし、
    // VisualElementを戻り値として渡すことで表示を変更できます
    public override VisualElement CreateInspectorGUI()
    {
        var treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UIElements/Test.uxml");
        var container = treeAsset.Instantiate();
        return container;
    }
}