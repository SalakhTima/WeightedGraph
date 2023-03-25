namespace WeightedGraph
{
    internal class Edge
    {
        public Node StartingNode { get; }
        public Node EndingNode { get; }
        public uint Weight { get; }

        public Edge(Node StartingNode, Node EndingNode, uint Weight)
        {
            this.StartingNode = StartingNode; this.EndingNode = EndingNode; this.Weight = Weight;
        }
    }
}
