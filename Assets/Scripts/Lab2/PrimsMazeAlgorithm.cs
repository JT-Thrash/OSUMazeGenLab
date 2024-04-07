using System.Collections.Generic;

namespace ThrashJT.Lab3
{


    public class PrimsMazeAlgorithm
    {

        private List<Cell> frontier;
        private List<Cell> inMaze;
        private List<List<Cell>> allCells;
        private GridGraph<Direction> directionGrid;

        public PrimsMazeAlgorithm()
        {

            // list of cells which are adjacent to visited cells
            frontier = new List<Cell>();

            // all cells added to maze (visited cells)
            inMaze = new List<Cell>();
        }

        //struct representing single cell in the maze
        struct Cell
        {
            public Cell(int r, int c) { row = r; col = c; }
            public readonly int row;
            public readonly int col;
        };


        private  bool InMaze(Cell cell)
        {
            return inMaze.Contains(cell);
        }

        private bool NotInMaze(Cell cell)
        {
            return !inMaze.Contains(cell);
        }

        // mark cell as part of the maze
        private void Mark(Cell cell)
        {
            inMaze.Add(cell);

            foreach (Cell neighbor in Neighbors(cell))
            {
                frontier.Add(neighbor);
            }

            frontier.RemoveAll(InMaze);
            
        }

        private readonly Dictionary<(int, int), (Direction, Direction)> map = new Dictionary<(int, int), (Direction, Direction)>()
        {
            { (-1, 0), (Direction.North, Direction.South) },
            { (1, 0), (Direction.South, Direction.North) },
            { (0, -1), (Direction.East, Direction.West) },
            { (0, 1), (Direction.West, Direction.East) }
        };


        private void CarvePassage(Cell cell1, Cell cell2)
        {
            (Direction cell1Dir, Direction cell2Dir) = map[(cell1.row - cell2.row, cell1.col - cell2.col)];

            CarveDirection(cell1, cell1Dir);
            CarveDirection(cell2, cell2Dir);

        }

        private void CarveDirection(Cell cell, Direction direction)
        {
            Direction currentDirection = directionGrid.GetCellValue(cell.row, cell.col);
            directionGrid.SetCellValue(cell.row, cell.col, currentDirection | direction);
        }

        public GridGraph<Direction> GenerateMaze(int rows, int columns)
        {

            //grid of directions to be returned
            directionGrid = new GridGraph<Direction>(rows, columns);



            //create list of list of cells
            allCells = new List<List<Cell>>();
            for (int i = 0; i < directionGrid.NumberRows; i++)
            {
                allCells.Add(new List<Cell>());
                for (int j = 0; j < directionGrid.NumberColumns; j++)
                {
                    allCells[i].Add(new Cell(i, j));
                }
                    
            }

            //mark random cell in grid to begin
            Mark(allCells[Seed.Next(rows)][Seed.Next(columns)]);


            //loop until all cells have been visited
            while(inMaze.Count < rows * columns)
            {

                // pick random cell from frontier
                Cell nextCell = frontier[Seed.Next(frontier.Count)];

                //mark the next cell and add its neighbors that haven't been visited to frontier
                Mark(nextCell);

                // pick random visited cell and carve passage from there to next cell
                List<Cell> adjacentCells = Neighbors(nextCell);
                adjacentCells.RemoveAll(NotInMaze);
                Cell startCell = adjacentCells[Seed.Next(adjacentCells.Count)];
                CarvePassage(startCell, nextCell);

            }

            AddEntranceAndExit(rows, columns);

            return directionGrid;
        }

        //randomly select cells in first and last row to be entrance and exit
        private void AddEntranceAndExit(int rows, int columns)
        {

            int randColumn1 = Seed.Next(columns), randColumn2 = Seed.Next(columns);

            Direction currentDirection = directionGrid.GetCellValue(0, randColumn1);
            directionGrid.SetCellValue(0, randColumn1, currentDirection | Direction.South);

            currentDirection = directionGrid.GetCellValue(rows - 1, randColumn2);
            directionGrid.SetCellValue(rows - 1, randColumn2, currentDirection | Direction.North);
        }


        //get cells immediately north, south, east, and west of current cell
        private List<Cell> Neighbors(Cell cell)
        {
            List<Cell> neighbors = new List<Cell>();
            int row = cell.row;
            int col = cell.col;

            if (row < directionGrid.NumberRows - 1) neighbors.Add(allCells[row+1][col]);
            if (row > 0) neighbors.Add(allCells[row-1][col]);
            if (col < directionGrid.NumberColumns - 1) neighbors.Add(allCells[row][col+1]);
            if (col > 0) neighbors.Add(allCells[row][col - 1]);

            return neighbors;
        }
    }
}

