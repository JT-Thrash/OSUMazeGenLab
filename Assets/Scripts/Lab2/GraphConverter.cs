using System.Collections.Generic;

namespace ThrashJT.Lab3
{
    public static class GraphConverter
    {
        //small boolean grids corresponding to each element of the direction grid
        private static Dictionary<Direction, GridGraph<bool>> cellStamps;


        // checks if cell in a boolean grid is a path or wall cell
        // Example for cell in 3x3 boolean grid that goes north:
        //
        //              [wall, path, wall]
        //              [wall, path, wall]
        //              [wall, wall, wall]

        private static bool isPath(int row, int col, int numRows, int numCol, Direction dir)
        {
            bool middleCols = col > 0 && col < numCol - 1;
            bool middleRows = row > 0 && row < numRows - 1;
            bool middleOfCell = middleCols && middleRows;

            return row == 0 && middleCols && (dir & Direction.South) > 0    
                || row == numRows - 1 && middleCols && (dir & Direction.North) > 0
                || col == 0 && middleRows && (dir & Direction.West) > 0
                || col == numCol - 1 && middleRows && (dir & Direction.East) > 0
                || (middleOfCell && dir != Direction.None);
        }

        // get grid of bools that corresponds to specific direction
        private static GridGraph<bool> GetBoolGrid(int numRows, int numColumns, Direction dir)
        {
            GridGraph<bool> grid = new GridGraph<bool>(numRows, numColumns);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (isPath(i, j, numRows, numColumns, dir)) grid.SetCellValue(i, j, true);
                }
            }
            return grid;
        }



        public static GridGraph<bool> Convert(GridGraph<Direction> directionGrid, int boolRows, int boolCols)
        {

            int directionGridRows = directionGrid.NumberRows;
            int directionGridColumns = directionGrid.NumberColumns;

            GridGraph<bool> newGrid = new GridGraph<bool>(boolRows * directionGridRows, boolCols * directionGridColumns);

            FillStamps(boolRows, boolCols);


            foreach ((int, int) position in directionGrid.positions)
            {

                GridGraph<bool> gridToAdd = cellStamps[directionGrid.GetCellValue(position.Item1, position.Item2)];

                foreach ((int, int) pos in gridToAdd.positions)
                {
                    bool val = gridToAdd.GetCellValue(pos.Item1, pos.Item2);
                    newGrid.SetCellValue(position.Item1 * boolRows + pos.Item1, position.Item2 * boolCols + pos.Item2, val);
                }
            }

            return newGrid;

        }


        private static void FillStamps(int numRows, int numColumns)
        {

            cellStamps = new Dictionary<Direction, GridGraph<bool>>();
            for (int i = 0; i < 16; i++)
            {
                Direction dir = (Direction)i;
                cellStamps.Add(dir, GetBoolGrid(numRows, numColumns, dir));
            }
        }

    }
}

