#pragma once
template<typename T>
class tList
{
	struct Node
	{

		T data;                     // data for the element stored
		Node * prev;                // pointer to node following this node
		Node * next;                // pointer to node following this node

		//Constructor takes in two parameters if you want two values
		Node() {};
		Node(T orig)
		{
			data = orig;
		}
	};
	Node * tail;
	Node * head;                    // pointer to head of linked list

public:
	tList();                 // initializes head to null
	tList(const tList& other);            // copy-constructor
	tList& operator=(const tList &rhs);   // copy-assignment
	~tList();                // delete all nodes upon destruction

	void push_front(const T& val);  // adds element to front (i.e. head)
	void pop_front();               // removes element from front
	void push_back(const T& val);   // adds element to back (i.e. before back)
	void pop_back();                // removes element from back

	T& front();                     // returns the element at the head
	const T& front() const;         // returns the element at the head (const)
	T& back();                      // returns the element at the tail
	const T& back() const;          // returns the element at the tail (const)

	void remove(const T& val);      // removes all elements equal to the given value


	bool empty() const;             // Returns true if there are no elements
	void clear();                   // Destroys every single node in the linked list
	int size();
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
		T& operator*();								// returns a reference to the element pointed to by the current node
		T& operator*() const;                       // returns a reference to the element(data) pointed to by the current(cur) node
		iterator & operator++();                    // pre-increment (returns a reference to this iterator after it is incremented)
		iterator operator++(int);                   // post-increment (returns an iterator as it was before it was incremented)
		iterator& operator--();                     // pre-decrement (returns a reference to this iterator after it is decremented)
		iterator operator--(int);                   // post-decrement (returns an iterator as it was before it was decremented)
		////T& operator*() const;                       // returns a reference to the element(data) pointed to by the current(cur) node
		//iterator operator++(int);                   // post-increment (returns an iterator to current node while incrementing the existing iterator)
		//const T& operator*() const;                 // returns a reference to the element pointed to by the current node
	};

	iterator begin();
	const iterator begin() const;                   // returns a const iterator pointing to the first element
	iterator end();
	const iterator end() const;                     // returns a const iterator pointing to one past the last element


};

template<typename T>
inline tList<T>::tList()
{
	head = nullptr;
}

template<typename T>
inline tList<T>::~tList()
{

}

// adds element to front (i.e. head)
template<typename T>
inline void tList<T>::push_front(const T & val)
{
	//Creating new node pointer
	Node *n = new Node;
	//Setting values of new node to val
	n->data = val;
	//Pointing new node to head
	n->next = this->head;
	//Setting the head to the new node
	if (head != nullptr)
	{
		this->head->prev = n;
	}
	this->head = n;

	if (tail == nullptr)
	{
		tail = head;
	}
	// n and tmp are two pointers that are iterating, prev is being set after tail moves forward, so it's always a step behind tail. tmp IS NOT prev
	//while (n->next != nullptr)
	//{
	//	n = n->next;
	//	n->prev = tmp;
	//	tmp = tmp->next;
	//}
	//tail = n;
	//head->prev = nullptr;
}

// removes element from front aka removing whole node
template<typename T>
inline void tList<T>::pop_front()
{
	if (head != nullptr)
	{
		//Temp data for head so it can be deleted
		Node *tempN = head;
		//set head to the next Node
		head = head->next;
		if (head != nullptr)
		{
			head->prev = nullptr;
		}
		//delete old headed node
		delete (tempN);
	}


}

// Adds element to back (i.e. before back).
template<typename T>
inline void tList<T>::push_back(const T & val)
{
	//Creating new node pointer
	Node *n = new Node;
	//Setting values of new node to val
	n->data = val;
	//Pointing new node to head
	n->prev = tail;
	//Setting the head to the new node
	if (tail != nullptr)
	{
		tail->next = n;
	}
	tail = n;

	if (head == nullptr)
	{
		head = n;
	}
}
// removes element from back
template<typename T>
inline void tList<T>::pop_back()
{
	if (tail == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	if (tail->prev == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	// Temp data for tail so it can be deleted.
	Node *temp = tail;
	// Set head to the next Node
	tail= tail->prev;
	// Delete old headed node
	delete (temp);
}

// Returns the element at the head
template<typename T>
inline T & tList<T>::front()
{
	return head->data;
}
// returns the element at the head (const) can use for dynamic arrays
template<typename T>
inline const T & tList<T>::front() const
{
	return head->data;
}
// Returns the element at the tail.
template<typename T>
inline T & tList<T>::back()
{
	return tail->data;
}
// returns the element at the tail (const)
template<typename T>
inline const T & tList<T>::back() const
{
	return tail->data;
}

// removes all elements equal to the given value
template<typename T>
inline void tList<T>::remove(const T & val)
{

	//Check head first and check if null
	while (head->data == val || head == nullptr)
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
inline tList<T>::tList(const tList & other)
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
inline tList<T> & tList<T>::operator=(const tList & rhs)
{
	//head null check head - nullptr
	//rhs isn't pointer so I use . instead of ->
	if (this == &rhs)
	{
		return *this;
	}
	clear();
	Node * rhsNode = rhs.head;
	iterator it = rhs.head;
	while (it != end())
	{
		it++;
		push_back(rhsNode->data);
		rhsNode = rhsNode->next;
	}
	return *this;
}

// Returns true if there are no nodes in the linked list
template<typename T>
inline bool tList<T>::empty() const
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
inline void tList<T>::clear()
{
	if (head == nullptr)
	{
		std::cout << "They are no nodes in this list" << std::endl;
		return;
	}
	while (head != nullptr)
	{
		pop_front();
	}
	tail = nullptr;
}
template<typename T>
inline int tList<T>::size()
{
	int nodeCount = 0;
	iterator it = head;
	while (it != nullptr)
	{
		nodeCount++;
		it++;
	}
	return nodeCount;
}
// Resizes the linked list to contain the given number of elements
// New elements are default-initialized

template<typename T>
inline void tList<T>::resize(size_t newSize)
{
	int sizeInt = size();
	Node *placeHolderNode = new Node;
	placeHolderNode->data = 0;
	Node* currentHead = head;
	if (newSize > size())
	{
		for (int i = 0; i < sizeInt - 1; i++)
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
//inline typename tList<T>::iterator::begin()
template<typename T>
inline typename tList<T>::iterator tList<T>::begin()
{
	return iterator(head);
}

template<typename T>
inline typename const tList<T>::iterator tList<T>::begin() const
{
	return iterator(head);
}

template<typename T>
inline typename tList<T>::iterator tList<T>::end()
{
	return iterator(nullptr);
}

template<typename T>
inline typename const tList<T>::iterator tList<T>::end() const
{
	return iterator(nullptr);
}

template<typename T>
inline tList<T>::iterator::iterator()
{
	cur = nullptr;
}

template<typename T>
inline tList<T>::iterator::iterator(Node * startNode)
{
	cur = startNode;
}

template<typename T>
inline bool tList<T>::iterator::operator==(const iterator & rhs) const
{
	if (rhs.cur == cur)
	{
		return true;
	}
	else
	{
		return false;
	}
}

template<typename T>
inline bool tList<T>::iterator::operator!=(const iterator & rhs) const
{
	if (rhs.cur != cur)
	{
		return false;
	}
	else
	{
		return true;
	}
}

// returns a reference to the element pointed to by the current node
template<typename T>
inline T & tList<T>::iterator::operator*()
{
	return *cur->data;
}
// returns a reference to the element pointed to by the current node as a const
template<typename T>
inline T & tList<T>::iterator::operator*() const
{
	return *cur->data;
}

// pre-increment (returns a reference to this iterator after it is incremented)
template<typename T>
inline typename tList<T>::iterator & tList<T>::iterator::operator++()
{
	cur = cur->next;
	return *this;
}
// post-increment (returns an iterator as it was before it was incremented)
template<typename T>
inline typename tList<T>::iterator tList<T>::iterator::operator++(int)
{
	iterator tmp = *this;
	cur = cur->next;
	return tmp;
}

// pre-decrement (returns a reference to this iterator after it is decremented)
template<typename T>
inline typename tList<T>::iterator & tList<T>::iterator::operator--()
{
	cur = cur->prev;
	return *cur;
}
// post-decrement (returns an iterator as it was before it was decremented)
template<typename T>
inline typename tList<T>::iterator tList<T>::iterator::operator--(int)
{
	iterator tmp = *this;
	cur = cur->prev;
	return tmp;
}


