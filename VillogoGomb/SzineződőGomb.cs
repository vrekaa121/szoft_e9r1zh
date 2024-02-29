using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzineződőGomb : Button
    {
        public SzineződőGomb() 
        {
            Height = 20;
            Width = 20;
            Click += SzineződőGomb_Click;
        }

        private void SzineződőGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
