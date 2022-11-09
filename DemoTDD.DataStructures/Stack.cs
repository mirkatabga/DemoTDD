namespace DemoTDD.DataStructures
{
    public class Stack
    {
        private List<int> _elements = new List<int>();
        private int _size = 0;

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public void Push(int element)
        {
            _size++;
            _elements.Add(element);
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException();
            }

            _size--;

            return _elements[_size];
        }
    }
}