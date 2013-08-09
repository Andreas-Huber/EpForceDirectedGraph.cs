﻿/*! 
@file GridLine.cs
@author Woong Gyu La a.k.a Chris. <juhgiyo@gmail.com>
		<http://github.com/juhgiyo/epForceDirectedGraph.cs>
@date August 08, 2013
@brief GridLine Interface
@version 1.0

@section LICENSE

Copyright (C) 2013  Woong Gyu La <juhgiyo@gmail.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

@section DESCRIPTION

An Interface for the GridLine Class.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EpForceDirectedGraph
{
    class GridLine
    {
        public int fromX, fromY, toX, toY;
        public Pen pen;
        
        public GridLine(int iFromX, int iFromY, int iToX,int iToY)
        {
            this.fromX = iFromX + 9;
            this.fromY = iFromY + 9;
            this.toX = iToX + 9;
            this.toY = iToY + 9;
            pen = new Pen(Color.Yellow);
            pen.Width = 2;
            
            
        }

        public void DrawLine(Graphics iPaper)
        {
            iPaper.DrawLine(pen, fromX, fromY, toX, toY);
            
        }


        public void Dispose()
        {
            if (this.pen != null)
                this.pen.Dispose();

        }
    }
}
