#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <time.h>

int main_menu(void);/*this function shows the main menu and returns the value that the user enters*/
void produce_ships(char[][16]);/*chooses places that ships is placed*/
void produce_game_sheet(char[][16]);/*initialize the array given as input parameter.in the end all cells have the value 'g'*/
void show_last_condition(char[][16]);/*shows the user the current status of the guessed places*/
void remaining(char[][16],int,int);/*calculates the remaining number of each type of ships*/
int mtg,firkateyn,kurvazor,ug;

int main()
{
	int menu,playing,validty_test=1,replay;
	int row,column,guesses,best_score=256;
	char places[16][16];
	char sheet[16][16];
	char shot[4];
	do
	{
		menu=main_menu();
		if(menu==1)
		{
			do
			{
				guesses=0;
				mtg=4;
				firkateyn=4;
				kurvazor=2;
				ug=1;
				produce_ships(places);
				produce_game_sheet(sheet);
				playing=1;
				do
				{
					show_last_condition(sheet);
					printf("Remaining Ships: %d M, %d F, %d K, %d U. Guesses: %d. Best Score: %d\n",mtg,firkateyn,kurvazor,ug,guesses,best_score);
					do
					{						
						printf("Type your guess with a capital letter from A to P and a number from 1 to 16:");
						scanf("%s",shot);
						if(strcmp(shot,"XX")==0)
						{
							replay=0;
							playing=0;
							validty_test=1;
						}
						else
						{
							
							row=shot[0]-'A';
							if(row<0||row>15)
								validty_test=0;
							else
								validty_test=1;
							if(validty_test==1 && shot[1]-'0'==1 && shot[2]-'0'>=0 && shot[2]-'0'<=6 && shot[3]=='\0')
								column=(shot[1]-'0')*10+(shot[2]-'0')-1;
							else if(validty_test==1 && shot[1]-'0'>0 && shot[1]-'0'<=9 && shot[2]=='\0')
								column=shot[1]-'0'-1;
							else
								validty_test=0;
							if(validty_test==1 && sheet[row][column]!='g')
							{
								printf("%s is tried previously.\n",shot);
								validty_test=0;
							}
							else if(validty_test)
							{
								sheet[row][column]=places[row][column];
								guesses++;
							}
						}
					}while(validty_test==0);
					if(playing==1)
					{
						if(sheet[row][column]!='X')
							remaining(sheet,row,column);
						if(mtg+firkateyn+kurvazor+ug==0)
							playing=0;
					}
				}while(playing);
				if(strcmp(shot,"XX")!=0)
				{
					show_last_condition(sheet);
					printf("Remaining Ships: %d M, %d F, %d K, %d U. Guesses: %d. Best Score: %d\n",mtg,firkateyn,kurvazor,ug,guesses,best_score);
					if(guesses<best_score)
						best_score=guesses;
					printf("Game over.Total score: %d.\n",guesses);
					printf("Updated Best Score: %d.\n",best_score);
					replay=0;
					while(!(replay==1 || replay==2))
					{
						printf("1.Main Menu\n");
						printf("2.Replay\n");
						printf("Type your choice:");
						scanf("%d",&replay);
					}
					replay=replay-1;
				}
			}while(replay);
		}
	}while(menu==1);
	return 0;
}


/*this function shows the main menu and returns the value that the user enters*/
int main_menu(void)
{
	int menu;
	printf("-Main Menu-\n");
	printf("1-New Game\n");
	printf("2-Stop\n");
	while(1)
	{
		printf("Select from the menu items: ");
		scanf("%d",&menu);
		if(menu==1||menu==2)
			break;
	}
	return menu;
}

/*chooses places that ships is placed*/
void produce_ships(char places[][16])
{
	int ship=2,i=0,row,column,direction,j,k,check;
	int number[4]={4,4,2,1};
	srand(time(NULL));
	for(j=0;j<16;j++)
	{
		for(k=0;k<16;k++)
			places[j][k]='X';
	}
	while(ship<6)
	{
		row=rand()%16;
		column=rand()%16;
		direction=rand()%2;
		check=1;
		if(direction==0)
		{
			for(j=0;j<ship;j++)
			{
				if(row+j>15)
					check=0;
				if(places[row+j][column]!='X')
					check=0;
				if(places[row+j][column+1]!='X' && column<15)
					check=0;
				if(places[row+j][column-1]!='X' && column>=1)
					check=0;
			}
			if(row>=1 && (places[row-1][column]!='X' || (places[row-1][column+1]!='X' && column<15) || (places[row-1][column-1]!='X' && column>=1)))
				check=0;
			if(row+ship<16 && (places[row+ship][column]!='X' || (places[row+ship][column+1]!='X' && column<15) || (places[row+ship][column-1]!='X' && column>=1)))
				check=0;
			if(check)
			{
				for(j=0;j<ship;j++)
					places[row+j][column]=ship+'0';
				number[i]--;
				if(number[i]==0)
				{
					ship++;
					i++;
				}
			}
		}
		else
		{
			for(j=0;j<ship;j++)
			{
				if(column+j>15)
					check=0;
				if(places[row][column+j]!='X')
					check=0;
				if(places[row+1][column+j]!='X' && row<15)
					check=0;
				if(places[row-1][column+j]!='X' && row>=1)
					check=0;
			}
			if(column>=1 && (places[row][column-1]!='X' || (places[row+1][column-1]!='X' && row<15) || (places[row-1][column-1]!='X' && row>=1)))
				check=0;
			if(column+ship<16 && (places[row][column+ship]!='X' || (places[row+1][column+ship]!='X' && row<15) || (places[row-1][column+ship]!='X' && row>=1)))
				check=0;
			if(check)
			{
				for(j=0;j<ship;j++)
					places[row][column+j]=ship+'0';
				number[i]--;
				if(number[i]==0)
				{
					ship++;
					i++;
				}
			}
		}
	}
}


/*initialize the array given as input parameter.in the end all cells have the value 'g'*/
void produce_game_sheet(char game_sheet[][16])
{
	int i,j;
	for(i=0;i<16;i++)
	{
		for(j=0;j<16;j++)
			game_sheet[i][j]='g';
	}
}

/*shows the user the current status of the guessed places*/
void show_last_condition(char game_sheet[][16])
{
	int i,j;
	char symbol='A';
	printf(" ");
	for(i=1;i<=9;i++)
		printf("   %d",i);
	for(i=10;i<=16;i++)
		printf("  %d",i);
	printf("\n");
	printf("  ");
	for(i=0;i<=64;i++)
		printf("=");
	printf("\n");
	for(i=0;i<=15;i++)
	{
		printf("%c |",symbol);
		symbol++;
		for(j=0;j<=15;j++)
		{
			printf(" %c |",game_sheet[i][j]);
		}
		printf("\n");
		printf("  ");
		for(j=0;j<=64;j++)
			printf("=");
		printf("\n");
	}
}

/*calculates the remaining number of each type of ships*/
void remaining(char game_sheet[][16],int row,int column)
{
	int length,i;
	i=0;
	while(game_sheet[row+i][column]!='X' && game_sheet[row+i][column]!='g' && row+i<=15)
		i++;
	length=i;
	i=0;
	while(game_sheet[row-i][column]!='X' && game_sheet[row-i][column]!='g' && row-i>=0)
		i++;
	length=length+i-1;
	if(length==game_sheet[row][column]-'0')
	{
		if(length==2)
			mtg--;
		else if(length==3)
			firkateyn--;
		else if(length==4)
			kurvazor--;
		else
			ug--;
	}
	else
	{
		i=0;
		while(game_sheet[row][column+i]!='X' && game_sheet[row][column+i]!='g' && column+i<=15)
			i++;
		length=i;
		i=0;
		while(game_sheet[row][column-i]!='X' && game_sheet[row][column-i]!='g' && column-i>=0)
			i++;
		length=length+i-1;
		if(length==game_sheet[row][column]-'0')
		{
			if(length==2)
				mtg--;
			else if(length==3)
				firkateyn--;
			else if(length==4)
				kurvazor--;
			else
				ug--;
		}
	}
}
