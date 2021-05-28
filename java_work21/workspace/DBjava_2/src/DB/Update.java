package DB;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

public class Update {

	public static void up(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null; // DB연결된 상태(세션)을 담은 객체
        PreparedStatement pstm = null;  // SQL 문을 나타내는 객체
        ResultSet rs = null;  // 쿼리문을 날린것에 대한 반환값을 담을 객체
		try {	
			int count =0;
			STUDENT[] student = new STUDENT[50];
//			 Class.forName("oracle.jdbc.driver.OracleDriver");
//			 Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			 // 프로시저 호출
			 CallableStatement cs = conn.prepareCall("begin update_student(?,?,?,?,?); end;");
			 Scanner scan = new Scanner(System.in);
			// 입력 파라메터
			 	System.out.println("순서는? ");
				cs.setInt(1, scan.nextInt());
				scan.nextLine();
				System.out.println("이름은? ");
				cs.setString(2, scan.nextLine());				
				System.out.println("휴대폰번호는? ");
				cs.setString(3, scan.nextLine());
				System.out.println("도시는? ");
				cs.setString(4, scan.nextLine());
				System.out.println("학과는? ");
				cs.setString(5, scan.nextLine());			
			 int seq= cs.executeUpdate();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
			 
			 if ( seq ==0 )
			 {
				 System.out.println(seq+"값");
			 }
			 else
			 {
				 System.out.println(seq+"값");
			 }
			 
//			 rs.close();
			 cs.close();
			 conn.close();
			 } catch(Exception e){
			 e.printStackTrace();
			 }
	}

}
