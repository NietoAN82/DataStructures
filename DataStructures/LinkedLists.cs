using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Doubly linked list implementation commented out
    /*public class LinkedLists
    {
        static LinkedList<string> linkedList = new LinkedList<string>();
        public static void Main(string[] args)
        {
            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("last element");

            //Gives us the number of nodes contained in the LinkedList
            System.Diagnostics.Debug.WriteLine(linkedList.Count);

            //Get the first and last value respectibely of the linked list.
            System.Diagnostics.Debug.WriteLine(linkedList.First.Value);
            System.Diagnostics.Debug.WriteLine(linkedList.Last.Value);

            //Can use Contains() method to see if a value exists or not
            if(linkedList.Contains("last element")) { }

            //Find first node that contains specified value
            LinkedListNode<string> LinkedListNode = linkedList.Find("root");

            //Find last node that contains specified value
            LinkedListNode<string> Node2 = linkedList.FindLast("root");

            //Remove elements from linked list
            linkedList.Remove(Node2); //remove node
            linkedList.Remove("root");//remove value
            linkedList.RemoveFirst();//remove first
            linkedList.RemoveLast();//remove last
            linkedList.Clear();//clear linked list

        }
    }*/
    //Single linked list implementation commented out.
    /*public class LinkedLists
    {
        //Single linked list implementation commented out.
        public class LinkedList
        {
            public class Node
            {
                public Node next;
                public object data;
            }

            private Node root;

            public Node First {  get { return root;} }

            public Node Last
            {
                get
                {
                    Node currentNode = root;
                    if(currentNode == null)
                    {
                        return null;
                    }

                    while(currentNode.next != null)
                    {
                        currentNode = currentNode.next
                    }

                    return currentNode;
                }
            }

            /// <summary>
            /// Function that adds a value to the end of the linked list.
            /// </summary>
            /// <param name="value"></param>
            public void Append(object value)
            {
                Node node = new Node { data = value };
                if(root == null)
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }

            /// <summary>
            /// Remove a node in the linked list
            /// </summary>
            /// <param name="node"></param>
            public void Delete(Node node)
            {
                if(root == node)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while(current.next != null)
                    {
                        if(current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
        }
                                    
    }*/
    
}
