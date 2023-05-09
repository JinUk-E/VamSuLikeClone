public interface IContainer
{
    // this interface is management container history and container stack
    UIContainer Next(string containerName);
    UIContainer Back();
}
