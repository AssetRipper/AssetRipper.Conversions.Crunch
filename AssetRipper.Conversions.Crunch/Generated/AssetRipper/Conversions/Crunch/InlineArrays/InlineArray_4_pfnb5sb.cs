using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray_4_pfnb5sb : IEquatable<InlineArray_4_pfnb5sb>, IEqualityOperators<InlineArray_4_pfnb5sb, InlineArray_4_pfnb5sb, bool>, IEnumerable, IInlineArray<InlineArray_4_pfnb5sb, crnd_chunk_tile_desc>
{
	private crnd_chunk_tile_desc __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray_4_pfnb5sb x, InlineArray_4_pfnb5sb y)
	{
		return InlineArrayHelper.Equals<InlineArray_4_pfnb5sb, crnd_chunk_tile_desc>(x, y);
	}

	public static bool operator !=(InlineArray_4_pfnb5sb x, InlineArray_4_pfnb5sb y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_4_pfnb5sb other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_4_pfnb5sb)
		{
			return Equals((InlineArray_4_pfnb5sb)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_4_pfnb5sb, crnd_chunk_tile_desc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_chunk_tile_desc>)this).GetEnumerator();
	}
}
