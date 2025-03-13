namespace CSharpIntermediate
{
    public class Stack()
    {
        public object input;
        List<object> list = new List<object>();

        public void Push(object obj)
        {
            input = obj;
            if (input == null)
                throw new InvalidOperationException("Input cannot be null.");
            else
                list.Add(input);
        }

        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot Pop because Stack is empty.");
            else
            {
                var removed = list[list.Count - 1];
                list.Remove(list[list.Count - 1]);
                return removed;
            }
        }

        public void Clear()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot Pop because Stack is empty.");
            else
            {
                for (var i = list.Count - 1; i >= 0; i--)
                    list.Remove(list[i]);
            }
                

        }

        public void Display()
        {
            Console.WriteLine(list.Count);
        }
    }
}
