class AAA{
	AAA() { /*super();*/ System.out.println("AAA 생성자");}
}
	
class BBB extends AAA{
	BBB() { /*super();*/ System.out.println("BBB 생성자");}
}
	
class CCC extends BBB{
	CCC() { /*super();*/ System.out.println("CCC 생성자");}
}
	
public class Ex02 {
	Ex02(){
		CCC ccc = new CCC();
	}
	public static void main(String[] args) {
		new Ex02();
	}
}
