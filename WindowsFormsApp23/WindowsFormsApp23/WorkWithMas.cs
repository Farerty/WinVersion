using System;
using System.Collections.Generic;
namespace WindowsFormsApp23
{
    class WorkWithMas
    {
        static int[] IntArray;
        static int n;
        static List<int> list = new List<int>();
        public WorkWithMas(int size)
        {
            n = size;
            IntArray = new int[size];
            list.Clear();
        }
        public void MassivFuller(string numberOfMassive)
        {
            string s = "";
            int suze = 0;

            for (int i = 0; i < numberOfMassive.Length; i++)
            {
                char c = numberOfMassive[i];
                if (c.ToString() == " ")
                {
                    int counter = 0;
                    counter = Convert.ToInt32(s);
                    list.Add(counter);
                    suze++;
                    s = "";

                }
                else
                {
                    s += c;
                }
            }

            

            IntArray = new int[suze];
            for (int i = 0; i < suze; i++)
            {
                IntArray[i] = list[i];
            }
           
        }
       
        public void sort()
        {
            Array.Sort(IntArray);
        }

        public int SizeOfMassiv
        {
            get { return n; }

        }
        public int ScalUmOnMassiv
        {
            set
            {
                int scal = value;
                for (int i = 0; i < n; i++)
                {
                    IntArray[i] = IntArray[i] * scal;
                }
            }
        }
        public string MassivShowev()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s+=IntArray[i] + " ";
            }
            return s;
        }
        public int this[int i]
        {
            get
            {
                return IntArray[i];
            }
            set
            {
                IntArray[i] = value;
            }
        }
        public static WorkWithMas operator ++(WorkWithMas a)
        {
            WorkWithMas temp = a;
            for (int i = 0; i < n; i++)
            {
                temp[i] = temp[i] + 1;
            }
            return temp;
        }
        public static WorkWithMas operator --(WorkWithMas a)
        {
            WorkWithMas temp = a;
            for (int i = 0; i < n; i++)
            {
                temp[i] = temp[i] - 1;
            }
            return temp;
        }
        public static WorkWithMas operator *(WorkWithMas a, int scal)
        {
            WorkWithMas temp = a;
            for (int i = 0; i < temp.SizeOfMassiv; i++)
            {
                temp[i] = temp[i] * scal;
            }
            return temp;
        }
        public static bool operator !(WorkWithMas a)
        {
            int counter = 1;
            for (int i = 1; i < n; i++)
            {
                if (IntArray[i - 1] < IntArray[i])
                {
                    counter++;
                }
            }
            if (counter == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator int[](WorkWithMas a)
        {
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = IntArray[i];
            }
            return temp;
        }
        public static implicit operator WorkWithMas(int[] a)
        {
            WorkWithMas temp = new WorkWithMas(n);
            for (int i = 0; i < n; i++)
            {
                temp[i] = a[i];
            }
            return temp;
        }


    }
}
