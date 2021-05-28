class AA{
	public void doA() {System.out.println(11);
		
	}
}

public class Ex01 {
	Ex01(){
		int arr[] = new int[5];
		for (int i = 0; i<5; i++){
			System.out.println("arr["+i+"] = "+ arr[i]);
		}
		
		String string_arr[] = new String[5];
		for (int i = 0; i<5; i++){
			System.out.println("strint_arr["+i+"] ="+string_arr[i]);
		}
		
		AA aa_arr[] = new AA[5];
		for(int i=0; i<5;i++){
			System.out.println("aa_arr["+i+"] = "+aa_arr[i]);
		}

		aa_arr[0] = new AA();
		
		//에러 발생
		aa_arr[0].doA(); // == null.doA();
		
		aa_arr[1].doA(); // == null.doA();
		//프로세스는 여러개의 쓰레드로 이루어져있다
	}
	public static void main(String[] args) {
		new Ex01();
	}
}
