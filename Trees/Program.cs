namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            PreOrderTraversal t = new PreOrderTraversal();
            t.BuildTree();
            t.Traverse();
        }
    }
}
