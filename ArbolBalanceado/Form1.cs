using System;
using System.Windows.Forms;

namespace ArbolBalanceado
{
    public partial class Form1 : Form
    {
        private class TreeNode
        {
            public int data;
            public TreeNode left, right;

            public TreeNode(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        private class BalancedTree
        {
            private TreeNode root;

            // Función para insertar un nuevo nodo en el árbol balanceado
            private TreeNode Insert(TreeNode node, int data)
            {
                if (node == null)
                    return new TreeNode(data);

                if (data < node.data)
                    node.left = Insert(node.left, data);
                else if (data > node.data)
                    node.right = Insert(node.right, data);

                return node;
            }

            // Función para recorrer el árbol en orden
            private void InorderTraversal(TreeNode node, ListBox listBox)
            {
                if (node != null)
                {
                    InorderTraversal(node.left, listBox);
                    listBox.Items.Add(node.data);
                    InorderTraversal(node.right, listBox);
                }
            }

            // Método público para insertar un nuevo nodo en el árbol balanceado
            public void Insert(int data)
            {
                root = Insert(root, data);
            }

            // Método público para recorrer el árbol en orden
            public void Traverse(ListBox listBox)
            {
                listBox.Items.Clear();
                InorderTraversal(root, listBox);
            }
        }

        private BalancedTree tree;

        public Form1()
        {
            InitializeComponent();
            tree = new BalancedTree();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxValue.Text, out int value))
            {
                tree.Insert(value);
                tree.Traverse(listBoxTraversal);
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
