import java.awt.*;
import javax.swing.*;

public class Label2044 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		JLabel nLabel = new JLabel("North");
		
		ImageIcon labelIcon = new ImageIcon("GUItip.gif");
		
		JLabel centerLabel = new JLabel(labelIcon);
		JLabel sLabel = new JLabel(labelIcon);
		
		sLabel.setText("South");
		
		JFrame app = new JFrame();
		
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		app.add(nLabel, BorderLayout.NORTH);
		app.add(centerLabel, BorderLayout.CENTER);
		app.add(sLabel, BorderLayout.SOUTH);
	
		app.setSize(300, 300);
		app.setVisible(true);
	}

}
