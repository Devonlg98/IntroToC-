#pragma once
#include <iostream>
#include <cmath>
#include <fstream>

template <typename T>
class tVector
{
	const static size_t GROWTH_FACTOR = 2;

	T *arr;                             // pointer to underlying array
	size_t arrSize;                     // stores the number of elements currently used
	size_t arrCapacity;                 // stores the capacity of the underlying array

public:
	tVector();                // initializes the vector's default values
	~tVector();                      // destroys the underlying array
	tVector(const tVector &vec);
	tVector& operator=(const tVector &vec);
	T *data();                          // returns a pointer to the underlying array

	void reserve(size_t newCapacity);   // reallocates the underlying array to at least the given capacity

	void push_back(const T &value);     // adds an element to the end of the vector
	void pop_back();                    // destroys and removes the last element of the vector

	T &at(size_t index);                // returns the element at the given index

	size_t size() const;                // returns current number of elements
	size_t capacity() const;            // returns maximum number of elements we can store
};


template <typename T>
tVector<T>::tVector()
{
	
	arrSize = 0;
	arrCapacity = 10;
}

template <typename T>
tVector<T>::~tVector()
{

}



