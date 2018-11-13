#include<stdio.h>
#include<conio.h>


void main()
{
 typedef struct
 {
  char name[20];
  char surname[20];
  int age;
 }T;

 FILE *f1 = fopen("binarywrite.dat", "w");
 FILE *f2 = fopen("printfwrite.txt", "w");

 T example= {"qwerty", "asdfg", 66};
 T tmp;


 fwrite(&example, sizeof(T), 1, f1);
 fprintf(f2, "%s %s %d", example.name, example.surname, example.age);

 fclose(f1);
 fclose(f2);
 f1 = fopen("binarywrite.dat", "r");
 f2 = fopen("printfwrite.txt", "r");

 fread(&tmp,  sizeof(T), 1, f1);

 printf("Read by fread:  %s %s %d\n", tmp.name, tmp.surname, tmp.age);


 fscanf(f2,  "%s %s %d", tmp.name, tmp.surname, &(tmp.age));

 printf("Read by fscanf: %s %s %d\n", tmp.name, tmp.surname, tmp.age);

 getch();

 fclose(f1);
 fclose(f2);
}