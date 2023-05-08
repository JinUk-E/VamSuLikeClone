using System.Collections;
using UnityEngine;

public abstract class UIView : MonoBehaviour,IView
{
    [SerializeField] private UIManager uiManager;
    private Stack _viewHistory = new();
    private void PushView(UIView view) => _viewHistory.Push(view);
    private void PopView() => _viewHistory.Pop();
    
    public UIView Next(string viewName)
    {
        var view = uiManager.GetView(viewName);
        if (view == null) return null;
        PushView(view);
        return view;    
    }

    public UIView Back()
    {
        if (_viewHistory.Count == 0) return null;
        var view = _viewHistory.Peek() as UIView;
        PopView();
        return view;
    }
    
    public abstract void OnEnter();
    public abstract void OnExit();
}
