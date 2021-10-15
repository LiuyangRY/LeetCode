using LeetCodeSolutions.DataStructure;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class BinarySearchTreeTest
	{
		[Fact]
		public void BinarySearchTree_BasicTest()
		{
			BinarySearchTree<TestModel> test = new();
			TestModel t1 = new() { Id = 0, TestName = "t1"};
			Assert.True(test.GetSize() == 0);
			Assert.True(test.IsEmpty());
			Assert.False(test.Contains(t1));
			test.Add(t1);
			Assert.True(test.GetSize() == 1);
			Assert.False(test.IsEmpty());
			Assert.True(test.Contains(t1));
		}

		[Theory]
		[InlineData(new int[]{10, 8, 20, 17, 6, 9, 7, 15, 2, 3, 5})]
		public void BinarySearchTree_TraversalNoRecursionTest(int[] array)
		{
			List<TestModel> testModels = new();
			foreach(int item in array)
			{
				testModels.Add(new() { Id = item, TestName = $"t{item}" });
			}
			BinarySearchTree<TestModel> test = new(testModels);
			List<int> preOrder = test.PreOrderTraversalNoRecursion().Select(t => t.Id).ToList();
			List<int> inOrder = test.InOrderTraversalNoRecursion().Select(t => t.Id).ToList();
			List<int> postOrder = test.PostOrderTraversalNoRecursion().Select(t => t.Id).ToList();
			List<int> levelOrder = test.LevelOrderTraversal().Select(t => t.Id).ToList();
			List<int> exceptedPreOrder = new() { 10, 8, 6, 2, 3, 5, 7, 9, 20, 17, 15 };
			List<int> exceptedInOrder = new() { 2, 3, 5, 6, 7, 8, 9, 10, 15, 17, 20 };
			List<int> exceptedPostOrder = new() { 5, 3, 2, 7, 6, 9, 8, 15, 17, 20, 10 };
			List<int> exceptedLevelOrder = new() { 10, 8, 20, 6, 9, 17, 2, 7, 15, 3, 5 };
			for(int index = 0; index < array.Length; index++)
			{
				Assert.Equal(exceptedPreOrder[index], preOrder[index]);
				Assert.Equal(exceptedInOrder[index], inOrder[index]);
				Assert.Equal(exceptedPostOrder[index], postOrder[index]);
				Assert.Equal(exceptedLevelOrder[index], levelOrder[index]);
			}
		}

		[Theory]
		[InlineData(new int[]{10, 8, 20, 17, 6, 9, 7, 15, 2, 3, 5})]
		public void BinarySearchTree_EditTest(int[] array)
		{
			List<TestModel> testModels = new();
			foreach(int item in array)
			{
				testModels.Add(new() { Id = item, TestName = $"t{item}" });
			}
			BinarySearchTree<TestModel> test = new(testModels);
			TestModel minimumItem = test.GetMinimum();	
			TestModel maximumItem = test.GetMaximum();
			Assert.True(test.Contains(minimumItem));
			Assert.True(test.Contains(maximumItem));
			TestModel deletedItem = test.RemoveMin();
			Assert.Equal(deletedItem, minimumItem);
			Assert.False(test.Contains(minimumItem));
			deletedItem = test.RemoveMax();
			Assert.Equal(deletedItem, maximumItem);
			Assert.False(test.Contains(maximumItem));
			TestModel t1 = testModels.Find(m => m.Id.Equals(10));
			Assert.True(test.Contains(t1));
			test.Remove(t1);
			Assert.False(test.Contains(t1));
		}	
	}
}