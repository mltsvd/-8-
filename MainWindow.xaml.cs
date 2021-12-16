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

namespace Практическая_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        Chisla chislo = new Chisla();
        Chisla chislo1 = new Chisla();
        private void Compare1_Click(object sender, RoutedEventArgs e)
        {
            
            if (chislo.val.CompareTo(chislo1.val) == 1) MessageBox.Show("Первое число больше");
            if (chislo.val.CompareTo(chislo1.val) == -1) MessageBox.Show("Второе число больше");
            if (chislo.val.CompareTo(chislo1.val) == 0) MessageBox.Show("Числа равны");
        }

        private void Clone_Click(object sender, RoutedEventArgs e)
        {
            
            Chisla x1 = chislo.ShallowClone();
            Chisla x2 = (Chisla)chislo.Clone();
        }

        private void Oprogramme_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №8\n Выполнил студент группы ИСП-31 Лейбович Михаил\nСоздать интерфейс – серия чисел (см. лекцию). Создать класс – простые числа. Класс должен включать конструктор.Сравнение производить по текущему значению.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Заполнить_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int kol = Convert.ToInt32(Kol.Text);
            for (int i = 0; i < kol; i++)
            {
                int val = rnd.Next(2, 100);
                listBox.Items.Add(chislo.GetNext(val,kol));
            }
            
        }

        private void Добавить1_Click(object sender, RoutedEventArgs e)
        {
            first.Text = listBox.SelectedItem.ToString();
            chislo.val = Convert.ToInt32(first.Text);
        }

        private void Добавить2_Click(object sender, RoutedEventArgs e)
        {
            Second.Text = listBox.SelectedItem.ToString();
            chislo1.val = Convert.ToInt32(Second.Text);
        }
    }
}
