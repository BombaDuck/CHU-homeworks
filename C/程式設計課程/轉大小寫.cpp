#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void)
{
    FILE *fp1, *fp2;
    int ch;
    int first, blank;
    
    if((fp1 = fopen("input.txt","r")) == NULL)
    {
        printf("¶}ÀÉ¿ù»~~~\n");
        system("pause");      
        return 0;   
    }
    
    fp2 = fopen("output.txt","w"); 
    first = 1;
    blank = 0;
    while((ch = getc(fp1)) != EOF)
    {
              
         if(isalpha(ch))         
         {
             if(blank == 1)
             {
                blank = 0;      
                first = 1;      
             }
             else if(blank == 0)
             {
                ch = tolower(ch);    
             }
             
             if(first == 1)
             {
                ch = toupper(ch);                                   
                first = 0;
             }
    }     
         else
         {
             if(blank == 0) blank = 1;
         }     
        printf("%c",ch);     
        putc(ch,fp2);     
    }      
              
    fclose(fp1);              
    fclose(fp2);             
    printf("\n");
    
    system("pause");
    return 0;
}

