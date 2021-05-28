// c언어 제어문 주소값 함수형
// java 언어 class 객체지향형 프로 그래밍
class A{
	int a = 20;
	int b = 30;
	public void doA(){
		System.out.println("doA 함수입니다.");
	}
}

public class Ex01 extends A {
	int c = 40;
	Ex01(){
		System.out.println(a);
		System.out.println(b);
		doA();
	}
	public static void main(String[] args) {
		Ex01 aa = new Ex01();
	}
}
