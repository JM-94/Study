package DB;

import java.sql.*;
import oracle.jdbc.*;

public class SELECT {

	public static void se(String[] args) {
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
			 CallableStatement cs = conn.prepareCall("begin SELECTALLCOLUMN_student(?); end;");
//			 CallableStatement cs = conn.prepareCall("begin singlerow_BUYTBL(?,?); end;");
			 // 입력 파라메터
//			 cs.setInt(1, 30);
			 // 출력 파라메터
			 cs.registerOutParameter(1, oracle.jdbc.OracleTypes.CURSOR);
			 // ?가 1개 -> 1
			 // 실행
			 cs.execute();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
			 rs = (ResultSet)cs.getObject(1);
			 // ?가 1개 ->1
			 
			 while(rs.next()) {
				 
					/*
					 *  int STUDENTNO = rs.getInt(1);
					 *  String name = rs.getString(2);
					 *  String PHONENUMBER = rs.getString(3);
					 *  String CITY = rs.getString(4);
					 *  int DEPARTMENT = rs.getInt(6);                   
					 */
				 student[count]=new STUDENT(rs.getInt("STUDENTNO"),rs.getString("NAME"),rs.getString("PHONENUMBER"),
					 rs.getString("CITY"),rs.getString("DEPARTMENT"));
				 //생성자 타입에 맞춰서 넣기
			 count++;
			 }
			 
			 for (int i=0;student.length>i;i++)
			 {
				if(student[i] != null)
				{
					student[i].print();
				}
			 }
			 
			 rs.close();
			 cs.close();
			 conn.close();
			 } catch(Exception e){
			 e.printStackTrace();
			 }
	}

}
