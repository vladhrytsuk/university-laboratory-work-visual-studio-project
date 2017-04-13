#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <alloc.h>

typedef struct monument{
	char name [15]; // ��������
	char type [14]; // ��� ���������
	char location [15];  // ������������
	char info[30];   // ����������
struct monument* next;
} Monument;
void help();
void menu();
void search();
void List();
void Save();
void Load();
void sort();
void autosave();
void clean();
void delet();
void edit();
void Listwalk();
void add();
int exit();
void add_l(FILE* f);
void printmenu(int x, int y);
int now_n=1,N=1,z=0,save_check=0;
Monument* Head=NULL;
int main ()
{
	char ch;
	clrscr();
	menu();
	while(1)
	{
		if(!(ch=getch()))
		{
			ch=getch();
		}
		switch(ch)
		{
			case 75:
				if (now_n!=1&&now_n!=7&&now_n!=11&&now_n!=15&&now_n!=17&&now_n!=20)
					now_n--;
				menu();
				break;
			case 77:
				if(now_n!=6&&now_n!=10&&now_n!=12&&now_n!=15&&now_n!=19&&now_n!=22)
					now_n++;
				menu();
				break;
			case 27:
				if(now_n>=7&&now_n<=19)
					now_n=1;
				menu();
				break;
			case 59:
				help();
				menu();
				break;
			case 60:
				Save();
				break;
			case 61:
				Load();
				menu();
				break;
			case 62:
				List();
				Listwalk();
				break;
			case 63:
				if (exit()==1)
				{
					if(save_check==1)
						Save();
					return 0;
				}
				break;
		}
		if (ch==13)
		{
			switch(now_n)
			{
				case 1:
					now_n=7;
					menu();
					break;
				case 2:
					now_n=11;
					menu();
					break;
				case 3:
					now_n=15;
					menu();
					search();
					now_n=1;
					menu();
					break;
				case 4:
					now_n=17;
					menu();
					break;
				case 5:
					help();
					menu();
					break;
				case 6:
					if(exit()==1)
					{
						if(save_check==1)
						Save();
						return 0;
					}
					break;
				case 7:
					add();
					menu();
					if(save_check==1)
					Save();
					break;
				case 8:
					clean();
					List();
					if(save_check==1)
					Save();
					break;
				case 9:
					edit();
					menu();
					if(save_check==1)
					Save();
					break;
				case 10:
					List();
					Listwalk();
					break;
				case 11:
					sort();
					menu();
					break;
				case 12:
					sort();
					menu();
					break;
				case 17:
					Save();
					break;
				case 18:
					Load();
					menu();
					break;
				case 19:
					autosave();
					menu();
					break;
			}
		 }
	}

}
void menu() // ������� ��� ������ � ����
{

	if(now_n>=1&&now_n<=6)
	printmenu(1,6);
	if(now_n>=7&&now_n<=10)
	printmenu(7,10);
	if(now_n>=11&&now_n<=12)
	printmenu(11,12);
	if(now_n==15)
	printmenu(15,16);
	if(now_n>=17&&now_n<=19)
	printmenu(17,19);
	if(now_n>=20&&now_n<=22)
	printmenu(20,22);
}
void printmenu(int x, int y) // ������� ��� ���������� ����
{

	int j,i;
	char** meny=(char**) malloc(23);
	for(j=1;j<=23;j++)
	meny[j]=(char*) malloc(17);
	meny[1]="|| ���᮪  |";
	meny[2]="| ����஢�� |";
	meny[3]="|  ����  |";
	meny[4]="|  ����  |";
	meny[5]="| ������ |";
	meny[6]="|  ��室  ||";
	meny[7]="||  ��������  |";
	meny[8]="| ������ ᯨ᮪ |";
	meny[9]="| ���a��஢a�� |";
	meny[10]="| ��ᬮ�� �a�� �a���� ||";
	meny[11]="|| �� ����   |"; // �� ����
	meny[12]="|  �� �aᯮ�������|";     // �� ������������
	meny[15]="|| ���� |";
	meny[16]="|  �a��a���: ";             //��������
	meny[17]="|| ����a����  |";
	meny[18]="|  �a��㧨��  |";
	meny[19]="|  ������a�����  |";
	window(1,1,80,25);
	textbackground(BLACK);
	clrscr();
	for (i=1;i<=80;i++)
	{
		printf("%c",205);
	}
	window(1,2,80,2);
	textbackground(GREEN);
	clrscr();
	for(i=x;i<=y;i++)
		if(now_n!=i)
			cputs(meny[i]);
		else
		{
			textbackground(RED);
			cputs(meny[i]);
			textbackground(GREEN);
		}
	textbackground(BLACK);
	printf("\n%c",201);
	for (i=1;i<=77;i++)
	printf("%c",205);
	printf("%c",187);
	free(meny);
	window(1,25,80,25);
	textbackground(GREEN);
	clrscr();
	cprintf("| F1 - ������ | F2 - ���࠭��� | F3 - ����㧨�� | F4 - ���᮪  | F5 - ��室   |");
	window(1,1,80,25);
	textbackground(BLACK);
	List();

}
void help() // ������� ��� ������
{
	int c;
	window(1,1,80,25);
	clrscr();
	window(1,5,80,18);
	textbackground(GREEN);
	clrscr();
	cprintf("Powered by RAD Studio XE4, Turbo C 3.0 + DOSBox 0.74                             \n");
	c=getch();
	if(c==27)
	return;
}
void add() // ������� ��� ���������� �������
{
	Monument *pre,*new_item,*cur;
	float f,*fp;
	int i;
	fp=&f;
	new_item=(Monument*)malloc(sizeof(Monument));
	if(new_item==NULL)
	{
		puts("Memory error");
		getch();
		return;
	}
	window(1,4,80,25);
	clrscr();
	printf ("\n\t\t\t\t���������� ������\n");   // ���������� ������
	cprintf("������ �a��a��� �a��⭨�a: ");   // ������� �������� ���������:
	scanf("%s",&new_item->name);
	cprintf("������ ���: ");     // ������� ���:
	scanf("%s",&new_item->type);
	cprintf("������ �aᯮ�������: ");       // ������� ������������
	scanf("%s",&new_item->location);
	cprintf("������ ����a�� (�� ����� 30 ᨬ�����, ����� �஡��a �ᯮ�짮�a�� _ ):"); //������� ����������(�� ����� 30 ��������, ������ ������� ������������ _ ):
	scanf("%s",&new_item->info);

	if(Head==NULL)
	{
		Head=new_item;
		Head->next=NULL;
		return;
	}
	pre=Head;
	while(pre->next!=NULL)
	pre=pre->next;
	pre->next=new_item;
	new_item->next=NULL;
	clrscr();
	return;
}
void List() // ������� ��� �������� ������� ���� ������
{
	Monument* cur;
	int j;
	window(1,4,80,4);
	textbackground(GREEN);
	clrscr();
	cprintf("%c    �a��a���   %c     ���      %c  �aᯮ������� %c          ����a��          %c",186,179,179,179,186);
	window(1,5,80,24);
	textbackground(BLACK);
	clrscr();
	if(Head==NULL)
	return;
	cur=Head;
	while(N>(19+z)||N<(1+z))
	{
		if(N>(19+z))
		z++;
		if(N<(1+z))
		z--;
	}
	for(j=1;j<=z;j++)
	cur=cur->next;
	for(j=1;j<=19;j++)
	{
		if(cur==NULL)
		break;
		if(j==N-z)
		{
			textbackground(RED);
			cprintf("%c%-15s%c%-14s%c%-15s%c%-30s%c ",186,cur->name,179,cur->type,179,cur->location,179,cur->info,186);
			textbackground(BLACK);
			cur=cur->next;
		}
		else
		{
			cprintf("%c%-15s%c%-14s%c%-15s%c%-30s%c ",186,cur->name,179,cur->type,179,cur->location,179,cur->info,186);
			cur=cur->next;
		}
	   }
	   window(1,24,80,24);
	   printf("%c",200);
	   for (j=1;j<=77;j++)
	   printf("%c",205);
	   printf("%c",188);

}
void Listwalk() // ������� ��� ��������� ���� ������, ���������� ���� ������.
{
	Monument* cur=Head;
	int n=1,t;
	char c;
	if(Head==NULL)
	return;
	while(cur->next!=NULL)
	{
		cur=cur->next;
		n++;
	}
	while(1)
	{
		window(1,24,80,24);
		textbackground(BLACK);
		clrscr();
		for(t=1;t<=79;t++)
		cprintf("_");
		window(1,25,80,25);
		textbackground(GREEN);
		clrscr();
		cprintf("| F1 - ����. | F2 - �������� | F3 - ������� | F4 - ������஢��� | ESC - �����|");
		window(1,1,80,25);
		textbackground(BLACK);
		if(!(c=getch()))
		{
			c=getch();
		}

		switch(c)
		{
			case 72:
				if(N!=1)
				N--;
				List();
				break;
			case 80:
				if(N<n)
				N++;
				List();
				break;
			case 27:
				return;

			case 59:
				t=now_n;
				now_n=12;
				sort();
				now_n=t;
				List();
				break;
			case 60:
				add();
				List();
				if(save_check==1)
				Save();
				break;
			case 61:
				delet();
				List();
				if(save_check==1)
				Save();
				break;
			case 62:
				edit();
				List();
				if(save_check==1)
				Save();
				break;
		}
	}
}
void  clean() // ������� ������� ���� ���� ������
{
	Monument *cur;
	cur=Head;
	char a;
	window(25,10,55,14);
	textbackground(GREEN);
	clrscr();
	cprintf("���� ������ ᯨ᮪?");
	window(25,13,55,14);
	cprintf("     Y/� - �� ");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='�'||a=='�'||a=='l'||a=='L'||a=='�'|a=='�'){
	while (1)
	{
	cur=Head->next;
	if(cur->next==NULL)
	{
		Head=NULL;
		return;
	}
	free(Head);
	Head=cur;
	}
	Head=NULL;}
}

void Save () // ������� ����������
{
	FILE* f;
	Monument* cur=Head;
	if ((f=fopen ("Monument.txt","w")) ==NULL) {
		printf ("Save error");
		getch ();
		return;
	}
	while(cur!=NULL)
	{
		fprintf (f," %s %s %s %s",cur->name,cur->type,cur->location,cur->info);
		cur=cur->next;
	}
	fclose (f);
}
void Load () // ������� ��������
{
	FILE * f;
	if ( ! ( f = fopen("Monument.txt", "r") ) )
	{
		printf("fopen error");
		return;
	}
	while (!feof(f))
	{
		add_l(f);
	}
	fclose (f);
}
void add_l(FILE* f) // ������� ��� ����������� ��������� �������, ��� ��������
{
	Monument *pre,*new_item;
	new_item=(Monument*)malloc(sizeof(Monument));
	if(new_item==NULL)
	{
		puts("Memory error");
		getch();
		return;
	}
	fscanf(f," %s",&new_item->name);
	fscanf(f,"%s",&new_item->type);
	fscanf(f,"%s",&new_item->location);
	if(feof(f))
	return;
	fscanf(f,"%s",&new_item->info);
	if(Head==NULL)
	{
		new_item->next=NULL;
		Head=new_item;
		return;
	}
	pre=Head;
	while(pre->next!=NULL)
	pre=pre->next;
	pre->next=new_item;
	new_item->next=NULL;
	return;
}
void delet() // ������� �������� �������
{
	Monument *cur=Head,*prev=Head;
	char a;
	int k=0;
	cur=cur->next;
	cur=Head;
	window(25,10,55,14);
	textbackground(GREEN);
	clrscr();
	cprintf("���� 㤠���� ��࠭��       �����?");
	window(25,13,55,14);
	cprintf("     Y/� - �� ");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='�'||a=='�'||a=='l'||a=='L'||a=='�'|a=='�')
	{
		if(N==1)
		{
			cur=Head->next;
			free(Head);
			Head=cur;
			return;
		}
		for(k=1;k<(N-1);k++)
		prev=prev->next;
		cur=prev->next;
		prev->next=cur->next;
		free(cur);
		N--;
	}
	return;
}
void edit() // ������� �������������� �������
{
	Monument *cur=Head;
	int k=0;
	char a;
	window(25,10,55,14);
	textbackground(GREEN);
	clrscr();
	cprintf("���� ।���஢��� ��࠭��       �����?");
	window(25,13,55,14);
	cprintf("      Y/� - �� ");
	textbackground(BLACK);
	window(1,1,80,25);
	a=getch();
	if(a==27)
	return;
	if(a=='Y'||a=='y'||a=='�'||a=='�'||a=='l'||a=='L'||a=='�'|a=='�')
	{
		for(k=1;k<N;k++)
		cur=cur->next;
		window(1,4,80,25);
		clrscr();
		cprintf("������ �a��a��� �a��⭨�a: ");   // ������� �������� ���������:
		scanf("%s",&cur->name);
		cprintf("������ ���: ");     // ������� ���:
		scanf("%s",&cur->type);
		cprintf("������ �aᯮ�������: ");       // ������� ������������
		scanf("%s",&cur->location);
		cprintf("������ ����a��: ");         //������� ����������:
		scanf("%s",&cur->info);

	}
}
void autosave() // ������� ��������������
{
	char a;
	window(25,10,55,14);
	textbackground(GREEN);
	clrscr();
	if(save_check==1)
	{
		cprintf("     �����࠭���� ����祭�");
		window(25,13,55,14);
		cprintf("   Y/� - �몫����");
	}
	else
	{
		cprintf("     �����࠭���� �몫�祭�");
		window(25,13,55,14);
		cprintf("   Y/� - �������");
	}
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='�'||a=='�'||a=='l'||a=='L'||a=='�'|a=='�')
	{
		if(save_check==1)
			save_check=0;
		else
			save_check=1;
	}
}
void sort() // ������� ����������       ������� �� ������, �����, ������, ���� ����������
{
	Monument *cur,*out=NULL,*p,*pr;
	while (Head !=NULL)
	{
		cur = Head;
		Head = Head->next;
		if(now_n==11){
		for (p=out,pr=NULL; p!=NULL && cur->type<p->type; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		} }
		if(now_n==12){
		for (p=out,pr=NULL; p!=NULL && cur->location<p->location; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		} }
	 }
Head=out;
return;
}
int exit() // ������� ��� ���������� ������ ���������
{
	char a;
	window(25,10,55,14);
	textbackground(GREEN);
	clrscr();
	cprintf("   ��筮 ��� ���?");
	window(25,13,55,14);
	cprintf("   Y/� - ��");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='�'||a=='�'||a=='l'||a=='L'||a=='�'|a=='�')
	return 1;
	return 0;
}
void search() // ������� ��� ������ �� ���� ������
{
	char sname[15];
	int n=1;
	Monument *cur;
	cur=Head;
	window(28,2,79,2);
	textbackground(GREEN);
	scanf("%s",&sname);
	if(Head==NULL)
	{
		cprintf(" ���᮪ ���� ");
		return;
	}
	while(cur->next!=NULL)
	{
		if(strcmp(cur->name,sname)==0)
		{
			clrscr();
			cprintf("%s �a����!",sname);
			window(1,1,80,25);
			textbackground(BLACK);
			N=n;
			getch();
			return;
		 }
		 n++;
		 cur=cur->next;
	}
	cprintf("%s �� �a����!",sname);
	window(1,1,80,25);
	textbackground(BLACK);
	getch();
	return;
}


