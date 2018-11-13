#include<stdio.h>
#define MaxDegree 8
typedef struct{
int CoeffArray[MaxDegree+1];
int HighPower;
} *Polynomial;

void ZeroPolynomial(Polynomial Poly){
int i;

for(i=0;i<=MaxDegree;i++)
	Poly->CoeffArray[i]=0;
Poly->HighPower=0;
}

void MultPolynomial(const Polynomial Poly1,const Polynomial Poly2,Polynomial PolyProd)
{
int i,j;

ZeroPolynomial(PolyProd);
PolyProd->HighPower=Poly1->HighPower+Poly2->HighPower;

if(PolyProd->HighPower>MaxDegree)
printf("Exceeded array size\n");
else
for(i=0;i<=Poly1->HighPower;i++)
	for(j=0;j<=Poly2->HighPower;j++)
	PolyProd->CoeffArray[i+j]+=Poly1->CoeffArray[i]*Poly2->CoeffArray[j];
}

main(){
Polynomial P3;
Polynomial P2;
Polynomial P1;
ZeroPolynomial(P1);
P1->CoeffArray[0]=7;
P1->CoeffArray[1]=5;
P1->CoeffArray[2]=0;
P1->CoeffArray[3]=3;
}