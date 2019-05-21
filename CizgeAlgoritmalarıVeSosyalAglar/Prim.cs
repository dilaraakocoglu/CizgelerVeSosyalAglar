using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizgeAlgoritmalarıVeSosyalAglar
{
    public class Prim
    {
        public int MinKey(int[] key, bool[] set, int verticesCount)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public string Print(int[] parent, int[,] graph, int verticesCount)
        { 
            
            string cikti = " ";

            for (int i = 1; i < verticesCount; ++i)
                   cikti+= (parent[i] + 1).ToString() + " " + "-" +" "+ " " + (i + 1).ToString() + " " + " " + " " + " " + graph[i, parent[i]].ToString() + Environment.NewLine;

            return cikti;
        }

        public string Prim1 (int[,] graph, int verticesCount)
        {
            int[] parent = new int[verticesCount];
            int[] key = new int[verticesCount];
            bool[] mstSet = new bool[verticesCount];
            string cikti3 = " ";


            for (int i = 0; i < verticesCount; ++i)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinKey(key, mstSet, verticesCount);
                mstSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (Convert.ToBoolean(graph[u, v]) && mstSet[v] == false && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }

            cikti3 = Print(parent, graph, verticesCount); // string türünde fonksiyon olacak. print bir stringe atanacak ve return olarak o string döndürülecek form da öyle çağrılacak.

            return cikti3;
            
        }
    }
}
