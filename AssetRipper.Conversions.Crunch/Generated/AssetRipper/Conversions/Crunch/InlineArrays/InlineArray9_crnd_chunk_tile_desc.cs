using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(9)]
public partial struct InlineArray9_crnd_chunk_tile_desc : IEquatable<InlineArray9_crnd_chunk_tile_desc>, IEqualityOperators<InlineArray9_crnd_chunk_tile_desc, InlineArray9_crnd_chunk_tile_desc, bool>, IEnumerable, IInlineArray<InlineArray9_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
{
	private crnd_chunk_tile_desc __element0;

	public static int Length => 9;

	public static bool operator ==(InlineArray9_crnd_chunk_tile_desc x, InlineArray9_crnd_chunk_tile_desc y)
	{
		return InlineArrayHelper.Equals<InlineArray9_crnd_chunk_tile_desc, crnd_chunk_tile_desc>(x, y);
	}

	public static bool operator !=(InlineArray9_crnd_chunk_tile_desc x, InlineArray9_crnd_chunk_tile_desc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray9_crnd_chunk_tile_desc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray9_crnd_chunk_tile_desc)
		{
			return Equals((InlineArray9_crnd_chunk_tile_desc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray9_crnd_chunk_tile_desc, crnd_chunk_tile_desc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_chunk_tile_desc>)this).GetEnumerator();
	}
}
