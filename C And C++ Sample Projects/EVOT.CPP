#include <stdio.h>
#include <conio.h>
#include <string.h>


typedef struct vtr
{
 char name[20], pass[20];
 int voted;
} V;

typedef struct cnd
{
 char name[20];
 char surname[20];
 char party[20];
 int votes;
 int id;
 int isdropped;
} C;

typedef struct vt
{
 int v[50];
} Votes;

V currentvtr;
int noofvoters = 0, noofcands = 0;

int voterlogin(V *voters)
{
 char c, username[20], password[20];
 int i = 0, n = 0;
 FILE *f1;

  printf("enter username: ");
  scanf("%s", username);
  printf("enter password: ");
  scanf("%s", password);

  if(( f1 = fopen("voterinf.dat", "r"))==NULL){
	  printf("File could not be opened.\n")}
  else{

  while (!feof(f1))
  {
  fscanf(f1, "%s %s %d\n", voters[n].name, voters[n].pass, &(voters[n].voted));
  n++;
  }
  n = noofvoters;
  for(i=0;i<=n;i++)
  {
   if(strcmp(voters[i].name, username)==0 && strcmp(voters[i].pass, password)==0 && voters[i].voted == 0)
   {
    currentvtr = voters[i];
    return i + 1;
   }
  }
  flose(f1);
  return 0;
}


int isdup(int n, int v[], int k)
{
int i;

 for (i = 0; i<k; i++)
  if (n == v[i])
   return 1;
 return 0;
}

int loadcands(C *c)
{
 FILE *f3 = fopen("cands.dat", "r");
 int i,j, n= 0;

 while(!feof(f3))
 {
  fscanf(f3, "%s %s %s\n", c[n].name, c[n].surname, c[n].party);
  n++;
 }
 noofcands = n;
 for (i = 0; i<n; i++)
 {
  for (j = i + 1; j<n; j++)
   if (strcmp(c[i].surname, c[j].surname) > 0)
   {
    C hold = c[i];
    c[i] = c[j];
    c[j] = hold;
   }
  c[i].id = i + 1;
 }
 fclose(f3);
 return n;
}

int printcands(C *c, int n)
{
 int i;

 printf("%-2s %-20s %-20s %-20s\n", "ID", "Name", "Surname", "Party");
 printf("____________________________________________________\n");
 for (i = 0; i < n; i++)
 {
  printf("%-2d %-20s %-20s %-20s\n", c[i].id, c[i].name, c[i].surname, c[i].party);
 }
 return n;
}

void getvote(C *c)
{
 FILE *f2 = fopen("votes.dat","a+");

 int vot[100] = {0},vt, i, n = loadcands(c);

 printcands(c, n);

 printf("Please enter your votes:");

 for (i = 0; i< n; i++)
 { do
   {
    scanf("%d", &vt);
    if (isdup(vt, vot, i) || vt < 0 || vt > n)
    {
     printf("Invalid or duplicate vote... please enter it again.\n");
    }
    else
     break;
   }while (1);
 vot[i] = vt;
 }

 for (i = 0; i < n; i++)
  fprintf(f2, "%d ", vot[i]);

 fprintf(f2, "\n");
 fclose(f2);
}

void writevoters(V *v)
{
 int i;

 FILE *f4 = fopen("voterinf.dat", "w");

 for (i = 0; i < noofvoters; i++)
  fprintf(f4, "%s %s %d\n", v[i].name, v[i].pass, v[i].voted);
 fclose(f4);
}

int adminlogin()
{
 FILE *f5 = fopen("admin.dat", "r");

 char username[20], password[20], username2[20], password2[20];

  printf("enter username: ");
  scanf("%s", username);
  printf("enter password: ");
  scanf("%s", password);

  fscanf(f5, "%s %s\n", username2, password2);

  fclose(f5);

  if(strcmp(username, username2) == 0 && strcmp(password, password2) == 0)
   return 1;
  else
   return 0;
}

int main()
{
 char c;
 int  vind;
 FILE *f1;
 V voters[100];
 C cands[50];

 do
 {
 clrscr();
 printf("press v for voter login, a for admin login\n");
 scanf("%c", &c);
 if (c == 'v')
 {
  if ((vind = voterlogin(voters)) != 0)
  {
   getvote(cands);
   voters[vind - 1].voted = 1;
   writevoters(voters);
   printf("Voting is done. press a key to quit.");
  }
  else
  {
   printf("Bad password or you have already voted.\n");
  }
 }
 else if (c == 'a')
 {
  if (adminlogin() == 1)
  {
   char cc;
   C cn[50];
   int n, i, j;

   printf("logged in as admin.\n");
   n = loadcands(cn);
   do
   {
   printf("please enter choice.\n");
   printf("1 - add candidate\n");
   printf("2 - delete candidate.\n");
   printf("3 - count votes.\n");
   printf("4 - exit.\n");
   fflush(stdin);
   scanf("%c", &cc);

   if (cc == '1')
   {
    if (n < 50)
    {
     C newc;
     printf("enter name:");
     scanf("%s", newc.name);
     printf("enter surname:");
     scanf("%s", newc.surname);
     printf("enter party:");
     scanf("%s", newc.party);

     cn[n] = newc;

     for (i = 0; i<n; i++)
     {
     for (j = i + 1; j<n; j++)
      if (strcmp(cn[i].surname, cn[j].surname) > 0)
      {
       C hold = cn[i];
       cn[i] = cn[j];
       cn[j] = hold;
      }
     cn[i].id = i + 1;
     }
     noofcands++;
     n++;
    }
    else
     printf("no place for new cand.");
   }
   else if (cc == '2')
   {
    int id;
    printcands(cn, n);
    printf("\nPlease enter id to delete: ");
    scanf("%d", &id);

    cn[id - 1].name[0] = '\0';
    cn[id - 1].surname[0] = '\0';
    cn[id - 1].party[0] = '\0';
    cn[id - 1].id = 0;
    cn[id - 1].votes = 0;
    cn[id - 1].isdropped = 0;

    for (i = id - 1; i < n - 1; i++)
    {
     cn[i] = cn[i + 1];
    }
    noofcands--;

   }
   else if (cc == '3')    //counting
   {
    FILE *f7 = fopen("votes.dat", "r");
    int vlist[100][50], i, j = 0, roff = 1, nv, c;
    char a[20], b[20];

    FILE *f8 = fopen("voterinf.dat", "r");
    while (!feof(f8))
    {
     fscanf(f8, "%s %s %d\n", a, b, &c);
     nv++;
    }
    noofvoters = nv;
    fclose(f8);

    for(j=0; j < noofvoters; j++)
    {
     for (i = 0; i < noofcands; i++)
     {
      fscanf(f7, "%d ", &(vlist[j][i]));
     }
    }

    fclose(f7);

    for (i = 0; i < noofcands; i++)
    {
     cn[i].votes = 0;
     cn[i].isdropped = 0;
    }
//-----
   C mostpop = cn[0], leastpop = cn[0];

   for(i = 0; i < noofvoters; i++)
    {
     j = 0;
     while (cn[vlist[i][j]].isdropped != 0 && j < noofvoters)
      j++;
     cn[vlist[i][j] - 1].votes++;
    }

    for (i = 1; i < noofcands; i++)
     if (cn[i].votes > mostpop.votes)
     {
      mostpop = cn[i];
     }
     else if (cn[i].votes < leastpop.votes)
     {
      leastpop = cn[i];
     }

    if ((float) mostpop.votes / noofvoters * 100 >= 50.0)
    {
     printf("%s %s won the election with %0.2f%% of %d votes.\n", mostpop.name, mostpop.surname, (float) mostpop.votes / noofvoters * 100.0, noofvoters);

     getch();
     return 0;
    }
    else
    {
     leastpop.isdropped = roff++;
     printf("%s %s is dropped in %d. roundoff with %-0.2f%%.\n", leastpop.name, leastpop.surname, (float) leastpop.votes / noofvoters * 100.0, noofvoters);
    }
    }


   else if (cc == '4')
   {
    FILE *f6 = fopen("cands.dat", "w");
    for (i = 0; i<noofcands; i++)
     fprintf(f6, "%s %s %s\n", cn[i].name, cn[i].surname, cn[i].party);
    break;
   }
   char r;
   printf("quit? (q): ");
   scanf("%c", &r);
   if (r == 'q')
    break;
   } while (1);
  }
  else
  {
   printf("invalid admin account.");
  }

 }
 getch();

 printf("Do you wanna login as another user (y/n)? ");
 char cc;
 scanf("%c", &cc);
 if (cc != 'y')
  break;
 } while(1);
}