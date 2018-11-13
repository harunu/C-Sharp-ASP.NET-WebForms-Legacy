#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <ctype.h>

char *RemoveLetters(const char *, const char *);

main(){

	char a[80],b[80],l;

	printf("\n******** CSE200 Lab - Week(2) 11/10/2004 ********\n"
		    "\nString Manipulation Functions: \n\t- strlen, strcpy, strcat(, strncat), strspn, strstr\n\n\t");

	printf("Enter a string: ");
	gets(a);
	strcpy(b,"");
	
	printf("Now start entering the letters you want to remove (enter '.' (dot) to stop)\n");
	do{
	
	printf("Enter next letter\n");
	
	fflush(stdin); scanf("%c",&l); fflush(stdin); 
	// fflush(stdin) empties the standard input i.e. (anything you typed) 
	// so that the newline character (enter) at the end of your last input will not be used as 
	// your next input i.e. next scanf statement.

	if (isalpha(l)) // Input check! input must be a letter.
		if (strstr(b,&l) == NULL) // If current input is already in the list ignore it.
			strncat(b,&l,1);
	} while (l != '.'); // End of the list  
	printf("\tFirst String: %s \n\tLetters to be removed: %s\n\tResult: %s\n",a,b,RemoveLetters(a,b));
	
	printf("End of The Week 2\n\n");
	return 0;
}

char *RemoveLetters(const char *string, const char *charList){
	char *tmp, *result;
	int size,l;

	size = strlen( string );
	// size is needed since we have to reserve enough space for strings: tmp and result.

	tmp = (char *)malloc(size + 1 * sizeof(char)); // size + 1 is for null character.
	result = (char *)malloc(size + 1 * sizeof(char));

	strcpy(result, ""); // Initialize the strings. Result string is empty at first.
	strcpy(tmp, string); // tmp is used to keep original string unchanged.
	
	while (tmp[0] != '\0'){ // Process will continue until the end of the source string
		l = strspn(tmp, charList); 
		// start searching for the current letter in the list, from the beginng of the source string

		if ( l == 0 ){ 
		// If the current letter of the source string is not in the list, 
		// append it to the result array.
		
			result = strncat(result,tmp,1);
			tmp = tmp + 1; // Current letter becomes the next letter in the source string.
		} else
			tmp = tmp + l; 
		// Else there are one or more letters at the beginning of the source string 
		// which are members of the list. So move to the first letter of the source string 
		// that does belong to the list.
	}
return result;
}