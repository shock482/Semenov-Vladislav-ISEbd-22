using laba2sem1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sem1
{

    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        /* private T[] places;
         private T defaultValue;

         public ClassArray(int sizes, T defVal)
         {
             defaultValue = defVal;
             places = new T[sizes];
             for (int i = 0; i < places.Length; i++)
             {
                 places[i] = defaultValue;
             }
         }

         public T getObject(int ind)
         {
             if (ind > -1 && ind < places.Length)
             {
                 return places[ind];
             }
             return defaultValue;
         }

         public static int operator +(ClassArray<T> p, T rock)
         {
             for (int i = 0; i < p.places.Length; i++)
             {
                 if (p.CheckFreePlace(i))
                 {
                     p.places[i] = rock;
                     return i;
                 }
             }
             return -1;
         }

         public static T operator -(ClassArray<T> p, int index)
         {
             if (!p.CheckFreePlace(index))
             {
                 T rock = p.places[index];
                 p.places[index] = p.defaultValue;
                 return rock;
             }
             return p.defaultValue;
         }

         private bool CheckFreePlace(int index)
         {
             if (index < 0 || index > places.Length)
             {
                 return false;
             }
             if (places[index] == null)
             {
                 return true;
             }
             if (places[index].Equals(defaultValue))
             {
                 return true;
             }
             return false;
         }*/

        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = 15;
        }

       /* class ParkingOverflowException : Exception
        {
            public ParkingOverflowException() :
                base("В магазине нет свободных мест")
            { }
        }*/

        public static int operator +(ClassArray<T> p, T rock)
        {
            var isDiamond = rock is Diamond;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (rock.GetType() == p.places[i].GetType())
                {
                    if (isDiamond)
                    {
                        if ((rock as Diamond).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((rock as RockFormation).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                 p.places.Add(index, rock);
            }
            p.places.Add(p.places.Count, rock);
            return p.places.Count - 1;
        }

        private int currentIndex;

        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is RockFormation && other.places[thisKeys[i]] is Diamond)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is Diamond && other.places[thisKeys[i]] is RockFormation)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is RockFormation && other.places[thisKeys[i]] is RockFormation)
                    {
                        return (places[thisKeys[i]] is RockFormation).CompareTo(other.places[thisKeys[i]] is RockFormation);
                    }
                    if (places[thisKeys[i]] is Diamond && other.places[thisKeys[i]] is Diamond)
                    {
                        return (places[thisKeys[i]] is Diamond).CompareTo(other.places[thisKeys[i]] is Diamond);
                    }
                }
            }
            return 0;
        }

/* class ParkingIndexOutOfRangeException : Exception
 {
     public ParkingIndexOutOfRangeException() :
         base("В магазине нет драгоценности по такому индексу")
     { }
 }*/

public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T rock = p.places[index];
                p.places.Remove(index);
                return rock;
            }
            // return p.defaultValue;
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
