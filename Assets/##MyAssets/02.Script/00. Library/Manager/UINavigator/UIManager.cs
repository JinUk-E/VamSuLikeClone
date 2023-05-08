using System.Collections.Generic;

public class UIManager : AtGameSingleton<UIManager>, IUIManagement
{
    // dictionary for container management
    private Dictionary<string, UIContainer> _containers = new();
    // dictionary for view management
    private Dictionary<string, UIView> _views = new();
    
    // get container
    public UIContainer GetContainer(string containerName) => _containers.TryGetValue(containerName, out var container) ? container : null;

    public UIView GetView(string viewName) => _views.TryGetValue(viewName, out var view) ? view : null;

    public void AddContainer(UIContainer container)
    {
        if(_containers.ContainsKey(container.name)) return;
        _containers.Add(container.name, container);
    }
    public void AddView(UIView view)
    {
        if(_views.ContainsKey(view.name)) return;
        _views.Add(view.name, view);
    }

    public void RemoveContainer(string containerName)
    {
        if (_containers.ContainsKey(containerName)) _containers.Remove(containerName);
    }

    public void RemoveView(string viewName)
    {
        if (_views.ContainsKey(viewName)) _views.Remove(viewName);
    }
    
    public void RemoveAllContainers() => _containers.Clear();
    public void RemoveAllViews() => _views.Clear();
    public void RemoveAll()
    {
        RemoveAllContainers();
        RemoveAllViews();
    }

    public bool CheckView(string viewName) => _views.ContainsKey(viewName);
}
