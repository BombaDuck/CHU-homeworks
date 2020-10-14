#include <stdio.h>
#include <stdlib.h>

int n=7;

int main(void)
{
    
    int a[n-3][n],h,i,k,j,q=0,z,s=1,p,R=0,L=0,ans,x=0;
	
	
	
    for(i=0;i<4;i++)
    {	
        for(j=0;j<4;j++)
        {
         scanf("%d",&z);
         a[i][j] = z;
         a[i][j+4] = z;
        }
	}
    

    for(i=0;i<4;i++)
	{	
		s=1;
		p=0;
		for(j=0;j<4;j++)
		{
			h=a[j][j+x];
			p=h*s;
			s=p;	
		}
		L = L + s;
		x++;
	}
	
	x=0;
	for(i=0;i<4;i++)
	{	
		q=0;
		s=1;
		p=0;
		for(j=6;j>2;j--)
		{
				
			h=a[q][j+x];
			p=h*s;
			s=p;	
			q++;
		
		}
		R = R + s;
		x--;
	}

 	printf("  ¯x°}\n");
    for(i=0;i<4;i++)
    {
       for(j=0;j<4;j++)
       {
        printf(" %3d ",a[i][j]);
       }printf("\n"); 
    }    
    ans = R-L;
    printf("                 ªº¸Ñ¬° :%d",ans);


  printf("\n");
  system("pause");
  return 0;
}















