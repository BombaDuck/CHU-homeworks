package Dodgeball;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.util.Random;

public class EnemyBossBullet extends GameObject 
{
	private Handler handler;
	Random r = new Random();
	
	public EnemyBossBullet(int x, int y, ID id, Handler handler)
	{
		super(x,y,id);
		
		this.handler = handler;
		
		velY = (r.nextInt(5 - -5)+ -5);
		velX = 5;
	}

	public Rectangle getBounds()
	{
		return new Rectangle((int)x, (int)y, 16, 16);
	}

	public void tick() 
	{
		x += velX;
		y += velY;
		
		if(y <= 0 || y >= TestGame.WIDTH-32) velY *=-1;
		//if(x <= 0 || x >= TestGame.HEIGHT-16) velX *=-1;
		
		if(y >= TestGame.HEIGHT)handler.removeObject(this);
		
		handler.addObject(new Trail(x, y,ID.Trial, Color.red, 16, 16, 0.02f, handler));
	}

	public void render(Graphics g) 
	{
		g.setColor(Color.red);
		g.fillRect((int)x, (int)y, 16, 16);
		
	}
}
