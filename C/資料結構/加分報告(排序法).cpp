#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define LENGTH 100

int array[LENGTH];

int BubbleA[LENGTH];
int SelectionA[LENGTH];
int InsertionA[LENGTH];

int BubbleTimes = 0;
int SelectionTimes = 0;
int InsertionTimes = 0;

void newArray();
void BubbleSort();
void SelectionSort();
void InsertionSort();
void cleanArray();
void PrintfAll();

int main(void)
{
	int i,j;
	
	srand(time(NULL));
	
	printf("< 按任意案件後產生亂數陣列 >.........");
	system("pause");
	
	for(i=0;i<100;i++)
	{
		newArray();
		
		printf("< 第%d個亂數陣列 >\n",i+1);
		
		for(j=0;j<LENGTH;j++)
		{
			if(j%10==0) //每印10個數字換一行 
			printf("\n");
			printf("%3d ",array[j]); //固定給3個位置 
		}
		printf("\n\n"); 
		BubbleSort();
    	SelectionSort();
		InsertionSort();
		cleanArray();
	}
	
	
	PrintfAll();
	
	
	system("pause");
	return 0;
}
void newArray()
{
	int i,j,number;
	
	
	for(i=0;i<LENGTH;i++)
	{
		number = (rand()%100)+1;
	
		for(j=0;j<i;j++)
		{
			if(array[j] == number)
			{
				i--;
				break;
			}
		} 
		if(j==i)
		array[i] = number;
	}
	
	for(i=0;i<LENGTH;i++)
	{
		BubbleA[i] = array[i];
		SelectionA[i] = array[i];
		InsertionA[i] = array[i];
	}
	
	
}
void cleanArray()
{
	int i;
	
	for(i=0;i<LENGTH;i++)
	{
		array[i] = 0;
	}
}
void PrintfAll()
{
	int i,j;
	
	BubbleTimes = BubbleTimes/LENGTH;
	SelectionTimes = SelectionTimes/LENGTH;
 	InsertionTimes = InsertionTimes/LENGTH;
	
	
	
	
	printf("\n\n");
	
	printf("BubbleSort後結果 : ");
	for(i=0;i<LENGTH;i++)
	{
		if(i%10==0)
		printf("\n");
		printf("%3d ",BubbleA[i]);
	}
	printf("\n平均(%d次)花費%d次\n\n",LENGTH,BubbleTimes);
	
	printf("SelectionSort後結果 : ");
	for(i=0;i<LENGTH;i++)
	{
		if(i%10 == 0)
		printf("\n");
		printf("%3d ",SelectionA[i]);
	}
	printf("\n平均(%d次)花費%d次\n\n",LENGTH,SelectionTimes);
	
	printf("InsertionSort後結果 : ");
	for(i=0;i<LENGTH;i++)
	{
		if(i%10 == 0)
		printf("\n");
		printf("%3d ",InsertionA[i]);
	}
	printf("\n平均(%d次)花費%d次\n\n",LENGTH,InsertionTimes);
	
	
	
}

void BubbleSort()
{
	int i,j,k,z;
	for(i=LENGTH-1;i>0;i--)
	{
		z=0;
		for(j=0;j<i;j++)
		{
			if(BubbleA[j]>BubbleA[j+1]) //前一個數字大於後一個數字的話 
			{
				k = BubbleA[j+1];  //交換 
				BubbleA[j+1] = BubbleA[j];
				BubbleA[j] = k;
				z = 1; //紀錄是否有交換 
			}
			BubbleTimes++;
		}
		if(z == 0) //沒有換的話跳出 
		break;
	}

	
}
void SelectionSort()
{
	int i,j,k,z;
	for(i=0;i<LENGTH-1;i++)
	{
		for(j=i+1;j<LENGTH;j++)
		{
			if(SelectionA[i]>SelectionA[j]) 
			{
				k = SelectionA[j];  //交換 
				SelectionA[j] = SelectionA[i];
				SelectionA[i] = k;
			}
			SelectionTimes++;
		}
	}
}
void InsertionSort()
{
	int i,j,k,z;
	
	 for (i = 1; i < LENGTH; i++) 
	 { 
	    z = InsertionA[i];
        for (j=i-1;j>=0 && InsertionA[j]>z;j--) 
		{
            InsertionA[j+1] = InsertionA[j];
            InsertionTimes++;
        }
        InsertionA[j+1] = z;
   		InsertionTimes++;

	}
}


































