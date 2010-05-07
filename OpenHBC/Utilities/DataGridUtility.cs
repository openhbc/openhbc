using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC.Utilities
{
    class DataGridUtility
    {
        public static object GetValue(DataGridViewRow gridViewRow, int cellIndex)
        {
            object i = gridViewRow.Cells[cellIndex].Value;

            return i;
            
        }
    }
}
