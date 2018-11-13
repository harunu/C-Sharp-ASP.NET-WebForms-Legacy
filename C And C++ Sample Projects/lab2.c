# include <stdio.h>
# include <conio.h>
void main ()
{
    int number;
    char choice;
	ELEMENT *mylist;
	mylist -> next = NULL;
	{
     printf ("What do you want? (I) Insert, (R) Remove, (P) Print, (U) Update, (Q) Quit");
     scanf("%c", &choice);
     switch(choice) {
                    
     case'i' : printf("Enter your number: \n");
               scanf("%d",&number);
               insert_list (mylist,number);
               break;
     case'r' : printf("Enter your  number: \n");
               scanf("%d",&number);
               delete_list (mylist,number);
               break;
     case'p' : print_list (mylist);
               break;          
     case'u' : update_valu (mylist,number,4);
               break; 
     case'q' : exit (0);
               break; 
     default : printf("Error \n");
                         
     struct linked_list {
            int value;
            struct linked_list *next;
}
     typedef struct linked_list ELEMENT;
     void print_list (ELEMENT *list) {
          while(list -> next != NULL) {
                printf("%d",list -> Value);
                list = list->next;
                }
            printf("%d",list->value);         
     }
     
     void insert(ELEMENT *list, int temp_num) {
     }
     
     void remove(ELEMENT *list, int temp_num) {
     }
     void update_list(ELEMENT *list, int i=1, int sira, int delta) {
          ELEMENT *K;
          K=L;
          ELEMENT temp;
          while (i < sira) {
                list = list->next;
                }
                list->value+=5;
                
                while(K->next != NULL) {
                      if (K->next->value<list->next->value) {
                          list->next->next = K->next;
                          K=list->next;
                          }
                          list = list->next;
                          }                            
}
