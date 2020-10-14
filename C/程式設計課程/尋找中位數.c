#include <stdio.h>
#include <stdlib.h>

void input(int [], int );
void compute_ave(int [],int );
void compute_middle(int [],int );
int main(void)
{
int n,x[10],a,i,j;

printf("請輸入n :");
scanf("%d",&n);
input(x,n);

for(i=0;i<n;i++)
{
	for(j=i+1;j<n;j++)
	{
		if(x[i]>x[j])
		{
			a = x[i];
			x[i] = x[j];
			x[j] = a;
		}
	}
}

printf("排列 小~大 : ");

for(i=0;i<n;i++)
{
	printf("%d ",x[i]);
}		
 printf("\n");
 compute_ave(x,n);
 compute_middle(x,n);


 system("pause");
 return 0;
 
}


void input(int x[], int n)
{
  int i=0;
  for(i=0;i<n;i++)
  {
  printf("輸入第[%d]個數字;",i+1);
  scanf("%d",&x[i]);             
  }
  
}

void compute_ave(int x[],int n)
{
  int i=0;
  double sum=0;
  float ave,d,sd; 
  for(i=0;i<n;i++)
  {
  sum = sum + x[i];                  
  }
  ave=sum/n;
  printf("平均   = %5.2f\n",ave);   
  sum=0;
}     


void compute_middle(int x[],int n)
{

	int t,s;
	float m;
	t = n/2 + 0.5;
	s = n/2 - 0.5;
	
	
	if(n%2==0)
	{
		m = (x[t]+x[s]);
		m = m/2;
		printf("中位數 = %5.2f\n",m);
	}
	
	else
	{
		printf("中位數 = %d\n",x[n/2]);
	}
	
	
	
}





















