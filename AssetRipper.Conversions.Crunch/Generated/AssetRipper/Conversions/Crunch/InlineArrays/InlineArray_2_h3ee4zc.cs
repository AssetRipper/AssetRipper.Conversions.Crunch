using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray_2_h3ee4zc : IEquatable<InlineArray_2_h3ee4zc>, IEqualityOperators<InlineArray_2_h3ee4zc, InlineArray_2_h3ee4zc, bool>, IEnumerable, IInlineArray<InlineArray_2_h3ee4zc, crnd_static_huffman_data_model>
{
	private crnd_static_huffman_data_model __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray_2_h3ee4zc x, InlineArray_2_h3ee4zc y)
	{
		return InlineArrayHelper.Equals<InlineArray_2_h3ee4zc, crnd_static_huffman_data_model>(x, y);
	}

	public static bool operator !=(InlineArray_2_h3ee4zc x, InlineArray_2_h3ee4zc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_2_h3ee4zc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_2_h3ee4zc)
		{
			return Equals((InlineArray_2_h3ee4zc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_2_h3ee4zc, crnd_static_huffman_data_model>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_static_huffman_data_model>)this).GetEnumerator();
	}
}
