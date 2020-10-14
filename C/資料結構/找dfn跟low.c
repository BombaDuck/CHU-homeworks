#include<string.h>
#include <stdio.h> 
#include <stdlib.h>
#define HIGH 15
#define WIDE 15

int graph[HIGH][WIDE];
int back_edge[WIDE];
int visit[WIDE];
int visited[WIDE];

void zero();
void read_graph();
void print_graph();
void DFS();


int main(void)
{
	
	read_graph();
	zero();
	DFS();
	print_graph();
	
	
	
	
	
	system("pause");
	return 0;
}
void zero()
{
	int i,j;
	for(i=0;i<WIDE;i++)
	{
		visit[i] = -1;
	}
}
void read_graph()
{
	char filename[10];
	FILE *fp;
	int i=0,j=0;
	int read;
	printf("Plz Enter Filename(a.txt) : ");
	scanf("%s",&filename);
	
	fp = fopen(filename,"r");
	
	if(fp == NULL) printf("Reading Failed!");
	else
	{
		for(i=0;i<WIDE;i++)
		{
			for(j=0;j<WIDE;j++)
			{
				fscanf(fp,"%d",&read);
				graph[i][j] = read;
			}
		}
		/*
		while(!(feof(fp))) 
		{
			fscanf(fp,"%d",&read);
			j++;
			if(fgetc(fp) =='\n')
			{
				graph[i][j] = read;
				i++;
				j=0;
			}
		}*/
	}
}
	

void print_graph()
{
	int i,j;
	printf("      0  1  2  3  4  5  6  7  8  9 10 11 12 13 14\n");
	printf("    ---------------------------------------------\n");
	
	for(i=0;i<HIGH;i++)
	{
		printf("%3d|",i);
		for(j=0;j<WIDE;j++)
		{
			printf("%3d",graph[i][j]);
		}
		printf("\n");
	}
	
	printf("\n");
	
	for(i=0;i<WIDE;i++)
	{
		printf(" %2d",visit[i]);
	}
	

}

void DFS()
{
	int i,j=0,b,k=0,z,y=0,last_spot = -1;
	
	
	for(i=0;i<WIDE;i++)
	{
		while(graph[k][j] != 1)
		{	
		j++;
			for(z = 0;z<WIDE;z++)
			{
				if(j == visit[z])
				{
					j++;
					break;
				}
			}
				
			
			if(j>WIDE-1)
			{
				visit[i] = k; //Àx¦s¦¹ÂI 
				k = visit[i-1]; //  
				y = 1;
				j=visit[i]+1;
				
			}
			
		
			
		    if(visit[WIDE-1] != -1 )
			{
				break;
			}
		}
	

		
	//	printf("%2d %2d %2d\n",i,k,visit[i]);

		if(y==0)
		visit[i] = k;
			printf("%2d %2d %2d\n",j,k,visit[i]);
		y = 0;
		k = j;
		j=visit[i]+1;
	}
	
	
	
}
