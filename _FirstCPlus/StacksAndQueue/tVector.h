#pragma once
#include <iostream>
#include <cmath>
#include <fstream>
#include<list>

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
	// returns a pointer to the underlying array
	T *data()
	{
		return *arr;
	}
	// reallocates the underlying array to at least the given capacity
	void reserve(size_t newCapacity)
	{
		T *tempArr = new T[newCapacity];
		for (int i = 0; i < arrSize; i++)
		{
			tempArr[i] = arr[i];
		}
		arrCapacity = newCapacity;

		delete[] arr;
		arr = tempArr;
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
		arrSize--;
	}

	// returns the element at the given index
	// check index valid number under arr size
	T &at(size_t index)
	{
		if (index > arrSize || index < 1)
		{
			std::cout << "Index smaller or larger than array's limits" << std::endl;
			//return;
		}

		return arr[index];
	}

	// returns current number of elements
	size_t size() const
	{
		return arrSize;
	}
	// returns maximum number of elements we can store
	size_t capacity() const
	{
		return arrCapacity;
	}
	// returns the object at the given index
	T& operator[] (size_t index)
	{
		return arr[index];
	}
	// Returns true if the vector contains no elements.
	bool empty() const
	{
		for (int i = 0; i < arrSize; i++)
		{
			if (!arr[i] == NULL)
				return false;
		}
		return true;
	}
	// Resizes the vector to contain the given number of elements.
	void resize(size_t newSize)
	{
		reserve(newSize);
	}

	// Resizes the vector's capacity to match its size.
	void shrink_to_fit()
	{
		arrCapacity = arrSize;
	}
	// Empties the vector (all elements are destroyed in this process)
	void clear()
	{
		delete[] arr;
	}

};


template <typename T>
tVector<T>::tVector()
{

	arrSize = 0;
	arrCapacity = 10;
	arr = new T[arrCapacity];
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

