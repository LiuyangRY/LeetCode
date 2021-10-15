using System;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 链表
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class LinkedList<T>
	{
		private ListNode<T> DummyHead { get; set; } = new();

		private int Size { get; set; } = 0;

		public LinkedList()
		{
		}

		/// <summary>
		///	清空链表 
		/// </summary>
		public void Clear()
		{
			DummyHead.Next = null;
			Size = 0;
		}

		/// <summary>
		/// 获取链表中的元素个数
		/// </summary>
		/// <returns>元素个数</returns>
		public int GetSize()
		{
			return Size;
		}

		/// <summary>
		/// 链表是否为空
		/// </summary>
		/// <returns>链表为空返回true，否则返回false</returns>
		public bool IsEmpty()
		{
			return Size == 0;
		}

		/// <summary>
		/// 在链表头部增加新的元素
		/// </summary>
		/// <param name="e">新的元素</param>
		public void AddFirst(T e)
		{
			Add(0, e);
		}

		/// <summary>
		/// 在链表尾部新增元素
		/// </summary>
		/// <param name="e">新元素</param>
		public void AddLast(T e)
		{
			Add(Size, e);
		}

		/// <summary>
		/// 在链表指定索引位置增加新元素
		/// </summary>
		/// <param name="index">索引位置</param>
		/// <param name="e">新元素</param>
		public void Add(int index, T e)
		{
			if(index < 0 || index > Size)
			{
				throw new Exception("Add failed. Illegal index.");
			}
			ListNode<T> prevNode = DummyHead;
			while(index > 0)
			{
				index--;
				prevNode = prevNode.Next;
			}
			ListNode<T> newNode = new(e, prevNode.Next);
			prevNode.Next = newNode;
			Size++;
		}

		/// <summary>
		/// 获取索引位置的元素
		/// </summary>
		/// <param name="index">索引</param>
		/// <returns>元素</returns>
		public T Get(int index)
		{
			if(index < 0 || index >= Size)
			{
				throw new Exception("Get failed. Illegal index.");
			}
			ListNode<T> cur = DummyHead.Next;
			for(int i = 0; i < index; i++)
			{
				cur = cur.Next;
			}
			return cur.Element;
		}

		/// <summary>
		/// 获取第一个元素
		/// </summary>
		/// <returns>第一个元素</returns>
		public T  GetFirst()
		{
			return Get(0);
		}

		/// <summary>
		/// 获取最后一个元素
		/// </summary>
		/// <returns>最后一个元素</returns>
		public T GetLast()
		{
			return Get(Size - 1);
		}

		/// <summary>
		/// 删除指定索引位置的元素
		/// </summary>
		/// <param name="index">索引位置</param>
		/// <returns>删除的元素</returns>
		public T Remove(int index)
		{
			if(index < 0 || index >= Size)
			{
				throw new Exception("Get failed. Illegal index.");
			}
			ListNode<T> prev = DummyHead;
			for(int i = 0; i < index; i++)
			{
				prev = prev.Next;
			}
			ListNode<T> result = prev.Next;
			prev.Next = result.Next;
			result.Next = null;
			Size--;
			return result.Element;
		}

		/// <summary>
		/// 从链表中删除指定元素
		/// </summary>
		/// <param name="element">指定元素</param>
		public void RemoveElement(T element)
		{
			ListNode<T> prev = DummyHead;
			while(prev.Next is not null)
			{
				if(prev.Next.Element.Equals(element))
				{
					break;
				}
				prev = prev.Next;
			}
			if(prev.Next is not null)
			{
				ListNode<T> delNode = prev.Next;
				prev.Next = delNode.Next;
				delNode.Next = null;
				Size--;
			}
		}

		/// <summary>
		/// 删除第一个元素
		/// </summary>
		/// <returns>第一个元素</returns>
		public T RemoveFirst()
		{
			return Remove(0);
		}

		/// <summary>
		/// 删除最后一个元素
		/// </summary>
		/// <returns>最后一个元素</returns>
		public T RemoveLast()
		{
			return Remove(Size - 1);
		}

		/// <summary>
		/// 设置指定索引位置的元素
		/// </summary>
		/// <param name="index">索引位置</param>
		/// <param name="e">设置的元素</param>
		public void Set(int index, T e)
		{
			if(index < 0 || index >= Size)
			{
				throw new Exception("Get failed. Illegal index.");
			}
			ListNode<T> cur = DummyHead.Next;
			for(int i = 0; i < index; i++)
			{
				cur = cur.Next;
			}
			cur.Element = e;
		}

		/// <summary>
		/// 链表中是否包含指定元素
		/// </summary>
		/// <param name="e">指定元素</param>
		/// <returns>包含元素返回true，否则返回false</returns>
		public bool Contains(T e)
		{
			ListNode<T> cur = DummyHead.Next;
			while(cur is not null)
			{
				if(cur.Element.Equals(e))
				{
					return true;
				}
				cur = cur.Next;
			}
			return false;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new();
			for(ListNode<T> cur = DummyHead.Next; cur is not null; cur = cur.Next)
			{
				sb.Append($"{cur}->");
			}
			sb.Append("NULL");
			return sb.ToString();
		}
	}
}