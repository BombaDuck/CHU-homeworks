package Dodgeball;

import java.awt.*;
import java.util.Random;

import javax.swing.JOptionPane;

public class Player extends GameObject
{
	Random r = new Random();
	Handler handler;
	HUD hud;
	private int score = 0;
	public Player(int x, int y, ID id, Handler handler) 
	{
		super(x, y, id);
		this.handler = handler;

	}
	
	public Rectangle getBounds()
	{
		return new Rectangle((int)x,(int)y,32,32);
	}
	
	public void tick()
	{
		x += velX;
		y += velY;
		
		x = TestGame.clamp(x, 0, TestGame.WIDTH - 37);
		y = TestGame.clamp(y, 0, TestGame.HEIGHT - 60);
		
		handler.addObject(new Trail(x, y,ID.Trial, Color.white, 32, 32, 0.08f, handler));
		
		collision();
	}
	
	private void collision() 
	{
		for(int i = 0; i<handler.object.size() ; i++)
		{
			GameObject tempObject = handler.object.get(i);
			
			if(tempObject.getId() == ID.BasicEnemy || tempObject.getId() == ID.FatEnemy || tempObject.getId() == ID.SmartEnemy)
				if(getBounds().intersects(tempObject.getBounds()))
				{
					HUD.HEALTH -=2;
					if(HUD.HEALTH == 0)
					{
						JOptionPane.showMessageDialog(null, " You Died! " );
						System.exit(1);
					}
					
					
				}
		}
	}

	public void render(Graphics g)
	{	
		g.setColor(Color.white);
		g.fillRect((int)x, (int)y, 32, 32);
	}
			
	
}
