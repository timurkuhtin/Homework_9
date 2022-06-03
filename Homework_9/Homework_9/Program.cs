using System;
using System.Collections;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Name<T> :IEnumerator 
        {
            T[] array = new T[1];
            int position = -1;
            public object Current => throw new NotImplementedException();

            public T[] Add(T item)
            {
                    T[] array2 = new T[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array2[i] = array[i];
                    }
                    array2[array.Length] = item;
                    return array2;
                
                //if (array[array.Length - 1] != null)
                //{
                //    T[] array2 = new T[array.Length * 2];
                //    for (int i = 0; i < array.Length; i++)
                //    {
                //        array2[i] = array[i];
                //    }
                //    array2[array.Length] = item;
                //    return array2;
                //}
                //else
                //{
                //    for (int i = array.Length/2; i < array.Length; i++)
                //    {
                //        if (array[i] == null)
                //        {
                //            array[i] = item;
                //        }
                //    }
                //    return array;
                //}
            }

            public T[] AddRange(T[] item)
            {
                T[] array2 = new T[array.Length + item.Length];
                for (int i = 0; i < array.Length - item.Length; i++)
                {
                    array2[i] = array[i];
                }
                for (int i = array.Length; i < array.Length - item.Length; i++)
                {
                    array2[i] = item[i - array.Length];
                }
                return array2;
                //if (array[array.Length - item.Length - 1] != null)
                //{
                //    T[] array2;
                //    if (item.Length <= array.Length)
                //    {
                //        array2 = new T[array.Length * 2];
                //    }
                //    else
                //    {
                //        array2 = new T[array.Length * 4];
                //    }                    
                //    for (int i = 0; i < array.Length; i++)
                //    {
                //        array2[i] = array[i];
                //    }
                //    for (int i = array.Length; i < array.Length + item.Length; i++)
                //    {
                //        array2[i] = item[i - array.Length];
                //    }
                //    return array2;
                //}
                //else
                //{
                //    int index = Array.IndexOf(array, null);
                //    for (int i = index; i < array.Length + item.Length; i++)
                //    {                        
                //        array[i] = item[i - array.Length];
                //    }
                //    return array;
                //}
            }

            public bool Remove(T item)
            {
                int index = Array.IndexOf(array, item);
                T[] array2 = new T[array.Length - 1];
                int f = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        array2[i] = array[i + f];
                    }
                    else
                    {
                        f++;
                    }
                }
                return true;
            }

            public bool RemoveAt(int index)
            {
                T[] array2 = new T[array.Length - 1];
                int f = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        array2[i] = array[i + f];
                    }
                    else
                    {
                        f++;
                    }
                }
                return true;
            }

            public void Sort()
            {
                for(int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])//подскажи, какой интерфейс нужно реализовать
                                                    //чтобы была возиожность применить сравнение,
                                                    //INumber только для математических операций ведь
                                                    //(и почемуто не хочет отображаться)
                        {
                            T temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            public bool MoveNext()
            {
                if (position < array.Length)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}
