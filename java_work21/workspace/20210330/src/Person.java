// ctel + shift + f 자동정렬
public class Person {
	String name;
	Person(String name) {
		this.name = name;
	}
// alt + shift + s
	@Override
	protected void finalize() throws Throwable {
		
		super.finalize();
		System.out.println("참조관계 해제로인한 메모리상에서 삭제");
		System.out.println("name = "+name);
	}
}
