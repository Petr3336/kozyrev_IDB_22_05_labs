using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TreeNode;

namespace TreeNodeTest
{
    [TestClass]
    public class TreeNodeTest
    {
        [TestMethod]
        public void TestTreeNodeCreation()
        {
            int value = 5;
            TreeNodeClass node = new TreeNodeClass(value);

            Assert.IsNotNull(node.Children);
            Assert.AreEqual(value, node.Value);
        }

        [TestMethod]
        public void TestAddChild()
        {
            TreeNodeClass parent = new TreeNodeClass(1);
            TreeNodeClass child = new TreeNodeClass(2);

            parent.AddChild(child);

            Assert.IsTrue(parent.Children.Contains(child));
        }

        [TestMethod]
        public void TestPrintTree()
        {
            TreeNodeClass root = new TreeNodeClass(1);
            TreeNodeClass child1 = new TreeNodeClass(2);
            TreeNodeClass child2 = new TreeNodeClass(3);
            root.AddChild(child1);
            root.AddChild(child2);

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                root.PrintTree();

                var result = sw.ToString().Trim();
                Assert.AreEqual("1\r\n2\r\n3", result);
            }
        }
    }
}
