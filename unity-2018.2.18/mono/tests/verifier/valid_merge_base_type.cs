using System;
using System.Reflection;
using System.Reflection.Emit;

public class Parent {

}

public class Foo : Parent {

}

public class Bar : Parent {

}
class Driver {


	public static int Main (string[] args) {
		Parent p;
		Foo f = new Foo();
		Bar b = new Bar();
		p = args == null? (Parent) f : (Parent) b;

		return 1;
	}
}	
