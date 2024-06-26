﻿namespace DoomsdayLogs.WindowsForms.Shared
{
    public static class DataGridViewExtensions
    {
        public static void ConfigGridChekered(this DataGridView grid)
        {
            Font font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightGray,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                SelectionBackColor = Color.LightGray,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }

        public static void ConfigGridOnlyRead(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;

            grid.RowsAdded += (sender, e) =>
            {
                grid.ClearSelection();
            };

            grid.RowsRemoved += (sender, e) =>
            {
                grid.ClearSelection();
            };
        }

        public static object SelectTheValueObject(this DataGridView grid)
        {
            const int firstLine = 0, firstColumn = 0;
            if (grid.SelectedRows.Count == 0)
                return null;

            object value = grid.SelectedRows[firstLine].Cells[firstColumn].Value;

            return value;
        }
    }
}
