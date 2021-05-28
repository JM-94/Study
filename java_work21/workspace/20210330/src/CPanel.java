import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JButton;

public class CPanel extends JPanel{
	private final JButton btnNewButton_1 = new JButton("New button");
	public CPanel() {
		setLayout(null);
		
		JLabel lblNewLabel = new JLabel("New label");
		lblNewLabel.setBounds(48, 56, 57, 15);
		add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("New label");
		lblNewLabel_1.setBounds(198, 87, 57, 15);
		add(lblNewLabel_1);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(48, 146, 97, 23);
		add(btnNewButton);
		btnNewButton_1.setBounds(293, 184, 97, 23);
		add(btnNewButton_1);
	}
	

}
