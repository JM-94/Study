import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Ex09 {
	public static void main(String[] args) throws FileNotFoundException {
		Scanner scan = new Scanner(new File("b.txt"));
		int a = scan.nextInt();
		int b = scan.nextInt();
		int c= scan.nextInt();
		
		System.out.println("a = "+a);
		System.out.println("b = "+b);
		System.out.println("c = "+c);
		scan.close();
	}
}
