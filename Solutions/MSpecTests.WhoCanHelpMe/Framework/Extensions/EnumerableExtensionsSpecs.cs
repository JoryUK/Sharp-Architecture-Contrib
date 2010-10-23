//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace MSpecTests.WhoCanHelpMe.Framework.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using FrameworkEnumerableExtensions = global::WhoCanHelpMe.Framework.Extensions;
	using Machine.Specifications;
	using Machine.Specifications.Runner.Impl;

	public class context_for_enumerable_extensions
	{
		Establish context = () =>
			{ };
	}

	[Subject(typeof(EnumerableExtensions))]
	public class when_the_enumerable_extensions_each_method_is_used : context_for_enumerable_extensions
	{
		static IEnumerable<int> targetList;

		static List<int> results;

		// Arrange
		Establish context = () =>
			{
				targetList = Enumerable.Range(0, 50);
				results = new List<int>(50);
			};

		// Act
		Because of = () => FrameworkEnumerableExtensions.EnumerableExtensions.Each(targetList, x => results.Add(x));

		// Assert
		It should_call_the_action_for_each_item_in_the_list = () => results.Count.ShouldEqual(50);
	}

	[Subject(typeof(EnumerableExtensions))]
	public class when_the_enumerable_extensions_each_method_is_used_with_an_empty_list : context_for_enumerable_extensions
	{
		static IEnumerable<int> targetList;

		static bool actionWasInvoked;

		// Arrange
		Establish context = () =>
		{
			targetList = new List<int>();
			actionWasInvoked = false;
		};

		// Act
		Because of = () => FrameworkEnumerableExtensions.EnumerableExtensions.Each(targetList, x => actionWasInvoked = true);

		// Assert
		It should_not_call_the_target_method = () => actionWasInvoked.ShouldBeFalse();
	}

	[Subject(typeof(EnumerableExtensions))]
	public class when_the_enumerable_extensions_each_method_is_used_with_a_null_collection : context_for_enumerable_extensions
	{
		static IEnumerable<int> targetList;

		static bool actionWasInvoked;

		Establish context = () =>
		{
			targetList = null;
			actionWasInvoked = false;
		};

		It should_throw_an_argument_null_exception = () => Catch.Exception(() => FrameworkEnumerableExtensions.EnumerableExtensions.Each(targetList, x => actionWasInvoked = true)).ShouldBeOfType<ArgumentException>();
	}

	[Subject(typeof(EnumerableExtensions))]
	public class when_the_enumerable_extensions_each_method_is_used_with_a_null_action : context_for_enumerable_extensions
	{
		static IEnumerable<int> targetList;

		Establish context = () =>
		{
			targetList = new List<int>();
		};

		It should_throw_an_argument_null_exception = () => Catch.Exception(() => FrameworkEnumerableExtensions.EnumerableExtensions.Each(targetList, null)).ShouldBeOfType<ArgumentNullException>();
	}
}