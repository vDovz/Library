using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClients
{
    public static class ShowData
    {
        public static void ShowGrid(this DataGridView grid ,List<string> data)
        {
            grid.Rows.Clear();
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
