using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_crnd_chunk_encoding_desc : IEquatable<InlineArray8_crnd_chunk_encoding_desc>, IEqualityOperators<InlineArray8_crnd_chunk_encoding_desc, InlineArray8_crnd_chunk_encoding_desc, bool>, IEnumerable, IInlineArray<InlineArray8_crnd_chunk_encoding_desc, crnd_chunk_encoding_desc>
{
	private crnd_chunk_encoding_desc __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_crnd_chunk_encoding_desc x, InlineArray8_crnd_chunk_encoding_desc y)
	{
		return InlineArrayHelper.Equals<InlineArray8_crnd_chunk_encoding_desc, crnd_chunk_encoding_desc>(x, y);
	}

	public static bool operator !=(InlineArray8_crnd_chunk_encoding_desc x, InlineArray8_crnd_chunk_encoding_desc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_crnd_chunk_encoding_desc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray8_crnd_chunk_encoding_desc)
		{
			return Equals((InlineArray8_crnd_chunk_encoding_desc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_crnd_chunk_encoding_desc, crnd_chunk_encoding_desc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_chunk_encoding_desc>)this).GetEnumerator();
	}
}
