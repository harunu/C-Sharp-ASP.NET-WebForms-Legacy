#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void create_ship(char [][16],int);/*creates a ship on the 16x16 matrix*/
void create_game(char [][16]);/*creates all ships on the 16x16 matrix*/
int menu(void);/*displays the menu items*/
void check_sink(int [], char [][16],int,int);/*check if a ship is sunk or not*/
void current_condition(char [][16]);/*displays the last condition of the 16x16 matrix after the last guess*/
int guess_check(int [],char [][16],char [][16],int);/*this function asks the user a guess and checks if it is a valid guess ornot
The function returns 0 if user enters XX,
                     1 if guess is not a valid
                     2 if guess is valid
*/

int main()
{
	int replay=0,choice,guess_number,best_score=256;
	int living_ships[4],i,j,game_condition;
	char ships[16][16],condition[16][16];

	while(1)
	{
		if(!replay)
		{
			choice=menu();/*showing the menu*/
			if(choice==2)
				break;
			if(choice!=1)
			{
				printf("Please enter 1 or 2 only\n");
				continue;
			}
		}
		guess_number=0;
		living_ships[0]=4;/*number of mayýn tarama gemisi*/
		living_ships[1]=4;/*number of fýrkateyn*/
		living_ships[2]=2;/*number of kurvazör*/
		living_ships[3]=1;/*number of uçak gemisi*/
		/*giving initial condition to the matrix by making all cells='g'*/
		for(i=0;i<16;i++)
		{
			for(j=0;j<16;j++)
			{
				condition[i][j]='g';
			}
		}
		/*giving initial empty value to the matrix that contains information that where the ships are*/
		for(i=0;i<16;i++)
			for(j=0;j<16;j++)
				ships[i][j]=' ';
		create_game(ships);/*placing ship on the matrix randomly*/
		game_condition=1;
		/*GAME*/
		while(1)
		{
			current_condition(condition);
			printf("Remaining Ships: %d M, %d F, %d K, %d U. Guesses: %d. Best Score: %d\n",living_ships[0],living_ships[1],living_ships[2],living_ships[3],guess_number,best_score);
			while(game_condition==1)
				game_condition=guess_check(living_ships,ships,condition,best_score);
			if(game_condition==2)
			{
				game_condition=1;
				guess_number++;
				if(living_ships[0]+living_ships[1]+living_ships[2]+living_ships[3]==0)
				{
					if(guess_number<best_score)
					{
						best_score=guess_number;
						printf("Best score is updated.\n");
					}
					current_condition(condition);
					printf("Remaining Ships: %d M, %d F, %d K, %d U. Guesses: %d. Best Score: %d\n",living_ships[0],living_ships[1],living_ships[2],living_ships[3],guess_number,best_score);
					printf("Game Over.\n");
					printf("Your Score: %d.\n",guess_number);
					printf("Best Score: %d.\n\n",best_score);
					replay=2;
					while(!(replay==0 || replay==1))
					{
						printf("If you want to replay, press 1 or press 0 to display the menu screen\n");
						scanf("%d",&replay);
					}
					break;
				}
				continue;
			}
			if(game_condition==0)
			{
				replay=0;
				break;
			}
		}
	}
	return 0;
}

/*displays the menu items*/
int menu(void)
{
	int choice;
	printf("Main Menu\n");
	printf("1 - New Game\n");
	printf("2 - Stop\n");
	printf("Enter 1 or 2 as a choice: ");
	scanf("%d",&choice);
	return choice;
}

/*displays the last condition of the 16x16 matrix after the last guess*/
void current_condition(char table[][16])
{
	int i,j;
	char row;
	printf("    1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16\n");
	printf("  ");
	for(i=0;i<65;i++)
		printf("=");
	printf("\n");
	row='A';
	for(i=0;i<16;i++)
	{
		printf("%c |",row);
		row++;
		for(j=0;j<16;j++)
		{
			printf(" %c |",table[i][j]);
		}
		printf("\n");
		printf("  ");
		for(j=0;j<65;j++)
			printf("=");
		printf("\n");
	}
}


/*creates all ships on the 16x16 matrix*/
void create_game(char ships[][16])
{
	int i,j;
	create_ship(ships,5);
	create_ship(ships,4);
	create_ship(ships,4);
	create_ship(ships,3);
	create_ship(ships,3);
	create_ship(ships,3);
	create_ship(ships,3);
	create_ship(ships,2);
	create_ship(ships,2);
	create_ship(ships,2);
	create_ship(ships,2);
	for(i=0;i<16;i++)
		for(j=0;j<16;j++)
			if(ships[i][j]==' ')
				ships[i][j]='X';
}

/*creates a ship on the 16x16 matrix*/
void create_ship(char ships[][16],int length)
{
	int i,row,column,direction;
	srand(time(NULL));
	row=rand()%16;
	column=rand()%16;
	direction=rand()%2;
	i=0;
	while(i<length)
	{
		if(direction)
		{
			if(ships[row+i][column]!=' ' || row+i>15)
			{
				i=0;
				row=rand()%16;
				column=rand()%16;
				direction=rand()%2;
				continue;
			}
			else
				i++;
		}
		else
		{
			if(ships[row][column+i]!=' ' || column+i>15)
			{
				i=0;
				row=rand()%16;
				column=rand()%16;
				direction=rand()%2;
				continue;
			}
			else
				i++;
		}
	}
	if(direction)
	{
		for(i=0;i<length;i++)
			ships[row+i][column]=length+48;
		if(column+1<16)
		{
			for(i=0;i<length;i++)
				ships[row+i][column+1]='X';
			if(row-1>=0)
				ships[row-1][column+1]='X';
			if(row+length<16)
				ships[row+length][column+1]='X';
		}
		if(column-1>=0)
		{
			for(i=0;i<length;i++)
				ships[row+i][column-1]='X';
			if(row-1>=0)
				ships[row-1][column-1]='X';
			if(row+length<16)
				ships[row+length][column-1]='X';
		}
		if(row-1>=0)
			ships[row-1][column]='X';
		if(row+length<16)
			ships[row+length][column]='X';
	}
	else
	{
		for(i=0;i<length;i++)
			ships[row][column+i]=length+48;
		if(row+1<16)
		{
			for(i=0;i<length;i++)
				ships[row+1][column+i]='X';
			if(column-1>=0)
				ships[row+1][column-1]='X';
			if(column+length<16)
				ships[row+1][column+length]='X';
		}
		if(row-1>=0)
		{
			for(i=0;i<length;i++)
				ships[row-1][column+i]='X';
			if(column-1>=0)
				ships[row-1][column-1]='X';
			if(column+length<16)
				ships[row-1][column+length]='X';
		}
		if(column-1>=0)
			ships[row][column-1]='X';
		if(column+length<16)
			ships[row][column+length]='X';
	}
}


/*this function asks the user a guess and checks if it is a valid guess ornot
The function returns 0 if user enters XX,
                     1 if guess is not a valid
                     2 if guess is valid
*/
int guess_check(int living_ships[],char ships[][16],char condition[][16],int best_score)
{
	char guess[4];
	int row,column;
	printf("Guess: ");
	scanf("%s",&guess);
	if(guess[0]=='X' && guess[1]=='X' && guess[2]=='\0')
		return 0;
	row=guess[0]-'A';
	if(row<0||row>15)
	{
		printf("Use capital letter and a number for your guess.ie: P6, D12, F10.\n"); 
		return 1;
	}
	if(guess[1]-'0'==1 && guess[2]-'0'>=0 && guess[2]-'0'<=6 && guess[3]=='\0')
		column=10*(guess[1]-'0')+(guess[2]-'0')-1;
	else if(guess[2]=='\0' && guess[1]-'0'>0 && guess[1]-'0'<=9)
		column=guess[1]-'0'-1;
	else
	{
		printf("Use capital letter and a number for your guess.ie: P6, D12, F10.\n\n"); 
		return 1;
	}
	if(condition[row][column]!='g')
	{
		printf("You guessed %s before\n",guess);
		return 1;
	}
	condition[row][column]=ships[row][column];
	if(condition[row][column]!='X')
		check_sink(living_ships,condition,row,column);
	return 2;
}
	
/*check if a ship is sunk or not*/
void check_sink(int living_ships[], char condition[][16],int row, int column)
{
	int i,j,length=0;
	i=row-(condition[row][column]-'0')+1;
	j=row+(condition[row][column]-'0')-1;
	while(i<0)
		i++;
	while(j>15)
		j--;
	while(i<=j)
	{
		if(condition[i][column]-condition[row][column]==0)
			length++;
		else
			length=0;
		if(length==condition[row][column]-'0')
		{
			living_ships[length-2]--;
			break;
		}
		i++;
	}
	i=column-(condition[row][column]-'0')+1;
	j=column+(condition[row][column]-'0')-1;
	while(i<0)
		i++;
	while(j>15)
		j--;
	while(i<=j)
	{
		if(condition[row][i]-condition[row][column]==0)
			length++;
		else
			length=0;
		if(length==condition[row][column]-'0')
		{
			living_ships[length-2]--;
			break;
		}
		i++;
	}
}
				






			

			
