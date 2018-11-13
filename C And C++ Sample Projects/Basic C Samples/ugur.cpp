#include<time.h>
#include<stdio.h>
#include<dos.h>
int fibonacci(int m);
int main(void)
{int y=38,k;
	clock_t start,end;
	start=clock();
	fibonacci(y);

	
	end=clock();
	
	printf("The time was: %f\n",(float)(end-start)/CLK_TCK);
	scanf("%d\n",k);
	
	return 0;
	}
	int fibonacci(int x)
	{
		if(x<2)
		return 1;
		else
        return fibonacci(x-1)+fibonacci(x-2);
}		
