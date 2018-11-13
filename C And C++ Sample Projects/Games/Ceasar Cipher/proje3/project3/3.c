#include<stdio.h>
#include<string.h>
#define LIMIT 255

char alphabet[26];
float english_letter_freq[26];
float message_letter_freq[26];
int ok[26] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

void ceasar(char *mes,int dist)
{
 int i,j;
 char *temp;
 temp=(char *)malloc(LIMIT);
 strcpy(alphabet,"abcdefghijklmnopqrstuvwxyz"); 
 for(i=0;i<strlen(mes);i++)
  {
   for(j=0;j<26;j++)
     {
       if(alphabet[j]==mes[i])
          temp[i]=alphabet[(j+dist)%26];
       if(mes[i]==32)
          temp[i]=32;
     }
    
  }
 printf("[%d] %s\n",dist,temp);  
}



void subs(char *msg)
{

int i,t=0,j,k,count=0,p,m,total;
char *message_alph,*temp_msg;
int how_many[100];
message_alph=(char *)malloc(LIMIT);
temp_msg=(char *)malloc(LIMIT);
strcpy(alphabet,"abcdefghijklmnoprqstuvwxyz");
temp_msg=msg;
english_letter_freq[0]=8.2;
english_letter_freq[1]=1.5;
english_letter_freq[2]=2.8;
english_letter_freq[3]=4.3;
english_letter_freq[4]=12.7;
english_letter_freq[5]=2.2;
english_letter_freq[6]=2.0;
english_letter_freq[7]=6.1;
english_letter_freq[8]=7.0;
english_letter_freq[9]=0.2;
english_letter_freq[10]=0.8;
english_letter_freq[11]=4.0;
english_letter_freq[12]=2.4;
english_letter_freq[13]=6.7;
english_letter_freq[14]=7.5;
english_letter_freq[15]=1.9;
english_letter_freq[16]=0.1;
english_letter_freq[17]=6.0;
english_letter_freq[18]=6.3;
english_letter_freq[19]=9.1;
english_letter_freq[20]=2.8;
english_letter_freq[21]=1.0;
english_letter_freq[22]=2.4;
english_letter_freq[23]=0.2;
english_letter_freq[24]=2.0;
english_letter_freq[25]=0.1;

printf("All letters in message:\n");
for(j=0;j<strlen(msg);j++)
 {
  for(k=0;k<26;k++)
   {
     if(alphabet[k]==msg[j])
      {
       if(ok[k]==0) {
         message_alph[t]=alphabet[k];
         ok[k]=1;
         t++; 
         }
     } 

      }
}
for(p=0;p<t;p++)
{
 for(m=0;m<strlen(msg);m++)
{ 
 if(msg[m]==message_alph[p])
  count++;
 }
how_many[p]=count;
printf("%c how many:%d frequency :%d%\n",message_alph[p],how_many[p],(how_many[p]*100)/t);
count=0;
}     
printf("\n");
printf("\nEnglish letters and their frequencies:\n");
int cnt,ii,ww=0;
temp_msg=msg;
char *guess=(char *)malloc(LIMIT);
for(cnt=0;cnt<26;cnt++)
 printf("[ %c:%f ]",alphabet[cnt],english_letter_freq[cnt]);
puts("\nMake your guess letters for message letters.Type OK if you are sure about letters.\n");
while(1)
{
 if(ww==0)
  printf("%s\n",message_alph);
 else printf("%s\n",guess);
 scanf("%s",guess);
 if(!strcmp(guess,"OK"))
  {
   puts("it is fnished...");
   exit(0);
  }
 else {
 puts("Reorganized message...");
 for(ii=0;ii<strlen(msg);ii++)
 {
  if(msg[ii]==message_alph[ww])
   {
    msg[ii]=guess[ww];
    message_alph[ww]=guess[ww];
    ww++;
   }
  if(msg[ii]==32)
    msg[ii]=32;
   printf("%c",msg[ii]);
 }
 ww=0;
}
}

}

int main()
 { 
  char *messg;
  int i,right ,chc;
  FILE *fd;
  messg=(char *)malloc(LIMIT);
  if((fd=fopen("dec.txt","r+"))==NULL)
   printf("Can not open dec.txt\n");
  else 
   fread(messg,1,LIMIT,fd);
  printf("Size of message:  %d\n",strlen(messg));
 while(1) {
  printf("[1] Decode with CEASAR cipher\n[2] Decode with SUBSTITUTION cipher\n[3] EXİT\n");
  scanf("%d",&chc);
  if(chc==1) {
   for(i=1;i<26;i++)
    ceasar(messg,i);
   printf("\nOne of these decoded messages must be true.\n\n");
  }
  if(chc==2)
   subs(messg);
  if(chc==3)
   exit(0);
}
  return 0;
 }
