#include<stdio.h>
#include<conio.h>
#include <dos.h>
#include<stdlib.h>

int life[8][8]={{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};
int life2[8][8]={{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};


int nb(int x,int y)
{
int neigh=0;

if((life[x][y+1]==1 ) && ((y+1)< 8))
  neigh++;

if((life[x][y-1]==1 ) && ((y-1) > -1))
  neigh++;
if((life[x+1][y]==1) && ((x+1)<8))
  neigh++;
if((life[x-1][y]==1 ) && ((x-1)>-1))
  neigh++;
if((life[x+1][y-1]==1 ) && ((x+1)<8) && ((y-1)>-1))
  neigh++;
if((life[x-1][y+1]==1) && ((x-1)>-1) && ((y+1)<8))
  neigh++; 
if((life[x+1][y+1]==1) && ((x+1)<8) && ((y+1)<8))
  neigh++;
if((life[x-1][y-1]==1) && ((x-1)>-1) && ((y-1)>-1))
  neigh++;
return neigh;
 }

int main()
{
    int i,j;
    char ch;
    //setting array
   
    printf("\n1.Block\n2.Blinker\n3.Glider\n4.User Defined\n5.An Example Task.\n");
    ch=getch();
    if(ch=='1') 
    {
      life[2][4]=1;
      life[2][5]=1;
      life[3][4]=1;
      life[3][5]=1;
      system("cls");
    }
    if(ch=='2')
    {
      life[3][5]=1;
      life[4][5]=1;
      life[5][5]=1;
    }
    if(ch=='3')
    {
      life[7][5]=1;
      life[6][5]=1;
      life[5][5]=1;
      life[5][6]=1;
      life[6][7]=1;
    }
    if(ch=='4')
     {
      char c;
      int cellx,celly;
      while(1)
      {
        printf("\nDo you want to create an alive cell?(Y/N):");
        c=getch();
        if(c=='N' || c=='n')
         {
         system("cls");
         break;
         }
        if(c=='Y' || c=='y')
         {
          printf("\nEnter x coordinate of alive cell:");
          scanf("%d",&cellx);
          printf("\nEnter y coordinate of alive cell:");
          scanf("%d",&celly);
          if(cellx<0 || celly<0 || cellx>7 || celly>7)
           puts("\nMaximum size of a coordinate can be 7,at least 0!\n"); 
          else life[cellx][celly]=1;
                 
         }
              }
     }
     
     if(ch=='5')
     {
       int m,n;
       int life3[8][8]={{0,0,0,1,0,1,1,1},{0,1,0,1,0,1,1,0},{1,1,0,1,0,0,0,0},{0,1,1,0,0,0,1,1},{0,0,0,0,0,0,1,0},{1,1,0,0,1,1,1,0},{0,0,0,1,1,0,0,0},{1,1,1,0,1,1,0,1}};
        for(m=0;m<8;m++)
         {
          for(n=0;n<8;n++) {
           life[m][n]=life3[m][n];
           }
   
         }
                }
    for(i=0;i<8;i++)
         {
          for(j=0;j<8;j++) {
            if(life[i][j]==0)
           printf(" - ");
            else printf(" * ");
           }
           printf("\n");
         }
          printf("Press any key to see next step...");
          getch();
          system("cls");
    while(1)
    {
       for(i=0;i<8;i++)
        {
        for(j=0;j<8;j++)
         {
          if(nb(i,j)==3 && life[i][j]==0)
           life2[i][j]=1;
          if((nb(i,j)==2 || nb(i,j)==3) && life[i][j]==1)
           life2[i][j]=1;
          if((nb(i,j)==0 || nb(i,j)==1) && life[i][j]==1)
           life2[i][j]=0;
          if((nb(i,j) > 3) && (life[i][j]==1))
           life2[i][j]=0;
           
           }
          
         }
        
        for(i=0;i<8;i++)
         {
          for(j=0;j<8;j++) {
           if(life2[i][j]==0)
           printf(" - ");
           else printf(" * ");
           life[i][j]=life2[i][j];
           }
           printf("\n");
         }
         printf("Press any key to see next step...");
         getch();
          system("cls");
         
        
}
}

