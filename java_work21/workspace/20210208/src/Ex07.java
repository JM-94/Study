class AAA{
	int a = 10;
	public void doA(BBB b){
		b.b = 30;
	}
	
	
}
class BBB{
	int b = 20;
	public void doB(AAA a){
		a.a = 40;
	}
}


public class Ex07 {
	public static void main(String[] args) {
		AAA aa = new AAA();
		BBB bb = new BBB();
		
		System.out.println("aa.a = "+aa.a);
		System.out.println("bb.b = "+bb.b);
		
		aa.doA(bb);
		bb.doB(aa);
	}
}
