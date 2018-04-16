﻿/*
   Copyright (C) 2011 Tom Thorpe

   This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details. You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AirStreamPlayer
{
    /// <remarks>
    /// An about box for the application to show title, byline, link etc.
    /// </remarks>
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Launches default browser to go to www.tomthorpe.com
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bylink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.tomthorpe.com");
        }
    }
}