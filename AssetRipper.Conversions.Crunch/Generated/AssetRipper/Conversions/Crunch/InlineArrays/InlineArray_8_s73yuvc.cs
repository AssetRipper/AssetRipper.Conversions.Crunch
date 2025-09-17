using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray_8_s73yuvc : IEquatable<InlineArray_8_s73yuvc>, IEqualityOperators<InlineArray_8_s73yuvc, InlineArray_8_s73yuvc, bool>, IEnumerable, IInlineArray<InlineArray_8_s73yuvc, crnd_crnd_encoding_tile_indices>
{
	private crnd_crnd_encoding_tile_indices __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray_8_s73yuvc x, InlineArray_8_s73yuvc y)
	{
		return InlineArrayHelper.Equals<InlineArray_8_s73yuvc, crnd_crnd_encoding_tile_indices>(x, y);
	}

	public static bool operator !=(InlineArray_8_s73yuvc x, InlineArray_8_s73yuvc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_8_s73yuvc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_8_s73yuvc)
		{
			return Equals((InlineArray_8_s73yuvc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_8_s73yuvc, crnd_crnd_encoding_tile_indices>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crnd_encoding_tile_indices>)this).GetEnumerator();
	}
}
