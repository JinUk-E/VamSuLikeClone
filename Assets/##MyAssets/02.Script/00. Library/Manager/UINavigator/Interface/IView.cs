public interface IView
{
    // this interface is management view
    UIView Next(string viewName);
    UIView Back();
}
