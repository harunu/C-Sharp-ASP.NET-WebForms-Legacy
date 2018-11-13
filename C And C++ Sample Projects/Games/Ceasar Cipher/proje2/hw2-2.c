#include<stdio.h>
#include<string.h>
#include<unistd.h>
#define BOUND 1000
#include<stdio.h>

char letters[26],cipher_letters[26];

char *get_ciphered_data()
{
 char *rv;
 FILE *f_descriptor;
 long limit;
 if((f_descriptor=fopen("ciphered_data.txt","r+"))==NULL)
  printf("can not open ciphered_data file.\n");
 rv=(char*)malloc(BOUND);
 fread(rv,1,BOUND,f_descriptor);
 return rv;
}

void set_ciphered_data(char *written)
{
 FILE *fd;
 if((fd=fopen("decipherd.txt","w+"))==NULL)
  printf("can not create decipher file.\n");
 fwrite(written,1,strlen(written),fd);
}
void get_letters()
{
 FILE *alp_fd;
 strcpy(letters,"abcdefghijklmnoqprstuvwxyz");
 if((alp_fd=fopen("cipher_letters.txt","r+"))==NULL)
  printf("can not open alphabet file.\n");
 fgets(cipher_letters,26,alp_fd);
}

char *decipher(char* encipher)
{
 char decipherd_ar[BOUND],*decipherd,encipher_ar[BOUND];
 int i,j;
 decipherd=(char *)malloc(BOUND);
 get_letters();
 for(i=0;i<strlen(encipher);i++)
 { 
  for(j=0;j<26;j++)
   {
    if(letters[j]==encipher[i])
       decipherd[i]=cipher_letters[j];  
             
     if(encipher[i]==32)
        decipherd[i]=32;
         
      if(encipher[i]=='\n')
         decipherd[i]='\n';
    }
 }
 set_ciphered_data(decipherd);
 return decipherd;
}

int main()
{
 printf("\n------------sUbsTituTioN CipHeR---------------\n");
       FILE *desc1,*desc2;
       printf("\n..........LOOKıNG FOR REQUIRED FILES...........\n");
       if((desc1=fopen("ciphered_data.txt","r+"))==NULL)
          printf("File ciphered_data.txt doesnot exists.\n");
       else printf("\nFile ciphered_data.txt exists.\n");
       if((desc2=fopen("cipher_letters.txt","r+"))==NULL)
          printf("File cipher_letters.txt doesnot exists.\n");
       else printf("File cipher_letters.txt exists.\n\n");
       printf("\n..........DECODING PROCESS...........\n");
       printf("\ndata:%s\n", get_ciphered_data());
       char * rv=get_ciphered_data();
       get_letters();
       printf("\ncipher alphabet:%s\n",cipher_letters);
       printf("\ndecoded :%s\n", decipher(rv));
       puts("result is written to decipherd.txt...");
 printf("\n------------------------------------------------------------\n");
 getch(); 
 return 0;
}
