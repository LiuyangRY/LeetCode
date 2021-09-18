namespace LeetCodeSolutions.DataStructure.Interface
{
	/// <summary>
	/// 栈接口
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public interface IStack<T>
	{
		/// <summary>
		/// 获取栈中元素数量
		/// </summary>
		/// <returns>栈中元素数量</returns>
		int GetSize();

		/// <summary>
		/// 获取栈容量
		/// </summary>
		/// <returns>栈容量</returns>
		int GetCapacity();

		/// <summary>
		/// 栈是否为空
		/// </summary>
		/// <returns>栈为空返回true，否则返回false</returns>
		bool IsEmpty();

		/// <summary>
		/// 往栈顶添加元素
		/// </summary>
		/// <param name="e">被添加的元素</param>
		void Push(T e);

		/// <summary>
		/// 从栈顶弹出元素（从栈中删除元素）
		/// </summary>
		/// <returns>栈顶元素</returns>
		T Pop();

		/// <summary>
		/// 从栈顶取出元素（元素不从栈中删除）
		/// </summary>
		/// <returns></returns>
		T Peek();
	}
}