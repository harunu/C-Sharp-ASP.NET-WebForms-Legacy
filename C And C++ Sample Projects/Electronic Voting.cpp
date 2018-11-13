//Omer SALMANOGLU

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <dos.h>

int MenuResult;//Menu sonucunu result fonkriyonuna yolla
char username[20];
char userlastname[20];
char password[20];


struct queueNode{//Dosyaya kullan?c?dan girilen votelar? yazarken kulland?§?m datat struct
    int vote;
    struct queueNode *nextptr;
    };

typedef struct queueNode QueueNode;
typedef QueueNode *QueueNodePtr;






struct svote{//Votelar? tek tek dosyaya atmak i?in kulland?§?m struct
    int vote;
};
typedef svote Svote;
Svote Vote;

struct sadmin{            //Admin bilgilerini program ba?lad?§?nda alan ve
       char username[20];// dosyaya yaz?lmas?n? sa§layan struct
       char password[20];
       char message[80];
       int startstopvoting;
};
typedef sadmin Sadmin;
Sadmin Admin;

struct svoter{    //Candidate ve Voter lar?n bilgilerini tutan struct
       char name[30];
       char lastname[30];
       char password[30];
       int digit;
       int account;
       int vote;
       };
typedef svoter Svoter;
Svoter Voter;
Svoter Candi;


void WhoamI();//Ben kimim Komutu
void MyWindow(int,int,int,int,int,int);//Pencereleri yaratmak i?in kulan?lan Komut
void cerceve (int,int,int,int,int,int);//Pencerelerin i?indeki cercevyi yapan komut
void yazc (int,int,char,int,int);//Pencelerin ve cercevelerin yap?m?nda kullan?l?r
void yaz (int,int,char,int,int); //Pencelerin ve cercevelerin yap?m?nda kullan?l?r
void secenek(int,int,int,int,int,int,int);//Menu fonsiyonundan gelen veriye göre secenek yaz fonsiyonunu çalýþtýran fonsiyon
void secenekyaz(int,int,int,int,int,int,int,int,int);//Menu fonsiyonundan gelen veriye göre yazýlarýn renkleri ve arka renkleri ile oynayan fonksiyo
void Join(int,int,int,int,int,int,int);//Voterlar?n sisteme giri? yapabilmesini sa§layan veya engelleyen Fonkiyon
void AdminEntry(int,int,int,int,int,int);//Adminin sisteme giri?ini sa§layan fonsiyon
void MessageToVoter(int,int,int,int,int,int);//Admin taraf?ndan kullan?c?ya mesaj yollayan fonsiyon
void MessageReader(int,int,int,int,int,int);//Kullan?cn?n Adminin yollad?§? mesaj? okumas?n? sa§layan fonsiyon
void ShowCandi(int,int,int,int,int,int);//Candidateleri s?ralay?p kullan?c?ya g?steren program
char message[80];
int Menu(int,int,int,int,int,int,int);//Menu Komutu
int Startup();//ba?lang?? fonsiyonu
void AdminID();//Program ilk a??l?rken admine verilen kullan?c? ad? ve ?ifreyi dosyaya yazd?ran program
int EntryMenuResult(int);//Giri? menusunden gelen Sonuca bakarak i?lem yapar
int AdminMenuResult(int);//Admin menusunden gelen Sonuca bakarak i?lem yapar
int VoterMenuResult(int);//Voter menusunden gelen Sonuca bakarak i?lem yapar
int CandiMenuResult(int);//Candidate menusunden gelen Sonuca bakarak i?lem yapar
int VoterscrMenuResult(int);//Voter Ekran?ndaki menuden gelen Sonuca bakarak i?lem yapar
int Adminscr(int,int,int,int,int,int);//Admin i?in pencere olu?turan ve menusunu yapan fonsiyon
int Voterscr(int,int,int,int,int,int);//Voter ve Candidate i?in pencere olu?turan ve menusunu yapan fonsiyon
int VotingScr(int,int,int,int,int,int);//Vote vermek i?in pencere olu?turan ve menusunu yapan fonsiyon
int Registeruser(int,int,int,int,int,int,int);//Candidate ve Voter register eden fonksiyon
int ListUser(int);//Candidate ve Voter List eden fonksiyon
int DeleteUser(int);//Candidate ve Voter silen eden fonksiyon
void insertqueue(QueueNodePtr *headptr,QueueNodePtr *tailptr,int data);//Kullan?c?dan girilen oylar? tek tek al?p s?raya dizen fonsiyon
void printqueue(QueueNodePtr currentptr);//s?raya dizilen votelar? tek tek dosyaya yazd?ran fonsiyon
int isEmpty(QueueNodePtr headptr);
void StartVoting();//Oylamay? ba?lat?r
void StoppVoting();//oylamay? bitiriken yap?lmas? gereken baz? i?lemler i?erir
void FinishVoting(int,int,int,int,int,int);//oylamay? bitirir
void Exit(int,int,int,int,int,int);//Çýkýþ için fonsiyon.

int main(){
    Startup();
    return 0;
}


Startup(){

    char secim;
    clrscr();
    AdminID();
    MyWindow(2,2,78,23,3,15);
    WhoamI();
    Menu(48,11,73,20,9,15,1);
    EntryMenuResult(MenuResult);
    getch();
    return 0;
}


void WhoamI(){
    gotoxy(3,17);cprintf("?MER SALMANO¦LU");
    gotoxy(3,18);cprintf("20202CS073");
    gotoxy(3,19);cprintf("e-m@il=omer.salmanoglu@gmail.com");
    gotoxy(3,20);cprintf("ICQ=11003354");
    }

void yaz (int x,int y,char yazi[],int tc,int tbc)
{ 
      textcolor(tbc);
      textbackground(tc);
      gotoxy(x,y);cputs(yazi);
}
void yazc (int x,int y,char yazi,int tc,int tbc)
{ 
      textcolor(tbc);
      textbackground(tc);
      gotoxy(x,y);cprintf("%c",yazi); 
} 
  
void cerceve (int x1,int y1,int x2,int y2,int tc,int tbc)
{
      int sayac;
      sayac=0;
      do 
      { 
    yaz(x1+sayac,y1,"Í",tc,tbc);
    yaz(x1+sayac,y2,"Í",tc,tbc);
            sayac++; 
      }while (sayac<=x2-x1); 
      sayac=0; 
      do 
      {
    yaz(x1,y1+sayac,"º",tc,tbc);
    yaz(x2,y1+sayac,"º",tc,tbc);
            sayac++; 
      }while (sayac<=y2-y1); 
      yaz(x1,y1,"É",tc,tbc);
      yaz(x2,y1,"»",tc,tbc);
      yaz(x1,y2,"È",tc,tbc);
      yaz(x2,y2,"¼",tc,tbc);
} 
void MyWindow (int x1,int y1,int x2,int y2,int tc,int tbc)
{ 
      window (x1+1,y1+1,x2+1,y2+1);
      textbackground(0);
      clrscr();
      window (1,1,80,24);
      cerceve (x1,y1,x2,y2,tc,tbc);
      window (x1+1,y1+1,x2-1,y2-1);
      clrscr();
}

int Menu(int x1, int y1, int x2, int y2,int tc, int tbc,int MenuNo){

    int kursor,karakter,secim;
    window(1,1,80,24);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    kursor=1;
    secenek(x1+1,y1,x2,9,3,kursor,MenuNo);
    while (secim!=1){
  karakter=getch();


  switch(karakter){
case 27:exit(0);break;
case 72:kursor--;secenek(x1+1,y1,x2,9,3,kursor,MenuNo);break;
case 80:kursor++;secenek(x1+1,y1,x2,9,3,kursor,MenuNo);break;
case 13:secim=1;MenuResult=kursor;break;
  }

    }
   return 0;
}
void secenek(int x1,int y1,int x2,int tc,int tbc,int secim,int MenuNo){
     textcolor(tc);
     switch(secim){
case 1:
secenekyaz(x1,y1,x2,tbc,9,9,9,9,MenuNo);
break;
case 2:
secenekyaz(x1,y1,x2,9,tbc,9,9,9,MenuNo);
break;
case 3:
secenekyaz(x1,y1,x2,9,9,tbc,9,9,MenuNo);
break;
case 4:
secenekyaz(x1,y1,x2,9,9,9,tbc,9,MenuNo);
break;
case 5:
secenekyaz(x1,y1,x2,9,9,9,9,tbc,MenuNo);
break;
     }
     }

void secenekyaz(int x1,int y1,int x2,int tbc1,int tbc2,int tbc3,int tbc4,int tbc5,int MenuNo){
     switch(MenuNo){
     case 1:
     textcolor(15);
     textbackground(tbc1);
     window(x1+1,y1+1,x2-1,y1+2);
     cprintf(" Description & Manual ");
     textbackground(tbc2);
     window(x1+1,y1+2,x2-1,y1+3);
     cprintf("      Admin Entry     ");
     textbackground(tbc3);
     window(x1+1,y1+3,x2-1,y1+3);
     cprintf("         Vote         ");
     textbackground(tbc4);
     window(x1+1,y1+4,x2-1,y1+4);
     cprintf("         Exit         ");
     break;
     case 2:
     FILE *readptr;
     if ((readptr=fopen("admindb.dat","r+"))=='\0'){
readptr=fopen("admindb.dat","w");
}
     fread(&Admin,sizeof(sadmin),1,readptr);
     textcolor(15);
     textbackground(tbc1);
     window(x1+1,y1+1,x2-1,y1+2);
     cprintf(" Candidates Processes ");
     textbackground(tbc2);
     window(x1+1,y1+2,x2-1,y1+3);
     cprintf("   Voter Processes    ");
     textbackground(tbc3);
     window(x1+1,y1+3,x2-1,y1+4);
     cprintf("  Message to Voters   ");
     if(Admin.startstopvoting==0){
textbackground(tbc4);
window(x1+1,y1+4,x2-1,y1+5);
cprintf("    Start Voting      ");
     }else{
textbackground(tbc4);
window(x1+1,y1+4,x2-1,y1+5);
cprintf("     Stop Voting      ");
     }
     fclose(readptr);
     textbackground(tbc5);
     window(x1+1,y1+5,x2-1,y1+6);
     cprintf("    Close Window      ");
     break;
     case 3:
     textcolor(15);
     textbackground(tbc1);
     window(x1+1,y1+1,x2-1,y1+2);
     cprintf(" Register New Voter ");
     textbackground(tbc2);
     window(x1+1,y1+2,x2-1,y1+3);
     cprintf("    Delete Voter    ");
     textbackground(tbc3);
     window(x1+1,y1+3,x2-1,y1+4);
     cprintf("   List All Voters  ");
     textbackground(tbc4);
     window(x1+1,y1+4,x2-1,y1+5);
     cprintf("    Close Window    ");
     break;
     case 4:
     textcolor(15);
     textbackground(tbc1);
     window(x1+1,y1+1,x2-1,y1+2);
     cprintf("Register New Candidates");
     textbackground(tbc2);
     window(x1+1,y1+2,x2-1,y1+3);
     cprintf("    Delete Candidates  ");
     textbackground(tbc3);
     window(x1+1,y1+3,x2-1,y1+4);
     cprintf("   List All Candidates ");
     textbackground(tbc4);
     window(x1+1,y1+4,x2-1,y1+5);
     cprintf("      Close Window     ");
     break;
     case 5:
     textcolor(15);
     textbackground(tbc1);
     window(x1+1,y1+1,x2-1,y1+2);
     cprintf("       Vote        ");
     textbackground(tbc2);
     window(x1+1,y1+2,x2-1,y1+3);
     cprintf("  Show Candidates  ");
     textbackground(tbc3);
     window(x1+1,y1+3,x2-1,y1+4);
     cprintf("   Read Message    ");
     textbackground(tbc4);
     window(x1+1,y1+4,x2-1,y1+5);
     cprintf("   Close Window    ");
     break;
     }
     }



int EntryMenuResult(int sonuc){
    switch (sonuc){
case 1:
         textcolor(1);
         window(3,3,50,20);
cprintf("This is a electronic Voting system.    ");
         window(3,4,50,20);
         cprintf("Voter use their votes if they are      ");
         window(3,5,50,20);
         cprintf("registered the voting system by        ");
         window(3,6,50,20); 
         cprintf("admin.Only Admin starts/stops the      ");
         window(3,7,50,20);
         cprintf("voting.Voter can vote by using Vote    ");
         window(3,8,50,20);
         cprintf("button but its requires name ,lastname ");
         window(3,9,50,20);
         cprintf("and password.For password they could   ");
         window(3,10,50,20);
         cprintf("write their names                      ");
getch();
Startup();
break;
case 2:
AdminEntry(5,5,46,10,9,15);
break;
case 3:
int votingstatus;
FILE *readptr;
if ((readptr=fopen("admindb.dat","r+"))=='\0'){
    readptr=fopen("admindb.dat","w");
}
fread(&Admin,sizeof(sadmin),1,readptr);
votingstatus=Admin.startstopvoting;
fclose(readptr);
Join(5,5,46,11,9,15,votingstatus);

break;
case 4:
Exit(20,9,56,15,9,15);
break;

}

    return 0;
    }

void AdminID(){

     FILE *writeptr;
     if ((writeptr=fopen("admindb.dat","r+"))=='\0'){

       writeptr=fopen("admindb.dat","w");
       strcpy(Admin.message,"");
       strcpy(Admin.username,"Admin");
       strcpy(Admin.password,"omer3264");
       Admin.startstopvoting=0;
       fseek(writeptr,0,0);
       fwrite(&Admin,sizeof(sadmin),1,writeptr);
     }


     fclose(writeptr);

}



void AdminEntry(int x1,int y1,int x2,int y2,int tc,int tbc){
   int user=0;
   int pass=0;
   FILE *readptr;

   while(user!=1&&pass!=1){
    window(1,1,80,24);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    window(x1+1,y1+1,x2-1,y1+2);
    printf("Enter Admin Username and Password:");
    window(x1+1,y1+3,x2-1,y1+4);
    printf("Username:");
    scanf("%s",username);
    window(x1+1,y1+4,x2-1,y1+5);
    printf("Password:");
    scanf("%s",password);

     if ((readptr=fopen("admindb.dat","r+"))=='\0'){
       readptr=fopen("admindb.dat","w");
     }
     fread(&Admin,sizeof(sadmin),1,readptr);
     if((strcmp(Admin.username,username)==0)&&(strcmp(Admin.password,password)==0)){
Adminscr(2,2,78,23,3,15);
user=1;
pass=1;
     }
   }


fclose(readptr);

}
void Join(int x1,int y1,int x2,int y2,int tc,int tbc,int voting){
   int karakter;
   int user=0;
   int pass=0;
   if(voting==1){
   FILE *readptr;

   while(user!=1&&pass!=1){
    window(1,1,80,24);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    window(x1+1,y1+1,x2-1,y2-1);
    printf("Please Enter Full Name and Password:");
    window(x1+1,y1+3,x2-1,y2-1);
    printf("Name:");
    scanf("%s",username);
    window(x1+1,y1+4,x2-1,y2-1);
    printf("Lastname:");
    scanf("%s",userlastname);
    window(x1+1,y1+5,x2-1,y2-1);
    printf("Password:");
    scanf("%s",password);

     if ((readptr=fopen("voterdb.dat","r+"))=='\0'){
       readptr=fopen("voterdb.dat","w");
     }
     int vno,vs;
     fseek(readptr,0,2);
     vs=ftell(readptr)/(sizeof(svoter));
     fseek(readptr,0,0);
     vno=0;
     while(vno<vs){//Kullanýcýný girdiði isme soyisme ve þifreye göre giriþ için izin veren döngü
       fread(&Voter,sizeof(svoter),1,readptr);
       if((Voter.account==1)&&(Voter.vote==0)){
if((strcmp(Voter.name,username)==0)&&(strcmp(Voter.lastname,userlastname)==0)){
   if(strcmp(Voter.password,password)==0){
     Voterscr(2,2,78,23,3,15);
     user=1;
     pass=1;
   }
}
}
     vno++;
     }
   }


fclose(readptr);
}else{
window(1,1,80,24);//Votingin baþlamamasý konumunda gelecek olan ekran
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    window(x1+4,y1+3,x2-1,y2-1);
    printf("!!!!!Voting isn't started!!!!!");
    sleep(3);
    Startup();

}
}

int Adminscr(int x1,int y1,int x2,int y2,int tc,int tbc){
    window(1,1,80,24);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    Menu(50,4,75,10,9,15,2);
    AdminMenuResult(MenuResult);
    getch();
     return 0;
    }

int AdminMenuResult(int sonuc){
    switch (sonuc){
case 1:
   Menu(48,13,75,18,9,15,4);
   CandiMenuResult(MenuResult);
   break;
case 2:
   Menu(50,13,75,18,9,15,3);
   VoterMenuResult(MenuResult);
   break;
case 3:
   MessageToVoter(4,18,76,21,15,3);
   break;
case 4:
   FILE *readptr;
   if ((readptr=fopen("admindb.dat","r+"))=='\0'){
       readptr=fopen("admindb.dat","w");
    }
   fread(&Admin,sizeof(sadmin),1,readptr);
   if(Admin.startstopvoting==0){
     StartVoting();
   }else{
     FinishVoting(5,5,35,15,15,9);
   }
   fclose(readptr);
   Adminscr(2,2,78,23,3,15);
   break;
case 5:
   Startup();
   break;
}

    return 0;
    }
int VoterMenuResult(int sonuc){
    switch (sonuc){
case 1:
   Registeruser(5,5,30,15,9,15,1);
   break;
case 2:
   DeleteUser(1);
   break;
case 3:
   ListUser(1);
   break;
case 4:
   Adminscr(2,2,78,23,3,15);
   break;

}

    return 0;
    }
int CandiMenuResult(int sonuc){
    switch (sonuc){
case 1:
   Registeruser(5,5,30,15,9,15,0);
   break;
case 2:
   DeleteUser(0);
   break;
case 3:
   ListUser(0);
   break;
case 4:
   Adminscr(2,2,78,23,3,15);
   break;

}

    return 0;
    }
int VoterscrMenuResult(int sonuc){
    switch (sonuc){
case 1:
   VotingScr(5,7,30,17,15,9);
   break;
case 2:
   ShowCandi(5,7,30,15,9,15);
   break;
case 3:
   MessageReader(4,19,76,21,15,9);
   break;
case 4:
   Startup();
   break;

}

    return 0;
    }
int Registeruser(int x1,int y1,int x2,int y2,int tc,int tbc,int state){
    char filename[15];
    int number1=0;
    int number2=0;

    FILE *writeptr;
    if(state==1){
       strcpy(filename,"voterdb.dat");
    }else{
       strcpy(filename,"candidatedb.dat");
    }

    window(x1+1,y1+1,x2-1,y2-1);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);

    printf("Name:");
    window(x1+1,y1+2,x2-1,y2-1);
    printf("Lastname:");
    if(state==1){
      window(x1+1,y1+3,x2-1,y2-1);
      printf("Password:");
    }
    if ((writeptr=fopen(filename,"r+"))=='\0'){
       writeptr=fopen(filename,"w");
       }
    if(state==1){
    while(!feof(writeptr)){
       fseek(writeptr,sizeof(svoter)*number1,0);
       fread(&Voter,sizeof(svoter),1,writeptr);


       number1=Voter.digit;
       number1++;

    }
    }else{
    while(!feof(writeptr)){
       fseek(writeptr,sizeof(svoter)*number2,0);
       fread(&Candi,sizeof(svoter),1,writeptr);
       number2=Candi.digit;
       number2++;

    }
    }
    window(x1+6,y1+1,x2-1,y2-1);
    if (state==1){
       gets(Voter.name);
    }else{
       gets(Candi.name);
    }
       window(x1+10,y1+2,x2-1,y2-1);
       if (state==1){
gets(Voter.lastname);
window(x1+10,y1+3,x2-1,y2-1);
gets(Voter.password);
       }if (state==0){
gets(Candi.lastname);
       }
       if(state==1){
  if(strlen(Voter.name)==0&strlen(Voter.lastname)==0){

     window(x1+1,y1+4,x2-1,y2-1);
     printf("Exit Registration? Y/N ");
     char press=toupper(getch());
     if (press=='Y'){
Adminscr(2,2,78,23,3,15);
     }
     if (press=='N'){
Registeruser(x1,y1,x2,y2,tc,tbc,1);
     }
  }
  Voter.vote=0;
  Voter.account=1;
  Voter.digit=number1;
  fwrite(&Voter,sizeof(svoter),1,writeptr);
       }
       if (state==0){
  if(strlen(Candi.name)==0&strlen(Candi.lastname)==0){
     window(x1+1,y1+4,x2-1,y2-1);
     printf("Exit Registeration? Y/N ");
     char press=toupper(getch());
     if (press=='Y'){
Adminscr(2,2,78,23,3,15);
     }
     if (press=='N'){
Registeruser(x1,y1,x2,y2,tc,tbc,0);
     }

  }
  Candi.account=1;
  Candi.digit=number2;
  fwrite(&Candi,sizeof(svoter),1,writeptr);
       }
    fclose(writeptr);
    Adminscr(2,2,78,23,3,15);
    return 0;
}

int ListUser(int state){
  char filename[15];
  window(1,1,80,24);
  clrscr();
  FILE *readptr;
  if(state==1)
       strcpy(filename,"voterdb.dat");
  if(state==0)
       strcpy(filename,"candidatedb.dat");

  if ((readptr=fopen(filename,"a+"))=='\0'){
       readptr=fopen(filename,"r");
  }
  int sn,vno,vs;
  fseek(readptr,0,2);
  vs=ftell(readptr)/(sizeof(svoter));
  fseek(readptr,0,0);
  vno=0;
  sn=2;
  while(vno<vs){
       if(state==1)
  fread(&Voter,sizeof(svoter),1,readptr);
       if(state==0)
  fread(&Candi,sizeof(svoter),1,readptr);

       if(Voter.account==1||Candi.account==1){
  gotoxy(1,1); printf("Name");
  gotoxy(20,1);printf("Lastname");
  if(state==1){
  gotoxy(40,1);printf("Password");
  gotoxy(60,1);printf("Number");
  }else{
  gotoxy(40,1);printf("Number");
  }
  if(state==1){
  gotoxy(1,(sn%20)+1); printf("%s",Voter.name);
  gotoxy(20,(sn%20)+1);printf("%s",Voter.lastname);
  gotoxy(40,(sn%20)+1);printf("%s",Voter.password);
  gotoxy(60,(sn%20)+1);printf("%d",Voter.digit);
  }else{
  gotoxy(1,(sn%20)+1); printf("%s",Candi.name);
  gotoxy(20,(sn%20)+1);printf("%s",Candi.lastname);
  gotoxy(40,(sn%20)+1);printf("%d",Candi.digit);
  }
  sn++;
       }
  vno++;
  if(sn%20==0){
    printf("\n\nPress any key to continue\n");
    getch();
    clrscr();
  }
  }
  printf("\nPress any key to continue\n");
  getch();
  fclose(readptr);
  clrscr();
  Adminscr(2,2,78,23,3,15);
  Menu(50,13,75,19,9,15,3);
  VoterMenuResult(MenuResult);
  return 0;
  }

int DeleteUser(int state){
    char filename[15];
    if(state==1){
       strcpy(filename,"voterdb.dat");
    }else{
       strcpy(filename,"candidatedb.dat");
    }
    FILE *readptr;
    char str[20];
    window(15,10,40,16);
    MyWindow(14,9,41,15,9,15);
    textcolor(9);
    textbackground(15);
    printf("Enter Lastname");
    window(15,11,40,16);
    printf("Lastname:");
    window(24,11,40,16);
    gets(str);
    if ((readptr=fopen(filename,"r+"))=='\0'){
       readptr=fopen(filename,"w+");
    }
    int vno,vs;
    fseek(readptr,0,2);
    vs=ftell(readptr)/(sizeof(svoter));
    fseek(readptr,0,0);
    vno=1;
    char press;
    while(vno<=vs){
       if (state==1){
fread(&Voter,sizeof(svoter),1,readptr);
if((Voter.account==1) && (strcmp(Voter.lastname,str)==0)){
     MyWindow(5,5,30,12,9,15);
     window(6,6,29,11);
     printf("Name:");
     window(11,6,29,11);
     printf("%s",Voter.name);
     window(6,7,29,11);
     printf("Lastname:");
     window(15,7,29,11);
     printf("%s",Voter.lastname);
     window(6,9,29,11);

     printf("Delete Voter? Y/N");
      for(;;){
press=toupper(getch());
if ((press=='Y')||(press=='N')){
   break;
}
      }
      if(press=='Y'){
  strcpy(Voter.name,"                    ");
  strcpy(Voter.lastname,"                    ");
  strcpy(Voter.password,"                    ");
  Voter.digit=0;
  Voter.vote=0;
  Voter.account=0;
  fseek(readptr,(sizeof(svoter)*(vno-1)),0);
  strcpy(Voter.name,"                    ");
  strcpy(Voter.lastname,"                    ");
  strcpy(Voter.password,"                    ");
  Voter.digit=0;
  Voter.vote=0;
  Voter.account=0;

  fwrite(&Voter,sizeof(svoter),1,readptr);
  fclose(readptr);
  Adminscr(2,2,78,23,3,15);

      }
}
       }else{
fread(&Candi,sizeof(svoter),1,readptr);
if((Candi.account==1) && (strcmp(Candi.lastname,str)==0)){
     MyWindow(5,5,30,12,9,15);
     window(6,6,29,11);
     printf("Name:");
     window(11,6,29,11);
     printf("%s",Candi.name);
     window(6,7,29,11);
     printf("Lastname:");
     window(15,7,29,11);
     printf("%s",Candi.lastname);
     window(6,9,29,11);
     printf("Delete Candidate? Y/N");
      for(;;){
press=toupper(getch());
if ((press=='Y')||(press=='N')){
   break;
}
      }
      if(press=='Y'){
  strcpy(Candi.name,"                    ");
  strcpy(Candi.lastname,"                    ");
  strcpy(Candi.password,"                    ");
  Candi.digit=0;
  Candi.account=0;
  fseek(readptr,(sizeof(svoter)*(vno-1)),0);
  strcpy(Candi.name,"                    ");
  strcpy(Candi.lastname,"                    ");
  strcpy(Candi.password,"                    ");
  Candi.digit=0;
  Candi.account=0;

  fwrite(&Candi,sizeof(svoter),1,readptr);
  fclose(readptr);
  Adminscr(2,2,78,23,3,15);
  }
      }

}
     vno++;
     }
    getch();
    fclose(readptr);
    Adminscr(2,2,78,23,3,15);

    return 0;
  }


void MessageToVoter(int x1,int y1,int x2,int y2,int tc,int tbc){

    int votingstatus;
    FILE *writeptr;
    Sadmin Admin={"","",""};
    window(x1+1,y1+1,x2-1,y2-1);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);

    printf("Write your message to voters");
    window(x1+1,y1+2,x2-1,y2-1);
    printf("Message:");
    if ((writeptr=fopen("admindb.dat","r+"))=='\0'){
       writeptr=fopen("admindb.dat","w");

       }
    fread(&Admin,sizeof(sadmin),1,writeptr);
    strcpy(username,Admin.username);
    strcpy(password,Admin.password);
    votingstatus=Admin.startstopvoting;


    window(x1+9,y1+2,x2-1,y2-1);
    gets(Admin.message);
    Admin.startstopvoting=votingstatus;
    strcpy(Admin.username,username);
    strcpy(Admin.password,password);
    fseek(writeptr,0,0);
    fwrite(&Admin,sizeof(sadmin),1,writeptr);
    fclose(writeptr);
    Adminscr(2,2,78,23,3,15);

}
void StartVoting(){

    char message[80];
    FILE *writeptr;
    Sadmin Admin={"","",""};

    if ((writeptr=fopen("admindb.dat","r+"))=='\0'){
       writeptr=fopen("admindb.dat","w");

       }
    fread(&Admin,sizeof(sadmin),1,writeptr);
    strcpy(username,Admin.username);
    strcpy(password,Admin.password);
    strcpy(message,Admin.message);



    Admin.startstopvoting=1;
    strcpy(Admin.username,username);
    strcpy(Admin.password,password);
    strcpy(Admin.message,message);
    fseek(writeptr,0,0);
    fwrite(&Admin,sizeof(sadmin),1,writeptr);
    fclose(writeptr);
    Adminscr(2,2,78,23,3,15);



}
void StoppVoting(){

    char message[80];
    FILE *writeptr1;
    FILE *writeptr2;
    FILE *writeptr3;
    FILE *writeptr;
    Sadmin Admin={"","",""};

    if ((writeptr=fopen("admindb.dat","r+"))=='\0'){
       writeptr=fopen("admindb.dat","w");

       }
       writeptr1=fopen("votesdb.dat","w");
       writeptr2=fopen("voterdb.dat","w");
       writeptr3=fopen("Candidatedb.dat","w");
    fread(&Admin,sizeof(sadmin),1,writeptr);
    strcpy(username,Admin.username);
    strcpy(password,Admin.password);
    strcpy(message,Admin.message);



    Admin.startstopvoting=0;
    strcpy(Admin.username,username);
    strcpy(Admin.password,password);
    strcpy(Admin.message,message);
    fseek(writeptr,0,0);
    fwrite(&Admin,sizeof(sadmin),1,writeptr);
    fclose(writeptr);
    fclose(writeptr1);
    fclose(writeptr2);
    fclose(writeptr3);
    Adminscr(2,2,78,23,3,15);



}
void FinishVoting(int x1,int y1,int x2,int y2,int tc,int tbc){
    window(x1+1,y1+1,x2-1,y2-1);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    FILE *readptr;
    FILE *readptr1;
    int votecounter[100]={0};

    if ((readptr=fopen("votesdb.dat","r+"))=='\0'){
       readptr=fopen("votesdb.dat","w");
    }
    if ((readptr1=fopen("candidatedb.dat","r+"))=='\0'){
       readptr1=fopen("candidatedb.dat","w");
    }
    int number=0,i;

     while(!feof(readptr1)){
       fseek(readptr1,sizeof(svoter)*number,0);
       fread(&Candi,sizeof(svoter),1,readptr1);
       number++;

    }
    number--;
    number--;

    printf("%d",number);

int vno,vs;
fseek(readptr,0,2);
vs=ftell(readptr)/(sizeof(svote));
fseek(readptr,0,0);
vno=1;
while(vno<vs){
     fseek(readptr,sizeof(svote)*vno,0);
     fread(&Vote,sizeof(svote),1,readptr);
     printf("%d ",Vote.vote);
     for(i=1;i<=number;i++){
if(i==Vote.vote){
    votecounter[i]++;
}
     }

vno=vno+number;}

for(i=1;i<=number;i++){
    window(x1+1,y1+i,x2-1,y2-1);
    printf("%d. candidate has %d vote",i,votecounter[i]);
}

    getch();
    StoppVoting();

    fclose(readptr);
    fclose(readptr1);
}



void MessageReader(int x1,int y1,int x2,int y2,int tc,int tbc){
    FILE *readptr;
    window(x1+1,y1+1,x2-1,y2-1);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    if ((readptr=fopen("admindb.dat","r+"))=='\0'){
       readptr=fopen("admindb.dat","w");
    }
    printf("Message:");
    fread(&Admin,sizeof(sadmin),1,readptr);
    printf("%s",Admin.message);
   
    fclose(readptr);
    sleep(5);
    Voterscr(2,2,78,23,3,15);

}

int Voterscr(int x1,int y1,int x2,int y2,int tc,int tbc){
    window(1,1,80,24);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    window(x1+15,y1+1,x2,y2);
    printf("WELLCOME TO ELECTRONIC VOTING");
    window(x1+20,y1+2,x2,y2);
    printf("%s %s",username,userlastname);
    textcolor(tc);
    textbackground(tbc);
    Menu(50,4,75,10,9,15,5);
    VoterscrMenuResult(MenuResult);
    getch();
    return 0;
}

int VotingScr(int x1,int y1,int x2,int y2,int tc,int tbc){

    QueueNodePtr headptr=NULL;
    QueueNodePtr tailptr=NULL;
    int number=0;
    FILE *readptr;
    FILE *writeptr;

    window(x1+1,y1+1,x2-1,y2-1);
    MyWindow(x1,y1,x2,y2,tc,tbc);
    textcolor(tc);
    textbackground(tbc);
    if ((readptr=fopen("voterdb.dat","r+"))=='\0'){
       readptr=fopen("voterdb.dat","w");
     }

    if ((writeptr=fopen("candidatedb.dat","r+"))=='\0'){
       writeptr=fopen("candidatedb.dat","w");
       }


     int vno,vs;
     fseek(readptr,0,2);
     vs=ftell(readptr)/(sizeof(svoter));
     fseek(readptr,0,0);
     vno=1;
     while(vno<=vs){
       fread(&Voter,sizeof(svoter),1,readptr);
       if((Voter.account==1)&&(Voter.vote==0)){
if((strcmp(Voter.name,username)==0)&&(strcmp(Voter.lastname,userlastname)==0)){
   if(strcmp(Voter.password,password)==0){
      while(!feof(writeptr)){
fseek(writeptr,sizeof(svoter)*number,0);
fread(&Candi,sizeof(svoter),1,writeptr);
  number=Candi.digit;
  number++;
      }
      --number;
      window(x1+2,y1+1,x2-1,y2-1);
      printf("Enter Your Votes");
      int vote=0;
      int i=0;
      while(i<number){
window(x1+2,y1+2+i,x2-1,y2-1);
printf("Vote %d=",++i);
i--;
scanf("%d",&vote);
insertqueue(&headptr,&tailptr,vote);
i++;
     }
     printqueue(headptr);


  strcpy(Voter.name,username);
  strcpy(Voter.lastname,userlastname);
  strcpy(Voter.password,password);
  Voter.account=1;
  Voter.vote=1;
  fseek(readptr,(sizeof(svoter)*(vno-1)),0);
  strcpy(Voter.name,username);
  strcpy(Voter.lastname,userlastname);
  strcpy(Voter.password,password);
  Voter.account=1;
  Voter.vote=1;
  fwrite(&Voter,sizeof(svoter),1,readptr);
   }
}
       }
     vno++;
     }
    fclose(readptr);
    fclose(writeptr);
  Voterscr(2,2,78,23,3,15);
  return 0;
  }

void insertqueue(QueueNodePtr *headptr,QueueNodePtr *tailptr,int vote){
     QueueNodePtr newptr;


     newptr=(QueueNodePtr)malloc(sizeof(queueNode));

     if (newptr!=NULL){
newptr->vote=vote;
newptr->nextptr=NULL;
if(isEmpty(*headptr)){
  *headptr=newptr;
}else{
  (*tailptr)->nextptr=newptr;
}
*tailptr=newptr;
     }
}

int isEmpty(QueueNodePtr headptr){
    return headptr==NULL;
    }

void printqueue(QueueNodePtr currentptr){

     FILE *writeptr;
     if ((writeptr=fopen("votesdb.dat","a+"))=='\0'){
       writeptr=fopen("votesdb.dat","w");
       }
     if(currentptr==NULL){
       printf("List is Empty\n\n");
     }else{
       printf("The Queue is:\n");

       while(currentptr!=NULL){
   printf("%d  ",currentptr->vote);
   Vote.vote=currentptr->vote;
   fwrite(&Vote,sizeof(svote),1,writeptr);
   currentptr=currentptr->nextptr;

       }

     }
     fclose(writeptr);
     }
void ShowCandi(int x1,int y1,int x2,int y2,int tc,int tbc){
      window(x1+1,y1+1,x2-1,y2-1);
      MyWindow(x1,y1,x2,y2,tc,tbc);
      textcolor(tc);
      textbackground(tbc);

      FILE *readptr;

      if ((readptr=fopen("candidatedb.dat","r+"))=='\0'){
readptr=fopen("candidatedb.dat","w");
       }
      int vno,vs;
      fseek(readptr,0,2);
      vs=ftell(readptr)/(sizeof(svoter));
      fseek(readptr,0,0);
      vno=1;
      while(vno<vs){
   fread(&Candi,sizeof(svoter),1,readptr);
   if(Candi.digit!=0){
   window(x1+1,y1+1+vno,x2-1,y2-1);
   printf("%d. %s %s",Candi.digit,Candi.name,Candi.lastname);
   vno++;

   }
      }
   fclose(readptr);
   sleep(3);
   Voterscr(2,2,78,23,3,15);
   }


void Exit(int x1,int y1,int x2,int y2,int tc,int tbc){
      window(1,1,80,25);
      textbackground(0);
      clrscr();

      MyWindow(x1,y1,x2,y2,tc,tbc);
      textcolor(tc);
      textbackground(tbc);
      window(x1+4,y1+3,x2-1,y2-1);
      printf("!!!!!Thanks For Voting!!!!!");
      sleep(3);
      exit(0);
}