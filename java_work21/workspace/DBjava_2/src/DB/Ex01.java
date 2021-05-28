package DB;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Button;

public class Ex01 extends JFrame{
	public Ex01() {
		getContentPane().setLayout(null);
		
		JButton btnNewButton = new JButton("1");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnNewButton.setBounds(12, 450, 144, 59);
		getContentPane().add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("3");
		btnNewButton_1.setBounds(413, 450, 144, 59);
		getContentPane().add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("2");
		btnNewButton_2.setBounds(12, 450, 144, 59);
		getContentPane().add(btnNewButton_2);
		
		JButton btnNewButton_1_1 = new JButton("4");
		btnNewButton_1_1.setBounds(413, 450, 144, 59);
		getContentPane().add(btnNewButton_1_1);
		
		JButton btnNewButton_1_2 = new JButton("5");
		btnNewButton_1_2.setBounds(413, 450, 144, 59);
		getContentPane().add(btnNewButton_1_2);
		
		Button button = new Button("New button");
		button.setBounds(157, 172, 116, 53);
		getContentPane().add(button);
		
		setSize(600,600);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	public static void main(String[] args) {
		new Ex01();
	}
}
