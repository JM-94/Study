package DB;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;


public class Final {
	/*
	 * 1.학생등록  2.학생조회  3.학생수정  4.학생삭제  5.종료
	 */

	public static void main(String[] args) throws Exception {
		

		// BufferedReader br = new BufferedReader(new InputStreamReader(fis));

		Scanner scan = new Scanner(System.in);
		while (true) {
			System.out.println("뭐할래요? 1.추가,2.검색,3수정,4삭제,5.종료  선택");
			int num = scan.nextInt();
			switch (num) {
			case 1:
				Add ad = new Add();
				ad.ad(args);
				break;
			case 2:
				SELECT se = new SELECT();
				se.se(args);
				break;
			case 3:
				Update up = new Update();
				up.up(args);
				break;
			case 4:				
				Del de = new Del();
				de.de(args);
				break;
			default:
				System.out.println("종료되었습니다.");
				break;
			}
			if(num>4)
			break;
		}
	}
}
