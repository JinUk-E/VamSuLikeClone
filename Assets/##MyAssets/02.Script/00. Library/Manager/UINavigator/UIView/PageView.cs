using UnityEngine;

public class PageView : UIView
{
    [SerializeField] private UIEffector effectorManager;
    public override void OnEnter()
    {
        Next(name);
        effectorManager.EffectStart(true);
    }

    public override void OnExit()
    {
        Back();
        effectorManager.EffectStart(false);
    }
}
