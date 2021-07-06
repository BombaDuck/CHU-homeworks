#include <stdio.h>
#include <stdlib.h>

int main(void){
int n,i=2,h;

printf("請輸入一個數字: ");
scanf("%d",&n);
for(;n>1;)
{
	if(n%i==0)
	{
		n=n/i;
		printf("%d ",i);
	}
	else
	{
		i++;
	}
}
printf("\n");

 system("pause");
 return 0;
}


