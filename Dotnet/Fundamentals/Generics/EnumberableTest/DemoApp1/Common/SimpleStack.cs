namespace Common;
public class SimpleStack<E> : IStackReader<E> ,IStackWriter<E>
{
    class Node
    {
        internal E element;
        internal Node below;

        internal Node Skip(int steps)
        {
            Node n = this;
            for(int i = 0; i < steps; ++i)
                n = n.below;
            return n;
        }
    }

    private Node top;

    public void Push(E item)
    {
        top = new Node {element = item, below = top};
    }

    public E Pop()
    {
        Node temp = top;
        top = top.below;
        return temp.element;
    }

    public bool Empty()
    {
        return top is null;
    }

    public E this[int index]
    {
        get{ return top.Skip(index).element; }
        set{ top.Skip(index).element = value; }
    }

    public Iterator GetEnumerator()
    {
        return new Iterator(this);
    }

    public struct Iterator(SimpleStack<E> source)
    {
        private Node next = source.top;

        public E Current {get; private set;}

        public bool MoveNext()
        {
            if (next != null)
            {
                Current = next.element;
                next = next.below;
                return true;
            }
            return false;
        }
    }
}
