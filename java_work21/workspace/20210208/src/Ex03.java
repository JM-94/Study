
public class Ex03 {
	public static int doA(int a){
		System.out.println("팩토리얼 함수");
		if(a>0){
			//3 * doA(2)
			//3 * 2 * doA(1)
			//3 * 2 * 1 * doA(0)
			//3 * 2 * 1 * 1
			return a * doA(a-1);
		}else{
			
		return 1;
	
		}
	}
	
	public static void main(String[] args) {
		int returnValue = doA(3);
		System.out.println("returnValue = "+returnValue);

	}
	/*
	  public static string doA(int a){
		System.out.println("팩토리얼 함수");
		if(a>0){
			//3 * doA(2)
			//3 * 2 * doA(1)
			//3 * 2 * 1 * doA(0)
			//3 * 2 * 1 * 1
			return a +"*"+ doA(a-1);
		}else{
			
		return 1;
	
		}
	}
	
	public static void main(String[] args) {
		string returnValue = doA(3);
		System.out.println("returnValue = "+returnValue);

	}*/
}
