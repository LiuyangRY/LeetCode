namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 链表节点
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class ListNode<T>
	{
		/// <summary>
		/// 节点数据
		/// </summary>
		/// <value></value>
		public T Element { get; set; }

		/// <summary>
		/// 下一个节点
		/// </summary>
		/// <value></value>
		public ListNode<T> Next { get; set; }

		/// <summary>
		/// 链表节点构造函数
		/// </summary>
		public ListNode() : this(default, null)
		{
		}

		/// <summary>
		/// 链表节点构造函数
		/// </summary>
		/// <param name="e">节点数据</param>
		public ListNode(T e) : this(e, null)
		{
		}

		/// <summary>
		/// 链表节点构造函数
		/// </summary>
		/// <param name="e">节点数据</param>
		/// <param name="next">下一个节点</param>
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