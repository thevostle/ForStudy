#include <iostream>

using namespace std;

struct StructLink
{
	int link;
	struct StructLink* next;
	struct StructLink* prev;
};

struct StructLink* StructInit(int n)
{
	struct StructLink* fst;
	fst = (struct StructLink*)malloc(sizeof(struct StructLink));
	fst->link = n;
	fst->next = NULL;
	fst->prev = NULL;

	return(fst);
}

struct StructLink* AddToStart(StructLink* fst)
{
	int number;
	cout << "Введите элемент для добавления в начало списка" << endl;
	cin >> number;
	struct StructLink* temp;
	temp = (struct StructLink*)malloc(sizeof(StructLink));

	while (fst->prev != NULL)
		fst = fst->prev;

	fst->prev = temp;
	temp->link = number;
	temp->next = fst;
	temp->prev = NULL;

	return(temp);
}

struct StructLink* AddToEnd(StructLink* fst)
{
	int number;
	cout << "Введите элемент для добавления в конец списка" << endl;
	cin >> number;
	struct StructLink* temp;
	temp = (struct StructLink*)malloc(sizeof(StructLink));

	while (fst->next != NULL)
		fst = fst->next;

	fst->next = temp;
	temp->link = number;
	temp->next = NULL;
	temp->prev = fst;
	return(temp);
}

struct StructLink* DeleteMin(StructLink* fst)
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* temp;
	temp = (struct StructLink*)malloc(sizeof(StructLink));
	temp = fst;
	a = temp->link;

	while (p->next != NULL)
	{
		b = p->link;
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
		b = p->link;
		if (a == b)
		{
			temp = p;
			p = p->next;
			prevv = temp->prev;
			nextt = temp->next;

			if (prevv != NULL)
				prevv->next = nextt;
			if (nextt != NULL)
				nextt->prev = prevv;
			if (temp == fst)
				fst = fst->next;
			free(temp);
		}
		else
			p = p->next;
	}

	return(fst);
}

struct StructLink* DeleteMax(StructLink* fst)
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* temp;
	temp = (struct StructLink*)malloc(sizeof(StructLink));
	temp = fst;
	a = temp->link;

	while (p->next != NULL)
	{
		b = p->link;
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
		b = p->link;
		if (a == b)
		{
			temp = p;
			p = p->next;
			prevv = temp->prev;
			nextt = temp->next;

			if (temp == fst)
				fst = fst->next;
			if (prevv != NULL)
				prevv->next = temp->next;
			if (nextt != NULL)
				nextt->prev = temp->prev;

			free(temp);
		}
		else
			p = p->next;
	}

	return(fst);
}

struct StructLink* deletehead(StructLink* root)
{
	struct StructLink* temp;
	temp = root->next;
	temp->prev = NULL;
	free(root);

	return(temp);
}

struct StructLink* SwapLink(StructLink* fst)
{
	struct StructLink* p;
	p = fst;
	int a, b;
	struct StructLink* min;
	min = (struct StructLink*)malloc(sizeof(StructLink));
	min = fst;
	a = min->link;

	while (p->next != NULL)
	{
		b = p->link;
		if (a > b)
		{
			min = p;
			a = b;
		}
		p = p->next;
	}

	p = fst;

	struct StructLink* max;
	max = (struct StructLink*)malloc(sizeof(StructLink));
	max = fst;
	a = max->link;

	while (p->next != NULL)
	{
		b = p->link;
		if (a < b)
		{
			max = p;
			a = b;
		}
		p = p->next;
	}

	struct StructLink* prevn, * prevx, * nextn, * nextx;
	prevn = min->prev;
	prevx = max->prev;
	nextn = min->next;
	nextx = max->next;

	if (max == nextn)
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

	else if (min == nextx)
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

	else
	{
		if (min != fst)
			prevn->next = max;
		max->next = nextn;
		if (max != fst)
			prevx->next = min;
		min->next = nextx;
		max->prev = prevn;
		if (nextx != NULL)
			nextx->prev = min;
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

void PrintStruct(StructLink* lst)
{
	cout << endl;
	struct StructLink* p;
	p = lst;

	do {
		printf("%d ", p->link);
		p = p->next;
	} while (p != NULL);

	cout << endl << endl;
}

void PrintStruct_Reverse(StructLink* lst)
{
	cout << endl;
	struct StructLink* p;
	p = lst;

	while (p->next != NULL)
		p = p->next;

	do {
		printf("%d ", p->link);
		p = p->prev;
	} while (p != NULL);

	cout << endl << endl;
}

int Menu(int task)
{
	do {
		cout << "Выберите действие" << endl;
		cout << "1. Добавление элемента в начало" << endl;
		cout << "2. Добавление элемента в конец" << endl;
		cout << "3. Удалить наименьший элемент" << endl;
		cout << "4. Удалить наибольший элемент" << endl;
		cout << "5. Поменять наибольший и наименьший элемент местами" << endl;
		cout << "6. Вывод списка" << endl;
		cout << "7. Вывод списка наоборот" << endl;
		cout << "0. Выход" << endl;
		cin >> task;
	} while (task < 0 || task > 7);

	return (task);
}

int main()
{
	setlocale(0, "");

	cout << "Введите начальный элемент списка" << endl;
	int a;
	cin >> a;

	struct StructLink* fst = StructInit(a);

	int task = 9;
	task = Menu(task);

	while (task >= 0 && task <= 7)
	{
		switch (task)
		{
			case 1:
			{
				fst = AddToStart(fst);
				task = Menu(task);
				break;
			}
			case 2:
			{
				AddToEnd(fst);
				task = Menu(task);
				break;
			}
			case 3:
			{
				fst = DeleteMin(fst);
				task = Menu(task);
				break;
			}
			case 4:
			{
				fst = DeleteMax(fst);
				task = Menu(task);
				break;
			}
			case 5:
			{
				fst = SwapLink(fst);
				task = Menu(task);
				break;
			}
			case 6:
			{
				PrintStruct(fst);
				task = Menu(task);
				break;
			}
			case 7:
			{
				PrintStruct_Reverse(fst);
				task = Menu(task);
				break;
			}
			case 0:
			{
				task = 10;
				break;
			}

			default: 
				Menu(task);
		}
	}
}
