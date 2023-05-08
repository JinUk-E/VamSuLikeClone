public class StartButton : ButtonPresenter
{
    protected override void OnClick() => SceneLoadManager.Instance.LoadScene("02.InGame");
}
