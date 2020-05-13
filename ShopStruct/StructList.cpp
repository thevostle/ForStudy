#include <iostream>

using namespace std;

template<typename T>
class List
{
public:
	List();
	~List();
	void push_back(T data);

	int GetSize()
	{
		return Size;
	}

private:

	template<typename T>
	class Node
	{
	public:
		Node* pNext;
		T data;
		Node(T data = T(), Node* pNext = nullptr)
		{
			this->data = data;
			this->pNext = pNext;
		}
	};

	int Size;
	Node<T>* head;
};

template<typename T>
List<T>::List()
{
	Size = 0;
	head = nullptr;
}

template<typename T>
List<T>::~List()
{

}

template<typename T>
void List<T>::push_back(T data)
{
	if (head == nullptr)
	{
		head = new Node<T>(data);
	}
	else
	{
		Node<T>* current = this->head;

		while (current->pNext != nullptr)
		{
			current = current->pNext;
			current->pNext = new Node<T>(data);
		}
	}

	Size++;
}

struct Shop
{
	int cost_1, cost_2, cost_3;
	int coords_x, coords_y;
};

/*
int main()
{
	List<int> lst;
	lst.push_back(5);
	lst.push_back(10);
	lst.push_back(12);

	cout << lst.GetSize() << "\t ta Element bor " << endl;
	int stop = 0;
	cin >> stop;
	return 0;
}*/
