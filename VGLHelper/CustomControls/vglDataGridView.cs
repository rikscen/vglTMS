using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGLHelper.CustomControls
{
    public class vglDataGridView : DataGridView
    {
        public vglDataGridView()
        {
            DoubleBuffered = true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            //if (keyData == Keys.Enter)
            //{
            //    EndEdit();
            //    int icolumn = CurrentCell.ColumnIndex;
            //    int irow = CurrentCell.RowIndex;
            //    int columnCount = GetVisibleColumnCount();

            //    if (icolumn == columnCount)
            //    {
            //        //grdUom.Rows.Add();
            //        try
            //        {
            //            CurrentCell = this[FirstDisplayedScrollingColumnIndex, irow + 1];
            //            BeginEdit(true);
            //        }
            //        catch (ArgumentOutOfRangeException)
            //        {
            //        }
            //    }
            //    else
            //    {
            //        CurrentCell = this[icolumn + 1, irow];
            //        BeginEdit(true);
            //    }
            //    return true;
            //}
            //else
            //    return base.ProcessDialogKey(keyData);
            if (keyData == Keys.Enter)
            {
                EndEdit();
                return SelectNextCell();
            }

            return base.ProcessDialogKey(keyData);
        }

        private bool SelectNextCell()
        {
            int row = CurrentCell.RowIndex;
            int column = CurrentCell.ColumnIndex;
            DataGridViewCell startingCell = CurrentCell;

            do
            {
                column++;
                if (column == Columns.Count)
                {
                    column = 0;
                    row++;
                }
                if (row == Rows.Count)
                    row = 0;
            } while ((this[column, row].ReadOnly || !this[column, row].Visible) && this[column, row] != startingCell);

            if (this[column, row] == startingCell)
                return false;

            try
            {
                CurrentCell = this[column, row];
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            BeginEdit(true);
            return true;
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);

            var sortIconColor = ColumnHeadersDefaultCellStyle.ForeColor;
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                //Draw Background
                e.PaintBackground(e.CellBounds, false);

                //Draw Text Default
                //e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);

                //Draw Text Custom
                TextRenderer.DrawText(e.Graphics, string.Format("{0}", e.FormattedValue),
                    e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                //Draw Sort Icon
                if (SortedColumn?.Index == e.ColumnIndex)
                {
                    var sortIcon = SortOrder == SortOrder.Ascending ? "▲" : "▼";

                    //Or draw an icon here.
                    TextRenderer.DrawText(e.Graphics, sortIcon,
                        e.CellStyle.Font, e.CellBounds, sortIconColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                }

                //Prevent Default Paint
                e.Handled = true;
            }
        }

        private int GetVisibleColumnCount()
        {
            int count = -1;
            foreach (DataGridViewColumn column in Columns)
            {
                if (column.Visible)
                {
                    count++;
                }
            }

            return count;
        }
    }
}