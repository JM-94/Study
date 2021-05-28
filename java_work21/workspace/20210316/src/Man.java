/* 생략 문법...
 * import java.lang.;
 * this 생략가능
 * 기본생성자 생략 가능한데.... 다른 생성자 선언시 생략 불가..
 * 기본생성자에서 super(); 상속받은 클래스 기본생성자 호출...
 */
public class Man extends BusinessMan{
	private String company;
	private String position;
	Man(){
		
		System.out.println("MAN 생성자");
	}// 생략가능하다
	
	Man(String company, String position, String name){
		super(name);
		this.company = company;
		this.position = position;
//		super.name = name; // this 써도 된다
	}
	
	public void tellYourInfo(){
		System.out.println("company = "+company);
		System.out.println("position = "+position);
		tellName();
	}
	public static void main(String[] args) {
		Man man = new Man("유니텍","개발팀","홍길동");
		man.tellYourInfo();
	}
}
