using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class LinkedListQueueTest
	{
		[Fact]
		public void LinkedListQueue_InitTest()
		{
			LinkedListQueue<TestModel> test = new();
			bool exceptedBool = true;
			int exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			test.EnQueue(new() { Id = 1, TestName = "t1"} );
			exceptedBool = false;
			exceptedValue = 1;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}
		
		[Fact]
		public void LinkedListQueue_EnQueueTest()
		{
			LinkedListQueue<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			string exceptedString = "t1";
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.EnQueue(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetFront().Id);
			Assert.Equal(exceptedString, test.GetFront().TestName);
			TestModel t2 = new() { Id = 2, TestName = "t2" };
			test.EnQueue(t2);
			Assert.Equal(t1.Id, test.GetFront().Id);
			Assert.Equal(t1.TestName, test.GetFront().TestName);
	
		}

		[Fact]
		public void LinkedListQueue_DeQueueTest()
		{
			LinkedListQueue<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 2;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			TestModel t2 = new() { Id = 2, TestName = "t2" };
			test.EnQueue(t1);
			test.EnQueue(t2);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			Assert.Equal(t1.Id, test.GetFront().Id);
			Assert.Equal(t1.TestName, test.GetFront().TestName);
			test.DeQueue();
			Assert.Equal(t2.Id, test.GetFront().Id);
			Assert.Equal(t2.TestName, test.GetFront().TestName);
			test.DeQueue();
			exceptedBool = true;
			exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}

		[Fact]
		public void LinkedListQueue_GetFrontTest()
		{
			LinkedListQueue<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.EnQueue(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			TestModel peek = test.GetFront();
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(t1.Id, peek.Id);
			Assert.Equal(t1.TestName, peek.TestName);
		}
	}
}