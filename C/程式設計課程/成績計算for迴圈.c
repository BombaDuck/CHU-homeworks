#include <stdio.h>
#include <stdlib.h>

int main(void){
int i=1,j=1,n,avg,sum=0,x;

printf("請輸入人數 :");
scanf("%d",&n);

if(i<=n)
{
        
        for(i=1;i<=n;i++)
        {
                        for(j=1;j<=3;j++)
                        {
                                         printf("請輸入第%d個人的第%d個成績 :",i,j);
                                         scanf("%d",&x); 
                                         sum = sum + x;
                                         if(x<0)
                                         {
                                                  printf("請輸入介於0~100的數字\n"); 
                                                   system("pause");
                                                   return 0;
                                         }
                                         else if(x>100)
                                         {
                                                  printf("請輸入介於0~100的數字\n"); 
                                                   system("pause");
                                                   return 0;
                                         }
                           }
                         avg = sum/3;  
                         printf("第%d個人的成績 :%d\n",i,avg);
                         sum=0;
        }
        
      
        
}
else{
printf("erro!  erro!  請輸入>=1的數字");
}






 system("pause");
 return 0;
}
