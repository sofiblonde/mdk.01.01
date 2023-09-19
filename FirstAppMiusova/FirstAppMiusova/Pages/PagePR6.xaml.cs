using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace FirstAppMiusova.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR6.xaml
    /// </summary>
    public partial class PagePR6 : Page
    {
        public PagePR6()
        {
            InitializeComponent();
        }

        private void BtnListFromFilePR6_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                LstInputPR6.Items.Add(sr.ReadLine());
            }
        }

        private void BtnResultPR6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = LstInputPR6.SelectedIndex;
                string str = (string)LstInputPR6.Items[index];
                int len = str.Length;
                int count = 0;
                int i = 0;
                string[] str1 = str.Split();
                for  (i = 0; i < str1.Length; i++)
                {
                    char Letter = char.ToLower(str1[i][0]);
                    str1[i] = Letter + str1[i].Substring(1);
                }

                string line = LstInputPR6.SelectedItem.ToString();
                string[] reverseLine = line.Split();
                TxbRezult.Text = string.Join(", ", reverseLine);

                TxbRezult.Text = string.Join(" ", str1);
                StreamWriter sw = new StreamWriter(@"Result.txt");
                sw.WriteLine($"Номер строки: {index}");
                sw.WriteLine($"Исходная строка: {index}");
                sw.WriteLine($"Новая строка: {TxbRezult.Text}");
                sw.Close();
            }

            catch (Exception ex) 
            { 
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnClearPR6_Click(object sender, RoutedEventArgs e)
        {
            LstInputPR6.Items.Clear();  
        }

        private void BtnBackPR6_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }

        private void BtnNextPR6_Click(object sender, RoutedEventArgs e)
        {
            //Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR6());
        }
    }
}
