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
	size_t capacity() const;      		// returns maximum number of elements we can store
	
	T *data()
	{
		return *arr;
	}

	void reserve(size_t newCapacity)
	{
		tempArr = new T[vec.arrCapacity];
		for (int i = 0; i < arrSize; i++)
		{
			temp[i] = arr[i];
		}
		arrCapacity = newCapacity;
		delete[] arr;
		arr[i] = temp[i];
		delete[] temp;
	}

	// adds an element to the end of the vector which is value
	void push_back(const T &value)
	{
		if (arrSize >= arrCapacity)
		{
			reserve(arrSize * 2);
		}
		arr[arrSize] = value;
		// Adding new element, so add to variable of size for future use
		arrSize++;

	}

	// destroys and removes the last element of the vector
	void pop_back()
	{
		arr[arrSize - 1] = nullptr;
	}

	// returns the element at the given index
	// check index valid number under arr size
	T &at(size_t index)
	{
		return 
	}
	size_t size() const
	{

	}
	size_t capacity() const
	{

	}
	

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

 template <typename T>
tVector<T>::tVector(const tVector &vec)
{
	arrSize = vec.arrSize;
	arrCapacity = vec.arrCapacity;
	arr = new T[vec.arrCapacity];
	for (int i = 0; i < arrSize; i++)
	{
		arr[i] = vec.arr[i];
	}
}

template <typename T>
tVector<T>& tVector<T>::operator=(const tVector<T> &vec)
{
	this->arrSize = vec.arrSize;
	this->arrCapacity = vec.arrCapacity;

	delete[] arr;

	arr = new T[vec.arrCapacity];
	for (int i = 0; i < arrSize; i++)
	{
		arr[i] = vec.arr[i];
	}
}


//Return type-> class -> function name

