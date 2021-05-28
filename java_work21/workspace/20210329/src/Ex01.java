import javax.swing.JButton;
import javax.swing.JFrame;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JLabel;
import javax.swing.JTextField;
import java.awt.Font;

/*
 * 화면 구현 하는 GUI -> 그래픽 사용자 도구
 * 
 * java -> jframe, javaFx
 * c# -> windowForm
 * python -> pyQt5,matplotlib.pyplot
 */
public class Ex01 extends JFrame{
	
	JButton btn1 = new JButton("입력");
	DataBaseManager dbm = new DataBaseManager();
	public static JTextField tf_idx;
	public static JTextField tf_name;
	public static JTextField tf_gender;
	public static JTextField tf_remark;
	
	//Ex01 은 JFrame
	Ex01(){
		getContentPane().setLayout(null); //버튼 꽉 차는 거 지워라
		
		JLabel lblNewLabel = new JLabel("IDX");
		lblNewLabel.setBounds(12, 10, 100, 30);
		getContentPane().add(lblNewLabel);
		
		JLabel lblName = new JLabel("NAME");
		lblName.setBounds(12, 55, 100, 30);
		getContentPane().add(lblName);
		
		JLabel lblGender = new JLabel("GENDER");
		lblGender.setBounds(12, 100, 100, 30);
		getContentPane().add(lblGender);
		
		JLabel lblRemark = new JLabel("REMARK");
		lblRemark.setBounds(12, 150, 100, 30);
		getContentPane().add(lblRemark);
		
		tf_idx = new JTextField();
		tf_idx.setFont(new Font("Constantia", Font.PLAIN, 12));
		tf_idx.setBounds(95, 15, 155, 25);
		getContentPane().add(tf_idx);
		tf_idx.setColumns(10);
		
		tf_name = new JTextField();
		tf_name.setFont(new Font("Constantia", Font.PLAIN, 12));
		tf_name.setColumns(10);
		tf_name.setBounds(95, 60, 155, 25);
		getContentPane().add(tf_name);
		
		tf_gender = new JTextField();
		tf_gender.setFont(new Font("Constantia", Font.PLAIN, 12));
		tf_gender.setColumns(10);
		tf_gender.setBounds(95, 105, 155, 25);
		getContentPane().add(tf_gender);
		
		tf_remark = new JTextField();
		tf_remark.setFont(new Font("Constantia", Font.PLAIN, 12));
		tf_remark.setColumns(10);
		tf_remark.setBounds(95, 155, 155, 25);
		getContentPane().add(tf_remark);
		
		btn1.setBounds(275,155,100,30);
//		btn1.addActionListener(new ActionListener() {
//			
//			@Override
//			public void actionPerformed(ActionEvent e) {
//				System.out.println("이거는 인터페이스");
//			}
//		});
//		
//		btn1.addActionListener((e)-> {System.out.println("람다...");});
		btn1.addActionListener(dbm);
		
		super.add(btn1);
		
		setSize(500, 600);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
//		for(int i =0; i<10; i++){
//			JFrame jf = new JFrame(i+"");
//			jf.setSize(500,600);
//			jf.setVisible(true);
//		}
	}
	public static void main(String[] args) {
	new Ex01();	
	}
}
