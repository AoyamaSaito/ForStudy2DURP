using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonTest : MonoBehaviour
{
    [SerializeField]
    private UIDocument _uiDocument;
    [SerializeField]
    private string _text = "";

    private int _power = 0;

    private void Start()
    {
        var label = _uiDocument.rootVisualElement.Q<Label>();
        var button = _uiDocument.rootVisualElement.Q<Button>();
        button.clicked += () =>
        {
            label.text = $"{_power++}";
        };
    }
}
