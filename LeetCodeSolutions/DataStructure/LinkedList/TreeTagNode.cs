using System;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 树标记节点类(用以标记树节点是否已被遍历)
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class TreeTagNode<T> where T : IComparable<T>
	{
		/// <summary>
		/// 树节点
		/// </summary>
		public BinaryTreeNode<T> Node { get; set; }

		/// <summary>
		/// 节点是否已被遍历
		/// </summary>
		public bool IsTraversed { get; set; } = false;

		public TreeTagNode(BinaryTreeNode<T> node)
		{
			Node = node;
		}
	}
}