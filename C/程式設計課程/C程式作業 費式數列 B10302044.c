#include <stdio.h>
#include <stdlib.h>

int main(void){
	int x=1,z=0,k=1,num,sum=0;
 	printf("�п�J�@�ӼƦr :");
	scanf("%d",&num);
	
	for(;;)
	{
	x++;
	sum=k+z;
	z=k;
	k=sum;
	
	if(num<0)
		{
		printf("��J���Ʀr���~ �п�J�@�ӥ���"); 
		break;
		}
	else if(num==1) 
		{
		printf("�`�@�[�F 1 ��"); 
		break;
		}
	else if(sum > num) 
		{
		printf("�`�@�[�F %d ��",x);
		break;
		}
	
	}
	
 system("pause");
 return 0;
}


