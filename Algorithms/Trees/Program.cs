using System;
using System.Collections.Generic;

namespace Trees {
    class Node{
        public Node Left {get; set;}
        public Node Right {get; set;}
        public int Data {get; set;}
    }

    class BinarySearchTree {
        public static Node Insert(Node root, int value) {
            if (root == null){
                root = new Node();
                root.Data = value;
            } else {
                if (value < root.Data) {
                    //insert on left
                    root.Left = Insert(root.Left, value);
                } else if (value > root.Data) {
                    //insert on right
                    root.Right = Insert(root.Right, value);
                }
            }
            return root;
        }

        //Preorder traversal: explores roots before leaves
        public static void preOrderTraversal(Node root) {
            if (root == null) {
                return;
            }
            Console.Write(root.Data + " ");
            preOrderTraversal(root.Left);
            preOrderTraversal(root.Right);
            }

        //Postorder traversal: explores leaves before roots
        public static void postOrderTraversal(Node root) {
            if (root != null) {
                postOrderTraversal(root.Left);
                postOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        //Inorder traversal: explore data sequentially
        public static void inOrderTraversal (Node root) {
            if (root != null) {
                inOrderTraversal (root.Left);
                Console.Write(root.Data + " ");
                inOrderTraversal (root.Right);
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            Console.WriteLine("Inorder traversal:");
            BinarySearchTree.inOrderTraversal (rootNode);
           
            Console.WriteLine("Preorder traversal:");
            BinarySearchTree.preOrderTraversal(rootNode);
            
            Console.WriteLine("PostOrder traversal:");
            BinarySearchTree.postOrderTraversal(rootNode);
        }
    }
}


