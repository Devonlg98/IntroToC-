#pragma once
template<typename T>
class tForwardList
{
	struct Node
	{

		T data;                     // data for the element stored
		Node * next;                // pointer to node following this node

		//Constructor takes in two parameters if you want two values
		Node() {};
		Node(T orig) 
		{
			data = orig;
		}
	};

	Node * head;                    // pointer to head of linked list

public:
	tForwardList();                 // initializes head to null
	~tForwardList();                // delete all nodes upon destruction

	void push_front(const T& val);  // adds element to front (i.e. head)
	void pop_front();               // removes element from front

	T& front();                     // returns the element at the head
	T& size();
	const T& front() const;         // returns the element at the head (const)

	void remove(const T& val);      // removes all elements equal to the given value

	tForwardList(const tForwardList& other);            // copy-constructor

	tForwardList& operator=(const tForwardList &rhs);   // copy-assignment

	bool empty() const;             // Returns true if there are no elements
	void clear();                   // Destroys every single node in the linked list
	void resize(size_t newSize);    // Resizes the linked list to contain the given number of elements
									// New elements are default-initialized

	class iterator
	{
		Node * cur;                                 // current node being operated upon

	public:
		//Iterator like currenthead
		iterator();                                 // initializes an empty iterator pointing to null
		iterator(Node * startNode);                 // initializes an iterator pointing to the given node

		bool operator==(const iterator& rhs) const; // returns true if the iterator points to the same node
		bool operator!=(const iterator& rhs) const; // returns false if the iterator does not point to the same node
		T& operator*() const;                       // returns a reference to the element(data) pointed to by the current(cur) node
		iterator & operator++();                     // pre-increment (returns a reference to this iterator after it is incremented)
		iterator operator++(int);                   // post-increment (returns an iterator to current node while incrementing the existing iterator)

	};

	iterator begin();
	iterator end();

};

template<typename T>
inline tForwardList<T>::tForwardList()
{
	head = nullptr;
}

template<typename T>
inline tForwardList<T>::~tForwardList()
{

}

// adds element to front (i.e. head)
template<typename T>
inline void tForwardList<T>::push_front(const T & val)
{
	//Creating new node pointer
	Node *n = new Node;
	//Setting values of new node to val
	n->data = val;
	//Pointing new node to head
	n->next = head;
	//Setting the head to the new node
	head = n;
}

// removes element from front aka removing whole node
template<typename T>
inline void tForwardList<T>::pop_front()
{
	if (head == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	if (head->next == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	//Temp data for head so it can be deleted
	Node *tempN = head;
	//set head to the next Node
	head = head->next;
	//delete old headed node
	delete (tempN);

}

// returns the element at the head
template<typename T>
inline T & tForwardList<T>::front()
{
	return head->data;
}

template<typename T>
inline T & tForwardList<T>::size()
{
	int nodeCount = 0;
	Node* currentHead = head;
	while (currentHead != nullptr)
	{
		nodeCount++;
		currentHead = currentHead->next;
	}
	return nodeCount;
}

// returns the element at the head (const) can use for dynamic arrays
template<typename T>
inline const T & tForwardList<T>::front() const
{
	return head->data;
}

// removes all elements equal to the given value
template<typename T>
inline void tForwardList<T>::remove(const T & val)
{
	
	//Check head first and check if null
	while (head->data == val|| head == nullptr)
	{
		pop_front();
	}

	Node* currentHead = head;
	//curentHead->next = the pointer from current head
	while (currentHead->next != nullptr)
	{
		if (currentHead->next->data == val)
		{
			Node* deleteNode = currentHead->next;
			currentHead->next = currentHead->next->next;
			delete (deleteNode);
		}
		else
		{
		currentHead = currentHead->next;
		}
	}
}
//Copy Constructor
template<typename T>
inline tForwardList<T>::tForwardList(const tForwardList & other)
{
	//head null check head - nullptr
	//Other isn't pointer so I use . instead of ->

	Node * otherNode = other.head;
	head = new Node(otherNode->data);
	Node * headPointer = head;

	while (otherNode->next != nullptr)
	{
		headPointer->next = new Node(otherNode->next->data);
		headPointer = headPointer->next;
		otherNode = otherNode->next;
	}
	//head = headPointer;

}

//Assignment Operator
template<typename T>
inline tForwardList<T> & tForwardList<T>::operator=(const tForwardList & rhs)
{
	head = rhs.head;
	return *this;
}

// Returns true if there are no nodes in the linked list
template<typename T>
inline bool tForwardList<T>::empty() const
{
	if (head == nullptr)
	{
		return true;
	}
	else
	{
		return false;
	}
}
// Destroys every single node in the linked list
template<typename T>
inline void tForwardList<T>::clear()
{
	if (head == nullptr)
	{
		std::cout << "They are no nodes in this list" << std::endl;
		return;
	}
	Node* currentHead = head;
	Node* deleteNode = currentHead;
	while (currentHead != nullptr)
	{
		currentHead = currentHead->next;
		delete (deleteNode);
		deleteNode = currentHead;
	}
	head = nullptr;
	delete(head);
}
// Resizes the linked list to contain the given number of elements
// New elements are default-initialized
template<typename T>
inline void tForwardList<T>::resize(size_t newSize)
{
	int sizeInt = size();
	Node *placeHolderNode = new Node;
	placeHolderNode->data = 0;
	Node* currentHead = head;
	if (newSize > size())
	{
		for (int i = 0; i < sizeInt-1; i++)
		{
			currentHead = currentHead->next;
		}
		for (int i = sizeInt; i < newSize; i++)
		{
			currentHead->next = new Node(placeHolderNode->data);
			currentHead = currentHead->next;
		}
	}
	else if (newSize <= sizeInt)
	{
		std::cout << "New size is smaller than current list" << std::endl;
		return;
	}

}


//template<typename T>
//inline typename tForwardList<T>::iterator::begin()
template<typename T>
inline typename tForwardList<T>::iterator tForwardList<T>::begin()
{
	this.cur = head;
	return this.cur;
}

template<typename T>
inline typename tForwardList<T>::iterator tForwardList<T>::end()
{
	return iterator(nullptr);
}

template<typename T>
inline tForwardList<T>::iterator::iterator()
{
	cur = nullptr;
}

template<typename T>
inline tForwardList<T>::iterator::iterator(Node * startNode)
{
	cur = startNode;
}

template<typename T>
inline bool tForwardList<T>::iterator::operator==(const iterator & rhs) const
{
	if (rhs == cur)
	{
		return true;
	}
	else
	{
		return false;
	}
}

template<typename T>
inline bool tForwardList<T>::iterator::operator!=(const iterator & rhs) const
{
	if (rhs != cur)
	{
		return false;
	}
	else
	{
		return true;
	}
}

template<typename T>
inline T & tForwardList<T>::iterator::operator*() const
{
	return &cur->data;
}

template<typename T>
inline typename tForwardList<T>::iterator tForwardList<T>::iterator::operator++(int )
{
	cur = cur->next;
	return *this;
}
template<typename T>
inline typename tForwardList<T>::iterator & tForwardList<T>::iterator::operator++()
{
	cur = cur->next;
	return *this;
}

