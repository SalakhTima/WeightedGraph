namespace WeightedGraph
{
    class Program
    {
        static void Main()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");

            Edge AB = new Edge(nodeA, nodeB, 10);
            Edge AC = new Edge(nodeA, nodeC, 20);
            Edge BC = new Edge(nodeB, nodeC, 30);

            nodeA.Edges.Add(AB);
            nodeA.Edges.Add(AC);
            nodeB.Edges.Add(BC);

            //foreach ()
            //{
                
            //}
        }
    }
}

