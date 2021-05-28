import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Ex02 {
	public static void main(String[] args)throws NumberFormatException, IOException {
	
		Scanner scan = new Scanner(System.in);
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		System.out.println("a 숫자 입력:");
		int a = scan.nextInt();
		System.out.println("b 숫자 입력 :");
		int b= Integer.parseInt(br.readLine());
				
				if(a>b){
					System.out.println("a - b = "+ (a-b));
				}else{
					System.out.println("b-a="+(b-a));
				}
		
	}
	
}
