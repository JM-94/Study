
public class Ex04 {
	public static void main(String[] args) {
		System.out.println("프로그램 시작");
		doA(12);
		doA(13);
		System.out.println("프로그램 끝");		
		
	}
	// 메서드 오버로딩 기법 매개변수가 다르면 같은 이름 사용 가능
		public static void doA(int age){
			System.out.println("doA시작");
			System.out.println("age ="+age);
			System.out.println("doA끝");
		}
		public static void doA(int age,int height){
			System.out.println("doA시작");
			System.out.println("age ="+age);
			System.out.println("doA끝");
		}
	}


