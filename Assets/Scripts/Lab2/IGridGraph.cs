using System.Collections.Generic;

namespace ThrashJT.Lab3
{
    public interface IGridGraph<T> : IEnumerable<T>
    {

        int NumberRows { get; }
        int NumberColumns { get; }

        T GetCellValue(int i, int j);
    }
}

