import java.util.Scanner;
/*
 * ����
 * �Ҽ� ��°�ڸ����� �Է¹޾Ƽ� �Ҽ� ù°�ڸ����� ����ϼ���..
 * 
 * ����
 * ���� �Է� : 21.234
 * ��� : 21.23
 * 
 * ��Ʈ
 * double ���� int ������ �ٲܶ� �Ҽ����� �����ȴ�.
 * 21.234 - int 21
 * 212.34 - int 212
 * 2123.4 - int 2123
 * int 2123 - double 2123.0000
 */
public class Ex04 {
	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		System.out.println("�Ҽ��� ���� �Է� : ");
		
		double a = scan.nextDouble();
		System.out.println("a = " +a);
		
		a = a*100;
		System.out.println("a= "+a);
		int b = (int)a;
		System.out.println("b= "+b);
		double c = (double)b/100;
		System.out.println("���\n c = "+c);
		//int a = 10;
//		double b = a;
//		
//		double c = 20.23d;
//		int d = (int)c;
//		
//		System.out.println("a = " +a);
//		System.out.println("b = " +b);
//
//		System.out.println("c = " +c);
//		System.out.println("d = " +d);
	}
}
