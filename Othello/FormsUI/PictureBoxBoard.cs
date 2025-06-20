﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public class PictureBoxBoard : PictureBox
    {
        private int m_RowIndex;
        private int m_ColIndex;

        public int Col
        {
            get { return m_ColIndex; }
            set { m_ColIndex = value; }
        }
        public int Row
        {
            get { return m_RowIndex; }
            set { m_RowIndex = value; }
        }
    }
}
