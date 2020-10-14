#include <stdio.h>
#include <stdlib.h>

int main(void){
  		int income, tax, x=0;
		double taxrate=0.0;
		printf("請輸入綜合所得淨額：");
		scanf("%d", &income);
		if(income >= 0 && income<=520000)
		{
			x=0;
			taxrate=0.05;
		}
		else if(income>520000 && income<=1170000)
		{
			x=36400;
			taxrate=0.12;
		}
		else if(income>1170000 && income<=2350000)
		{
			x=130000;
			taxrate=0.2;
		}
		else if(income>2350000 && income<=4400000)
		{
			x=365000;
			taxrate=0.3;
		}
		else if(income>4400000)
		{
			x=805000;
			taxrate=0.4;
		}
		else
		{
			printf("  請輸入大於等於0的數字!!");
			exit(0);
		}
		tax=income * taxrate ;
		printf("\n");
		printf("  綜合所得淨額： %d 元\n", income);
		printf("  稅        額： %2.0f ％\n", taxrate*100 );
		printf("  --------------------\n");
		printf("  稅        金： %d 元\n", tax);
		printf("  累 進 差  額： %d 元\n", x);
		printf("  --------------------\n");
		printf("  今年應納稅額： %d 元\n", tax-x);
	
  printf("\n\n");


 system("pause");
 return 0;
}


