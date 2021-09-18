using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class QueueTest
	{
		[Fact]
		public void Queue_InitTest()
		{
			ArrayQueue<TestModel> test = new();
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
		public void Queue_EnQueueTest()
		{
			ArrayQueue<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			string exceptedString = "t1";
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.EnQueue(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetFront().Id);
			Assert.Equal(exceptedString, test.GetFront().TestName);
		}

		[Fact]
		public void Queue_DeQueueTest()
		{
			ArrayQueue<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.EnQueue(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			test.DeQueue();
			exceptedBool = true;
			exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}

		[Fact]
		public void Queue_GetFrontTest()
		{
			ArrayQueue<TestModel> test = new();
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