using System;
namespace Indexer18._10.Models
{
	internal class ListInt
	{
		private int[] _array;

        public int this[int index]
        {
            get
            {
                if (index < _array.Length)
                {
                    return _array[index];
                }
                return _array[_array.Length - 1];


            }
            set
            {
                if (index < _array.Length)
                {
                    _array[index] = value;
                }

            }
        }

        public ListInt()
        {
            _array = new int[0];
        }


        public void Add(int num)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = num;
        }

        public void AddRange(params int[] nums)
        {
            Array.Resize(ref _array, _array.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                _array[(_array.Length - nums.Length) + i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            foreach (var item in _array)
            {
                if (item == num)
                    return true;
            }
            return false;
        }

        public int Sum()  //Muellim ozum hazir method istifade etmedim ki, birden bal kesersiz :D
        {
            int sum = 0;
            foreach (var item in _array)
            {
                sum += item;
            }
            return sum;
        }

        public void Remove(int num) 
        {
            int[] _newarray = new int[0];
            foreach (int i in _array)
            {
                if (i!=num)
                {
                    Array.Resize(ref _newarray, _newarray.Length + 1);
                    _newarray[^1] = i;
                }
            }
            _array = _newarray;
        }

        public void RemoveRange(params int[] nums)
        {

            foreach (int i in nums)
            {
                Remove(i);
            }

        }

        public override string ToString()
        {
            return string.Join(", ", _array);
        }

    }


}

