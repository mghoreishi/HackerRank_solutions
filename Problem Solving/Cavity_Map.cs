using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Cavity_Map
    {
        public static List<string> cavityMap(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if ((i != grid.Count - 1 && grid[i][j] > grid[i + 1][j]) &&
                        (i != 0 && grid[i][j] > grid[i - 1][j]) &&
                         (j != grid[i].Length - 1 && grid[i][j] > grid[i][j + 1]) &&
                         (j != 0 && grid[i][j] > grid[i][j - 1]))

                        grid[i] = grid[i].Remove(j, 1).Insert(j, "X");

                }
            }

            return grid;
        }
    }
}
