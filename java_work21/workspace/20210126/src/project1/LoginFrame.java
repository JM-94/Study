package project1;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;

public class LoginFrame extends JFrame {

	TimeFunction tf = new TimeFunction();
	private JPasswordField tfPassword;
	private JPanel contentPane;
	private JTextField tfUsername;
	private JButton loginBtn, joinBtn, findbtn, OutBtn;
	private Connection conn; // DB 연결 객체
	private PreparedStatement pstmt; // Query 작성 객체
	private ResultSet rs; // Query 결과 커서
	public int Time = 0;
	public int seat = 0;
	
	/*
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					LoginFrame frame = new LoginFrame();

				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public LoginFrame() {
		
		setTitle("로그인");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(481, 260);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		JLabel lblLogin = new JLabel("ID");
		lblLogin.setBounds(37, 53, 70, 35);
		lblLogin.setHorizontalAlignment(JLabel.CENTER);
		contentPane.add(lblLogin);

		JLabel lblPassword = new JLabel("비밀번호");
		lblPassword.setBounds(51, 104, 70, 35);
		lblLogin.setHorizontalAlignment(JLabel.CENTER);
		contentPane.add(lblPassword);

		tfUsername = new JTextField();
		tfUsername.setBounds(133, 53, 170, 35);
		contentPane.add(tfUsername);
		tfUsername.setColumns(10);

		joinBtn = new JButton("회원가입");
		joinBtn.setBounds(327, 106, 90, 30);
		contentPane.add(joinBtn);

		loginBtn = new JButton("로그인");
		loginBtn.setBounds(327, 55, 90, 30);
		contentPane.add(loginBtn);


		tfPassword = new JPasswordField();
		tfPassword.setColumns(10);
		tfPassword.setBounds(133, 104, 170, 35);
		contentPane.add(tfPassword);

		setVisible(true);
 
		// 회원가입 액션
		joinBtn.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				JoinFrame frame = new JoinFrame();

			}
		});

		// 로그인 액션
		loginBtn.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				conn = DB.getConnection();
				String username = tfUsername.getText();
				String password = tfPassword.getText();
				MemberDao dao = MemberDao.getInstance();
				int result = dao.findByUsernameAndPassword(username, password);
				if (result == 1) {
					// 로그인 성공 메시지
					JOptionPane.showMessageDialog(null, "로그인 성공");
					// 회원 정보 리스트 화면 이동과 동시에 username,password 세션값으로 넘김.
					MemberListFrame mlf = new MemberListFrame(username, password);
					// 현재 화면 종료
					
					dispose();
				} else {
					try {
						JOptionPane.showMessageDialog(null, "로그인 실패");

						if (username.equals("")) {
							JOptionPane.showMessageDialog(null, "아이디를 입력하세요.");
						} else {
							JOptionPane.showMessageDialog(null, "아이디가 틀렸습니다.");
						}

						if (password.equals("")) {
							JOptionPane.showMessageDialog(null, "비밀번호를 입력하세요.");
						} else {
							JOptionPane.showMessageDialog(null, "비밀번호가 틀렸습니다.");
						}

					} catch (Exception e2) {
						// TODO: handle exception
					}

				}
				
			}
		});
	}
}
