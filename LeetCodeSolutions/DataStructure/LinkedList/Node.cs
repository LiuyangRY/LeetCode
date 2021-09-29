namespace LeetCodeSolutions.DataStructure
{
	public class Node<T>
	{
		public T Element { get; set; }

		public Node<T> Next { get; set; }

		public Node() : this(default, null)
		{
		}

		public Node(T e) : this(e, null)
		{
		}

		public Node(T e, Node<T> next)
		{
			Element = e;
			Next = next;
		}

		public override string ToString()
		{
			return Element?.ToString();
		}
	}
}