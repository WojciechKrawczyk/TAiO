using System;
using System.Collections.Generic;
using TAiO.Graphs;

namespace TAiO
{
    public class ProblemRepresentation
    {
        public GraphWithRepresentation Graph1 { get; private set; }
        public GraphWithRepresentation Graph2 { get; private set; }
        public int Size { get; private set; }
        public int InitialCost { get; private set; }
        public bool IsSmall { get; private set; }
        private const int _sizeThreshold = 10;
        private readonly string _smaller = string.Empty;
        private readonly string _bigger = string.Empty;

        public ProblemRepresentation(GraphWithRepresentation graph1, GraphWithRepresentation graph2)
        {
            InitialCost = Math.Abs(graph1.Size - graph2.Size);
            if (graph1.Size >= graph2.Size)
            {
                Graph1 = graph1;
                Graph2 = graph2;
                if(graph1.Size != graph2.Size)
                {
                    _bigger = "1";
                    _smaller = "2";
                    Graph2.Extend(Graph1.Size);
                }
            }
            else
            {
                Graph1 = graph2;
                Graph2 = graph1;
                _bigger = "2";
                _smaller = "1";
                Graph1.Extend(Graph2.Size);
            }
            Size = Graph1.Size;
            IsSmall = Graph1.Size <= _sizeThreshold & Graph2.Size <= _sizeThreshold ? true : false;
        }

        public string[] GetComments()
        {
            var comentEnds = new string[] { "izolowany wierzchołek", "izolowane wierzchołki", "izolowanych wierzchołków" };

            var comments = new List<string>();
            if (InitialCost == 0)
                comments.Add("Wejściowe grafy mają taki sam rozmiar.");
            else
            {
                comments.Add($"Graf {_smaller} miał mniej wierzchołków niż graf {_bigger}.");
                var commentEnd = InitialCost == 1
                    ? comentEnds[0]
                    : InitialCost % 10 == 2 || InitialCost % 10 == 3 || InitialCost % 10 == 4
                        ? comentEnds[1]
                        : comentEnds[2];
                comments.Add($"Graf {_smaller} został rozszerzony o {InitialCost} {commentEnd}.");
            }

            return comments.ToArray();
        }
    }
}