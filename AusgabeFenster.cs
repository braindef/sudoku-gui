using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolverMask
{
    class AusgabeFenster : System.Windows.Forms.Form
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
            int x0 = 55;
            int y0 = 30;
			System.Drawing.Graphics g = e.Graphics;
            //g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Blue), 0, 0, 100, 100);
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Blue), x0, y0 + i * 20, x0+177, 30 + i * 20);
                if (i % 3 == 0) g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Blue), x0, y0-1 + i * 20, x0 + 177, 29 + i * 20);
                if(i<9) 
                    for (int j = 0; j < 9; j++)
                    {
                        String myString = Tree.solution[i, j].ToString();
                        g.DrawString(myString, new System.Drawing.Font("Arial Bold", 13), new System.Drawing.SolidBrush(System.Drawing.Color.Red), x0+5 + i * 20, y0 + j * 20, new System.Drawing.StringFormat(System.Drawing.StringFormat.GenericTypographic));
                    }
            }
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Blue), x0+20*i, y0, x0+20*i, 30 + 9 * 20);
                if (i % 3 == 0) g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Blue), x0 - 1 + 20 * i, y0, x0 - 1 + 20 * i, 210);
            }

		}

        public void init()
        {
            this.Show();
        }
    }
}
