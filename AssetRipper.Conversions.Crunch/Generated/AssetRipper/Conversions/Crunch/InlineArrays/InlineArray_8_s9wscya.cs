using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray_8_s9wscya : IEquatable<InlineArray_8_s9wscya>, IEqualityOperators<InlineArray_8_s9wscya, InlineArray_8_s9wscya, bool>, IEnumerable, IInlineArray<InlineArray_8_s9wscya, crnd_chunk_encoding_desc>
{
	private crnd_chunk_encoding_desc __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray_8_s9wscya x, InlineArray_8_s9wscya y)
	{
		return InlineArrayHelper.Equals<InlineArray_8_s9wscya, crnd_chunk_encoding_desc>(x, y);
	}

	public static bool operator !=(InlineArray_8_s9wscya x, InlineArray_8_s9wscya y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_8_s9wscya other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_8_s9wscya)
		{
			return Equals((InlineArray_8_s9wscya)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_8_s9wscya, crnd_chunk_encoding_desc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_chunk_encoding_desc>)this).GetEnumerator();
	}
}
