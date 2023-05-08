public class PageView : UIView
{
    public override void OnEnter() => Next(name);
    public override void OnExit() => Back();
}
