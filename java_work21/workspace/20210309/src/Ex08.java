class Box{
	private String content;
	Box(){}
	Box(String contnnt){
		this.content = content;
	}
	//alt + shift +s ->s toString 만들기
	//alt + shift +s ->r getter setter 만들기
	//alt + shift +s -> 생성자 만들기
	@Override
	public String toString() {
		return "Box [content=" + content + "]";
	}
	
}
/* import java.lang.*
 * toString() 생략가능
 * 기본생성자 생략
 * this 생략
 * */


public class Ex08 {
	//oxf3 0xeee f2 xe3
	public static void main(String[] args) {
		StringBuilder stb= new StringBuilder("12");
		stb.append("34");
		System.out.println(stb.toString());
		System.out.println(stb);
		
		Box box = new Box(); //기본생성자도 생략 되어진 표현
		System.out.println(box);
		System.out.println(box.toString());
	}
}
