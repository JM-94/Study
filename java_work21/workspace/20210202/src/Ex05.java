
public class Ex05 {
	
	public static void main(String[] args) {
		System.out.println(doA());
		System.out.println(doB());
		doC();
	}
	
	public static int doA(){
		return 5;
	}
	public static double doB(){
		return 1.2;
	}
	public static void doC(){
		for(int i =1; i<10; i++){
			if(i==5)
				return;
		System.out.println("i = "+ i);
		}
	}
}
