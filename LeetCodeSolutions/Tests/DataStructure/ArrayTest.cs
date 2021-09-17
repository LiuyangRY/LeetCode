using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
    public class ArrayTest
    {
        [Fact]
        public void Array_CountTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }};
            Array<TestModel> test = new();
            bool exceptedBool = true;
            Assert.Equal(test.IsEmpty(), exceptedBool);
            int exceptedValue = 0;
            Assert.Equal(test.GetSize(), exceptedValue);
            exceptedValue = 10;
            Assert.Equal(test.GetCapacity(), exceptedValue);
            for(int i = 0; i < array.Length; i++)
            {
                test.Add(array[i]);
            }
            exceptedBool = false;
            Assert.Equal(test.IsEmpty(), exceptedBool);
            exceptedValue = 2;
            Assert.Equal(test.GetSize(), exceptedValue);
            exceptedValue = 10;
            Assert.Equal(test.GetCapacity(), exceptedValue);
            test.Clear();
            exceptedBool = true;
            Assert.Equal(test.IsEmpty(), exceptedBool);
            exceptedValue = 0;
            Assert.Equal(test.GetSize(), exceptedValue);
            exceptedValue = 10;
            Assert.Equal(test.GetCapacity(), exceptedValue);
        }

        [Fact]
        public void Array_AddTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            test.Add(array[0]);
            TestModel t1 = test.Get(0);
            int exceptedValue = 1;
            string exceptedString = "t1";
            Assert.Equal(t1.Id, exceptedValue);
            Assert.Equal(t1.TestName, exceptedString);
            test.AddFirst(array[1]);
            TestModel t2 = test.Get(0);
            exceptedValue = 2;
            exceptedString = "t2";
            Assert.Equal(t2.Id, exceptedValue);
            Assert.Equal(t2.TestName, exceptedString);
            test.AddLast(array[2]);
            TestModel t3 = test.Get(2);
            exceptedValue = 3;
            exceptedString = "t3";
            Assert.Equal(t3.Id, exceptedValue);
            Assert.Equal(t3.TestName, exceptedString);
        }

        [Fact]
        public void Array_UpdateTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            bool exceptedBool = false;
            int exceptedValue = 0;
            Assert.Equal(test.Contain(array[0]), exceptedBool);
            test.Add(array[0]);
            TestModel t1 = test.Get(0);
            exceptedBool = true;
            exceptedValue = 1;
            Assert.Equal(test.Contain(t1), exceptedBool);
            test.Set(0, array[1]);
            TestModel t2 = test.Get(0);
            exceptedValue = 2;
            Assert.Equal(test.Contain(t2), exceptedBool);
            Assert.Equal(t2.Id, exceptedValue);
        }

        [Fact]
        public void Array_RemoveTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            bool exceptedBool = true;
            test.Add(array[0]);
            test.Add(array[1]);
            test.Add(array[2]);
            Assert.Equal(test.Contain(array[0]), exceptedBool);
            test.RemoveFirst();
            exceptedBool = false;
			Assert.Equal(test.Contain(array[0]), exceptedBool);
            exceptedBool = true;
			Assert.Equal(test.Contain(array[1]), exceptedBool);
            test.Remove(0);
            exceptedBool = false;
            Assert.Equal(test.Contain(array[1]), exceptedBool);
            exceptedBool = true;
            Assert.Equal(test.Contain(array[2]), exceptedBool);
            test.RemoveLast();
            exceptedBool = false;
            Assert.Equal(test.Contain(array[2]), exceptedBool);
        }
    }

    public class TestModel
    {
        public int Id { get; set; }

        public string TestName { get; set; }
    }
}