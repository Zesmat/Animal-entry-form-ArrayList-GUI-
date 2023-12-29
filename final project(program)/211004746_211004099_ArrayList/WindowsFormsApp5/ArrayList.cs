
/*
 * ArrayList is a data structure which represented in class located in System.Collection. It can allocate data
   dynamically which means when adding or removing data it adjusts the array size automatically.
 * It can store objects of differnet data types in the same ArrayList instance. However, each object needed to be
   type casted before its used.
 * Most used iteration method in ArrayList is foreach loop due to its simplicty in accessing indivdual elements in their index.
 * It has various methods which can be used:Add(object value), Remove(object value), Clear(), IndexOf(object value)
 * In this project, we implemented ArrayList manually with more functions such as update, sort, search
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class MyArrayList
    {
        private object[] _items;// object is the base of all data type. Every class or data type
                                // inherits implicitly or explicitly from the object 
        private int _size;
        //internal int _Size;

        public MyArrayList()//defualt constructor
        {
            _items = new object[10]; //Create of array of objects with size 10
            _size = 0;
        }

        public MyArrayList(object[] items, int size)//paramitrized constructor
        {
            this._items = items;
            this._size = size;
        }

        

        public object this[int index]// defines the MyArrayList class instances with an indexer to make it accessible
                                    // in the array
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();//This is an exception that indicates that an attempt was made to
                                                         //access an element of an array or collection with an index that is outside the valid range.

                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();

                _items[index] = value;
            }
        }
        public void Add(object item)//add function
        {
            EnsureCapacity(_size + 1);//ensures that there is enough space for the entered item
            _items[_size++] = item;
        }

        //dynamically removes the data from the array
        //remove function
        public void _Remove(object item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (Equals(_items[i], item))//if currnet item is equal to item enter in the form then(true)
                {
                    Array.Copy(_items, i + 1, _items, i, _size - i - 1);//(sourceArray, sourceIndex, destArray,destIndex,length)
                                                                        //shift sall the items after the found item one position to the left
                    _size--;//decrement size array
                    break;
                }
            }
        }
        public void Update(int index, object newItem)//update function
        {
            if (index < 0 || index >= _size)
                throw new IndexOutOfRangeException();

            _items[index] = newItem;
        }

        public int PerformSearch(object searchTerm)//search function
        {
            // Sort the list before searching
            Sort();
           
            // Use binary search for optimized searching
            //it needs to be sorted before using Binary search
            int left = 0, right = _size - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;//calculate middle index number
                int comparison = string.Compare(_items[mid].ToString(), searchTerm.ToString(), StringComparison.OrdinalIgnoreCase);//(strA, strB, StringComparison comparisonType)
                if (comparison == 0)//item is found
                    return mid;
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // Item not found
            return -1;
        }
       

        public void Sort()//sort function
        {
            // Bubble Sort (for simplicity)
            for (int i = 0; i < _size - 1; i++)
            {
                for (int j = 0; j < _size - i - 1; j++)
                {
                    if (Comparer.Default.Compare(_items[j], _items[j + 1]) > 0)
                    {
                        object temp = _items[j];
                        _items[j] = _items[j + 1];
                        _items[j + 1] = temp;
                    }
                }
            }
        }
        public void Clear()
        {
            _size = 0;
        }

        //this method ensures that the _items array has enough space to hold a certain number of elements. 
        private void EnsureCapacity(int minCapacity)//minCapacity is the minimum capacity size the array should have
        {
            if (_items.Length < minCapacity)//checks if the current array size is less than the minimum size
            {
                int newCapacity = _items.Length * 2; // Doubling strategy for simplicity:common resizing strategy because
                                                     // it offers a good balance between performance and memory usage.
                if (newCapacity < minCapacity)
                    newCapacity = minCapacity;

                Array.Resize(ref _items, newCapacity);//reallocate the array size of _items to newCapacity
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
