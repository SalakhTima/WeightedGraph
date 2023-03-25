namespace WeightedGraph
{
    internal class Node
    {
        public string Name { get; }
        public List<Edge> Edges { get; }

        public Node(string Name)
        {
            this.Name = Name; Edges = new List<Edge>();
        }
    }
}
