#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int game_over(int);/*this function performs necessary operations when a game is over and returns 1 if user wants to replay or returns 0 if user doesn't want to replay*/
void show(char [][16]);/*this function shows the previous guesses on a table*/
int start(char[][16],char[][16]);/*This function makes guessing start and returns 0 if user enters XX or user doesn't want to replay. If user wants to replay it returns 1*/
int guess_control(char [][16],int []);/*interprets user's entry.It realizes if user enters XX or if user enters a valid entry and returns the reletad value.*/
void ships_control(char [][16],int,int,int []);/*if a game is sunk, this function make necessary changes to show the user current remaining ships*/
void make_ships(char[][16]);/*places the ships randomly*/
int best_score=256;

int main()
{
	char all_ships[16][16],guessed_places[16][16];
	int game_continues=1,menu,replay,i,j;
	while(game_continues)
	{
		printf("--- Menu ---\n1- New Game\n2- Stop\n");
		menu=0;
		while(menu!=1 && menu!=2)
		{
			printf("Select from the menu items: ");
			scanf("%d",&menu);
		}
		if(menu==1)
		{
			replay=1;
			while(replay)
			{
				for(i=0;i<16;i++)
				{
					for(j=0;j<16;j++)
					{
						all_ships[i][j]='0';
						guessed_places[i][j]='g';
					}
				}
				make_ships(all_ships);
				for(i=0;i<16;i++)
				{
					for(j=0;j<16;j++)
					{
						if(all_ships[i][j]=='0')
							all_ships[i][j]='X';
					}
				}
				replay=start(all_ships,guessed_places);
			}
		}
		else
			game_continues=0;
	}
	return 0;
}

/*this function shows the previous guesses on a table*/
void show(char guessed_places[][16])
{
	int i,j;
	char symbol;
	printf("    1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16\n");
	printf("  ");
	for(i=0;i<65;i++)
		printf("=");
	printf("\n");
	symbol='A';
	for(i=0;i<16;i++)
	{
		printf("%c |",symbol);
		symbol++;
		for(j=0;j<16;j++)
		{
			printf(" %c |",guessed_places[i][j]);
		}
		printf("\n");
		printf("  ");
		for(j=0;j<65;j++)
			printf("=");
		printf("\n");
	}
}

/*interprets user's entry.It realizes if user enters XX or if user enters a valid entry and returns the reletad value.*/
int guess_control(char guessed_places[][16],int selection[])
{
	char entry[4];
	printf("Enter your guess.Use a capital letter (A to P) and a number (1 to 16):");
	scanf("%s",entry);
	if(entry[0]=='X' && entry[1]=='X' && entry[2]=='\0')
		return 2;
	selection[0]=entry[0]-'A';
	if(selection[0]<0||selection[0]>15)
		return 1;
	if(entry[1]-'0'==1 && entry[2]-'0'>=0 && entry[2]-'0'<=6 && entry[3]=='\0')
		selection[1]=10*(entry[1]-'0')+(entry[2]-'0')-1;
	else if(entry[2]=='\0' && entry[1]-'0'>0 && entry[1]-'0'<=9)
		selection[1]=entry[1]-'0'-1;
	else
		return 1;
	if(guessed_places[selection[0]][selection[1]]!='g')
	{
		printf("You have already chosen %s.\n",entry);
		return 1;
	}
	else
		return 0;
}

/*if a game is sunk, this function make necessary changes to show the user current remaining ships*/
void ships_control(char guessed_places[][16],int i,int j,int ship_numbers[])
{
	int length,examine,sunk,k;
	if(guessed_places[i][j]!='X')
	{
		length=guessed_places[i][j]-'0';
		examine=0;
		sunk=0;
		for(k=1-length;k<length;k++)
		{
			if(guessed_places[i+k][j]==guessed_places[i][j])
			{
				examine++;
				if(examine==length)
					sunk=1;
			}
			else
				examine=0;
		}
		if(sunk)
			ship_numbers[length-2]--;
		else
		{
			examine=0;
			for(k=1-length;k<length;k++)
			{
				if(guessed_places[i][j+k]==guessed_places[i][j])
				{
					examine++;
					if(examine==length)
						sunk=1;
				}
				else
					examine=0;
			}
			if(sunk)
				ship_numbers[length-2]--;
		}
	}
}


/*This function makes guessing start and returns 0 if user enters XX or user doesn't want to replay. If user wants to replay it returns 1*/
int start(char all_ships[][16],char guessed_places[][16])
{
	int i,j,check;
	int remaining;
	int result=2,guesses=0;
	int ship_numbers[4]={4,4,2,1};
	int selection[2];	
	while(result==2)
	{
		show(guessed_places);
		printf("Remaining Ships: %d M, %d F, %d K, %d U. Guesses: %d. Best Score: %d\n",ship_numbers[0],ship_numbers[1],ship_numbers[2],ship_numbers[3],guesses,best_score);
		remaining=ship_numbers[0]+ship_numbers[1]+ship_numbers[2]+ship_numbers[3];
		if(remaining==0)
		{
			result=game_over(guesses);
			break;
		}
		check=1;
		while(check==1)
			check=guess_control(guessed_places,selection);
		if(check==2)
			result=0;
		else
		{
			i=selection[0];
			j=selection[1];
			guesses++;
		}
		if(result!=0)
		{
			guessed_places[i][j]=all_ships[i][j];
			ships_control(guessed_places,i,j,ship_numbers);
		}
	}
	return result;
}

/*this function performs necessary operations when a game is over and returns 1 if user wants to replay or returns 0 if user doesn't want to replay*/
int game_over(int guesses)
{
	int selection;
	if(guesses<best_score)
		best_score=guesses;
	printf("Game over with %d guesses.\n",guesses);
	printf("Best Score After The Game: %d.\n",best_score);
	selection=0;
	while(!(selection==1 || selection==2))
	{
		printf("Press 1 for Menu,2 for Replay\nYour choice:");
		scanf("%d",&selection);
	}
	if(selection==1)
		return 0;
	else
		return 1;
}

/*places the ships randomly*/
void make_ships(char matrix[][16])
{
	int ship_length[4]={5,4,3,2};
	int ship_number[4]={1,2,4,4};
	int row,column,position,i,j,turn_loop;
	srand(time(NULL));
	i=0;
	while(i<4)
	{
		position=rand()%2;
		turn_loop=1;
		if(position)
		{
			while(turn_loop)
			{
				row=rand()%(16-ship_length[i]+1);
				column=rand()%16;
				turn_loop=ship_length[i];
				for(j=0;j<ship_length[i];j++)
				{
					if(matrix[row+j][column]=='0')
						turn_loop--;
				}
			}
			for(j=0;j<ship_length[i];j++)
				matrix[row+j][column]=ship_length[i]+'0';
			if(row>1)
				matrix[row-1][column]='X';
			if(row+ship_length[i]<16)
				matrix[row+ship_length[i]][column]='X';
			if(column>0)
			{
				if(row>0)
					matrix[row-1][column-1]='X';
				if(row+ship_length[i]<16)
					matrix[row+ship_length[i]][column-1]='X';
				for(j=0;j<ship_length[i];j++)
					matrix[row+j][column-1]='X';
			}
			if(column<15)
			{
				if(row>0)
					matrix[row-1][column+1]='X';
				if(row+ship_length[i]<16)
					matrix[row+ship_length[i]][column+1]='X';
				for(j=0;j<ship_length[i];j++)
					matrix[row+j][column+1]='X';
			}
		}
		else
		{
			while(turn_loop)
			{
				row=rand()%16;
				column=rand()%(16-ship_length[i]+1);
				turn_loop=ship_length[i];
				for(j=0;j<ship_length[i];j++)
				{
					if(matrix[row][column+j]=='0')
						turn_loop--;
				}
			}
			for(j=0;j<ship_length[i];j++)
				matrix[row][column+j]=ship_length[i]+'0';
			if(column>1)
				matrix[row][column-1]='X';
			if(column+ship_length[i]<16)
				matrix[row][column+ship_length[i]]='X';
			if(row>0)
			{
				if(column>0)
					matrix[row-1][column-1]='X';
				if(column+ship_length[i]<16)
					matrix[row-1][column+ship_length[i]]='X';
				for(j=0;j<ship_length[i];j++)
					matrix[row-1][column+j]='X';
			}
			if(row<15)
			{
				if(column>0)
					matrix[row+1][column-1]='X';
				if(column+ship_length[i]<16)
					matrix[row+1][column+ship_length[i]]='X';
				for(j=0;j<ship_length[i];j++)
					matrix[row+1][column+j]='X';
			}
		}
		ship_number[i]--;
		if(ship_number[i]==0)
			i++;
	}
}


