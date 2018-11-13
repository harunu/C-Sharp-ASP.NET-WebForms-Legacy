

#include<stdio.h>
#include <malloc.h>
	

#include <conio.h>

 	

#include <stdlib.h>


 struct barbie
   {
	 int coff;
	 int pow;
	 struct barbie *link;
	}*ptr,*start1,*node,*start2,*start3,*ptr1,*ptr2;
	typedef struct barbie bar;
	int temp1,temp2;

  int main()
	 {

	  void create(void);
	  void prnt(void);
	  void suml(void);
	  void sort(void);
	  
	  printf("Enrter the elements of the first poly :");
	  node = (bar *) malloc(sizeof (bar));
	  start1=node;
	  if (start1==NULL)
		 {
		   printf("Unable to create memory.");
		   getch();
		   return 0;
		  }
	  create();

	  printf("Enrter the elements of the second poly :");
	  node = (bar *) malloc(sizeof (bar));
	  start2=node;
	  if (start2==NULL)
		 {
		   printf("Unable to create memory.");
		   getch();
		   return 0;
		  }
	  create();
	  
	  //printing the elements of the lists
	  printf("The elements of the poly first are :");
	  ptr=start1;
	  prnt();

	  printf("The elements of the poly second are :");
	  ptr=start2;
	  prnt();

	  printf("The first sorted list is :");
	  ptr=start1;
	  sort();
	  ptr=start1;
	  prnt();

	  printf("The second sorted list is :");
	  ptr=start2;
	  sort();
	  ptr=start2;
	  prnt();

	  printf("The sum of the two lists are :");
	  suml();
	  ptr=start3;
	  prnt();

	  getch();

	 }


	 void create()
	   {
		 char ch;
		 while(1)
		  {
			printf("Enter the coff and pow :");
			scanf("%d%d",&node->coff,&node->pow);
			if (node->pow==0 )
				  {
					ptr=node;
					node=(bar *)malloc(sizeof(bar));
					node=NULL;
					ptr->link=node;
					break;
				  }

			printf("Do u want enter more coff ?(y/n)");
			fflush(stdin);
			scanf("%c",&ch);
				 if (ch=='n' )
				  {
					ptr=node;
					node=(bar *)malloc(sizeof(bar));
					node=NULL;
					ptr->link=node;
					break;
				  }
			  ptr=node;
			  node=(bar *)malloc(sizeof(bar));
			  ptr->link=node;
			}
		}

	  void prnt()
		{  int i=1;

		   while(ptr!=NULL )
			 {
				if(i!=1)
				printf("+ ");
				printf(" %dx^%d ",ptr->coff,ptr->pow);
				ptr=ptr->link;
				i++;
			 }
			//printf(" %d^%d",ptr->coff,ptr->pow);
		 }

	void sort()
	 {
		for(;ptr->coff!=NULL;ptr=ptr->link)
			  for(ptr2=ptr->link;ptr2->coff!=NULL;ptr2=ptr2->link)
				{
				  if(ptr->pow>ptr2->pow)
					{
					  temp1=ptr->coff;
					  temp2=ptr->pow;
					  ptr->coff=ptr2->coff;
					  ptr->pow=ptr2->pow;
					  ptr2->coff=temp1;
					  ptr2->pow=temp2;

					}
				 }
	  }


	   void suml()
		 {
		   node=(bar *)malloc (sizeof(bar));
		   start3=node;

		   ptr1=start1;
		   ptr2=start2;

		   while(ptr1!=NULL && ptr2!=NULL)
		   {
			  ptr=node;
			  if  (ptr1->pow > ptr2->pow )
				{
				  node->coff=ptr2->coff;
				  node->pow=ptr2->pow;
				  ptr2=ptr2->link;   //update ptr list B
				 }
			   else if ( ptr1->pow < ptr2->pow )
				{
				  node->coff=ptr1->coff;
				  node->pow=ptr1->pow;
				  ptr1=ptr1->link;   //update ptr list A
				 }
			   else
				 {
				  node->coff=ptr2->coff+ptr1->coff;
				  node->pow=ptr2->pow;
				  ptr1=ptr1->link;   //update ptr list A
				  ptr2=ptr2->link;   //update ptr list B

				 }

				 node=(bar *)malloc (sizeof(bar));
				 ptr->link=node;   //update ptr list C
			  }//end of while

		   if (ptr1==NULL)     //end of list  A
			  {
				while(ptr2!=NULL)
				  {
					node->coff=ptr2->coff;
					node->pow=ptr2->pow;
					ptr2=ptr2->link;   //update ptr list B
					ptr=node;
					node=(bar *)malloc (sizeof(bar));
					ptr->link=node;   //update ptr list C
				  }
			  }

			else if (ptr2==NULL)     //end of list  B
			  {
				while(ptr1!=NULL)
				  {
					node->coff=ptr1->coff;
					node->pow=ptr1->pow;
					ptr1=ptr1->link;   //update ptr list B
					ptr=node;
					node=(bar *)malloc (sizeof(bar));
					ptr->link=node;   //update ptr list C
				  }
			  }
		  node=NULL;
		  ptr->link=node;
		}
