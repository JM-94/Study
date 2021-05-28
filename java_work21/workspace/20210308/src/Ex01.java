class StaticValues{
	static int A = 10; //static 대문자가 표준
	int b = 20;
}

class A{
	public void doPrintStaticA(){ 
		System.out.println("SV.A = "+StaticValues.A++);
		StaticValues sv = new StaticValues();
		System.out.println("SV.b = "+sv.b++);
		;}
}
class B{
	public void doPrintStaticA(){ System.out.println("SV.A = "+StaticValues.A++);}
	
}
public class Ex01 {
	/*
	 * 데이터 영역 
	 * 값을 저장 .. 프로그램 시작에서 종료시까지
	 * 
	 * -> 싱글톤..
	 * 
	 * 스텍영역
	 * auto int a = 10;
	 * 함수에서 기본변수를 선언시에 사용하고.. 함수종료할때 메모리에서 삭제..
	 * 힙영역
	 * molloc calloc realloc free 개발자가 사용해서 직접.. 메모리 할당 및 삭제
	 * c++
	 * malloc free... new ~ delete...
	 */
	
	public static void main(String[] args) {
		A a = new A();
		a.doPrintStaticA();
		B b = new B();
		b.doPrintStaticA();
		System.out.println("SV.A = "+StaticValues.A);
	}
}
