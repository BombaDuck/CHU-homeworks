#include <stdio.h>
#include <stdlib.h>

int main(void){
int i=1,j=1,n,avg,sum=0,x,full;

printf("請輸入人數 :");
scanf("%d",&n);
printf("請輸入滿分成績 :");
scanf("%d",&full);
  if(i<=n)
  {
        while(i<=n)
        {
                  		 while(j<=3)
                        {
                        	
                                         printf("請輸入第%d個人的第%d個成績 :",i,j);
                                         scanf("%d",&x); 
                                         if(x<0)
                                         {
                                                   printf("請輸入介於0~%d的數字\n",full); 
                                                   j=j-1;
                                                   i=i-1;
												   break;
                                         }
                                         else if(x>full)
                                         {
                                                   printf("請輸入介於0~%d的數字\n",full); 
                                                   j=j-1;
                                                   i=i-1;
												   break;
                                         }
                            		  	 sum = sum + x;
                        			 	 j++;
						}
            avg = sum/3;  
            printf("第%d個人的成績 :%d\n",i,avg);
            sum=0;
        	i++;
			j=1;
		}
  }
	else
	{
	printf("erro!  erro!  請輸入>=1的數字");
	}


 system("pause");
 return 0;
}
