using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTut {
	class Rect : Quad {

		public int GetArea() {
			return (Side1 * Side2);
		}

		public string Print() {
			return "Rectangle";
		}
		public Rect() : base() { }

		public Rect(int s1, int s2) : base(s1, s2, s1, s2) { }




	}
}


