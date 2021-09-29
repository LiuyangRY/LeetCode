namespace LeetCodeSolutions.DataStructure
{
	public class ListNode<T>
	{
		public T Element { get; set; }

		public ListNode<T> Next { get; set; }

		public ListNode() : this(default, null)
		{
		}

		public ListNode(T e) : this(e, null)
		{
		}

		public ListNode(T e, ListNode<T> next)
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