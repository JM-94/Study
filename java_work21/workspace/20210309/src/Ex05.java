import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ex05 {
	public static void main(String[] args) throws IOException {
		String k = 11 + "aa";
		
		String z = 2 + "";
		String z1 = String.valueOf(22);
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("�Է� : ");
		String a = br.readLine();
		System.out.println("a = "+a);
		
		int b =Integer.parseInt(a) + 10;
		System.out.println("b = "+b);
		
		String c = String.valueOf(b);
		System.out.println("c = "+c);
		
//		'-' +-+ *-* +_+ *_* '_' '��' '��' '��' '��' '��' '��' '��' '��' +��+ *��*
	}
}
