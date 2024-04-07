using System.Collections;
using System.Collections.Generic;

namespace ThrashJT.Lab3
{
    public class GridGraph<T> : IGridGraph<T>
    {

        private T[,] grid;
        public readonly (int rows, int col)[] positions;

        public int NumberRows { get; private set; }
        public int NumberColumns { get; private set; }


        public GridGraph(int rows, int columns)
        {

            NumberRows = rows;
            NumberColumns = columns;
            grid = new T[rows, columns];
            positions = new (int rows, int col)[rows * columns];

            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for( int j = 0; j < columns; j++)
                {
                    positions[index++] = (i, j);
                }
            }
        }



        public void SetCellValue(int i, int j, T value)
        {
            grid[i, j] = value;

        }
        public T GetCellValue(int i, int j)
        {
            return grid[i, j];
        }

    

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (T cellData in grid)
            {
                yield return cellData;
            }

            
        }




    


    }
}

