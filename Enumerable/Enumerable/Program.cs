using System;
using System.Collections;
using System.Threading;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        //IEnumerator 멤버
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        //IEnumrator 멤버
        public bool MoveNext()
        {
            if(position == array.Length - 1 )
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < array.Length; i++ )
            {
                yield return (array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for( int i = 0; i < 5; i++ )
            {
                list[i] = i;
            }

            foreach( int e in list)
            {
                Console.WriteLine(e);
            }

            //연습문제 2 번

            int[,] arrA =new int [2,2] { { 3,2} , { 1,4} };
            int[,] arrB = { { 9, 2 }, { 1, 7 } };
            int[,] arrAB = new int[2, 2];

            arrAB[0, 0] = (arrA[0, 0] * arrB[0, 0]) + (arrA[0, 1] * arrB[1, 0]);
            arrAB[0, 1] = (arrA[0, 0] * arrB[0, 1]) + (arrA[0, 1] * arrB[1, 1]);
            arrAB[1, 0] = (arrA[1, 0] * arrB[0, 0]) + (arrA[1, 1] * arrB[1, 0]);
            arrAB[1, 1] = (arrA[1, 0] * arrB[0, 1]) + (arrA[1, 1] * arrB[1, 1]);

            foreach( int e in arrAB)
            {
                Console.WriteLine(e);
            }

        }
    }
}
