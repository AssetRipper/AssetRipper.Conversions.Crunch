using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_crnd_chunk_tile_desc : IEquatable<InlineArray4_crnd_chunk_tile_desc>, IEqualityOperators<InlineArray4_crnd_chunk_tile_desc, InlineArray4_crnd_chunk_tile_desc, bool>, IEnumerable, IInlineArray<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
{
	private crnd_chunk_tile_desc __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_crnd_chunk_tile_desc x, InlineArray4_crnd_chunk_tile_desc y)
	{
		return InlineArrayHelper.Equals<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>(x, y);
	}

	public static bool operator !=(InlineArray4_crnd_chunk_tile_desc x, InlineArray4_crnd_chunk_tile_desc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_crnd_chunk_tile_desc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_crnd_chunk_tile_desc)
		{
			return Equals((InlineArray4_crnd_chunk_tile_desc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_chunk_tile_desc>)this).GetEnumerator();
	}
}
