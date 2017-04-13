#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <alloc.h>

typedef struct kino{ // —оздание структуры kino
	char name [15]; // ѕеременна€ дл€ Ќазвание  инотеатра
	char film [19]; // Ќазвание фильма
	char genre [17];  // ∆анр
	float session; //—еанс
	int info;   //÷ена
struct kino* next; // указатель на структуру *next типа struct kino
} Kino; //объ€вление объекта типа Kino, при этом выдел€етьс€ 64 байта пам€ти
void help(); // ќбъ€вл€ем функцию дл€ ѕомощи
void menu(); // ќбъ€вл€ем функцию дл€ ћеню
void search(); // ќбъ€вл€ем функцию дл€ ѕоиска
void List(); // ќбъ€вл€ем функцию дл€ ќдномерного списка
void Save(); // ќбъ€вл€ем функцию дл€ —охранени€
void Load(); // ќбъ€вл€ем функцию дл€ «агрузки
void sort(); // ќбъ€вл€ем функцию дл€ —ортировки
void autosave(); // ќбъ€вл€ем функцию дл€ јвтосохранени€
void clean(); // ќбъ€вл€ем функцию дл€ ќчистки списка
void delet(); // ќбъ€вл€ем функцию дл€ ”далени€ записей
void edit();  // ќбъ€вл€ем функцию дл€ –едактировани€ записей
void Listwalk(); // ќбъ€вл€ем функцию дл€ ѕрокрутки одномерноего списка
void add(); // ќбъ€вл€ем функцию дл€ ƒобавлени€ записей в одномерный список
int exit(); // ќбъ€вл€ем функцию дл€ ¬ыхода
void add_l(FILE* f); // ќбъ€вл€ем функцию дл€ ƒальнейшего обновлени€ структур
void printmenu(int x, int y); // ќбъ€вл€ем функцию дл€ ¬ыведени€ меню
int now_n=1,N=1,z=0,save_check=0; // ќбъ€вл€ютс€ переменный целого типа, и каждому присваиваетс€ определенное значение
Kino* Head=NULL; //указатель на структуру *Head типа Kino, равный нуль
int main ()
{
	char ch; // ќбъ€вл€ем переменную ch типа char
	clrscr(); // ќчистка экрана
	menu(); // »нициализаци€ ћеню
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
				if(now_n!=6&&now_n!=10&&now_n!=14&&now_n!=15&&now_n!=19&&now_n!=22)
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
				case 13:
					sort();
					menu();
					break;
				case 14:
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
void menu() // функци€ дл€ работы с меню
{

	if(now_n>=1&&now_n<=6)
	printmenu(1,6);
	if(now_n>=7&&now_n<=10)
	printmenu(7,10);
	if(now_n>=11&&now_n<=14)
	printmenu(11,14);
	if(now_n==15)
	printmenu(15,16);
	if(now_n>=17&&now_n<=19)
	printmenu(17,19);
	if(now_n>=20&&now_n<=22)
	printmenu(20,22);
}
void printmenu(int x, int y) // функци€ дл€ прорисовки меню
{

	int j,i;
	char** meny=(char**) malloc(23);
	for(j=1;j<=23;j++)
	meny[j]=(char*) malloc(15);
	meny[1]="|| Сѓ®бЃ™  |";
	meny[2]="| СЃав®аЃҐ™† |";
	meny[3]="|  ПЃ®б™  |";
	meny[4]="|  Ф†©Ђ  |";
	meny[5]="| ПЃђЃйм |";
	meny[6]="|  ВлеЃ§  ||";
	meny[7]="||  ДЃ°†Ґ®вм  |";
	meny[8]="| Оз®бв®вм бѓ®бЃ™ |";
	meny[9]="| Р•§a™в®аЃҐaвм |";
	meny[10]="| ПаЃбђЃва °aІл §a≠≠ле† ||";
	meny[11]="|| ПЃ НaІҐa≠®о   |"; // по фильму
	meny[12]="|  ПЃ ¶a≠аг  |";     // по жанру
	meny[13]="|  ПЃ б•a≠бг  |";     //по сеансу
	meny[14]="|  ПЃ ж•≠•  ||";       // по цене
	meny[15]="|| ПЃ®б™ |";
	meny[16]="|  Ф®Ђмђ: ";             //‘ильм
	meny[17]="|| СЃеаa≠®вм  |";
	meny[18]="|  Зa£агІ®вм  |";
	meny[19]="|  АҐвЃбЃеаa≠•≠®•  |";
	window(1,1,80,25);
	textbackground(BLACK);
	clrscr();
	for (i=1;i<=80;i++)
	{
		printf("%c",205);
	}
	window(1,2,80,2);
	textbackground(BLUE);
	clrscr();
	for(i=x;i<=y;i++)
		if(now_n!=i)
			cputs(meny[i]);
		else
		{
			textbackground(RED);
			cputs(meny[i]);
			textbackground(BLUE);
		}
	textbackground(BLACK);
	printf("\n%c",201);
	for (i=1;i<=77;i++)
	printf("%c",205);
	printf("%c",187);
	free(meny);
	window(1,25,80,25);
	textbackground(BLUE);
	clrscr();
	cprintf("| F1 - ПЃђЃйм | F2 - СЃеа†≠®вм | F3 - З†£агІ®вм | F4 - Сѓ®бЃ™  | F5 - ВлеЃ§   |");
	window(1,1,80,25);
	textbackground(BLACK);
	List();

}
void help() // ‘ункци€ дл€ помощи
{
	int c;
	window(1,1,80,25);
	clrscr();
	window(1,5,80,18);
	textbackground(BLUE);
	clrscr();
	cprintf("\n\n\nВлѓЃЂ≠®Ђ бвг§•≠в, 1 ™габa, Бa£Ђa© Н.М., £агѓѓл Э-53                                \n");    //¬ыполнил студент, 1 курса, Ѕалгай Ќ.ћ., группы Ё-53
	cprintf("Powered by RAD Studio XE4, Turbo C 3.0 + DOSBox 0.74                             \n");
	c=getch();
	if(c==27)
	return;
}
void add() // ‘ункци€ дл€ добавлени€ записей
{
	Kino *pre,*new_item,*cur;
	float f,*fp;
	int i;
	fp=&f;
	new_item=(Kino*)malloc(sizeof(Kino));
	if(new_item==NULL)
	{
		puts("Memory error");
		getch();
		return;
	}
	window(1,4,80,25); // «адаем размеры окна
	clrscr(); // ќчищаем экран
	printf ("\n\t\t\t\tДОБАВЛЕНИЕ ЗАПИСИ\n");   // ƒќЅј¬Ћ≈Ќ»≈ «јѕ»—»
	cprintf("ВҐ•§®в• ≠aІҐa≠®• К®≠Ѓв•aваa: ");   // ¬ведите название  инотеатра:
	scanf("%s",&new_item->name); // обращаемс€ к полю name структурной переменной new_item.
	cprintf("ВҐ•§®в• ≠aІҐa≠®• Ф®Ђмђa: ");     // ¬ведите название ‘ильма
	scanf("%s",&new_item->film); // обращаемс€ к полю film структурной переменной new_item.
	cprintf("ВҐ•§®в• ¶a≠а д®Ђмђa: ");       // ¬ведите жанр фильма
	scanf("%s",&new_item->genre); // обращаемс€ к полю chest структурной переменной new_item.
	cprintf("ВҐ•§®в• Ґа•ђп б•a≠бa: ");        //¬ведите врем€ сеанса
	scanf("%f",&new_item->session); // обращаемс€ к полю waist структурной переменной new_item.
	cprintf("ВҐ•§®в• ж•≠г б•a≠бa: ");         //¬ведите цену сеанса
	scanf("%d",&new_item->info);  // обращаемс€ к полю hip структурной переменной new_item.

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
void List() // функци€ дл€ создани€ таблицы базы данных
{
	Kino* cur;
	int j;
	window(1,4,80,4);
	textbackground(BLUE);
	clrscr();
	cprintf("%c   К®≠Ѓв•aва   %c       Ф®Ђмђ       %c       Жa≠а      %c    С•a≠б  %c    Ц•≠a   %c",186,179,179,179,179,186);
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
			cprintf("%c%-15s%c%-19s%c%-17s%c%-11.2f%c%-11d%c ",186,cur->name,179,cur->film,179,cur->genre,179,cur->session,179,cur->info,186);
			textbackground(BLACK);
			cur=cur->next;
		}
		else
		{
			cprintf("%c%-15s%c%-19s%c%-17s%c%-11.2f%c%-11d%c ",186,cur->name,179,cur->film,179,cur->genre,179,cur->session,179,cur->info,186);
			cur=cur->next;
		}
	   }
	   window(1,24,80,24);
	   printf("%c",200);
	   for (j=1;j<=77;j++)
	   printf("%c",205);
	   printf("%c",188);

}
void Listwalk() // ‘ункци€ дл€ просмотра базы данных, прокурутки базы данных.
{
	Kino* cur=Head;
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
		textbackground(BLUE);
		clrscr();
		cprintf("| F1 - СЃав. | F2 - ДЃ°†Ґ®вм | F3 - У§†Ђ®вм | F4 - Р•§†™в®аЃҐ†вм | ESC - Н†І†§|");
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
void  clean() // ‘ункци€ очистки всей базы данных
{
	Kino *cur;
	cur=Head;
	char a;
	window(25,10,55,14);
	textbackground(BLUE);
	clrscr();
	cprintf("ХЃв®в• Ѓз®бв®вм бѓ®бЃ™?");
	window(25,13,55,14);
	cprintf("     Y/Д - §† ");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='Д'||a=='§'||a=='l'||a=='L'||a=='Н'|a=='≠'){
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

void Save () // ‘ункци€ сохранени€
{
	FILE* f;
	Kino* cur=Head;
	if ((f=fopen ("KINO.txt","w")) ==NULL) {
		printf ("Save error");
		getch ();
		return;
	}
	while(cur!=NULL)
	{
		fprintf (f," %s %s %s %f %d",cur->name,cur->film,cur->genre,cur->session,cur->info);
		cur=cur->next;
	}
	fclose (f);
}
void Load () // ‘ункци€ загрузки
{
	FILE * f;
	if ( ! ( f = fopen("KINO.txt", "r") ) )
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
void add_l(FILE* f) // ‘ункци€ дл€ дальнейшего добалени€ записей, при загрузке
{
	Kino *pre,*new_item;
	new_item=(Kino*)malloc(sizeof(Kino));
	if(new_item==NULL)
	{
		puts("Memory error");
		getch();
		return;
	}
	fscanf(f," %s",&new_item->name);
	fscanf(f,"%s",&new_item->film);
	fscanf(f,"%s",&new_item->genre);
	fscanf(f,"%f",&new_item->session);
	if(feof(f))
	return;
	fscanf(f,"%d",&new_item->info);
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
void delet() // ‘ункци€ удалени€ записей
{
	Kino *cur=Head,*prev=Head;
	char a;
	int k=0;
	cur=cur->next;
	cur=Head;
	window(25,10,55,14);
	textbackground(BLUE);
	clrscr();
	cprintf("ХЃв®в• г§†Ђ®вм Ґл°а†≠≠л©       нЂ•ђ•≠в?");
	window(25,13,55,14);
	cprintf("     Y/Д - §† ");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='Д'||a=='§'||a=='l'||a=='L'||a=='Н'|a=='≠')
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
void edit() // ‘ункци€ редактировани€ записей
{
	Kino *cur=Head;
	int k=0;
	char a;
	window(25,10,55,14);
	textbackground(BLUE);
	clrscr();
	cprintf("ХЃв®в• а•§†™в®аЃҐ†вм Ґл°а†≠≠л©       нЂ•ђ•≠в?");
	window(25,13,55,14);
	cprintf("      Y/Д - §† ");
	textbackground(BLACK);
	window(1,1,80,25);
	a=getch();
	if(a==27)
	return;
	if(a=='Y'||a=='y'||a=='Д'||a=='§'||a=='l'||a=='L'||a=='Н'|a=='≠')
	{
		for(k=1;k<N;k++)
		cur=cur->next;
		window(1,4,80,25);
		clrscr();
		cprintf("ВҐ•§®в• ≠aІҐa≠®• К®≠Ѓв•aваa: ");   // ¬ведите название  инотеатра:
		scanf("%s",&cur->name); // обращаемс€ к полю name структурной переменной cur.
		cprintf("ВҐ•§®в• ≠aІҐa≠®• Ф®Ђмђa: ");     // ¬ведите название ‘ильма
		scanf("%s",&cur->film); // обращаемс€ к полю film структурной переменной cur.
		cprintf("ВҐ•§®в• ¶a≠а д®Ђмђa: ");       // ¬ведите жанр фильма
		scanf("%s",&cur->genre); // обращаемс€ к полю chest структурной переменной cur.
		cprintf("ВҐ•§®в• Ґа•ђп б•a≠бa: ");        //¬ведите врем€ сеанса
		scanf("%f",&cur->session); // обращаемс€ к полю waist структурной переменной cur.
		cprintf("ВҐ•§®в• ж•≠г б•a≠бa: ");         //¬ведите цену сеанса
		scanf("%d",&cur->info);  // обращаемс€ к полю hip структурной переменной cur.
	}
}
void autosave() // ‘ункци€ автосохранени€
{
	char a;
	window(25,10,55,14);
	textbackground(BLUE);
	clrscr();
	if(save_check==1)
	{
		cprintf("     АҐвЃбЃеа†≠•≠®• Ґ™Ђоз•≠Ѓ");
		window(25,13,55,14);
		cprintf("   Y/Д - Вл™Ђоз®вм");
	}
	else
	{
		cprintf("     АҐвЃбЃеа†≠•≠®• Ґл™Ђоз•≠Ѓ");
		window(25,13,55,14);
		cprintf("   Y/Д - В™Ђоз®вм");
	}
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='Д'||a=='§'||a=='l'||a=='L'||a=='Н'|a=='≠')
	{
		if(save_check==1)
			save_check=0;
		else
			save_check=1;
	}
}
void sort() // ‘ункци€ сортировки       —делано по фильму, жанру, сеансу, цене сортировка
{
	Kino *cur,*out=NULL,*p,*pr;
	while (Head !=NULL)
	{
		cur = Head;
		Head = Head->next;
		if(now_n==11){
		for (p=out,pr=NULL; p!=NULL && cur->film<p->film; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		} }
		if(now_n==12){
		for (p=out,pr=NULL; p!=NULL && cur->genre<p->genre; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		} }
		if(now_n==13){
		for (p=out,pr=NULL; p!=NULL && cur->session<p->session; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		}}
		if(now_n==14){
		for (p=out,pr=NULL; p!=NULL && cur->info<p->info; pr=p,p=p->next);
		if (pr==NULL)
		{
			cur->next=out; out=cur;
		}
		else
		{
			cur->next=p; pr->next=cur;
		}}
	 }
Head=out;
return;
}
int exit() // ‘ункци€ дл€ завершени€ работы программы
{
	char a;
	window(25,10,55,14);
	textbackground(BLUE);
	clrscr();
	cprintf("   ТЃз≠Ѓ еЃв®в• Ґл©в®?");
	window(25,13,55,14);
	cprintf("   Y/Д - §†");
	window(1,1,80,25);
	textbackground(BLACK);
	a=getch();
	if(a=='Y'||a=='y'||a=='Д'||a=='§'||a=='l'||a=='L'||a=='Н'|a=='≠')
	return 1;
	return 0;
}
void search() // ‘ункци€ дл€ поиска по базе данных
{
	char sname[15];
	int n=1;
	Kino *cur;
	cur=Head;
	window(28,2,79,2);
	textbackground(BLUE);
	scanf("%s",&sname);
	if(Head==NULL)
	{
		cprintf(" Сѓ®бЃ™ ѓгбв ");
		return;
	}
	while(cur->next!=NULL)
	{
		if(strcmp(cur->film,sname)==0)
		{
			clrscr();
			cprintf("%s ≠a©§•≠!",sname);
			window(1,1,80,25);
			textbackground(BLACK);
			N=n;
			getch();
			return;
		 }
		 n++;
		 cur=cur->next;
	}
	cprintf("%s ≠• ≠a©§•≠!",sname);
	window(1,1,80,25);
	textbackground(BLACK);
	getch();
	return;
}


