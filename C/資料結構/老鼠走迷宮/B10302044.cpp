#include<string.h>
#include <stdio.h> 
#include <stdlib.h>
#include<windows.h>
#include <time.h>
#define HIGH 24
#define WIDE 60
#define health 500

char maze[HIGH][WIDE];
int end1,end2,success = 0;
int starti=0,startj=0;
int healths = 500;
int map[24][60];
void print_maze();
void initialization();
void read_maze();
void run_maze();
void SetColor(int,int);
void gotoxy(int xpos, int ypos);
void toint();

typedef struct
{
	int x;
	int y;
}Point;

Point pt[health];

int main(void)
{
	Point start;
	initialization();
	read_maze();
	toint();
	printf("\nClicking To Start.....\n");


	system("pause");

	run_maze();

	//print_maze();
	system("pause");
	return 0;
}
void toint()
{
	char x[2];
	int i,j,k;
	for(i=0;i<HIGH;i++)
		for(j=0;j<WIDE;j++)
		{
			if(maze[i][j] == '#')
			{
				map[i][j] = 4;
			}
			else if(maze[i][j] == '$')
			{
				map[i][j] = 5;
			}
			else if(maze[i][j] == '+')
			{
				map[i][j] = 6;
			}
			else if(maze[i][j] == '-')
			{
				map[i][j] = 7;
			}
			else if(maze[i][j] == '*')
			{
				map[i][j] = 8;
			}
			else if(maze[i][j] == '@')
			{
				map[i][j] = 3;
			}
			else
			{
				x[0] = maze[i][j];
				map[i][j] = atoi(x);
			}
		}	
}
void initialization()
{
	int i,j;
	for(i=0;i<HIGH;i++)
		for(j=0;j<WIDE;j++)
		{
			maze[i][j] = -1;
		}

}
void print_maze()
{
	int i,j;
	
	
	for(i=0;i<HIGH;i++)
	{
		
		for(j=0;j<WIDE;j++)
		{
			if (map[i][j]== 1 )
			{
				SetColor(7,6);
				printf("█");	
			}
			else if(map[i][j]== 0)
			{
				SetColor(7,0);
				printf("  ");
			}
			else if(map[i][j]==5)
			{
				SetColor(6,0);
				printf("＄");
			}
			else if(map[i][j]==8)
			{
				SetColor(0,3);
				printf("＊");
			}
			else if(map[i][j]==4)
			{
				SetColor(7,3);
				printf("Ｅ");
				
				end1 = i;
				end2 = j;
			}
			else if(map[i][j]==3)
			{
				SetColor(6,0);
				printf("★");
				
			}
			else if(map[i][j]==6)
			{
				SetColor(4,0);
				printf("＋");
			}
			else if(map[i][j] ==7)
			{
				SetColor(7,0);
				printf("－");
			}
			else if(map[i][j] ==2)
			{
				SetColor(7,0);
				printf("．");
			}
			else if(map[i][j] ==9)
			{
				SetColor(7,0);
				printf("Ｘ");
			}
			else
			{
				SetColor(7,0);
				printf("%2c",maze[i][j]);
			}
			
		}
		SetColor(0,7);
		
	}
	

	
}
void read_maze()
{
	char filename[10];
	FILE *fp;
	int i=0,j=0;
	
	printf("Plz Enter Filename(a.txt) : ");
	scanf("%s",&filename);
	
	fp = fopen(filename,"r");
	
	if(fp == NULL) printf("Reading Failed!");
	else
	{
		
		while(!(feof(fp))) 
		{
			fscanf(fp,"%s",&maze[i][j]);
			j++;
			if(fgetc(fp) =='\n')
			{
				i++;
				j=0;
			}
		}
	
	}
	maze[0][0] = '@';
}
void SetColor(int f=7,int b=0)
{
    unsigned short ForeColor=f+16*b;
    HANDLE hCon = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hCon,ForeColor);
}
void run_maze()
{	
	
		print_maze();
		
		int i=0,j=0;
		int z=0,p=0;

		
	while((pt[z].x !=end1) || (pt[z].y != end2)){
		
		_sleep(10);
		
	
		
	
	
		
		healths --;
		printf("\n\n\n 剩餘生命值 = %d",healths);

		if(map[pt[z].x+1][pt[z].y+1] != 1 && map[pt[z].x+1][pt[z].y+1] !=2 && map[pt[z].x+1][pt[z].y+1] != 9) //右下 
		{
			if(map[pt[z].x+1][pt[z].y+1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x+1][pt[z].y+1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x+1][pt[z].y+1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x+1][pt[z].y+1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x+1;
			pt[z+1].y = pt[z].y+1;
			map[pt[z+1].x][pt[z+1].y] = 3;
			z++;
	
		}
		else if(map[pt[z].x-1][pt[z].y] != 1 && map[pt[z].x-1][pt[z].y] != 2&& map[pt[z].x-1][pt[z].y] != 9) //上 
		{
			if(map[pt[z].x-1][pt[z].y] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x-1][pt[z].y] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x-1][pt[z].y] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x-1][pt[z].y] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x-1;	
			pt[z+1].y = pt[z].y;
			z++;
			map[pt[z].x][pt[z].y] = 3;
		
		}
		else if(map[pt[z].x+1][pt[z].y-1] != 1&& map[pt[z].x+1][pt[z].y-1] != 2&& map[pt[z].x+1][pt[z].y-1] != 9) //左上 
		{
			if(map[pt[z].x+1][pt[z].y-1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x+1][pt[z].y-1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x+1][pt[z].y-1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x+1][pt[z].y-1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x+1;	
			pt[z+1].y = pt[z].y-1;
			z++;
			map[pt[z].x][pt[z].y] = 3;
		
		}
		else if(map[pt[z].x-1][pt[z].y+1] != 1 && map[pt[z].x-1][pt[z].y+1] != 2&& map[pt[z].x-1][pt[z].y+1] != 9) //右上 
		{
			if(map[pt[z].x-1][pt[z].y+1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x-1][pt[z].y+1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x-1][pt[z].y+1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x-1][pt[z].y+1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x-1;	
			pt[z+1].y = pt[z].y+1;
			z++;
			map[pt[z].x][pt[z].y] = 3;
		
		}
		else if(map[pt[z].x+1][pt[z].y] != 1 && map[pt[z].x+1][pt[z].y] != 2&& map[pt[z].x+1][pt[z].y] != 9) //下 
		{
			if(map[pt[z].x+1][pt[z].y] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x+1][pt[z].y] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x+1][pt[z].y] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x+1][pt[z].y] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x+1;	
			pt[z+1].y = pt[z].y;
			z++;
			map[pt[z].x][pt[z].y] = 3;
		
			
		}
		else if(map[pt[z].x-1][pt[z].y-1] != 1 && map[pt[z].x-1][pt[z].y-1] != 2&& map[pt[z].x-1][pt[z].y-1] != 9) //左下 
		{
			if(map[pt[z].x-1][pt[z].y-1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x-1][pt[z].y-1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x-1][pt[z].y-1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x-1][pt[z].y-1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x-1;	
			pt[z+1].y = pt[z].y-1;
			z++;
			map[pt[z].x][pt[z].y] = 3;
		
		}
		else if(map[pt[z].x][pt[z].y-1] != 1 && map[pt[z].x][pt[z].y-1] != 2&& map[pt[z].x][pt[z].y-1] != 9) //左 
		{
			if(map[pt[z].x][pt[z].y-1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x][pt[z].y-1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x][pt[z].y-1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x][pt[z].y-1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x;	
			pt[z+1].y = pt[z].y-1;
			z++;
			map[pt[z].x][pt[z].y] = 3;
	
		} 
		
		else if(map[pt[z].x][pt[z].y+1] != 1 && map[pt[z].x][pt[z].y+1] != 2&& map[pt[z].x][pt[z].y+1] != 9) //右 
		{
			if(map[pt[z].x][pt[z].y+1] == 5)
			{
				healths = healths+100;
			}
			else if(map[pt[z].x][pt[z].y+1] == 6)
			{
				healths = healths+30;
			}
			else if(map[pt[z].x][pt[z].y+1] == 7)
			{
				healths = healths+50;
			}
			else if(map[pt[z].x][pt[z].y+1] == 8)
			{
				healths = healths+80;
			}
			map[pt[z].x][pt[z].y] = 2;
			pt[z+1].x = pt[z].x;	
			pt[z+1].y = pt[z].y+1;
			z++;
			map[pt[z].x][pt[z].y] = 3;
	
		}
		else
		{	
			
			pt[z+1].x = pt[z-1].x;
			pt[z+1].y = pt[z-1].y;
			map[pt[z].x][pt[z].y] = 9;
			z--;
			map[pt[z].x][pt[z].y] = 3;
		}
		gotoxy(0,4);
		print_maze();
		
		
	}

}
void gotoxy(int xpos,int ypos)//設置列印座標 
{

  COORD scrn;
  HANDLE hOuput = GetStdHandle(STD_OUTPUT_HANDLE);
  scrn.X = xpos; scrn.Y = ypos;
  SetConsoleCursorPosition(hOuput,scrn);

}

