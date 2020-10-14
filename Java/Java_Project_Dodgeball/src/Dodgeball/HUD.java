package Dodgeball;

import java.awt.Color;
import java.awt.Graphics;


public class HUD 
{
	public static float HEALTH = 100;
	private float greenValue = 255f;
	
	private int score = 0;
	private int level = 1;
	
	public void tick()
	{
		//HEALTH--;
		HEALTH = TestGame.clamp(HEALTH, 0, 100);
		greenValue = TestGame.clamp(greenValue, 0, 255);
		
		greenValue = HEALTH*2;
		
		score++;
	}
	
	public void render(Graphics g)
	{
		g.setColor(Color.gray);
		g.fillRect(15, 15, 200, 32);
		g.setColor(new Color(75, (int)greenValue, 0));
		g.fillRect(15, 15, (int)HEALTH * 2, 32);
		g.setColor(Color.white);
		g.drawRect(15, 15, 200, 32);
		
		g.drawString("Score : "+ score, 10, 64);
		g.drawString("level : "+ level, 10, 80);
		g.drawString("Health : "+ HEALTH, 100, 64);
	}
	
	public void score(int score)
	{
		this.score = score;
	}
	public int getScore()
	{
		return score;
	}
	public int getLevel()
	{
		return level;
	}
	public void setLevel(int level)
	{
		this.level = level;
	}
	
}