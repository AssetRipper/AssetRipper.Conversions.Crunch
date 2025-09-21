using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_crnd_crnd_encoding_tile_indices : IEquatable<InlineArray8_crnd_crnd_encoding_tile_indices>, IEqualityOperators<InlineArray8_crnd_crnd_encoding_tile_indices, InlineArray8_crnd_crnd_encoding_tile_indices, bool>, IEnumerable, IInlineArray<InlineArray8_crnd_crnd_encoding_tile_indices, crnd_crnd_encoding_tile_indices>
{
	private crnd_crnd_encoding_tile_indices __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_crnd_crnd_encoding_tile_indices x, InlineArray8_crnd_crnd_encoding_tile_indices y)
	{
		return InlineArrayHelper.Equals<InlineArray8_crnd_crnd_encoding_tile_indices, crnd_crnd_encoding_tile_indices>(x, y);
	}

	public static bool operator !=(InlineArray8_crnd_crnd_encoding_tile_indices x, InlineArray8_crnd_crnd_encoding_tile_indices y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_crnd_crnd_encoding_tile_indices other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray8_crnd_crnd_encoding_tile_indices)
		{
			return Equals((InlineArray8_crnd_crnd_encoding_tile_indices)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_crnd_crnd_encoding_tile_indices, crnd_crnd_encoding_tile_indices>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crnd_encoding_tile_indices>)this).GetEnumerator();
	}
}
