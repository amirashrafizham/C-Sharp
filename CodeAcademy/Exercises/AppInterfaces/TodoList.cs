using System;

namespace AppInterfaces
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach (var item in Todos)
            {
                Console.WriteLine(item);
            }
        }
        public void Reset()
        {
            Array.Clear(Todos, 0, Todos.Length);
            nextOpenIndex = 0;
        }
    }
}
