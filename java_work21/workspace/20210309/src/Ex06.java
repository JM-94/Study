
public class Ex06 {
	public static void main(String[] args) {
		String a = "990925-1012999";
		System.out.println(a.replace("-"," "));
		
		char[] test = a.toCharArray();
		for(int i =0; i<test.length;i++){
			if(test[i] =='-'){
				test[i]=' ';
			}
		}
		String k =new String(test);
		System.out.println("k = "+k);
	}
}
