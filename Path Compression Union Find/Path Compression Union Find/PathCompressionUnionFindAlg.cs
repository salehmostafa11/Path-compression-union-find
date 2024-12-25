using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Compression_Union_Find
{
    public class PathCompressionUnionFindAlg
    {

        private int siz; //The whole number of elements
        private int[] sz; //Size of each component
        private int[] id; //id[i] points to the parent of i (if id[i] = i then i is the root)
        private int numberOfComponents;

        public PathCompressionUnionFindAlg(int size)
        {
            if (size <= 0)
            {
                throw new Exception("Size <=0 not allowed");
            }
            this.siz = size;
            numberOfComponents = size;
            this.sz = new int[siz];
            this.id = new int[siz];
            for (int i = 0; i < size; i++)
            {
                sz[i] = 1; //each component initially include 1 element
                id[i] = i; //each element is the root of it self
            }
        }

        //Finds the component that p belongs to
        public int find(int p)
        {
            int root = p;
            while (root != id[root])
            {
                root = id[root];
        }

            while (p != root)
            {
                int next = id[p]; //making the upcoming element is the next
                id[p] = root; // making the root of p is the parent of the component (Path Compression Union Find)
                p = next; // Go to the next element
            }
            return root;
        }

        //Check if two elements belong to the same component by it's root
        public bool connected(int p, int q)
        {
            return find(p) == find(q);
        }

        public int componentSize(int p)
        {
            return sz[find(p)]; // returns the size of component using the aaray of sizes
        }

        // Number of elements in the whole union find set
        public int size()
        {
            return this.siz;
        }

        public int components()
        {
            return numberOfComponents;
        }

        public bool unify(int p, int q)
        {
            int root1 = find(p);
            int root2 = find(q);
            if (root1 == root2)
            {
                return false; //already the same component
            }

            // Merging two components based the large size
            if (sz[root1] < sz[root2])
            {
                sz[root2] += sz[root1];
                id[root1] = root2;
            }
            else
            {
                sz[root1] += sz[root2];
                id[root2] = root1;
            }

            //After changing the root we really need to decrease number of components by 1
            numberOfComponents--;
            return true;
        }
    }
}
