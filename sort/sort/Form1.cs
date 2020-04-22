using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort
{
    public partial class Form1 : Form
    {
        List<ListItem> elements;
        List<FormListItem> form_elements;
        bool is_sorted;

        public Form1()
        {
            InitializeComponent();

            init_form();
        }

        private void init_elements()
        {
            elements = new List<ListItem>();
            elements.Add(new ListItem(Properties.Resources._1, "Антон"));
            elements.Add(new ListItem(Properties.Resources._2, "Настя"));
            elements.Add(new ListItem(Properties.Resources._3, "Настя"));
            elements.Add(new ListItem(Properties.Resources._4, "Маша"));
            elements.Add(new ListItem(Properties.Resources._5, "Денис"));
            elements.Add(new ListItem(Properties.Resources._6, "Саша"));
            elements.Add(new ListItem(Properties.Resources._7, "Ден"));
            elements.Add(new ListItem(Properties.Resources._8, "Леша"));
            elements.Add(new ListItem(Properties.Resources._9, "Саша"));
            elements.Add(new ListItem(Properties.Resources._10, "Даня"));
        }

        private void init_form_elements()
        {
            form_elements = new List<FormListItem>();
            form_elements.Add(new FormListItem(pbArray1, tbArray1));
            form_elements.Add(new FormListItem(pbArray2, tbArray2));
            form_elements.Add(new FormListItem(pbArray3, tbArray3));
            form_elements.Add(new FormListItem(pbArray4, tbArray4));
            form_elements.Add(new FormListItem(pbArray5, tbArray5));
            form_elements.Add(new FormListItem(pbArray6, tbArray6));
            form_elements.Add(new FormListItem(pbArray7, tbArray7));
            form_elements.Add(new FormListItem(pbArray8, tbArray8));
            form_elements.Add(new FormListItem(pbArray9, tbArray9));
            form_elements.Add(new FormListItem(pbArray10, tbArray10));
        }

        private void show_elements()
        {
            for(int i = 0; i < form_elements.Count; i++)
            {
                form_elements[i].Pb.Image = elements[i].Image;
                form_elements[i].Tb.Text = elements[i].Name;
                form_elements[i].Pb.SizeMode = PictureBoxSizeMode.Zoom;
                form_elements[i].Tb.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void init_form()
        {
            
        }

        private List<int> get_indexies()
        {
            List<int> indexies = new List<int>();
            for(int i = 0; i < elements.Count; i++)
            {
                indexies.Add(i);
            }
            return indexies;
        }

        private void mixed_elements()
        {
            List<int> free_indexies = get_indexies();
            Random rnd = new Random();
            for (int i = 0; i < form_elements.Count; i++)
            {
                int elem_index = rnd.Next(0, free_indexies.Count);
                form_elements[i].Pb.Image = elements[free_indexies[elem_index]].Image;
                form_elements[i].Tb.Text = elements[free_indexies[elem_index]].Name;
                form_elements[i].Pb.SizeMode = PictureBoxSizeMode.Zoom;
                form_elements[i].Tb.TextAlign = HorizontalAlignment.Center;
                free_indexies.RemoveAt(elem_index);
            }
            is_sorted = false;
            btnBinSearch.Enabled = false;
        }

        private void sort_elements()
        {
            
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            mixed_elements();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBinSearch_Click(object sender, EventArgs e)
        {
            if (is_sorted)
            {

            }
        }
    }
}
