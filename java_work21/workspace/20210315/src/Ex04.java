import java.util.List;
import java.util.Arrays;

public class Ex04 {
	
	Ex04(){
		int arr[] = new int[3];
		arr[0] = 7;
		arr[1] = 9;
		arr[2] = 11;
		
		System.out.println("brr = "+arr[0]);
		System.out.println("brr = "+arr[1]);
		System.out.println("brr = "+arr[2]);
		
//		arr = {8,9,10} 한꺼번에 하는거 안된다
		List brr = Arrays.asList(1,2,3);
		System.out.println("brr = "+brr.get(0));
		System.out.println("brr = "+brr.get(1));
		System.out.println("brr = "+brr.get(2));
	}
	public static void main(String[] args) {
		new Ex04();
	}
}
