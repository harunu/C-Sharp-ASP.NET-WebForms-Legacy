#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <dos.h>
#include <string.h>
#define LIMIT   100



typedef struct all {
        char coun[25];
        char state[25];
        char req[25];
        char block[100];
        
        int km;
        };
all all_d[20];

int length;

     
int set_up()
{
FILE *file_desc;
int i=0,k,m,cnt;
char *blocks=(char *)malloc(100);
if((file_desc=fopen("countries.txt","r+"))==NULL)
 puts("file can not be found!");
 while(!feof(file_desc))
  {
   fgets(blocks,100,file_desc);
   strcpy(all_d[i].block,blocks);
   //printf("%s\n",all_d[i].block);
   i++;
   }
   fclose(file_desc);
 return i;
}
 
void analyse()
{
 int k=0,m=0,i,space=0,r=0,r1=0,r2=0,j;
 bool turn=false;
/*parsing countries*/
for(i=0;i<length;i++) {
  for(j=0;j<strlen(all_d[i].block);j++)
   {
    turn=false;
    if(!turn)
     { 
       if(all_d[i].block[j]==32) { space++;turn=true;r=0;}
       else if(all_d[i].block[j]=='.'){ space=0;r=0; break;}
       else if(all_d[i].block[j]!=32 && all_d[i].block[j]!='.' && !turn){
      if(space==0) 
        all_d[i].coun[r]=all_d[i].block[j];
      if(space==1)
        all_d[i].state[r]=all_d[i].block[j];
      if(space==2)
        all_d[i].req[r]=all_d[i].block[j]; 
      r++;
       }
      }
     
     }
     all_d[i].km=atoi(all_d[i].req);
  
}
               
}
     


//printf("\n%s\n",all_d[i].coun);



  
 
 int main()
 {   

 int i,j,reqist;
 char selected,str_1[100],str_2[15],str_3[15],op;
 length=set_up();
 analyse();
 while(1) {
  printf("\n---------------------------------------------------------------------------\n");
  printf("| 1.Countries | 2.Cities | 3.Distances | 4.HELP | 5.File Check | q.Exit  |");
  printf("\n---------------------------------------------------------------------------\n");
  selected=getch();
  if(selected=='4')
  {
    printf("This program sorts values which are read from file siz ways:\n");
    puts("1.Sorts countries alphabetically(increasing)");
    puts("2.Sorts countries alphabetically(decreasing)");
    puts("3.Sorts cities alphabetically(increasing)");
    puts("4.Sorts cities alphabetically(decreasing)");
    puts("5.Sorts distances(increasing)");
    puts("6.Sorts distances(decreasing)");
    printf("\nBe sure if countries.txt exists at same directory.You can add entry to file as;\ncountry(space)city(space)distance.\n");
  }
  
  if(selected=='5')
  {
    FILE *f;
    if((f=fopen("countries.txt","r+"))==NULL)
     puts("File does not exist.");
    else { puts("File exists"); fclose(f);} 
      }
  
  if(selected=='1')
  {
  printf("\nYou are ordering countries.Press 1 for increasing 0 for decreasing\n");
  op=getch();
  if(op=='1') {

  for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {
     if(strcmp(all_d[i].coun,all_d[j].coun) > 0)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);
         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      }
       }
         printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
       
        }
                  }
if(op=='0')
{
 for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {
     if(strcmp(all_d[i].coun,all_d[j].coun) < 0)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);
         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      }
       }
         printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
       
        }

}

}

 
        
  if(selected=='3')
   {
     printf("\nYou are ordering distances.Press 1 for increasing 0 for decreasing\n");
     op=getch();
     if(op=='1') {
     for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {
     if(all_d[i].km > all_d[j].km)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);
         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      } //end if
    } //end for
  printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
}
}
if(op=='0')
 {
  for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {
     if(all_d[i].km < all_d[j].km)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);
         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      } //end if
    } //end for
  printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
}
   
           }
}
  
    if(selected=='2')
  {
    printf("\nYou are ordering cities.Press 1 for increasing 0 for decreasing\n");
  op=getch();
  if(op=='0') {
   for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {
     if(strcmp(all_d[i].state,all_d[j].state) < 0)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);
         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      }
       }
         printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
       
        }
     }
        printf("\n");
       if(op=='1') {
   for(i=0;i<length;i++) {
    for(j=i+1;j<length;j++) {

     if(strcmp(all_d[i].state,all_d[j].state) > 0)
      {
         strcpy(str_1,all_d[i].block);
         strcpy(all_d[i].block,all_d[j].block);
         strcpy(all_d[j].block,str_1);
         strcpy(str_3,all_d[i].state);
         strcpy(str_2,all_d[i].coun);

         reqist=all_d[i].km;
         strcpy(all_d[i].state,all_d[j].state);
         strcpy(all_d[i].coun,all_d[j].coun);
         all_d[i].km=all_d[j].km;
         strcpy(all_d[j].state,str_3);
         strcpy(all_d[j].coun,str_2);
         all_d[j].km=reqist;
      }
       }
         printf("\n%s %s %d.",all_d[i].coun,all_d[i].state,all_d[i].km);
        }

}
        }

    if(selected=='q')
   {
    printf("\n------------process is ending--------------\n");
    exit(0);
   }

 }
    getch();
    return 0;
}
