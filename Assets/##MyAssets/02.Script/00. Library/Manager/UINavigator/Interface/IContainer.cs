public interface IContainer
{
    // this interface is management container history and container stack
    UIContainer GetCurrentContainer();
    UIContainer Next(string containerName);
    UIContainer Back();
}
