namespace CommonDataStructures
{
    public class LinkedList<T>
    {
        private Node Head { get; set; }
        private int Count { get; set; }

        public LinkedList(T head = default)
        {
            Head = new Node(head);
            Count = 0;
        }

        public int GetCount() => Count;
        public void Insert(T value)
        {
            var newNode = new Node(value);
            newNode.SetNext(Head.GetData());
            Head = newNode;
            Count++;
        }

        public T Find(T value)
        {
            var item = Head;
            while (item != null)
            {
                var nodeData = currentNode.GetData();

            }
        }

        public class Node
        {
            private T Value { get; set; }
            private T Next { get; set; }

            public Node(T value) => Value = value;

            public T GetData() => Value;
            public void SetDate(T value) => Value = value;
            public T GetNext() => Next;
            public void SetNext(T next) => Next = next;
        }
    }
}