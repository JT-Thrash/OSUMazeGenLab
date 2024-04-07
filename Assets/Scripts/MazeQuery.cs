using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class MazeQuery
    {

        private GridGraph<Direction> maze;
        private int cellWidth, cellLength;

        public MazeQuery(GridGraph<Direction> maze, int cellWidth, int cellLength)
        {
            this.maze = maze;
            this.cellLength = cellLength;
            this.cellWidth = cellWidth;
        }

        // Get row/column corresponding to world position
        public (int, int) GetRowColumn(Vector3 position)
        {
            int row = (int)position.z / cellLength;
            int column = (int)position.x / cellWidth;

            return (row, column);
        }

        // Get world space position for row/column in the maze
        public Vector3 GetMazeSpacePosition(int row, int column)
        {
            if (!ValidCoordinate(row, column))
            {
                Debug.LogError("Error in GetMazeSpace: Invalid input for row and column");
            }

            float zPosition = GetMiddle(row, row + 1, cellLength);
            float xPosition = GetMiddle(column, column + 1, cellWidth);

            return new Vector3(xPosition, 0, zPosition);
        }

        // Get center position for row or column
        public float GetMiddle(int num1, int num2, int size)
        {
            bool odd = size % 2 != 0;
            if (odd) return (num1 * size + num2 * size) / 2;

            return (num1 * size + num2 * size - 1) / 2f;
        }

        // Starting cell of the maze
        public Vector3 GetStartPosition()
        {
            int startingColumn = 0;
            for (int col = 0; col < maze.NumberColumns; col++)
            {
                if (maze.GetCellValue(0, col).HasFlag(Direction.South))
                {
                    startingColumn = col;
                    break;
                }
            }
            return GetMazeSpacePosition(0, startingColumn);
        }

        // End of the maze
        public Vector3 GetEndPosition()
        {
            int endingColumn = 0;
            int lastRow = maze.NumberRows - 1;
            for (int col = 0; col < maze.NumberColumns; col++)
            {
                if (maze.GetCellValue(lastRow, col).HasFlag(Direction.North))
                {
                    endingColumn = col;
                    break;
                }
            }
            return GetMazeSpacePosition(lastRow, endingColumn);
        }

        private bool ValidCoordinate(int row, int column)
        {
            return row >= 0 && row < maze.NumberRows
                && column >= 0 && column < maze.NumberColumns;
        }


        public IEnumerable<(int, int)> GetDeadEnds()
        {
            foreach ((int, int) row_column in maze.positions)
            {
                int row = row_column.Item1, column = row_column.Item2;
                Direction direction = maze.GetCellValue(row, column);

                if (direction.IsDeadEnd())
                    yield return (row, column);
            }

        }

        public IEnumerable<(int, int)> GetStraights()
        {
            foreach ((int, int) row_column in maze.positions)
            {
                int row = row_column.Item1, column = row_column.Item2;
                Direction direction = maze.GetCellValue(row, column);

                if (direction.IsStraight())
                    yield return (row, column);
            }

        }

        public IEnumerable<(int, int)> GetTJuncts()
        {
            foreach ((int, int) row_column in maze.positions)
            {
                int row = row_column.Item1, column = row_column.Item2;
                Direction direction = maze.GetCellValue(row, column);

                if (direction.IsTJunction())
                    yield return (row, column);
            }

        }

        public IEnumerable<(int, int)> GetTurns()
        {
            foreach ((int, int) row_column in maze.positions)
            {
                int row = row_column.Item1, column = row_column.Item2;
                Direction direction = maze.GetCellValue(row, column);

                if (direction.IsTurn())
                    yield return (row, column);
            }

        }

        public IEnumerable<(int, int)> GetCrossSections()
        {
            foreach ((int, int) row_column in maze.positions)
            {
                int row = row_column.Item1, column = row_column.Item2;
                Direction direction = maze.GetCellValue(row, column);

                if (direction.IsCrossSection())
                    yield return (row, column);
            }
        }


    }
}