using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SudokuSolverMask
{
    public partial class Eingabemaske : Form
    {
        public static int[,] sudoku = new int[9, 9];
        System.Windows.Forms.TextBox[,] Brett=new System.Windows.Forms.TextBox[9,9];
        Tree myTree;

        public void enter(int i, int j)
        {
            //Brett = new System.Windows.Forms.TextBox[9, 9];
            Brett[i, j] = new System.Windows.Forms.TextBox();
            Brett[i, j].Left = 50 + i * 21;
            Brett[i, j].Top = 30 + j * 21;
            Brett[i, j].Width = 20;


            Brett[i, j].Leave += delegate { try { sudoku[i, j] = System.Int32.Parse(Brett[i, j].Text); } catch { }; };


            Brett[i, j].Show();
            this.Controls.Add(Brett[i, j]);

        }
        public Eingabemaske()
        {
            
            InitializeComponent();
        }
    }
}