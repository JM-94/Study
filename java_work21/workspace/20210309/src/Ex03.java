
public class Ex03 {
	public static void main(String[] args) {
		String str1 = "Simple String";
		String str2 = "Simple String";

		String str3 = new String("Simple String");
		String str4 = new String("Simple String");

		if (str3.equals(str4))
			System.out.println("같은 값이다.");

		if (str1 == str2) {
			System.out.println("동일한 주소값");
		}
		if (str3 == str4) {

		} else {
			System.out.println("다른 주소값");
		}
	}
}
