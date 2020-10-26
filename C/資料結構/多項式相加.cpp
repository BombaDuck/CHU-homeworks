#include <stdio.h> 
#include <stdlib.h>
#define SIZE 20

int poly_a[2][SIZE]; 
int poly_b[2][SIZE];
int poly_c[2][SIZE];
int item_a,item_b,item_c;
void print_poly_a();
void print_poly_b();
void print_poly_c();
void read_poly_a();
void read_poly_b();
void initialization();
void poly_add();
void print_poly_c_final();
int index_a = 0,index_b = 0,index_c = 0;

int main(void)//主程式 
{
	initialization();
	read_poly_a();
	read_poly_b();
	print_poly_a();
	print_poly_b();
	poly_add();
	print_poly_c_final();
	system("pause");
}
void poly_add ()//多項式相加 
{
	
	while((index_a < item_a) && (index_b < item_b))
	{
		if(poly_a[1][index_a] == poly_b[1][index_b])
		{
		poly_c[0][index_c] = poly_a[0][index_a] + poly_b[0][index_b];
		poly_c[1][index_c] = poly_a[1][index_a];
		index_a++;
		index_b++;
		index_c++;
	    }
	    else if(poly_a[1][index_a] > poly_b[1][index_b])
	    {
	    	poly_c[0][index_c] = poly_a[0][index_a];
	    	poly_c[1][index_c] = poly_a[1][index_a];
	    	index_a++;
			index_c++;
	    }
	    else
	    {
	    	poly_c[0][index_c] = poly_b[0][index_b];
	    	poly_c[1][index_c] = poly_b[1][index_b];
	    	index_b++;
	    	index_c++;
	    }
	    
	}
    if((index_a >= item_a) && (index_b < item_b))
    {
    	while(index_b < item_b)
    	{
    		poly_c[0][index_c] = poly_b[0][index_b];
	    	poly_c[1][index_c] = poly_b[1][index_b];
	    	index_b++;
	    	index_c++;
    	}
    }
    else if((index_a < item_a) && (index_b >= item_b))
    {
    	while(index_a < item_a)
		{
			poly_c[0][index_c] = poly_a[0][index_a];
	    	poly_c[1][index_c] = poly_a[1][index_a];
	    	index_a++;
	    	index_c++;
		}	
    }
	item_c = index_c;
	print_poly_c();
}
void initialization()
{
	int i,j;
	for(i=0;i<2;i++)
		for(j=0;j<SIZE;j++)
		{
		poly_a[i][j] = -1;
		poly_b[i][j] = -1;
		poly_c[i][j] = -1;
		}
	item_a = 0;
	item_b = 0;
	item_c = 0;
}
void read_poly_a()
{
	char filename[10];
	FILE *fp;
	int coef1, exp1;
	int i;
	
	printf("請輸入檔名(a.txt) : ");
	scanf("%s",&filename);
	
	fp = fopen(filename,"r");
	
	if(fp == NULL) printf("開讀黨失敗!");
	else
	{
		i = 0;
		while(!feof(fp))
		{
			fscanf(fp,"%d",&coef1);
			fscanf(fp,"%d",&exp1);
			poly_a[0][i] = coef1;
			poly_a[1][i] = exp1;
			i++;
		}
	}
	item_a = i;
}
void read_poly_b()
{
	char filename[10];
	FILE *fp;
	int coef1, exp1;
	int i;
	
	printf("請輸入檔名(b.txt) : ");
	scanf("%s",&filename);
	
	fp = fopen(filename,"r");
	
	if(fp == NULL) printf("開讀黨失敗!");
	else
	{
		i = 0;
		while(!feof(fp))
		{
			fscanf(fp,"%d",&coef1);
			fscanf(fp,"%d",&exp1);
			poly_b[0][i] = coef1;
			poly_b[1][i] = exp1;
			i++;
		}
	}
	item_b = i;
}
void print_poly_a()
{
	int i,j;
	printf("----------------------- A 式 -----------------------\n");
	for(j=0;j<10;j++) printf("%5d",j);
	printf("\n---------------------------------------------------\n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<item_a;j++)
		{
			printf("%5d",poly_a[i][j]);
		}
		printf("\n");
	}
	printf("\n");
}
void print_poly_b()//印出B檔案
{
	int i,j;
	printf("----------------------- B 式 -----------------------\n");
	for(j=0;j<10;j++) printf("%5d",j);
	printf("\n--------------------------------------------------\n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<item_b;j++)
		{
			printf("%5d",poly_b[i][j]);
		}
		printf("\n");
	}
	printf("\n");
}
void print_poly_c()//印出C檔案
{
	int i,j;
	printf("----------------------- 答案 -----------------------\n");
	for(j=0;j<10;j++) printf("%5d",j);
	printf("\n--------------------------------------------------\n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<item_c;j++)
		{
			printf("%5d",poly_c[i][j]);
		}
		printf("\n");
	}
}
void print_poly_c_final()//把C轉換成式子 
{
	int i,j;
	printf("\n---------------------------------------------------\n");
	printf("Ans: ");
	for(i=0;i<item_c;i++)
	{
		if(poly_c[0][i] == 1)
		{
			printf("x^%d",poly_c[1][i]);
	    }
		else if(poly_c[1][i] == 1)
		{
			printf("%dx",poly_c[0][i]);
		}
		else if(poly_c[1][i] == 0)
		{
			printf("%d",poly_c[0][i]);
		}
		else if(poly_c[0][i+1] < 0 )
		{
			printf("%dx^%d",poly_c[0][i],poly_c[1][i]);
		}
		else
		{
			printf("%dx^%d+",poly_c[0][i],poly_c[1][i]);
		}
		
		
	}
	printf("\n");
} 


