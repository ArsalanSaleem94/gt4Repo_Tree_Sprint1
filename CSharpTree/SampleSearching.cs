using System;

namespace CSharpTree
{
    class SampleSearching
    {
        static void Main(string[] args)
        {
            TreeNode<string> treeRoot = SampleData.GetSet1();
            TreeNode<string> found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("210"));

            //Console.WriteLine("Found: " + found.Data);

            //var x = treeRoot.RemoveNode(found);
            //if (x.Item1)
            //{
            //    Console.WriteLine(x.Item2);
            //}
            //else
            //{
            //    Console.WriteLine("Not Removed");
            //}
            //found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("210"));
            //Console.WriteLine("Found: " + found);






            //treeRoot = SampleData.GetSet1();
            //found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("210"));
            //Console.WriteLine("Found: " + found);


            Console.WriteLine("Before Removing");



            found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("node2"));
            Console.WriteLine("Found: " + found.Data);
            foreach (var foundChild in found.Children)
            {
                Console.WriteLine(foundChild);
            }

            found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("node21"));
            Console.WriteLine($"Removing {found.Data} ");

            var x = treeRoot.RemoveNode(found);
            Console.WriteLine("After Removing");
            if(x.Item1)
                Console.WriteLine(x.Item2);
            found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("node2"));
            Console.WriteLine("Found: " + found.Data);
            foreach (var foundChild in found.Children)
            {
                Console.WriteLine(foundChild);
            }

            Console.ReadLine();
        }
    }
}
