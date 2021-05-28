
public class BusinessMan {
	protected String name;
	public BusinessMan() {}
	public BusinessMan(String name) {
		super();
		this.name = name;
	}
	public void tellName() {
		System.out.println("name = "+name);
	}
}
