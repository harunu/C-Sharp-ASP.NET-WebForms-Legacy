#include<stdio.h>
#include<stdlib.h>
#include<math.h>
#include<string.h>

const STR_LENGTH = 100;
char *CATALOG_FILE_NAME = "LIBRARY_CATALOG";

int Menu(void)
{
	char key,line[100];
	printf("\nCard Catalog:\n");
	printf("1. Enter\n");
	printf("2. Search by Author\n");
	printf("3. Search by Title\n");
	printf("4. Show Records\n");
	printf("5. Save Catalog and Exit\n");
	printf("6. Quit Without Saving\n");
	printf("Choose your selection: ");
	fgets(line, sizeof(line), stdin);
	sscanf(line, "%c", &key);
	switch(key)
	{
		case '1': return(1); break;
		case '2': return(2); break;
		case '3': return(3); break;
		case '4': return(4); break;
		case '5': return(5); break;
		case '6': return(0); break;
		default: return(99); break;
	}

}

struct rec
{
	char name[STR_LENGTH],
		 author[STR_LENGTH],
		 publisher[STR_LENGTH],
		 ISBN[14];
};

typedef struct rec recType;

struct recPtr
{
	char name[STR_LENGTH],
		 author[STR_LENGTH],
		 publisher[STR_LENGTH],
		 ISBN[14];	
	struct recPtr *next;
};

typedef struct recPtr recPtrType;

recPtrType *create()
{
	recPtrType *adres;
	if((adres=(recPtrType *)malloc(sizeof(recPtrType)))==NULL)
	{
		printf("Allocation error!\n");
		exit(0);
	}
	adres->next = NULL;
	strcpy(adres->name,"");
	return(adres);
}	

FILE *OpenFile(char *fileName)
{
	FILE *filePtr;
	printf("Opening Catalog File... ");
	filePtr=fopen(fileName,"rb");
	if(filePtr==NULL)
	{
		printf("Catalog file not found!\n");
		printf("Creating new catalog file... ");
		if((filePtr=fopen(fileName,"wb+"))==NULL)
		{
			printf("File System Error!\n");
			exit(0);
		}		
	}
	printf("Done.\n");
	return(filePtr);
}

recPtrType *Add(recType input,recPtrType *first)
{
	// allocate memory for new record
	recPtrType *newAdrs;
	if( ( newAdrs = (recPtrType *)malloc(sizeof(recPtrType)) ) == NULL )
	{
		printf("Allocation error!\n");
		exit(0);
	}

	// insert data into new record
	strcpy(newAdrs->name,input.name);
	strcpy(newAdrs->author,input.author);
	strcpy(newAdrs->publisher,input.publisher);
	strcpy(newAdrs->ISBN,input.ISBN);

	// link new record to the list
	newAdrs->next = first;

	// return address of new record
	return(newAdrs);
}

recPtrType *GetFromFile(FILE *file, recPtrType *first)
{
	int i=0;

	recType *record;
	record = (recType *)malloc(sizeof(recType));
	
	while( fread(record,1,sizeof(recType),file) )
	{
		i++;
		first = Add(*(record),first);
	}


	/*
	while( fread(record,1,sizeof(recType),file) )
	{
		printf("*** inside while ***\n");
		i++;
		//recType data;
		strcpy(data.name,record->name);
		strcpy(data.author,record->author);
		strcpy(data.publisher,record->publisher);
		strcpy(data.ISBN,record->ISBN);
		printf("*** after strcpy ***\n");
		//first = Add(data,first);
	}
	*/

	printf("Number of records from Catalog File: %d\n",i);

	return(first);
}

void SaveToFile(FILE *file, recPtrType *first)
{
	fclose(file);

	FILE *filePtr;
	printf("Saving Catalog File... ");

	if((filePtr=fopen(CATALOG_FILE_NAME,"wb"))==NULL)
	{
		printf("File System Error!\n");
		exit(0);
	}		

	recPtrType *adr = first;
	while( adr != NULL )
	{
		recType *data;
		data = (recType *)malloc(sizeof(recType));
		strcpy(data->name,adr->name);
		strcpy(data->author,adr->author);
		strcpy(data->publisher,adr->publisher);
		strcpy(data->ISBN,adr->ISBN);
		fwrite(data,1,sizeof(recType),filePtr);

		adr = adr->next;
	}
	
	fclose(filePtr);
	
	printf("Done.\n");
}

int checkISBN(char *isbn)
{
	// check length
	if(strlen(isbn)!=14) return(0);

	// check syntax
	int index = 10, sum = 0;
	for(int i=0;i<13;i++)
	{
		char chr = isbn[i];
		if( ((chr >= '0')&&(chr <= '9')) || (chr == '-') || (chr == ' ') )
		{
			if((chr >= '0')&&(chr <= '9'))
			{
				int value;
				value = chr - '0';
				sum += value*(index--);
			}
		}
		else return(0);
		
	}

	if(sum % 11 != 0) return(0);

	return(1);
}

recPtrType *enterRec(recPtrType *first)
{	
	recType input;
	printf("\nEnter Book Information\n");
	printf("Name: ");
	fgets(input.name, STR_LENGTH, stdin);
	if(input.name[0] == 10) return(NULL);
	printf("Author: ");
	fgets(input.author, STR_LENGTH, stdin);
	printf("Publisher: ");
	fgets(input.publisher, STR_LENGTH, stdin);
	char retry = 0;
	do
	{
		char isbn[20];
		printf("ISBN: ");
		fgets(isbn, 120, stdin);
		strncpy(input.ISBN,isbn,15);
		if(!checkISBN(input.ISBN))
		{
			char key;
			do
			{
				printf("ISBN is incorrect!\nReenter ISBN(Yes,No)? ");
				char line[10];
				fgets(line, sizeof(line), stdin);
				strupr(line);
				sscanf(line, "%c", &key);
			}
			while( (key != 'Y') && (key != 'N') );
			if(key == 'Y') retry = 1;
			else return(NULL);
		}
		else retry = 0;
	}
	while( retry == 1 );

	// add input to the linked list	
	first = Add(input,first);	

	return(first);
}

void SearchByAuthor(recPtrType *first)
{
	char name[STR_LENGTH];
	printf("\nEnter author name: ");
	fgets(name, STR_LENGTH, stdin);

	recPtrType *adr = first;
	while( adr != NULL )
	{
		char str1[STR_LENGTH],str2[STR_LENGTH];
		strcpy(str1,name);
		strcpy(str2,adr->author);
		strupr(str1);
		strupr(str2);
		if( !strcmp(str1,str2) )
		{
			printf("Record found.\n\n");
			printf("Name = %s",adr->name);
			printf("Author = %s",adr->author);
			printf("Publisher = %s",adr->publisher);
			printf("ISBN = ");
			int i;
			for(i=0;i<13;i++) printf("%c",adr->ISBN[i]);
			printf("\n");
		}
		adr = adr->next;
	}
}

void SearchByTitle(recPtrType *first)
{
	char title[STR_LENGTH];
	printf("\nEnter book title: ");
	fgets(title, STR_LENGTH, stdin);

	recPtrType *adr = first;
	while( adr != NULL )
	{
		if( !strcmp(title,adr->name) )
		{
			printf("Record found.\n\n");
			printf("Name = %s",adr->name);
			printf("Author = %s",adr->author);
			printf("Publisher = %s",adr->publisher);
			printf("ISBN = ");
			int i;
			for(i=0;i<13;i++) printf("%c",adr->ISBN[i]);
			printf("\n");			
		}
		adr = adr->next;
	}
}

void ShowList(recPtrType *first)
{
	printf("\n");
	recPtrType *adr;
	adr = first;
	while( adr != NULL )
	{
		printf("Name = %s",adr->name);
		printf("Author = %s",adr->author);
		printf("Publisher = %s",adr->publisher);
		printf("ISBN = ");
		int i;
		for(i=0;i<13;i++) printf("%c",adr->ISBN[i]);
		printf("\n\n");
		adr = adr->next;
	}
	printf("\nEnd of List\n");
}

void main(void)
{


	// Open catalog file
	FILE *catalog = OpenFile(CATALOG_FILE_NAME);

	// Generate first address of linked list
	recPtrType *first = NULL;
	
	// Read from catalog file
	first = GetFromFile(catalog,first);

	// Display menu
	int state = 99;
	do
	{
		state = Menu();
		switch(state)
		{
			case 1: recPtrType *adrs;
					do
					{
						adrs = enterRec(first);
						if(adrs) first = adrs;
					} while(adrs);
					break;
			case 2: SearchByAuthor(first);
					break;
			case 3: SearchByTitle(first);
					break;
			case 4: ShowList(first);
					break;
			case 5: SaveToFile(catalog,first);
					state=0;
					break;
			default: break;
		}
	}
	while(state!=0);

	fclose(catalog);

}

