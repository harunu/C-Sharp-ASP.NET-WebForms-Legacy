#include <stdio.h>

struct linked_list {
	int value; //the data that we store in one element
   	struct linked_list *next; //link to next element in the list

}

typedef struct linked_list ELEMENT;

void print_list(ELEMENT *list) {

	while(list->next!=NULL)
	{
		printf("%d\n",list->value);
		list=list->next;
		
	}
	printf("%d",list->value);
}

void insert(ELEMENT *list, int temp_num){
	ELEMENT temp;
	ELEMENT *k;
	k=list;
	temp=malloc(sizeof(ELEMENT));
	if(temp_num<k->value)
		temp=k->next;
		k=k->next->next;
	}
}

void delete_item(ELEMENT *list, int pos){
	ELEMENT *K;
	ELEMENT temp;
	K=list;
	while(list->value!=pos){
		list=list->next;
	}
	temp->next=list;
	list->next=list->next->next;
	free(temp->next);

default: printf("there is no element in the given position\n");
}


void update_value(ELEMENT *list, int pos, int delta){
	int i=1;
	ELEMENT *K;
	K=list;

	while(i<pos-1) {
		list->next=list->next->next;
	}
	
	list->next->value+=5;

	while(K->next!=NULL) {
		if(K->value<list->value)
			list->next=K;
	}
		list=list->next;
}
		while (K->value>K->next->value){
			K=K->next;
		}
		K=K->next->next;
}



void main(void)
{
	int number;
	char choice;
	ELEMENT * mylist;
	mylist->next=NULL;
	{
		printf("what do you want? (I) Insert,(R) Remove, (P) Print, (U) Update (Q) Quit:\n");
		scanf("%c",choice) {
			case 'I': printf("Enter number:\n");
				scanf("%d",&number);
				insert_list(mylist,number);
				break;
			case 'R' : printf("Enter number:\n");
				scanf("%d",&number);
				delete_list(mylist,number);
				break;

			case 'P' : print_list(mylist);
				break;

			case 'U' : update_value(mylist,number,4);
				break;

			case 'Q' : exit(0);
					break;

			default: printf("ERROR!!!\n");
		}
	}
}
