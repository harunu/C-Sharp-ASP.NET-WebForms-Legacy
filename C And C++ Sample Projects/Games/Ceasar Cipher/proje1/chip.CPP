#include<stdio.h>
#include<conio.h>
#include<string.h>
#include<stdlib.h>
#include<dos.h>
#define  limit  50

char alphabet[26];
void makeNull(char arr[]);
char *extractFromFile();

char *decrypt(char inputData[] )
{
 int move,i,j,position;
 char *data,*off,temp[limit];
 strcpy(alphabet,"abcdefghijklmnopqrstuvwxyz");
 data=(char *)malloc(limit);
 makeNull(temp);
 off=strtok(inputData," "); /*parse input data.delimeter is space.first part is offset */
 move=atoi(off);
 data=strtok(NULL," "); /*second part is message*/
 strcpy(temp,data);
 /*begin decryption */
 for(i=0;i<strlen(temp);i++)
 {
  for(j=0;j<26;j++)
   if(alphabet[j]==temp[i])
    position=j;
    temp[i]=alphabet[(position+move)%26]; /*mapping letters*/
   }
 /*end decryption*/
 strcpy(data,temp);
 return data;
}

char *extractFromFile()
{
 FILE *fd;
 char *enc,buf[limit];
 enc=(char *)malloc(limit);
 makeNull(buf);
 if((fd=fopen("C:\\encrypt.TXT","r"))==NULL)
   printf("file C:\\encrypt.TXT can not be found...");
 fgets(buf,50,fd);
 strcpy(enc,buf);
 return enc;
}


void makeNull(char arr[])
{
 int j;
  for(j=0;j<50;j++)
   arr[j]='\0';
}

void main()
{
 char input[limit];
 FILE *out;
 makeNull(input);
 char  *result,*file_get,what;
 
 /* menu */
 printf("\n\n############## CEASAR CIPHER #############\n\n");
 printf("Select a Choice.Press any key to quit:\n1-Input From File\n2-Input From Keyboard\n");
 what=getch();
 switch(what)
  {
   case '1':
     file_get=extractFromFile();
     strcpy(input,file_get);
     printf("\nData from file:%s\n",input);
     result=decrypt(input);
     printf("Decrypted data: %s",result);
      if((out=fopen("C:\\decrypt.txt","w+"))==NULL)
	 printf("file C:\\decrypt.txt can not be created...\n");
      puts("\nit is written to C:\\decrypt.txt");
     fputs(result,out);
       break;
   case '2':
	printf("\nEnter encrypted data as:offset(space)word\n");
	gets(input);
	result=decrypt(input);
	printf("Decrypted data: %s\n",result);
       break;




  }
  /* end of menu */
// printf("%s\n",inp);
  getch();

}
