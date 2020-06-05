using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic1
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedNodes<double> ln = new LinkedNodes<double>();


            ln.AddNodes(8);
            ln.AddNodes(11.2);
            ln.AddNodes(12.4);
            ln.AddNodes(19);

            ln.RemoveNodes(11.2);

            ln.NodesSize();

            ln.PrintNodes();

            
           



            Console.ReadKey();
        }
    }

    public class LinkedNodes<Gen> where Gen : struct
    {
        private Node _first = null;


     
        public Node Firstitem
        {
            get 
            { 
                return _first;
            }
        }


        

        public class Node
        {
            public Node next = null;
            public Gen data;
        }

        public bool Exists()
        {
            return _first != null;
        }

        public void AddNodes(Gen value)
        {
            Node newNode = new Node() { data = value };

            if (_first == null)
            {
                _first = newNode;
            }

            else
            {
                Node current = _first;
                while (current.next != null)
                {
                    
                    current = current.next;

                }

                current.next = newNode;
                
            }

            
        }

        public void RemoveNodes(Gen data)
        {
            if (_first != null && Object.Equals(_first.data, data))
            {
                Node node = _first;
                _first = node.next;
                node.next = null;
            }

            else
            {
                Node current = _first;
                while(current.next != null)
                {
                    if(Object.Equals(current.next.data, data))
                    {
                        Node node = current.next;
                        current.next = node.next;
                        node.next = null;
                        break;
                    }

                }
            }
        }


        public void PrintNodes()
        {

            Node current = _first;
            while(current != null)
            {
                
                Console.WriteLine(current.data);
                current = current.next;
        
            }
        }


        public void NodesSize()
        {
            LinkedNodes<double> ln = new LinkedNodes<double>();
            int i = 0;
            Node current = _first;
            while (current != null)
            {
                current = current.next;
                i = i + 1;
                if (current == null)
                {
                   
                    Console.WriteLine("Node count: " + i);

                    ln.AddNodes(i);
                    
                }
                
            }

            
        }
    }
}
