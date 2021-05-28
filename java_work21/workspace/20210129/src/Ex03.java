
public class Ex03 {
	public static void main(String[] args) {
		short a =10;
		a = (short)(a * 20L);
		System.out.println("a = " +a);
		
		int b = 20;
		b = (int) (20*3.5);
		System.out.println("b = " +b);
		
		System.out.println("a>b = "+(a>b));
		System.out.println("a<b = "+(a<b));
		
		System.out.println("a==b = "+(a==b));
		System.out.println("a!=b = "+(a!=b));
	}
}
