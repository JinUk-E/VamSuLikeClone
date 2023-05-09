using System.Collections;
using UnityEngine;

public class UIContainer : MonoBehaviour, IContainer
{
    [SerializeField] private UIManager uiManager;
    private Stack _containerHistory = new Stack();
    private void PushContainer(UIContainer container) => _containerHistory.Push(container);
    private void PopContainer() => _containerHistory.Pop();
    
    public UIContainer Next(string containerName)
    {
        var container = uiManager.GetContainer(containerName);
        if (container == null) return null;
        PushContainer(container);
        return container;
    }

    public UIContainer Back()
    {
        if (_containerHistory.Count == 0) return null;
        var container = _containerHistory.Peek() as UIContainer;
        PopContainer();
        return container;
    }
}
