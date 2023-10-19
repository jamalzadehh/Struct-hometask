using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListInt
    {
        private int[] array = new int[0];

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("null"); //alt + enter
                }

                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("null");
                }

                array[index] = value;
            }
        }

        public void Add(int num)
        {
            int[] newArray = new int[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = num;
            array = newArray;
        }

        public void AddRange(params int[] nums)
        {
            int[] newArray = new int[array.Length + nums.Length];
            array.CopyTo(newArray, 0);
            nums.CopyTo(newArray, array.Length);
            array = newArray;
        }

        public bool Contains(int num)
        {
            foreach (int i in array)
            {
                if (i == num)
                {
                    return true;
                }
            }

            return false;
        }

        public int Sum()
        {
            int sum = 0;

            foreach (int i in array)
            {
                sum += i;
            }

            return sum;
        }

        public void Remove(int num)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                int[] newArray = new int[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j] = array[i];
                        j++;
                    }
                }
                array = newArray;
            }
        }

        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                Remove(num);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", array);
        }
    }
}
