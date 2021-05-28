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
	private Connection conn; // DB ���� ��ü
	private PreparedStatement pstmt; // Query �ۼ� ��ü
	private ResultSet rs; // Query ��� Ŀ��
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
		
		setTitle("�α���");
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

		JLabel lblPassword = new JLabel("��й�ȣ");
		lblPassword.setBounds(51, 104, 70, 35);
		lblLogin.setHorizontalAlignment(JLabel.CENTER);
		contentPane.add(lblPassword);

		tfUsername = new JTextField();
		tfUsername.setBounds(133, 53, 170, 35);
		contentPane.add(tfUsername);
		tfUsername.setColumns(10);

		joinBtn = new JButton("ȸ������");
		joinBtn.setBounds(327, 106, 90, 30);
		contentPane.add(joinBtn);

		loginBtn = new JButton("�α���");
		loginBtn.setBounds(327, 55, 90, 30);
		contentPane.add(loginBtn);


		tfPassword = new JPasswordField();
		tfPassword.setColumns(10);
		tfPassword.setBounds(133, 104, 170, 35);
		contentPane.add(tfPassword);

		setVisible(true);
 
		// ȸ������ �׼�
		joinBtn.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				JoinFrame frame = new JoinFrame();

			}
		});

		// �α��� �׼�
		loginBtn.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				conn = DB.getConnection();
				String username = tfUsername.getText();
				String password = tfPassword.getText();
				MemberDao dao = MemberDao.getInstance();
				int result = dao.findByUsernameAndPassword(username, password);
				if (result == 1) {
					// �α��� ���� �޽���
					JOptionPane.showMessageDialog(null, "�α��� ����");
					// ȸ�� ���� ����Ʈ ȭ�� �̵��� ���ÿ� username,password ���ǰ����� �ѱ�.
					MemberListFrame mlf = new MemberListFrame(username, password);
					// ���� ȭ�� ����
					
					dispose();
				} else {
					try {
						JOptionPane.showMessageDialog(null, "�α��� ����");

						if (username.equals("")) {
							JOptionPane.showMessageDialog(null, "���̵� �Է��ϼ���.");
						} else {
							JOptionPane.showMessageDialog(null, "���̵� Ʋ�Ƚ��ϴ�.");
						}

						if (password.equals("")) {
							JOptionPane.showMessageDialog(null, "��й�ȣ�� �Է��ϼ���.");
						} else {
							JOptionPane.showMessageDialog(null, "��й�ȣ�� Ʋ�Ƚ��ϴ�.");
						}

					} catch (Exception e2) {
						// TODO: handle exception
					}

				}
				
			}
		});
	}
}
