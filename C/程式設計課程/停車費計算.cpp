#include <stdio.h>
#include <stdlib.h>

int main(void){
 int w;
 int t;
 int m;

 printf("請輸入星期 1~7 時間(分鐘)\n");
 scanf("%d %d",&w,&t);
 
 if(w>=1&&w<=5){
           if(t>5)
           {
                   if(t>65)
                   {
                            if(t%30>=5)
                            {
                            m = (t/30+1)*20;
                            printf("費用 = %d \n",m);
                                         }
                            else if(t%30<6)
                            {
                            m = (t/30)*20;
                            printf("費用 = %d \n",m);
                                         }
                            }
                   else
                   { 
                        printf("費用 = 40\n");
                        } 
           }
           else
           {
                printf("費用 = 0\n");
                }
 }
 else if(w>=6&&w<=7)
 {
            if(t>5)
            {
                   if(t>65)
                   {
                            if(t%30<6)
                            {
                            m = (t/30)*30;
                            printf("費用 = %d \n",m);
                                         }
                            else if(t%30>=5)
                            {
                            m = (t/30+1)*30;
                            printf("費用 = %d \n",m);
                                         }
                            }
                   else
                   {
                        printf("費用 = 60\n");
                        }
           }
           else
           {
                printf("費用 = 0\n");
           }
 } 
 else
     { 
      printf("無效的星期!! 請輸入正確的星期\n");
      }


 system("pause");
 return 0;
}


