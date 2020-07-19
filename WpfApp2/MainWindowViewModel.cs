using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2
{
    class MainWindowViewModel : BaseViewModel
    {
        string[] row = { "awdaw", "ss", "ssss" };
        public ObservableCollection<ListViewItem> listItems { get; set; } = new ObservableCollection<ListViewItem>();

        public MainWindowViewModel()
        {
            MyVoid();
        }

        private void MyVoid()
        {
            RoutedCommand aa = new RoutedCommand("awdad", typeof(MainWindow));

            for (var index = 0; index < row.Length; index++)
            {
                var bb = new Button() { Name = $"_{index}", Content = row[index] };
                bb.Click += Bb_Click;
                listItems.Add(new ListViewItem() { Content = bb });
            }
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {
            var ss = (Button)sender;
            var index = int.Parse(ss.Name.Substring(1));

            MessageBox.Show(row[index]);
        }
    }
}
