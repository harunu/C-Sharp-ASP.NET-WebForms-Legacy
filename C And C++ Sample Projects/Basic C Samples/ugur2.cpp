#include<time.h>
#include<stdio.h>
#include<dos.h>
int fibonacci(int m);
int main(void)
{int b=1,k=41,a=1,tmp,m;
	clock_t start,end;
	start=clock();
	
	for(b=1;b<k;b++){
	  tmp=b;
	  b=a+b;
	  a=tmp;}
   
	
	end=clock();
	
	printf("The time was: %d\n",(end-start)/CLK_TCK);
	scanf("%d",&m);
	return 0;
	}
	
