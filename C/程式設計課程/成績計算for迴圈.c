#include <stdio.h>
#include <stdlib.h>

int main(void){
int i=1,j=1,n,avg,sum=0,x;

printf("�п�J�H�� :");
scanf("%d",&n);

if(i<=n)
{
        
        for(i=1;i<=n;i++)
        {
                        for(j=1;j<=3;j++)
                        {
                                         printf("�п�J��%d�ӤH����%d�Ӧ��Z :",i,j);
                                         scanf("%d",&x); 
                                         sum = sum + x;
                                         if(x<0)
                                         {
                                                  printf("�п�J����0~100���Ʀr\n"); 
                                                   system("pause");
                                                   return 0;
                                         }
                                         else if(x>100)
                                         {
                                                  printf("�п�J����0~100���Ʀr\n"); 
                                                   system("pause");
                                                   return 0;
                                         }
                           }
                         avg = sum/3;  
                         printf("��%d�ӤH�����Z :%d\n",i,avg);
                         sum=0;
        }
        
      
        
}
else{
printf("erro!  erro!  �п�J>=1���Ʀr");
}






 system("pause");
 return 0;
}
