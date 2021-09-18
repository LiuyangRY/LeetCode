using System;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	public class Array<T>
	{
		public Array() : this(10)
		{
		}

		public Array(int capacity)
		{
			data = new T[capacity];
			size = 0;
		}

		/// <summary>
		/// 获取数组的容量
		/// </summary>
		/// <returns>数组容量</returns>
		public int GetCapacity()
		{
			return data.Length;
		}
		
		/// <summary>
		/// 获取数组中元素的个数
		/// </summary>
		/// <returns>数组元素个数</returns>
		public int GetSize()
		{
			return size;
		}

		/// <summary>
		/// 数组是否为空
		/// </summary>
		/// <returns>数组为空返回true，否则返回false</returns>
		public bool IsEmpty()
		{
			return size == 0;
		}

		/// <summary>
		///	向所有元素后添加一个新元素 
		/// </summary>
		/// <param name="e">新元素</param>
		public void AddLast(T e)
		{
			Add(size, e);
		}

		/// <summary>
		///	向所有元素前添加一个新元素 
		/// </summary>
		/// <param name="e">新元素</param>
		public void AddFirst(T e)
		{
			Add(0, e);
		}

		/// <summary>
		/// 在数组尾部添加一个新元素
		/// </summary>
		/// <param name="e">新元素</param>
		public void Add(T e)
		{
			Add(size, e);
		}

		/// <summary>
		/// 在指定位置插入一个新元素
		/// </summary>
		/// <param name="index">位置索引</param>
		/// <param name="e">新元素</param>
		public void Add(int index, T e)
		{
			if(index < 0 || index > size)
			{
				throw new ArgumentException("Add failed. Require index >= 0 and index <= size.");
			}
			if(size == data.Length)
			{
				Resize(2 * data.Length);
			}
			for(int i = size - 1; i >= index; i--)
			{
				data[i + 1] = data[i];
			}
			data[index] = e;
			size++;
		}

		/// <summary>
		/// 获取指定位置的元素
		/// </summary>
		/// <param name="index">指定位置</param>
		/// <returns>指定位置的元素</returns>
		public T Get(int index)
		{
			if(index < 0 || index >= size)
			{
				throw new ArgumentException("Get failed. Index is illegal.");
			}
			return data[index];
		}

		/// <summary>
		/// 获取第一个元素
		/// </summary>
		/// <returns>第一个元素</returns>
		public T GetFirst()
		{
			return Get(0);
		}

		/// <summary>
		/// 获取最后一个元素
		/// </summary>
		/// <returns>最后一个元素</returns>
		public T GetLast()
		{
			return Get(size - 1);
		}

		/// <summary>
		/// 修改指定位置的元素
		/// </summary>
		/// <param name="index">指定位置</param>
		/// <param name="e">新元素</param>
		public void Set(int index, T e)
		{
			if(index < 0 || index >= size)
			{
				throw new ArgumentException("Set failed. Index is illegal.");
			}
			data[index] = e;
		}

		/// <summary>
		/// 查找数组中是否包含指定元素
		/// </summary>
		/// <param name="e">指定元素</param>
		/// <returns>包含返回true，否则返回false</returns>
		public bool Contain(T e)
		{
			for(int i = 0; i < size; i++)
			{
				if(data[i].Equals(e))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 查找数组中指定元素的索引，如果不存在，则返回-1
		/// </summary>
		/// <param name="e">指定元素</param>
		/// <returns>指定元素索引</returns>
		public int Find(T e)
		{
			for(int i = 0; i < size; i++)
			{
				if(data[i].Equals(e))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>
		/// 从数组中删除指定位置的元素，返回删除的元素
		/// </summary>
		/// <param name="index">指定位置索引</param>
		/// <returns>删除的元素</returns>
		public T Remove(int index)
		{
			if(index < 0 || index >= size)
			{
				throw new ArgumentException("Remove failed. Index is illegal.");
			}
			T ret = data[index];
			for(int i = index + 1; i < size; i++)
			{
				data[i - 1] = data[i];
			}
			size--;
			data[size] = default;
			if(size == data.Length / 4 && data.Length / 2 != 0)
			{
				Resize(data.Length / 2);
			}
			return ret;
		}

		/// <summary>
		/// 从数组中删除第一个元素，返回删除的元素
		/// </summary>
		/// <returns>删除的元素</returns>
		public T RemoveFirst()
		{
			return Remove(0);
		}

		/// <summary>
		/// 是删除数组中的最后一个元素，返回删除的元素
		/// </summary>
		/// <returns>删除的元素</returns>
		public T RemoveLast()
		{
			return Remove(size - 1);
		}

		/// <summary>
		/// 从数组中删除指定元素
		/// </summary>
		/// <param name="e">指定元素</param>
		public void Remove(T e)
		{
			int index = Find(e);
			if(index != -1)
			{
				Remove(index);
			}
		}

		/// <summary>
		/// 清空数组
		/// </summary>
		public void Clear()
		{
			data = new T[10];
			size = 0;
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			sb.AppendLine($"Array: size = {size}, capacity = {data.Length}");
			sb.Append("[");
			for(int i = 0; i < size; i++)
			{
				sb.Append($"{data[i]},");
			}
			if(size > 0)
			{
				sb.Remove(sb.Length - 1, 1);
			}
			sb.Append("]");
			return sb.ToString();
		}

		private T[] data;

		private int size;

		/// <summary>
		/// 将数组空间容量改为指定大小
		/// </summary>
		/// <param name="newCapacity">新容量</param>
		private void Resize(int newCapacity)
		{
			T[] newData = new T[newCapacity];
			for(int i = 0; i < size; i++)
			{
				newData[i] = data[i];
			}
			data = newData;
		}
	}
}