using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(54)]
public partial struct InlineArray54_SByte : IEquatable<InlineArray54_SByte>, IEqualityOperators<InlineArray54_SByte, InlineArray54_SByte, bool>, IEnumerable, IInlineArray<InlineArray54_SByte, sbyte>, IInlineArray<InlineArray54_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 54;

	public static bool operator ==(InlineArray54_SByte x, InlineArray54_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray54_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray54_SByte x, InlineArray54_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray54_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray54_SByte)
		{
			return Equals((InlineArray54_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray54_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
