using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于链表结构的队列
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class LinkedListQueue<T> : IQueue<T>
	{
		private LinkedList<T> list = new();

		public T DeQueue()
		{
			return list.RemoveFirst();
		}

		public void EnQueue(T e)
		{
			list.AddLast(e);
		}

		public T GetFront()
		{
			return list.GetFirst();
		}

		public int GetSize()
		{
			return list.GetSize();
		}

		public bool IsEmpty()
		{
			return list.IsEmpty();
		}
	}
}