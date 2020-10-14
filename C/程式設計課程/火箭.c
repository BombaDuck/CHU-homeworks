#include <stdio.h>
#include <stdlib.h>

int main(void){
int x,y;

for(x=1;x<10;x=x+2)
{
	for(y=10;y>x;y=y-2)
	{
		printf(" ");
	}
	
	for(y=0;y<x;y++)
	{
		printf("*");
	}
	printf("\n");
}

for(x=0;x<10;x++)
{
	printf("   ");
	
	for(y=0;y<5;y++)
	{
		printf("*");
	}
	printf("\n");
}

for(x=7;x<12;x=x+2)
{
	for(y=10;y>x;y=y-2)
	{
		printf(" ");
	}
	
	for(y=0;y<x;y++)
	{
		printf("*");
	}
	printf("\n");
}

for(x=0;x<3;x++)
{
	for(y=0;y<11;y++)
	{
		printf("*");
	}
	printf("\n");
}

for(x=5;x<11;x=x+2)
{
	for(y=11;y>x;y=y-2)
	{
		printf("*");
	}
	for(y=0;y<x;y++)
	{
		printf(" ");
	}
	for(y=11;y>x;y=y-2)
	{
		printf("*");
	}
	printf("\n");
}

for(x=0;x<6;x++)
{
	for(y=0;y<2;y++)
	{
		printf(" ");
	}
	for(y=0;y<3;y++)
	{
		printf(" *");
	}
	printf("\n");
}


 system("pause");
 return 0;
}


