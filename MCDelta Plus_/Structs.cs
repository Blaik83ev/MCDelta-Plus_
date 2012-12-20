using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDelta_Plus
{
	public struct Point2
	{
		public ushort x;
		public ushort y;

		public Point2(ushort X, ushort Y)
		{
			x = X;
			y = Y;
		}
	}
	public struct Point3
	{
		public short x;
		public short y;
		public short z;

		public Point3(short X, short Z, short Y)
		{
			x = X;
			y = Y;
			z = Z;
		}
		public Point3(ushort X, ushort Z, ushort Y)
		{
			x = (short)X;
			y = (short)Y;
			z = (short)Z;
		}
	}
}