package DB;

public class STUDENT {
	private int STUDENTNO;
	private String NAME ;
	private String PHONENUMBER;
	private String CITY ;
	private String DEPARTMENT;
	// 1 setter...
	// 2 생성자로...
	public STUDENT(int STUDENTNO,String NAME,String PHONENUMBER, String CITY, String DEPARTMENT ){
		// TODO Auto-generated constructor stub
		this.STUDENTNO = STUDENTNO;
		this.NAME = NAME;
		this.PHONENUMBER = PHONENUMBER;
		this.CITY = CITY;
		this.DEPARTMENT = DEPARTMENT;
	}
	
	public void print(){
		System.out.println("학생번호는 "+STUDENTNO+"입니다");
		System.out.println("이름은 "+NAME+"입니다");
		System.out.println("휴대폰번호는 "+PHONENUMBER+"입니다");
		System.out.println("도시는 "+CITY+"입니다");
		System.out.println("학과는 "+DEPARTMENT+"입니다");
		System.out.println();
		System.out.println();
	}
}
