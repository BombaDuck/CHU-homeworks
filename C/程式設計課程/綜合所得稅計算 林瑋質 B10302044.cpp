#include <stdio.h>
#include <stdlib.h>

int main(void){
  		int income, tax, x=0;
		double taxrate=0.0;
		printf("�п�J��X�ұo�b�B�G");
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
			printf("  �п�J�j�󵥩�0���Ʀr!!");
			exit(0);
		}
		tax=income * taxrate ;
		printf("\n");
		printf("  ��X�ұo�b�B�G %d ��\n", income);
		printf("  �|        �B�G %2.0f �H\n", taxrate*100 );
		printf("  --------------------\n");
		printf("  �|        ���G %d ��\n", tax);
		printf("  �� �i �t  �B�G %d ��\n", x);
		printf("  --------------------\n");
		printf("  ���~���ǵ|�B�G %d ��\n", tax-x);
	
  printf("\n\n");


 system("pause");
 return 0;
}


