using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class PositionList
    {

        public List<Vector3> positions { get; private set; }

        /// <summary>
        /// creates list of positions for either path or wall cells
        /// </summary>
        /// <param name="path">true if generating floor positions</param>
        public PositionList(GridGraph<bool> boolGrid, bool path, int cellSize)
        {
            positions = new List<Vector3>();

            foreach((int,int) pos in boolGrid.positions)
            {
                if (boolGrid.GetCellValue(pos.Item1, pos.Item2) == path)
                {
                    positions.Add(new Vector3(pos.Item2 * cellSize, 0, pos.Item1 * cellSize));
                }
            }
        }



    }
}

