package Dodgeball;

import java.awt.Graphics;
import java.util.LinkedList;

public class Handler 
{
	LinkedList<GameObject> object = new LinkedList<GameObject>();
	
	public void tick()
	{
		for(int i = 0 ; i < object.size() ; i++)
		{
			GameObject tempObject = object.get(i);
			
			tempObject.tick();
		}
	}
	
	public void render(Graphics g)
	{
		for(int i = 0 ; i < object.size() ; i++)
		{
			GameObject tempObject = object.get(i);
			
			tempObject.render(g);
		}
	}
	
	public void clearEnemys()
	{
		for(int i = 0 ; i < object.size() ; i++)
		{
			GameObject tempObject = object.get(i);
			
			if(tempObject.getId() != ID.Player)
			{
				removeObject(tempObject);//刺激玩法
				//object.clear(); //簡單玩法
				//addObject(new Player((int)tempObject.getX(),(int)tempObject.getY(),ID.Player,this));//簡單玩法
			}
		}
	}
	
	public void addObject(GameObject object)
	{
		this.object.add(object);
	}
	
	public void removeObject(GameObject object)
	{
		this.object.remove(object);
	}
	
	
}
