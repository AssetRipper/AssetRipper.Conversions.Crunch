using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(49)]
public partial struct InlineArray49_Int32 : IEquatable<InlineArray49_Int32>, IEqualityOperators<InlineArray49_Int32, InlineArray49_Int32, bool>, IEnumerable, IInlineArray<InlineArray49_Int32, int>, IInlineArray<InlineArray49_Int32, uint>
{
	private int __element0;

	public static int Length => 49;

	public static bool operator ==(InlineArray49_Int32 x, InlineArray49_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray49_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray49_Int32 x, InlineArray49_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray49_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray49_Int32)
		{
			return Equals((InlineArray49_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray49_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
