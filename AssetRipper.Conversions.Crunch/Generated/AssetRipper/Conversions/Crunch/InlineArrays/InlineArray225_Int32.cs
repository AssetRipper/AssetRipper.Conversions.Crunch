using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(225)]
public partial struct InlineArray225_Int32 : IEquatable<InlineArray225_Int32>, IEqualityOperators<InlineArray225_Int32, InlineArray225_Int32, bool>, IEnumerable, IInlineArray<InlineArray225_Int32, int>, IInlineArray<InlineArray225_Int32, uint>
{
	private int __element0;

	public static int Length => 225;

	public static bool operator ==(InlineArray225_Int32 x, InlineArray225_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray225_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray225_Int32 x, InlineArray225_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray225_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray225_Int32)
		{
			return Equals((InlineArray225_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray225_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
