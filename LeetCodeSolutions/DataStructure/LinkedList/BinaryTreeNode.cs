using System;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 二叉树结点
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class BinaryTreeNode<T> : IComparable<T> where T : IComparable<T>
	{
		/// <summary>
		/// 节点数据
		/// </summary>
		public T element;

		/// <summary>
		/// 左节点
		/// </summary>
		/// <value></value>
		public BinaryTreeNode<T> LeftNode { get; set; } = null;

		/// <summary>
		/// 右节点
		/// </summary>
		/// <value></value>
		public BinaryTreeNode<T> RightNode { get; set; } = null;

		/// <summary>
		/// 二叉树节点构造函数
		/// </summary>
		/// <param name="element">节点数据</param>
		public BinaryTreeNode(T element)
		{
			this.element = element;
		}

		/// <summary>
		/// 二叉树节点构造函数
		/// </summary>
		/// <param name="element">节点数据</param>
		/// <param name="leftNode">左节点</param>
		/// <param name="rightNode">右节点</param>
		public BinaryTreeNode(T element, BinaryTreeNode<T> leftNode, BinaryTreeNode<T> rightNode) : this(element)
		{
			LeftNode = leftNode;
			RightNode = rightNode;
		}

		public int CompareTo(T other)
		{
			return element.CompareTo(other);
		}
	}
}