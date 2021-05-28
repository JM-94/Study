import java.awt.Image;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;

public class Ex01 extends JFrame{

	Ex01(){
		getContentPane().setLayout(null);
		
		ImageIcon ii = new ImageIcon("bin/a.png");
		
		Image img = ii.getImage();
		img = img.getScaledInstance(110, 77, Image.SCALE_SMOOTH);
		ii = new ImageIcon(img);
		
		JButton btnNewButton = new JButton(ii);
		btnNewButton.setBounds(66, 108, 110, 77);
		getContentPane().add(btnNewButton);
		
		JButton b11 = new JButton(ii);
		b11.setBounds(66, 208, 110, 77);
		getContentPane().add(b11);
		
		setSize(300,500);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	
	public static void main(String[] args) {
		new Ex01();
	}
}
