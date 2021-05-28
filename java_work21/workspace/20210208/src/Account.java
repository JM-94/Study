
public class Account {
	String name;
	int al;
	
	public void setName(String a){
		name = a;
	}
	//al 설정
	public void setAl(int value){
		al = value;
	}
	//al 출력
	public void printAL(){
		System.out.println("name = "+name);
		System.out.println("al = "+al);
	}
}
