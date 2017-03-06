using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class ShowData
    {
        public static void AddToGrid(this DataGridView grid, List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows.Add();
                var temp = data[i].Split(';');
                for (int j = 0; j < temp.Length; j++)
                {
                    grid.Rows[i].Cells[j].Value = temp[j];
                }
            }
        }

    }
}
