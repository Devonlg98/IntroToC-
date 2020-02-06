#pragma once
#include <iostream>

template <typename T>
class tList
{
	struct Node
	{

		T data;                     // data for the element stored
		Node * prev;                // pointer to node following this node
		Node * next;                // pointer to node following this node
		Node()
		{
			prev = nullptr;
			next = nullptr;

		}
		Node(const T& val, Node* prv, Node* nxt)
		{
			data = val;
			prev = prv;
			next = nxt;
		}
	};

	Node * head;                 // pointer to head of linked list
	Node * tail;                // pointer to tail of linked list

public:
	tList();                 // initializes head to null
	// copy-constructor
	tList(const tList& other) 
	{

		//iterates through loop with head pointer and other node and copys values from other into new nodes.
		Node * otherNode = other.head;
		head = new Node(otherNode->data, otherNode->prev, otherNode->next);
		Node * headPointer = head;

		while (otherNode->next->next != nullptr)
		{
			headPointer->next = new Node(otherNode->next->data, otherNode, otherNode->next->next);
			headPointer = headPointer->next;
			otherNode = otherNode->next;
		}

		otherNode->next = nullptr;
		tail = otherNode;
	}
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
	T& size();
	void resize(size_t newSize);    // Resizes the linked list to contain the given number of elements
									// New elements are default-initialized

	class iterator
	{
		Node * cur;                                 // current node being operated upon

	public:

		iterator();                                 // initializes an empty iterator pointing to null
		iterator(Node * startNode);                 // initializes an iterator pointing to the given node

		bool operator==(const iterator& rhs) const; // returns true if the iterator points to the same node
		bool operator!=(const iterator& rhs) const; // returns false if the iterator does not point to the same node
		T& operator*();								// returns a reference to the element pointed to by the current node
		T& operator*() const;                       // returns a reference to the element(data) pointed to by the current(cur) node
		iterator & operator++()                    // pre-increment (returns a reference to this iterator after it is incremented)
		{
			this->cur = this->cur->next;
			return *this;
		}
		iterator operator++(int)					// post-increment (returns an iterator as it was before it was incremented)

		{
			cur = cur->next;
			return *this;
		}
		//T& operator*() const;                       // returns a reference to the element(data) pointed to by the current(cur) node
		//const T& operator*(); const                 // returns a reference to the element pointed to by the current node
	};

	iterator begin();
	const iterator begin() const;                   // returns a const iterator pointing to the first element
	iterator end();
	const iterator end() const;						// returns a const iterator pointing to one past the last element


};

//Sets head and tail to null on constructor
template<typename T>
inline tList<T>::tList()
{
	head = nullptr;
	tail = nullptr;
}

//Deconstructor clears and deconstrucst list
template<typename T>
inline tList<T>::~tList()
{
	clear();
}

// adds element to front (i.e. head)
template<typename T>
inline void tList<T>::push_front(const T & val)
{
	//checking if the list is empty and creating initial node
	if (head == nullptr)
	{
		Node *n = new Node();
		n->data = val;
		head = n;
		tail = n;
	}
	else
	{
		//Creating new node pointer
		Node *n = new Node();
		//storing old head pointer for later
		Node * oldHead = head;
		//Setting values of new node to val
		n->data = val;
		//Pointing new node to head
		n->next = head;
		//Setting the head to the new node
		head = n;
		//setting oldHeads previous to head
		oldHead->prev = head;
	}

}

// removes element from front aka removing whole node
template<typename T>
inline void tList<T>::pop_front()
{
	if (head == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	if (tail == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		return;
	}
	if (tail->prev == nullptr)
	{
		Node *oldHead = head;
		head = head->next;
		tail = nullptr;
		delete (oldHead);
	}
	if (head->next == nullptr)
	{
		Node *oldHead = head;
		head = head->next;
		head = nullptr;
		delete (oldHead);
	}
	else
	{
		Node *oldHead = head;
		head = head->next;
		head->prev = nullptr;
		delete (oldHead);
	}
}

// Adds element to back (i.e. before back).
template<typename T>
inline void tList<T>::push_back(const T & val)
{
	if (tail == nullptr)
	{
		Node *n = new Node();
		n->data = val;
		head = n;
		tail = n;
	}
	else
	{
		//Creating new node pointer
		Node *n = new Node();
		Node * oldTail = tail;
		//Setting values of new node to val
		n->data = val;
		//Pointing new node to head
		n->prev = tail;
		//Setting the head to the new node
		tail = n;
		oldTail->next = tail;
	}
}
// removes element from back
template<typename T>
inline void tList<T>::pop_back()
{
	if (tail == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		head = nullptr;
		return;
	}
	if (head == nullptr)
	{
		std::cout << "List needs more than 1 nodes." << std::endl;
		tail = nullptr;
		return;
	}	
	if (head->next == nullptr)
	{
		Node *oldTail = tail;
		tail = tail->prev;
		head = nullptr;
		delete (oldTail);
	}
	else 
	{
		Node *oldTail = tail;
		tail = tail->prev;
		tail->next = nullptr;
		delete (oldTail);

	}


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
	if (head == nullptr)
	{
		return;
	}
	//Check head first and check if null
	while (head->data == val)
	{
		Node *oldHead = head;
		head = head->next;
		head->prev = nullptr;
		delete (oldHead);
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

//Assignment Operator
template<typename T>
inline tList<T> & tList<T>::operator=(const tList & other)
{

	this->clear();
	Node * originalCurr = other.head;
	this->head = new Node(other.head->data, other.head->prev, other.head->next);
	Node * currentNode = this->head;

	while (originalCurr->next != nullptr)
	{
		currentNode->next = new Node(originalCurr->next->data, originalCurr->prev, originalCurr->next);
		originalCurr = originalCurr->next;
		currentNode = currentNode->next;
	}
	currentNode->next = nullptr;
	tail = currentNode;
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
	delete(tail);
}


//Checks size of list by iterating through
template<typename T>
inline T & tList<T>::size()
{
	int nodeCount = 0;
	Node* currentHead = head;
	while (currentHead->next != nullptr)
	{
		nodeCount++;
		currentHead = currentHead->next;
	}
	if (nodeCount != 0)
	{
	nodeCount++;
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
	//if the new size is larger than current list, initalize empty nodes to the front
	if (newSize > size())
	{
		for (int i = 0; i < sizeInt - 1; i++)
		{
			currentHead = currentHead->next;
		}
		for (int i = sizeInt; i < newSize; i++)
		{
			currentHead->next = new Node(placeHolderNode->data, placeHolderNode->prev, placeHolderNode->next);
			currentHead = currentHead->next;
		}
		tail = currentHead;
	}
	//if the new size is smaller, return;
	else if (newSize < sizeInt)
	{
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

//returning iterator nullptr because the end is always null
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
//Initializes empty pointing to null
template<typename T>
inline tList<T>::iterator::iterator()
{
	cur = nullptr;
}
//initializes pointing to current node
template<typename T>
inline tList<T>::iterator::iterator(Node * startNode)
{
	cur = startNode;
}

//returns true if iteraor points to the same node, false if not
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

//returns true if iteraor does not point to the same node, true if it does
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
inline typename T & tList<T>::iterator::operator*() const
{
	return *cur->data;
}





