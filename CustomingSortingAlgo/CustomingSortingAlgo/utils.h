#pragma once
#include <iostream>
#include <cmath>
#include <fstream>
#include <algorithm>
#include<list>

template <typename T>
class tVector
{
	const static size_t GROWTH_FACTOR = 2;

	T *arr;                             // pointer to underlying array
	size_t arrSize;                     // stores the number of elements currently used
	size_t arrCapacity;                 // stores the capacity of the underlying array

public:
	tVector();						// initializes the vector's default values
	~tVector();                      // destroys the underlying array

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

	void bubbleSort()
	{
		bool valueSwapped = true;
		while (valueSwapped == true )
		{
			valueSwapped = false;
			for (int i = 0; i < size(); i++)
			{
				if (arr[i] < arr[i + 1])
				{
					std::swap(arr[i], arr[i + 1]);
					valueSwapped = true;
				}
			}
		}
	}
	void bubbleSortReverse()
	{
		bool valueSwapped = true;
		while (valueSwapped == true)
		{
			valueSwapped = false;
			for (int i = 0; i < size(); i++)
			{
				if (arr[i-1] > arr[i])
				{
					std::swap(arr[i-1], arr[i]);
					valueSwapped = true;
				}
			}
		}
	}

	void printList()
	{
		for (int i = 0; i < arrSize; i++)
		{
			std::cout << arr[i] << std::endl;
		}
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


