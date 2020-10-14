#include <stdio.h>
#include <stdlib.h>

int main(void){
	int x=1,z=0,k=1,num,sum=0;
 	printf("請輸入一個數字 :");
	scanf("%d",&num);
	
	for(;;)
	{
	x++;
	sum=k+z;
	z=k;
	k=sum;
	
	if(num<0)
		{
		printf("輸入的數字錯誤 請輸入一個正數"); 
		break;
		}
	else if(num==1) 
		{
		printf("總共加了 1 次"); 
		break;
		}
	else if(sum > num) 
		{
		printf("總共加了 %d 次",x);
		break;
		}
	
	}
	
 system("pause");
 return 0;
}


