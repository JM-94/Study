
public class Ex04 {
	public static void main(String[] args) {
		String str1 = "abc";
		String str2 = "def";
		
		String str3 = str1.concat(str2);
//		String str3 = str1 + str2;
		System.out.println("str3 = "+str3);
		String str4 = "abcdef".concat(str3);
		System.out.println("str4 = "+str4);
		
		String a ="���� ���� ������ 5�ð� 40�� ���Ҵ� ���ɽð� 1�ð� ���� 4�ð� 40��";
		System.out.println(a.substring(20));
		System.out.println(a.substring(2,10));
	}
}
