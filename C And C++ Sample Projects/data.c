#include<stdlib.h>

struct listnode {
  char data;
  struct listnode *nextptr;
};

typedef struct listnode ListNode;
typedef ListNode *ListNodePtr;

void insert(ListNodePtr *, char);
char delete(ListNodePtr *, char);
int isempty(ListNodePtr);
void printlist(ListNodePtr);
void instructions(void);

int main()
{
  ListNodePtr startptr=NULL;
  int choice;
  char item;

  instructions();
  printf("? ");
  scanf("%d",&choice);

  while(choice!=3)
  {
    switch(choice)
    {
      case 1:
	printf("Enter a character: ");
	scanf("\n%c",&item);
	insert(&startptr,item);
	printf("\n\n");
	printlist(startptr);
	printf("\n\n");
	instructions();
	break;
      case 2:
	if(!isempty(startptr))
	{
	  printf("Enter a character to be deleted: ");
	  scanf("\n%c",&item);
	  if(delete(&startptr,item))
	  {
	    printf("%c deleted\n\n",item);
	    printlist(startptr);
	    printf("\n\n");
	    instructions();
	  }
	  else
	  {
	    printf("%c not found\n\n",item);
	    instructions();
	  }
	}
	else
	{
	  printf("List is empty\n\n");
	  instructions();
	}
	break;
      default:
	printf("Invalid choice\n\n");
	instructions();
	break;
    }
    printf("? ");
    scanf("%d", &choice);
  }
  return 0;
}

void instructions(void)
{
  printf("Enter your choice:\n"
	 "1 - Insert\n"
	 "2 - Delete\n"
	 "3 - Quit\n");
}

void insert(ListNodePtr *sptr, char value)
{
  ListNodePtr newptr, previousptr, currentptr;

  newptr=malloc(sizeof(ListNode));

  if(newptr!=NULL)
  {
    newptr->data=value;
    newptr->nextptr=NULL;
    previousptr=NULL;
    currentptr=*sptr;

    while(currentptr!=NULL && value>currentptr->data)
    {
      previousptr=currentptr;
      currentptr=currentptr->nextptr;
    }
    if(previousptr==NULL)
    {
      newptr->nextptr=*sptr;
      *sptr=newptr;
    }
    else
    {
      previousptr->nextptr=newptr;
      newptr->nextptr=currentptr;
    }
  }
  else
    printf("%c not inserted. No memory available.\n\n",value);
}

char delete(ListNodePtr *sptr, char value)
{
  ListNodePtr previousptr, currentptr, tempptr;

  if(value==(*sptr)->data)
  {
    tempptr=*sptr;
    *sptr=(*sptr)->nextptr;
    free(tempptr);
    return value;
  }
  else
  {
    previousptr=*sptr;
    currentptr=(*sptr)->nextptr;

    while(currentptr!=NULL && currentptr->data!=value)
    {
      previousptr=currentptr;
      currentptr=currentptr->nextptr;
    }
    if(currentptr!=NULL)
    {
      tempptr=currentptr;
      previousptr->nextptr=currentptr->nextptr;
      free(tempptr);
      return value;
    }
  }
  return '\0';
}

int isempty(ListNodePtr sptr)
{
  return sptr==NULL;
}

void printlist(ListNodePtr currentptr)
{
  if(currentptr==NULL)
    printf("List is empty.\n\n");
  else
  {
    printf("The list is:\n\n");
    while(currentptr!=NULL)
    {
      printf("%c -->", currentptr->data);
      currentptr=currentptr->nextptr;
    }
    printf("NULL\n\n");
  }
}