#include<stdio.h>
#include<stdlib.h> 

#define MAXDIST 99999
#define MAXVERTEX 15
int graph[MAXVERTEX][MAXVERTEX] = 
{
	{0}, 
{0, 0,MAXDIST,2555,MAXDIST,MAXDIST,MAXDIST,MAXDIST,MAXDIST},
{0, MAXDIST,0,337,1843,MAXDIST,MAXDIST,MAXDIST,MAXDIST},
{0, 2555,337,0,1743,1233,MAXDIST,MAXDIST,MAXDIST},
{0, MAXDIST,1843,1743,0,802,MAXDIST,849,MAXDIST},
{0, MAXDIST,MAXDIST,1233,802,0,1387,MAXDIST,1120},
{0, MAXDIST,MAXDIST,MAXDIST,MAXDIST,1387,0,142,1099},
{0, MAXDIST,MAXDIST,MAXDIST,849,MAXDIST,142,0,1205},
{0, MAXDIST,MAXDIST,MAXDIST,MAXDIST,1120,1099,1205,0}
};
int s[MAXVERTEX],mark[MAXVERTEX],pdecessor[MAXVERTEX];
int numvertices = 8;

void printpath(int y,int i,int j[])
{
	if(i==y)
	{
		printf("%d",y);
	}
	else if(j[i]==0)
		printf(" There is no path from %d to %d",y,i);
	else
	{
        printpath(y,j[i],j);
		printf("=>%d",i);
	}
}

int minimum(int u[],int m[],int g)
{
	int maxi=MAXDIST;
	int k,l;
	for(k=1;k<=g;k++)
	{
		if(m[k]!=1)
		{
			if(maxi>=u[k])
			{
				maxi=u[k];
				l=k;
			}
		}
	}

	return l;
}

void ShortestPath(int source, int dest)
{
	int k,l,m;
	int counter=0;
	int pestimate[MAXVERTEX];

    for(l=1;l<=numvertices;l++)
	{
		mark[l]=0;
		pestimate[l]=MAXDIST;
		pdecessor[l]=0;
	}
	
	pestimate[source]=0;
 
	while(counter<numvertices)
	{
		m=minimum(pestimate,mark,numvertices);
		s[++counter]=m;
		mark[m]=1;
	
		for(k=1;k<=numvertices;k++)
		{
			if(graph[m][k]>0)
			{
				if(mark[k]!=1)
				{
					if(pestimate[k]>pestimate[m]+graph[m][k]){
						pestimate[k]=pestimate[m]+graph[m][k];
						pdecessor[k]=m;
					}
				}
			}
		}
	}

	printf("Here the Path is: ");
	printpath(source,dest,pdecessor);
	if(pestimate[k]!=MAXDIST)
		printf("\nTotal Distance: %d\n\n",pestimate[dest]);
}
void solveRTable(int source)
{
	int i,j,u, v;
	int counter=0;
	int pestimate[MAXVERTEX];

    for(j=1;j<=numvertices;j++)
	{
		mark[j]=0;
		pestimate[j]=MAXDIST;
		pdecessor[j]=0;
	}
	
	pestimate[source]=0;
 
	while(counter<numvertices)
	{
		u=minimum(pestimate,mark,numvertices);
		s[++counter]=u;
		mark[u]=1;
	
		for(i=1;i<=numvertices;i++)
		{
			if(graph[u][i]>0)
			{
				if(mark[i]!=1)
				{
					if(pestimate[i]>pestimate[u]+graph[u][i]){
						pestimate[i]=pestimate[u]+graph[u][i];
						pdecessor[i]=u;
					}
				}
			}
		}
	}

	for(i=1;i<=numvertices;i++)
	{
		
		printf("%d    ", i);
		
		if(pdecessor[i]==0)
			printf("-    ");
		else if(i==source)
		{
			
			printf("%d    ",i);
		}
		else
		{
			j = i;
			
			while( j != pdecessor[j])
			{
				v = u;
				u = j;
				j = pdecessor[j];
			}
			printf("%d    ", v);
		}
		
		printf("%d    \n\n",pestimate[i]);
	}
}

void main()
{
	int count=0;
	int source, dest;
	
	int a, j, i;

    printf("WELCOME TO IMPLEMENTATION OF DIJKSTRA'S SHORTEST PATH ROUTING\n");
	printf("Please Enter the number of vertices\n");
	scanf("%d",&numvertices);
	if(numvertices<=0 || numvertices > MAXVERTEX)
	{
		printf("\n Error!!!\n");
		exit(1);
	}
    
	printf("Without connection, Please Enter -1!\n");

	printf("\nPlease Enter Adjacent Matrix!!!\n");
    for(i=1;i<=numvertices;i++)
	{
		printf("\nPlease Enter values of row [%d]\n",i);
		for(j=1;j<=numvertices;j++)
		{
			scanf("%d",&graph[i][j]);
			if( graph[i][j] == -1)
				graph[i][j] = MAXDIST;
		}
	}

	while(1)
	{
		printf("[1]To Find Shortest Path Please Enter number 1\n[2]To show Routing Table Please Enter number 2\n[3]For Quit Please Enter number 3\n***Please Enter Your Option: ");
		scanf( "%d",&a);
		
		if(a==1){
				printf("\nPlease enter the Source Vertex\n");
				scanf("%d",&source);
				printf("\nPlease enter the Destination Vertex\n");
				scanf("%d",&dest);
				ShortestPath(source, dest);
		}else
		if(a==2){
			    printf("\nPlease enter the Source Vertex\n");
				scanf("%d",&source);
				solveRTable(source);
		}
		else
		if(a==3){
          exit(0);
		}
		else{
			printf("\nHuops ! Ýnvalid Choice! \n Please enter valid choice\n");
		}
}
}







