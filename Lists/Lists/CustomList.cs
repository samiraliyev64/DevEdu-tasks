using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class CustomList
    {
        public int capacity;
        public int count;
        public int[] myList;
        public CustomList(int Capacity)
        {
            myList = new int[Capacity];
            capacity = Capacity;
            count = 0;
        }
        public CustomList(int[] arr)
        {
            count = arr.Length;
            capacity = arr.Length;
            myList = new int[count];
            for (int i = 0; i < count; i++)
            {
                myList[i] = arr[i];
            }
        }

        public void Print()
        {
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
        public void Add(int newValue)
        {
            if(count >= capacity)
            {
                count++;
                capacity++;
                int[] newList = new int[capacity];
                for (int i = 0; i < myList.Length; i++)
                {
                    newList[i] = myList[i];
                }
                newList[newList.Length - 1] = newValue;
                myList = newList;
            }
            else if(count < capacity)
            {
                count++;
                int[] newList = new int[count];
                if (count == 1)
                {
                    newList[0] = newValue;
                }
                else
                {
                    for (int i = 0; i < count-1; i++)
                    {
                        newList[i] = myList[i];
                    }
                    newList[newList.Length - 1] = newValue;
                }
                myList = newList;
            }
        }
        public void Remove(int removedValue)
        {
            //checking existence of value
            bool isExist = false;
            foreach (var item in myList)
            {
                if(item == removedValue)
                {
                    isExist = true;
                }
            }
            if(!isExist)
            {
                Console.WriteLine("there is no such value in list");
                return;
            }

            int[] filteredList = new int[capacity-1];
            int i = 0;
            foreach (var item in myList)
            {
                if (item != removedValue)
                {
                    filteredList[i] = item;
                    i++;
                }
            }
            myList = filteredList;
            count--;
            capacity--;
            
        }
        public void Insert(int index, int insertedValue)
        {
            count++;
            capacity++;
            int[] newList = new int[capacity];
            int j = 0;
            for (int i = 0; i < newList.Length; i++)
            {
                if(i != index)
                {
                    newList[i] = myList[j];
                    j++;
                }
                else
                {
                    newList[i] = insertedValue;
                }
            }
            myList = newList;   
        }
        public void Clear()
        {
            count = 0;
            myList = new int[] { };
        }
        public bool Contains(int searchedValue)
        {
            bool doesContain = false;
            foreach (var item in myList)
            {
                if(item == searchedValue)
                {
                    doesContain = true;
                }
            }
            if (!doesContain)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
       

