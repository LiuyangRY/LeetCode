using System;

namespace LeetCodeSolutions.Tests
{
	public class TestModel : IComparable<TestModel>
	{
		public int Id { get; set; }

		public string TestName { get; set; }

		public int CompareTo(TestModel other)
		{
			return Id - other?.Id??0;
		}

		public override string ToString()
		{
			return $"Id: {Id}, TestName: {TestName}";
		}
	}
}