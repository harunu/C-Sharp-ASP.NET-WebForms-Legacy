/*This code is written on Dev-C++ 4.9.9.2 and working without problem
Program can be found at: http://sourceforge.net/projects/dev-cpp/ */
#include <stdio.h>
#include <stdlib.h>
#include "list.c"

struct linked_list{
       int value;
       struct linked_list *next;
};
typedef struct linked_list *element;
element mylist;
void PrintNum(element mylist, int rank); /*question 1*/
void PrintRank(element mylist, int num); /*question 2*/
void InsertAtRank(element mylist, int num, int rank); /*question 3*/
void RemoveAtRank(element mylist, int rank); /*question 4*/
void ChangeRanks(element mylist, int rank, int rank2); /*question 5*/
void PrintList( const List L );
void menu();

void main(){
    element P;
    int i;
    /*create list to use*/
    mylist = MakeEmpty( NULL );
    P = Header( mylist );
    for( i = 2; i <= 10; i++ )
    {
        Insert( i, mylist, P );
        P = Advance( P );
    }
	printf("List: ");
	PrintList( mylist );
	menu();
}


/*question 1*/
void PrintNum(element mylist, int rank){
       int i;
       /*we use for for finding number in structure mylist*/
       for(i=0;i<=rank;i++){
               if(i==rank)
                       printf("%d.rank value = %d",rank,mylist->value);
               if(mylist->next!=NULL){
                       mylist=mylist->next;
               }else{
                       i=rank+1;/*in order to finish for loop*/
               }
       }
}


/*question 2*/
void PrintRank(element mylist, int num){
       element head=mylist;
       int i=0;
       int ok; /*if ok == 1 number found*/
       /*first if is for if the number is rank 1*/
       if(head->value == num){
               printf("Numbers rank is %d",i);
               ok=1;
       }else{
               while(head->next!=NULL && ok!=1){
                       if(head->value == num){
                               printf("Numbers rank is %d",i);
                               ok=1;
                       }else{
                               i++;
                               head=head->next;
                       }
               }
       }
       /*we are checking the last element while loop wont check it since it will have its next as null*/
       if(ok!=1)
               if(head->value == num){
                       printf("Numbers rank is %d",i);
                       ok=1;
               }

       if(ok!=1)
               printf("The number does not exist in linked list");
}


/*question 3*/
void InsertAtRank(element mylist, int num, int rank){
	element head=mylist;
	element temp, TmpCell;
	int ok;
	int i=0;
	while(head->next!=NULL){
		if(i==rank && ok!=1){
			temp=head;
			TmpCell = (element)malloc(sizeof(element));
			temp=head;
			TmpCell->value=head->value;
			TmpCell->next=temp->next;
			temp->value=num;
			temp->next=TmpCell;
			ok=1;
		}
		i++;
		head=head->next;
	}
	/*if rank is bigger than number of elements in linked list it will be added to end*/
	if(ok!=1){
		TmpCell = (element)malloc(sizeof(element));
		TmpCell->value=num;
		TmpCell->next=NULL;
		head->next=TmpCell;
	}
	printf("New list is: ");
	PrintList( mylist );
}

/*question 4*/
void RemoveAtRank(element mylist, int rank){
	element head=mylist;
	int i=0, ok; /*if ok == 1 number found and deleted*/

	while(head->next!=NULL && ok!=1){
		if(i == rank){
			Delete( head->value, mylist );
			printf("New list is: ");
			PrintList( mylist );
			ok=1;
		}else{
			head=head->next;
			i++;
		}
	}

	if(ok!=1)
	       printf("The number does not exist in linked list");
}

/*question 5*/
void ChangeRanks(element mylist, int rank, int rank2){
	element head=mylist;
	element temp;
	int tempnum;
	int i=0;
	while(head->next!=NULL){
		i++;
		head = head->next;
	}
	head=mylist;
	/*checking if the given ranks exists in the linked list*/
	if(rank>i || rank2>i)
		printf("There are no elements in the given ranks (ranks does not exist)");
	else{
		if(rank>rank2){
			for(i=0;i<rank;i++){
				if(i==rank2){
					tempnum = head->value;
					temp = head;
				}
				head=head->next;
			}
			temp->value = head->value;
			head->value = tempnum;
		}else{
			for(i=0;i<rank2;i++){
				if(i==rank){
					tempnum = head->value;
					temp = head;
				}
				head=head->next;
			}
			temp->value = head->value;
			head->value = tempnum;
		}
		printf("New list is: ");
		PrintList( mylist );
	}
}


void menu(){
	int choice, value, value2;
	printf("\n1) Q1\n2) Q2\n3) Q3\n4) Q4\n5) Q5\nSelect: ");
	scanf("%d",&choice);
	switch(choice){
		case 1:
			printf("Please enter the number you wanted to shown:");
			scanf("%d",&value);
			PrintNum(mylist, value); /*question 1*/
		break;
		case 2:
			printf("Please enter the rank you wanted to shown:");
			scanf("%d",&value);
			PrintRank(mylist, value); /*question 2*/
		break;
		case 3:
			printf("Please enter the number:");
			scanf("%d",&value);
			printf("Please enter the rank:");
			scanf("%d",&value2);
			InsertAtRank(mylist, value, value2);
		break;		
		case 4:
			printf("Please enter the rank you wanted to get removed:");
			scanf("%d",&value);
			RemoveAtRank(mylist, value);
		break;
		case 5:
			printf("Please enter the rank first rank you want to get changed:");
			scanf("%d",&value);
			printf("Please enter the rank second rank you want to get changed:");
			scanf("%d",&value2);
			ChangeRanks(mylist, value, value2);case 0:break;
		break;
		default:
			printf("Please enter choose between 1-5");
		break;
	}
	menu();
}

/*print the linked list elements*/
void
PrintList( const List L )
{
    Position P = Header( L );

    if( IsEmpty( L ) )
        printf( "Empty list\n" );
    else
    {
        do
        {
            P = Advance( P );
            printf( "%d ", Retrieve( P ) );
        } while( !IsLast( P, L ) );
        printf( "\n" );
    }
}
