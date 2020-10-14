#include <stdlib.h>
#include <stdio.h>

int j=0,n=0,len = 0,sum = 0,steps[100];

void printSum() 
{
	printf("走法 = ");
	for (int i = 0; i < len; i++)
	printf(" %d",steps[i] );
	printf("\n");
}
void compute(int stair) 
{	
//	printf(" out: %d",stair );
	if (stair < 0) return;
	if (stair == 0) 
	{
		printSum();
		sum++;
		return;
	}
//	printf(" %d",stair );
	for (int i = 1; i <= 2; i++) 
	{
		steps[len] = i;
//		printf(" %d",steps[len] );
		len++;
		compute(stair - i);
		len--;
	}
}
int main(void)
{
	while(1)
	{
		printf("請輸入樓梯階層數 : ");
		scanf("%d",&n);
		printf("-------------------------------\n");
		if(n==0)
			printf("0種走法\n\n");
		if (n>=1)
		{
			compute(n);
			printf("\n共有 : %d種走法 \n\n",sum);
		}
		sum =0;
	}
	system("pause");
	return 0;
}




