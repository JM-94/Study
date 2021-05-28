/*
 * 메소드영역
 * 	메소드 바이트코드, static 변수
 * 	- 프로그램 시작한후 종료될때까지 메모리상에 존재한다.
 * 스택영역
 * 	함수안의 지역변수와 매개변수
 * 	- 함수안의 지역변수와 대개변수는 함수 종료시에 자동으로 삭제한다.
 * 힙영역
 * 	개발자가 new 라는 예약어를 통해서 변수 생성시에 사용하는 영역
 * 	- 힙영역에 변수들은 null을 참조할때 자바 갈비지 컬렉션이 자동으로 삭제된다.
 */

public class Ex01 {
	public static void main(String[] args) {
		Person p1 = new Person("노사연");
		Person p2 = new Person("김건모");
		
		System.gc();
		System.runFinalization();
		
		System.out.println("종료됨");
	}
}
