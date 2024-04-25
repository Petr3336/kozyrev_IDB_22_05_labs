using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;



namespace TreeNode
{
    public class TreeNodeClass
    {
        public int Value { get; set; }
        public List<TreeNodeClass> Children { get; set; }

        public TreeNodeClass(int value)
        {
            Value = value;
            Children = new List<TreeNodeClass>();
        }

        public void AddChild(TreeNodeClass child)
        {
            Children.Add(child);
        }

        public void PrintTree()
        {
            Console.WriteLine(Value);
            foreach (var child in Children)
            {
                child.PrintTree();
            }
        }
    }
}
