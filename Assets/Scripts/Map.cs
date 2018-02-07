using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Map<T>
{
    Point size;

    private T[,] array;

    public Map(int xSize, int ySize)
    {
        size = new Point(xSize, ySize);
        array = new T[xSize, ySize];
    }

    public T this[Point point]
    {
        get { return array[point.X, point.Y]; }
        set { array[point.X, point.Y] = value; }
    }

    public T this[int x, int y]
    {
        get{ return array[x, y]; }
        set { array[x, y] = value; }
    }

    public Point this[T gameObject]
    {
        get
        {
            for(int x = 0; x < size.X; x++)
            {
                for(int y = 0; y < size.Y; y++)
                {
                    if(array[x,y].Equals(gameObject))
                    {
                        return size;
                    }
                }
            }

            throw new System.IndexOutOfRangeException();
        }
        set
        {
            array[value.X, value.Y] = gameObject;
        }
    }
}
