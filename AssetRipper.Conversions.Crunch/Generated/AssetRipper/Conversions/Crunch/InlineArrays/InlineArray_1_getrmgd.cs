using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray_1_getrmgd : IEquatable<InlineArray_1_getrmgd>, IEqualityOperators<InlineArray_1_getrmgd, InlineArray_1_getrmgd, bool>, IEnumerable, IInlineArray<InlineArray_1_getrmgd, crnd_crn_packed_uint_0>
{
	private crnd_crn_packed_uint_0 __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray_1_getrmgd x, InlineArray_1_getrmgd y)
	{
		return InlineArrayHelper.Equals<InlineArray_1_getrmgd, crnd_crn_packed_uint_0>(x, y);
	}

	public static bool operator !=(InlineArray_1_getrmgd x, InlineArray_1_getrmgd y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_1_getrmgd other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_1_getrmgd)
		{
			return Equals((InlineArray_1_getrmgd)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_1_getrmgd, crnd_crn_packed_uint_0>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crn_packed_uint_0>)this).GetEnumerator();
	}
}
