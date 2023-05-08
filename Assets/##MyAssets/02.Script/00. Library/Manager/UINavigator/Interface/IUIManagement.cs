public interface IUIManagement
{
    UIContainer GetContainer(string containerName);
    UIView GetView(string viewName);
    void AddContainer(UIContainer container);
    void AddView(UIView view);
    void RemoveContainer(string containerName);
    void RemoveView(string viewName);
    void RemoveAllContainers();
    void RemoveAllViews();
    void RemoveAll();
    bool CheckView(string viewName);
}
