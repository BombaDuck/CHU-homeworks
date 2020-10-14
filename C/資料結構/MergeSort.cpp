#include<string.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define LENGTH 64

int array[LENGTH];
int ass,left,right;

void NewArray();
void PrintArray();
void Sort();
void findAss();
void switch_to_head();
void SortArray();
void switchArray();
void SortAss();

int main(void)
{
	srand(time(NULL));
	
	printf("產生2段32個亂數 : \n");
	NewArray();
//	PrintArray();
	
//	printf("排序2段32個亂數 : \n");
	Sort();
	PrintArray();
	
	printf("找屁股 : \n");
	findAss();	
	PrintArray();
	
	printf("最大的屁股移到前面 : \n");
	switch_to_head();
	PrintArray();
	
	printf("用屁股大小排順序 : \n");
	SortArray();	
	PrintArray();
	
	printf("交換排序 : \n");
	switchArray();	
	PrintArray();
	
	printf("把屁股整好 : \n");
	SortAss();	
	PrintArray();
	
	system("pause");
	return 0;
}
void NewArray()
{
	int i,j,number;
	
	for(i=0;i<LENGTH;i++)
	{
		number = (rand()%64)+1;
	
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
}
void PrintArray()
{
	int i;
	
	for(i=0;i<LENGTH;i++)
	{
		if(i%8==0 && i!= 0)
		printf(" | ");
		
		if(i%32==0 && i!= 0)
		printf("\n");
		
		printf("%3d",array[i]);

	}
	printf("\n\n");
}
void Sort()
{
	 int i,j,k,z;
	
	 for (i = 1; i < 32; i++) 
	 { 
	    z = array[i];
        for ( j = i-1 ; j>=0 && array[j] > z ; j--) 
		{
            array[j+1] = array[j];
        }
        array[j+1] = z;
	}
	
	for (i = 33; i < LENGTH; i++) 
	 { 
	    z = array[i];
        for (j=i-1;j>=32 && array[j]>z;j--) 
		{
            array[j+1] = array[j];
        }
        array[j+1] = z;
	}

}
void findAss()
{
	int i=0,j=0,temp;
	
	left = 31;
	right = 63;
	ass = 24;
	for(i=0;i<8;i++)
	{
		if( array[right] > array[left] )
		{
			temp = array[ass];
			array[ass] = array[right];
			array[right] = temp;
			right--;
			ass++;
		}
		else
		left--;
	}

	for(i=LENGTH-7;i<LENGTH;i++)
	{
		temp = array[i];
        for ( j = i-1 ; j>=56 && array[j] > temp ; j--) 
		{
            array[j+1] = array[j];
        }
        array[j+1] = temp;
	}	
}
void switch_to_head()
{
	int i,j,temp;
	j=24;
	for(i=0;i<8;i++)
	{
		temp = array[j];
		array[j]=array[i];
		array[i] = temp;
		j++;
	}	
}
void SortArray()
{
	int i,j,temp;
	left = 15;
	right = 23;
	for( left = 15 ; left < LENGTH-8 ; left=left+8 )
	{
		for(right = left + 8; right < LENGTH ; right = right + 8)
		{
		//	printf("%4d %4d\n",array[left],array[right]);
			if(array[left] > array[right])
			{
				j=right-7;
				for(i=left-7;i<=left;i++)
				{
					temp = array[j];
					array[j] = array[i];
					array[i] = temp;
					j++;	
				}	
			}
		}
	}
}
void switchArray()
{
	int i,j,temp,left_times=0,right_times=0;
	ass = 0;
	left = 8;
	right = 16;
	
	for(i=0 ; i <56 ; i++ )
	{
		if(left_times==8)
		{
			left = left +8;
			left_times=0;
		}
		if(right_times==8)
		{
			right = right +8;
			right_times=0;
		}
	//	printf("%d\n",right);
		
		if(right > 55)
		{
			right = 55;
		}
		if(left > 63)
		{
			left = 63;
		}
		
		if(array[left] < array[right])
		{
			temp = array[left];
			array[left] = array[ass];
			array[ass] = temp;
			left++;
			ass++;
			left_times++;
		}
		else if(array[right] < array[left])
		{
			temp = array[right];
			array[right] = array[ass];
			array[ass] = temp;
			right++;
			ass++;
			right_times++;
		}
	}
	
}
void SortAss()
{
	int i,j,z;
	
	for (i = 57; i < 64; i++) 
	 { 
	    z = array[i];
        for ( j = i-1 ; j>=0 && array[j] > z ; j--) 
		{
            array[j+1] = array[j];
        }
        array[j+1] = z;
	}
	
}
	// 0  1  2  3  4  5  6  7  ||  8  9 10 11 12 13 14 15 || 16 17 18 19 20 21 22 23 || 24 25 26 27 28 29 30 31 || 
	// 32 33 34 35 36 37 38 39 || 40 41 42 43 44 45 46 47 || 48 49 50 51 52 53 54 55 || 56 57 58 59 60 61 62 63 ||













































