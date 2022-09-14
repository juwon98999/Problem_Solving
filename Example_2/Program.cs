using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 9, 11, 16, 21, 28, 36, 5};
            int[] arr2 = { 3, 9, 10, 29, 40, 45, 7 };
            int[] arr3 = { 2, 5, 12, 14, 24, 39, 33 };
            int[] arr4 = { 1, 6, 13, 37, 38, 40, 9 };
            int[] arr5 = { 1, 21, 25, 29, 34, 37, 36 };

            int[] Union_arr = (int[])Union(arr1, arr2);
            int[] Union_arr2 = (int[])Union(arr3, arr4);
            int[] Union_arr3 = (int[])Union(Union_arr, arr5);
            int[] Last_arr = (int[])Union(Union_arr2, Union_arr3);

            int Union_arr_Count = 0;


            Union_arr_Count = Length_Count(Last_arr, Union_arr_Count);


            int[] Sort_arr = new int[Union_arr_Count + 1];
            Sort_arr = (int[])QuickSort(Last_arr, 0 ,Union_arr_Count -1);


            //결과 출력
            Console.Write("합집합 : ");
            for (int j = 0; j < Union_arr_Count; j++)
            {
                Console.Write(Sort_arr[j]);
            }

        }

        static int Length_Count (int[] arr, int result)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    result++;
                }
            }

            return result;
        }


        static Array Union (int[] arr1, int[] arr2)
        {
            int count = 0;
            int[] Union = new int[50];
            int Remove_count = 0;
            int arr1_length = Length_Count(arr1 , 0);
            int arr2_length = Length_Count(arr2, 0);



            for (int i = 0; i < arr1_length; i++)
            {
                for(int j = 0; j < arr2_length; j++)
                {
                    Union[i] = arr1[i];
                    Union[arr1_length + j] = arr2[j];
                }
            }

            for (int i = 0; i < Union.Length; i++)
            {
                for (int j = i + 1; j < Union.Length; j++)
                {
                    if (Union[i] == Union[j])
                    {
                        Union[j] = 0;
                    }
                }
            }

            count = Count_Search(count , Union);
            Console.WriteLine("숫자 : " + count);


            int[] Result = Recursicve(Union, Remove_count);

            return Result;
        }

        static int[] Recursicve(int[] Union, int Remove_count)
        {
            
            for (int k = 0; k < Union.Length; k++)
            {
                for (int z = k + 1; z < Union.Length - 1; z++)
                {
                    if (Union[k] == 0)
                    {
                        Remove_count += 1;
                        int temp = Union[k];
                        Union[k] = Union[z];
                        Union[z] = temp;
                    }
                }
               
            }

            for(int a = Remove_count; a < 0; a--)
            {
                Remove_count -= 1;
                Recursicve(Union, Remove_count);
            }

            int num = (Count_Search(0, Union));
            int[] remove_zero = new int[num];
            for (int b = 0; b < num; b++)
            {
                remove_zero[b] = Union[b];
            }


            return remove_zero;
        }

        static int Count_Search(int a , int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    a++;
                }
            }

            return a;
        }

        static Array QuickSort (int[] arr, int left, int right)
        {
            
            if(left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
           

            return arr;
        }

        static public int Partition(int[] list, int left, int right)
        {

            int pivot = list[left];

            while (true)
            {
                while (list[left] < pivot)
                    left++;

                while (list[right] > pivot)
                    right --;

                if(left < right)
                {
                    int temp = list[right];
                    list[right] = list[left];
                    list[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

    }
}
