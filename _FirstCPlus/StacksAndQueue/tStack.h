// tStack.h
#include "tVector.h"
#pragma once

template <typename T>
class tStack
{
	tVector<T> vec;                     // contains the data for a stack                   

public:
		// initializes the stack's default values
	tStack();
	void push(const T& value);

	// adds an element to the top of the Stack
	void pop();                         // drops the top-most element of the Stack

	T& top();                           // returns the top-most element at the given element

	bool empty() const; // returns true if empty, otherwise false

	size_t size() const;                // returns current number of elements
};

template<typename T>
inline tStack<T>::tStack()
{
	vec = new tVector();
}

template<typename T>
inline void tStack<T>::push(const T & value)
{
	vec.push_back();
}


template<typename T>
inline void tStack<T>::pop()
{
	vec.pop_back();
}

template<typename T>
inline T & tStack<T>::top()
{
	return vec[vec.size()-1];
}

template<typename T>
inline bool tStack<T>::empty() const
{
	vec.empty();
}

template<typename T>
inline size_t tStack<T>::size() const
{
	return vec.size();
}
