package Dodgeball;

import java.util.Random;

public class Spawn 
{
	private Handler handler;
	private HUD hud;
	private Random r = new Random();
	
	private int scoreKeep = 0;
	
	public Spawn(Handler handler, HUD hud)
	{
		this.handler = handler;
		this.hud = hud;
	}
	
	public void tick()
	{
		scoreKeep++;
		
		if(scoreKeep >=100)
		{
			scoreKeep = 0;
			hud.setLevel(hud.getLevel() + 1);
			
			if(hud.getLevel()==2)
				handler.addObject(new BasicEnemy(r.nextInt(TestGame.WIDTH-50),r.nextInt(TestGame.HEIGHT-50),ID.BasicEnemy,handler));
		    else if(hud.getLevel()==3)
				 handler.addObject(new BasicEnemy(r.nextInt(TestGame.WIDTH-50),r.nextInt(TestGame.HEIGHT-50),ID.BasicEnemy,handler));
			else if(hud.getLevel()==4)
				handler.addObject(new FatEnemy(r.nextInt(TestGame.WIDTH-50),r.nextInt(TestGame.HEIGHT-50),ID.FatEnemy,handler));
			else if(hud.getLevel()==5)
				handler.addObject(new FatEnemy(r.nextInt(TestGame.WIDTH-50),r.nextInt(TestGame.HEIGHT-50),ID.FatEnemy,handler));
			else if(hud.getLevel()==6)
				handler.addObject(new SmartEnemy(r.nextInt(TestGame.WIDTH-50),r.nextInt(TestGame.HEIGHT-50),ID.SmartEnemy,handler));
			else if(hud.getLevel()==7)
			{
				handler.clearEnemys();
				handler.addObject(new EnemyBoss((TestGame.WIDTH/8*3)-450,+160,ID.EnemyBoss,handler));
			}
			
			
		}
	}
}
