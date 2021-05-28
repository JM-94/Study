
public class Ex04 {
	public static void main(String[] args) {
		String str1 = "abc";
		String str2 = "def";
		
		String str3 = str1.concat(str2);
//		String str3 = str1 + str2;
		System.out.println("str3 = "+str3);
		String str4 = "abcdef".concat(str3);
		System.out.println("str4 = "+str4);
		
		String a ="오늘 집에 갈려면 5시간 40분 남았다 점심시간 1시간 수업 4시간 40분";
		System.out.println(a.substring(20));
		System.out.println(a.substring(2,10));
	}
}
