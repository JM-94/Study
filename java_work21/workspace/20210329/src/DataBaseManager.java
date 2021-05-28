import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

import javax.swing.JOptionPane;

//데이터베이스매니저클래스는 액션리스너이다...is a 관계 성립..
public class DataBaseManager implements ActionListener{

	//form 참조... 메뉴 오른쪽....
	//jar 라이브러리  add jar
	//pip install selenium
	//ctrl + shift + o
	@Override
	public void actionPerformed(ActionEvent e) {
		Connection conn = null; //데이터베이스 연결객체
		PreparedStatement pstmt = null;
		//시도해라
		try{
//			int a = 1/0;
			//oracle 연결하는 jar파일 추가 확인..
			Class.forName("oracle.jdbc.driver.OracleDriver");
			
			conn = DriverManager.getConnection("jdbc:oracle:thin:@192.168.0.103:1521:xe","AI","1234");
			pstmt = conn.prepareStatement("insert into atable values(?,?,?,?)");
			pstmt.setInt(1, Integer.parseInt(Ex01.tf_idx.getText()));
			pstmt.setString(2, Ex01.tf_name.getText());
			pstmt.setString(3, Ex01.tf_gender.getText());
			pstmt.setString(4, Ex01.tf_remark.getText());
			pstmt.executeUpdate();
			
		}
		catch (ArithmeticException ae){
			JOptionPane.showMessageDialog(null, "0으로 나눌 수 없다.");
		}
		catch (ClassNotFoundException cne){
			JOptionPane.showMessageDialog(null, "클래스 없다.");
		}
		//하다가 예외상황이 발생하면 catch로 빠져라
		catch (Exception exc){
			exc.printStackTrace();
		}
		finally {
			try{
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception closee){}
		}
		System.out.println("데이터베이스매니저..");
	}

}