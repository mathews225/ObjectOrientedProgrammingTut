using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTut {
	class Sqr : Rect {


		public string Print() {
			return "Square";
		}


		public Sqr() : base() { }

		public Sqr(int s1) : base(s1, s1) { }

	}
}
