using System;
using System.Collections.Generic;
using System.Text;

namespace prac2
{
    class SingleLinkedList
    {
        private Node first;

        public int First
        {
            get { return first.Info; }
        }
        public SingleLinkedList()
        {
            first = null;
        }

        public void Create(int data)
        {
            Node p = new Node(data);
            first = p;
        }
        public void Create(int[] data)
        {
            if (first != null) first = null;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                Node p = new Node(data[i]);
                if (first == null)
                {
                    first = p;
                }
                else
                {
                    p.Link = first;
                    first = p;
                }
            }
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                p.Link = first;
                first = p;
            }
        }
        public void InsertBeforeFirst(int[] data)
        {
            for (int i = data.Length - 1; i >= 0; i--)
            {
                Node p = new Node(data[i]);
                if (first == null)
                {
                    first = p;
                }
                else
                {
                    p.Link = first;
                    first = p;
                }
            }
        }

        public void InsertAfterLast(int data)
        {
            Node q = new Node(data);
            Node p = first;
            if (first != null)
            {
                while (p.Link != null)
                {
                    p = p.Link;
                    if (p.Link == null)
                    {
                        p.Link = q;
                        p = p.Link;
                    };
                }

            }
            else first = q;
        }

        public void InsertAfterLast(int[] data)
        {
            Node last = null;
            if (data.Length == 0) first = null;
            else
            {
                if (first == null)
                {
                    first = new Node(data[0], null);
                    last = first;
                }
                else
                {
                    Node p = first;
                    while (p.Link != null)
                    {
                        p = p.Link;
                        if (p.Link == null)
                        {
                            last = p;
                            p = new Node(data[0]);
                            last.Link = p;
                            last = p;
                        }
                    }
                }
            }
            for (int i = 1; i < data.Length; i++)
            {
                Node p = new Node(data[i], null);
                last.Link = p;
                last = last.Link;
            }
        }

        public void Print()
        {
            Node p = first;
            while (p != null)
            {
                Console.Write(p.Info + " ");
                p = p.Link;
            }
            Console.WriteLine();
        }


        public void InsertAfterLast1(int[] data)
        {
            Node last = null;
            for (int i = 0; i < data.Length; i++)
            {
                Node p = new Node(data[i]);
                if (last == null)
                {
                    last = p;
                    last.Link = first;
                    first = last;
                }
                else
                {
                    last.Link = p;
                    last = p;
                }
            }
        }









        public void DeleteBeforeFirst()
        {
            if (first != null) first = first.Link;
        }

        public int GetLenght()
        {
            Node p = first;
            int count = 0;
            while (p != null)
            {
                count += 1;
                p = p.Link;
            }
            return count;
        }

        public bool IsIncreasing()
        {
            bool flag = false;
            Node p = first;
            if ((p == null) || (p.Link == null)) flag = true;
            else
            {
                while ((p.Info <= p.Link.Info) && !flag)
                {
                    if (p.Link.Link != null)
                    { p = p.Link; }
                    else
                    { flag = true; }
                }
            }

            return flag;
        }
        public void InsertAfter(Node p, int data)
        {
            if (p != null)
            {
                Node q = new Node(data);
                q.Link = p.Link;
                p.Link = q;
            }
        }
        public void DeleteAfter(Node p)
        {
            if (p != null && p.Link != null) p.Link = p.Link.Link;
        }


        public Node DeleteAfter2(Node p)
        {
            Node q = null;
            if (p != null && p.Link != null)
            {
                q = p.Link;
                p.Link = q.Link;
            }
            return q;
        }
        public void Delete(ref Node p)
        {
            if (p != null)
            {
                if (first == p)
                {
                    first = first.Link;
                }
                else
                {
                    Node q = first;
                    while (q.Link != p) q = q.Link;
                    q.Link = p.Link;
                }
                p = null;
            }
        }
        public void DeleteList()
        {
            first = null;
        }

        public Node FindNode(int data)
        {
            Node p = first;
            while ((p != null) && (p.Info != data))
            {
                p = p.Link;
            }
            return p;
        }

        public Node DeleteBeforeFirstWithLink()
        {
            Node p = null;
            if (first != null)
            {
                p = first;
                first = first.Link;
            }
            return p;
        }
    }
}

    
