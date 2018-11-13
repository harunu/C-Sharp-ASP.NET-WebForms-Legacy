#include <stdio.h>
#include <stdlib.h>
#include <math.h>
void RootsOfPolynomial(double *,double *);
double ValueOfPolynomial(int, double *, double);
main(){
	int degree,choice,i;
	double coef[10],value,root[2],point;

	printf("\n******** CSE200 Lab - Week(1) 04/10/2004 ********\n "
		    "\nPolynomial Examples: \n\t- Quadratic polynomials, "
			"Root finding\n\t- Higher degree polynomials,Value of a polynomial."
			"\nThis example will review:"
			"\n\t- Arrays, \n\t- functions: Passing parameters, \n\t- Pointers and "
			"\n\t- Dynamic memory allocation\n");

	printf("\n******** Options ********\n\t 1) Finding roots of a quadratic polynomial."
			"\n\t 2) Finding value of a polynomial at a given point."
			"\n\t 3) Quit.\n\t Enter Your Choice: ");
	scanf("%d",&choice);

	while(choice !=3){
		switch(choice){

		case 1:
			printf("Enter the coefficients of the quadratic polynomial:\n");
			for(i = 0; i < 3; i++){
			printf("Enter Coefficient a%d: ",i);
			scanf("%lf",&coef[i]);
			}
			RootsOfPolynomial(coef,root);
			printf("The roots are: %lf and %lf\n",root[0],root[1]);
			break;
		case 2:
			printf("Enter the degree of the polynomial(Max. degree is 10):\n");
			scanf("%d",&degree);
			printf("Enter the coefficients of the polynomial:\n");
			for(i = 0; i <= degree; i++){
			printf("Enter Coefficient a%d: ",i);
			scanf("%lf",&coef[i]);
			}
			printf("Enter the point at which the polynomial value to be found");
			scanf("%lf",&point);
			value = ValueOfPolynomial(degree, coef, point);
			printf("The value is: %lf\n", value);
			break;
		}
		printf("\n******** Options ********\n\t 1) Finding roots of a quadratic polynomial."
				"\n\t 2) Finding value of a polynomial at a given point."
				"\n\t 3) Quit.\n\t Enter Your Choice: ");
		scanf("%d",&choice);
	}
	printf("End of The Week 1\n\n");
	return 0;
}

void RootsOfPolynomial(double *c,double *r){

	r[0] = (-c[1] - sqrt(pow(c[1],2) - 4.0 * c[0] * c[2]))/(2.0 * c[2]);
	r[1] = (-c[1] + sqrt(pow(c[1],2) - 4.0 * c[0] * c[2]))/(2.0 * c[2]);

}
double ValueOfPolynomial(int d, double *c, double p){

	int i;
	double res = 0;

	for (i = 0; i <= d; i++)
		res +=pow(p,i) * c[i];

	return res;
}