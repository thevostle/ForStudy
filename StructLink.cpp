#include <iostream>
#include <list>
#include <iterator>

using namespace std;

struct StructLink
{
	int field;
	struct StructLink* next;
	struct StructLink* prev;
};

struct StructLink* inti(int n) // инициализация списка
{
	struct StructLink* fst;
	fst = (struct StructLink*)malloc(sizeof(struct StructLink));
	fst->field = n;
	fst->next = NULL;
	fst->prev = NULL;
	return(fst);
}

struct StructLink* AddToStart(StructLink* fst) // добавление в начало
{
	int number;
	cout << "Введите элемент для добавления в начало списка" << endl;
	cin >> number;
	struct StructLink* temp; // буферный кусок
	temp = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер

	while (fst->prev != NULL)
		fst = fst->prev;

	fst->prev = temp; // fst становится следующим для
	temp->field = number; // в буферный задаем поле
	temp->next = fst; // в буферный задаем следующий за ним элемент - p
	temp->prev = NULL; // в буферный задаем предыдущий нуль
	return(temp);
}

struct StructLink* addingend(StructLink* fst) // добавление в конец
{
	int number;
	cout << "Введите элемент для добавления в конец списка" << endl;
	cin >> number;
	struct StructLink* temp; // буферный кусок
	temp = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер
	while (fst->next != NULL)
	{
		fst = fst->next;
	}
	fst->next = temp; // fst становится следующим для
	temp->field = number; // в буферный задаем поле
	temp->next = NULL; // в буферный задаем следующий за ним элемент - p
	temp->prev = fst; // в буферный задаем предыдущий ним элемент - fst
	return(temp);
}

struct StructLink* deletelemn(StructLink* fst) // удаляем min
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* temp; // буферный кусок
	temp = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер
	temp = fst;
	a = temp->field;

	while (p->next != NULL)
	{
		b = p->field;
		if (a > b)
		{
			temp = p;
			a = b;
		}
		p = p->next;
	};

	struct StructLink* prevv, * nextt;
	p = fst;
	while (p->next != NULL)
	{
		b = p->field;
		if (a == b)
		{
			temp = p;
			p = p->next;
			prevv = temp->prev; // узел, предшествующий lst
			nextt = temp->next; // узел, следующий за lst

			if (prevv != NULL)
				prevv->next = nextt; // переставляем указатель
			if (nextt != NULL)
				nextt->prev = prevv; // переставляем указатель
			if (temp == fst)
				fst = fst->next;
			free(temp); // освобождаем память удаляемого элемента
		}
		else
			p = p->next;
	}
	return(fst);
}

struct StructLink* deletelemx(StructLink* fst) // удаляем min
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* temp; // буферный кусок
	temp = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер
	temp = fst;
	a = temp->field;
	while (p->next != NULL)
	{
		b = p->field;
		if (a < b)
		{
			temp = p;
			a = b;
		}
		p = p->next;
	};

	struct StructLink* prevv, * nextt;
	p = fst;
	while (p->next != NULL)
	{
		b = p->field;
		if (a == b)
		{
			temp = p;
			p = p->next;
			prevv = temp->prev; // узел, предшествующий lst
			nextt = temp->next; // узел, следующий за lst
			if (temp == fst)
				fst = fst->next;
			if (prevv != NULL)
				prevv->next = temp->next; // переставляем указатель
			if (nextt != NULL)
				nextt->prev = temp->prev; // переставляем указатель
			free(temp); // освобождаем память удаляемого элемента
		}
		else
			p = p->next;
	}
	return(fst);
}

struct StructLink* deletehead(StructLink* root) // удаляем корневой
{
	struct StructLink* temp;
	temp = root->next;
	temp->prev = NULL;
	free(root); // освобождение памяти текущего корня
	return(temp); // новый корень списка
}

void listprint(StructLink* lst) // печатаем нормально
{
	cout << endl;
	struct StructLink* p;
	p = lst;
	do {
		printf("%d ", p->field); // вывод значения элемента p
		p = p->next; // переход к следующему узлу
	} while (p != NULL); // условие окончания обхода
	cout << endl << endl;
}

void listprintr(StructLink* lst) // печатаем задом наперед
{
	cout << endl;
	struct StructLink* p;
	p = lst;
	while (p->next != NULL)
		p = p->next; // переход к концу списка
	do {
		printf("%d ", p->field); // вывод значения элемента p
		p = p->prev; // переход к предыдущему узлу
	} while (p != NULL); // условие окончания обхода
	cout << endl << endl;
}

struct StructLink* lswap(StructLink* fst) // взаимообмен файлов
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* min; // буферный кусок
	min = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер
	min = fst;
	a = min->field;
	while (p->next != NULL)
	{
		b = p->field;
		if (a > b)
		{
			min = p;
			a = b;
		}
		p = p->next;
	};

	p = fst;

	struct StructLink* max; // буферный кусок
	max = (struct StructLink*)malloc(sizeof(StructLink)); // выделение памяти под буфер
	max = fst;
	a = max->field;
	while (p->next != NULL)
	{
		b = p->field;
		if (a < b)
		{
			max = p;
			a = b;
		}
		p = p->next;
	};

	struct StructLink* prevn, * prevx, * nextn, * nextx;
	prevn = min->prev; // узел предшествующий min
	prevx = max->prev; // узел предшествующий max
	nextn = min->next; // узел следующий за min
	nextx = max->next; // узел следующий за max
	if (max == nextn) // обмениваются соседние узлы
	{
		max->next = min;
		max->prev = prevn;
		min->next = nextx;
		min->prev = max;
		if (nextx != NULL)
			nextx->prev = min;
		if (min != fst)
			prevn->next = max;
	}

	else if (min == nextx) // обмениваются соседние узлы
	{
		min->next = max;
		min->prev = prevx;
		max->next = nextn;
		max->prev = min;
		if (nextn != NULL)
			nextn->prev = max;
		if (max != fst)
			prevx->next = min;
	}

	else // обмениваются отстоящие узлы
	{
		if (min != fst) // указатель prev можно установить только для элемента,
			prevn->next = max; // не являющегося корневым
		max->next = nextn;
		if (max != fst)
			prevx->next = min;
		min->next = nextx;
		max->prev = prevn;
		if (nextx != NULL) // указатель next можно установить только для элемента,
			nextx->prev = min; // не являющегося последним
		min->prev = prevx;
		if (nextn != NULL)
			nextn->prev = max;
	}

	if (min == fst)
		return(max);

	if (max == fst)
		return(min);

	return(fst);
}

int menue(int q)
{
	do
	{
		cout << "Выберите пунктик меню" << endl;
		cout << "1. Добавить в начало;" << endl;
		cout << "2. Добавить в конец;" << endl;
		cout << "3. Удалить элемент с наименьшим значением;" << endl;
		cout << "4. Удалить элемент с наибольшим значением;" << endl;
		cout << "5. Поменять наибольший и наименьший элемент местами;" << endl;
		cout << "6. Вывод списка по порядку;" << endl;
		cout << "7. Вывод списка с конца;" << endl;
		cout << "0. Выход." << endl;
		cin >> q;
	} while (q < 0 || q>7);

	return (q);
}

int main()
{
	setlocale(0, "");
	cout << "Введите начальный элемент списка" << endl;
	int a;
	cin >> a;
	struct StructLink* fst = inti(a);
	int q = 9;
	q = menue(q);
	while (q >= 0 && q <= 7)
	{
		switch (q)
		{
		case 1:
		{
			fst = AddToStart(fst);
			q = menue(q);
			break;
		}
		case 2:
		{
			addingend(fst);
			q = menue(q);
			break;
		}
		case 3:
		{
			fst = deletelemn(fst);
			q = menue(q);
			break;
		}
		case 4:
		{
			fst = deletelemx(fst);
			q = menue(q);
			break;
		}
		case 5:
		{
			fst = lswap(fst);
			q = menue(q);
			break;
		}
		case 6:
		{
			listprint(fst);
			q = menue(q);
			break;
		}
		case 7:
		{
			listprintr(fst);
			q = menue(q);
			break;
		}
		case 0:
		{
			q = 10;
			break;
		}

		default: menue(q);
		}
	}
}
