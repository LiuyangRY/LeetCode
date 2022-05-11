using System;

namespace LeetCodeSolutions.DataStructure
{
	public class MaxHeap<T> where T : IComparable<T>
	{
		private Array<T> data;

		public MaxHeap()
		{
			data = new();
		}

		public MaxHeap(int capacity)
		{
			data = new(capacity);
		}

		/// <summary>
		/// 堆中的元素个数
		/// </summary>
		/// <returns>元素个数</returns>
		public int Size()
		{
			return data.GetSize();
		}

		/// <summary>
		/// 堆是否为空
		/// </summary>
		/// <returns>堆为空返回true，否则返回false</returns>
		public bool IsEmpty()
		{
			return data.IsEmpty();
		}

		public void Add(T element)
		{
			data.AddLast(element);
			SiftUp(data.GetSize() - 1);
		}

		/// <summary>
		/// 查找堆中的最大元素
		/// </summary>
		/// <returns>堆中的最大元素</returns>
		public T FindMax()
		{
			if(data.GetSize() == 0)
			{
				throw new ArgumentException("Could not find the max element when heap is empty.");
			}
			return data.Get(0);
		}

		/// <summary>
		/// 取出堆中的最大元素
		/// </summary>
		/// <returns>堆中的最大元素</returns>
		public T ExtractMax()
		{
			T result = FindMax();
			data.Swap(0, data.GetSize() - 1);
			data.RemoveLast();
			SiftDown(0);
			return result;
		}

		/// <summary>
		/// 返回指定索引元素的父元素索引
		/// </summary>
		/// <param name="index">指定索引</param>
		/// <returns>父元素的索引</returns>
		private int ParentIndex(int index)
		{
			if(index == 0)
			{
				throw new ArgumentException("Index 0 doesn't have parent.");
			}
			return (index - 1) / 2;
		}

		/// <summary>
		/// 返回指定索引元素的左孩子节点的索引
		/// </summary>
		/// <param name="index">指定索引</param>
		/// <returns>指定元素左孩子节点索引</returns>
		private int LeftChildIndex(int index)
		{
			return index * 2 + 1;
		}

		/// <summary>
		/// 返回指定索引元素的右孩子节点的索引
		/// </summary>
		/// <param name="index">指定索引</param>
		/// <returns>指定元素右孩子节点索引</returns>
		private int RightChildIndex(int index)
		{
			return index * 2 + 2;
		}

		private void SiftUp(int k)
		{
			int parentIndex = ParentIndex(k);
			while(k > 0 && data.Get(parentIndex).CompareTo(data.Get(k)) < 0)
			{
				data.Swap(k, parentIndex);
				k = parentIndex;
				parentIndex = ParentIndex(k);
			}
		}

		private void SiftDown(int k)
		{
			while(LeftChildIndex(k) < data.GetSize())
			{
				// 获取索引为 k 的节点的左孩子节点
				int j = LeftChildIndex(k);
				if(j + 1 < data.GetSize() && data.Get(j + 1).CompareTo(data.Get(j)) > 0)
				{
					j++;
				}
				// 此时 j 为索引为 k 的节点的左右孩子节点中较大值所在节点的索引值
				if(data.Get(k).CompareTo(data.Get(j)) >= 0)
				{
					// 如果左右孩子节点都比索引为 k 的节点小，则退出此次循环
					break;
				}
				else
				{
					data.Swap(k, j);
					k = j;
				}
			}
		}
	}
}