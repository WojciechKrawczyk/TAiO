﻿namespace TAiO.Graphs
{
    public class Graph
    {
        public int Size { get; protected set; }
        public int[,] IncidenceMatrix { get; protected set; }

        public Graph(int[,] incidenceMatrix, int size)
        {
            IncidenceMatrix = incidenceMatrix;
            Size = size;
        }

        public virtual void Extend(int size)
        {
            if (Size >= size)
                return;
            var oldMatrix = IncidenceMatrix;
            IncidenceMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i < Size)
                        IncidenceMatrix[i, j] = oldMatrix[i, j];
                    else
                        IncidenceMatrix[i, j] = 0;
                }
            }
            Size = size;
        }

        public void SwapVertexes(int v1, int v2)
        {
            if (v1 == v2)
                return;
            //rows
            for (int i = 0; i < Size; i++)
            {
                var tmp = IncidenceMatrix[v1, i];
                IncidenceMatrix[v1, i] = IncidenceMatrix[v2, i];
                IncidenceMatrix[v2, i] = tmp;
            }
            //columns
            for (int i = 0; i < Size; i++)
            {
                var tmp = IncidenceMatrix[i, v1];
                IncidenceMatrix[i, v1] = IncidenceMatrix[i, v2];
                IncidenceMatrix[i, v2] = tmp;
            }
        }

        public virtual void UpdateMatrix(int[,] matrix)
        {
            IncidenceMatrix = matrix;
        }
    }
}
