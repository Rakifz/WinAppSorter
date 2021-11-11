using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorter.Models;
using Sorter.Algorithm;

namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arr=GetArr();
            QuickSort(arr);
            BubbleSort(arr);
            MergeSort(arr);
            GCFSort(arr);
        }

        private List<int> GetArr()
        {
            var stringList = textBox1.Text.Split(',');
            List<int> arr = new List<int>();
            foreach (var item in stringList)
            {
                var num = Int32.Parse(item);
                arr.Add(num);
            }
            return arr;
        }
        private void MergeSort(List<int> arr)
        {
            MergeSort merge = new MergeSort();
            dataGridView3.Rows.Clear();
            Stopwatch timer = Stopwatch.StartNew();
            var sorted = merge.MergeSortBegin(arr.ToArray());
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            dataGridView3.ColumnCount = 1;
            dataGridView3.Columns[0].Name = "sorted";
            foreach (var item in sorted)
            {
                string[] items = { item.ToString() };
                dataGridView3.Rows.Add(items);

            }
            label3.Text = (timespan).ToString() + "ms";
        

    }
        private void BubbleSort(List<int> arr) {
            BubbleSort bubble = new BubbleSort();
            dataGridView2.Rows.Clear();
            Stopwatch timer = Stopwatch.StartNew();
            var sorted=bubble.BubbleSortbegin(arr.ToArray());
            timer.Stop();

            TimeSpan timespan = timer.Elapsed;
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = "sorted";
            foreach (var item in sorted)
            {
                string[] items = { item.ToString() };
                dataGridView2.Rows.Add(items);

            }
            label2.Text = (timespan).ToString() + "ms";
        }

        private void QuickSort(List<int> arr)
        {
            QuickSort quickSort = new QuickSort();
            dataGridView1.Rows.Clear();
          
            SortedQuickSort sort = new SortedQuickSort();
            Stopwatch timer = Stopwatch.StartNew();
            sort.sorted = quickSort.QuickSortbegin(arr.ToArray()).ToList();
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            //var binding =new BindingList<SortedQuickSort>()
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "sorted";
            foreach (var item in sort.sorted)
            {
                string[] items = { item.ToString() };
                dataGridView1.Rows.Add(items);

            }
            label1.Text = (timespan).ToString() + "ms";
        }
        private void GCFSort(List<int> arr)
        {
            GCFSort bubble = new GCFSort();
            dataGridView4.Rows.Clear();
            var defaultComparator = 20;
            var comparator = string.IsNullOrEmpty(textBox2.Text)? defaultComparator: Int32.Parse(textBox2.Text);

            Stopwatch timer = Stopwatch.StartNew();
            var sorted = bubble.GCFSortBegin(arr.ToArray(),comparator);
            timer.Stop();

            TimeSpan timespan = timer.Elapsed;
            dataGridView4.ColumnCount = 1;
            dataGridView4.Columns[0].Name = "sorted";
            foreach (var item in sorted)
            {
                string[] items = { item.ToString() };
                dataGridView4.Rows.Add(items);

            }
            label4.Text = (timespan).ToString() + "ms";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
