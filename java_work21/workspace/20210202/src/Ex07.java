//p.142 6-1-2
public class Ex07 {
	public static void main(String[] args) {
		math(10,10);
		math(8,5);
		math(5,9);
	}
	public static void math(int x, int y){
		if(x>y)
			System.out.println(x-y);
		else
			System.out.println(y-x);
	}
}
