class A{
	public static int a = 10;
	public static void doA(){
		System.out.println("static doA 입니다.");
	}
	private void doB(){
		System.out.println("private doB 입니다.");
	}
	public void doC(){
		doB();
		System.out.println("static doC 입니다.");
	}
}

public class Ex01 {
	
	public static void main(String[] args) {
		A.doA();
		System.out.println(A.a);
		A a = new A();
//		A.doB();
		a.doC();
		
		//Thread라는 것들이 모여서 프로세스가 됩니다.
		
		Thread th = new Thread(new Runnable(){
			public void run(){
				for( int i = 0; i < 10000; i++){
					System.out.println("th i = "+i);
				}
			}
		});
		th.start();
		
		Thread ath = new Thread(new Runnable(){
			public void run(){
				for( int k = 0; k < 10000; k++){
					System.out.println("ath k = "+k);
				}
			}
		});
		ath.start();
				
	}
}
