namespace LeetCodeSolutions.DataStructure.Interface
{
	/// <summary>
	/// 集合接口
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public interface ISet<T>
	{
		void Add(T element);

		bool Contains(T element);

		void Remove(T element);

		int GetSize();

		bool IsEmpty();
	}
}