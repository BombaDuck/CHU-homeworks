#include <stdio.h>
#include <stdlib.h>

int main(void){
int i=1,j=1,n,avg,sum=0,x,full;

printf("�п�J�H�� :");
scanf("%d",&n);
printf("�п�J�������Z :");
scanf("%d",&full);
  if(i<=n)
  {
        while(i<=n)
        {
                  		 while(j<=3)
                        {
                        	
                                         printf("�п�J��%d�ӤH����%d�Ӧ��Z :",i,j);
                                         scanf("%d",&x); 
                                         if(x<0)
                                         {
                                                   printf("�п�J����0~%d���Ʀr\n",full); 
                                                   j=j-1;
                                                   i=i-1;
												   break;
                                         }
                                         else if(x>full)
                                         {
                                                   printf("�п�J����0~%d���Ʀr\n",full); 
                                                   j=j-1;
                                                   i=i-1;
												   break;
                                         }
                            		  	 sum = sum + x;
                        			 	 j++;
						}
            avg = sum/3;  
            printf("��%d�ӤH�����Z :%d\n",i,avg);
            sum=0;
        	i++;
			j=1;
		}
  }
	else
	{
	printf("erro!  erro!  �п�J>=1���Ʀr");
	}


 system("pause");
 return 0;
}
