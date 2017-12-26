using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SudokuApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ComboBox[,,,] m_aaaaComboBox = new ComboBox[3, 3, 3, 3];
        public MainPage()
        {
            this.InitializeComponent();

            m_aaaaComboBox[0, 0, 0, 0] = this.ComboBox0000;
            m_aaaaComboBox[0, 0, 0, 1] = this.ComboBox0001;
            m_aaaaComboBox[0, 0, 0, 2] = this.ComboBox0002;
            m_aaaaComboBox[0, 0, 1, 0] = this.ComboBox0010;
            m_aaaaComboBox[0, 0, 1, 1] = this.ComboBox0011;
            m_aaaaComboBox[0, 0, 1, 2] = this.ComboBox0012;
            m_aaaaComboBox[0, 0, 2, 0] = this.ComboBox0020;
            m_aaaaComboBox[0, 0, 2, 1] = this.ComboBox0021;
            m_aaaaComboBox[0, 0, 2, 2] = this.ComboBox0022;
            m_aaaaComboBox[0, 1, 0, 0] = this.ComboBox0100;
            m_aaaaComboBox[0, 1, 0, 1] = this.ComboBox0101;
            m_aaaaComboBox[0, 1, 0, 2] = this.ComboBox0102;
            m_aaaaComboBox[0, 1, 1, 0] = this.ComboBox0110;
            m_aaaaComboBox[0, 1, 1, 1] = this.ComboBox0111;
            m_aaaaComboBox[0, 1, 1, 2] = this.ComboBox0112;
            m_aaaaComboBox[0, 1, 2, 0] = this.ComboBox0120;
            m_aaaaComboBox[0, 1, 2, 1] = this.ComboBox0121;
            m_aaaaComboBox[0, 1, 2, 2] = this.ComboBox0122;
            m_aaaaComboBox[0, 2, 0, 0] = this.ComboBox0200;
            m_aaaaComboBox[0, 2, 0, 1] = this.ComboBox0201;
            m_aaaaComboBox[0, 2, 0, 2] = this.ComboBox0202;
            m_aaaaComboBox[0, 2, 1, 0] = this.ComboBox0210;
            m_aaaaComboBox[0, 2, 1, 1] = this.ComboBox0211;
            m_aaaaComboBox[0, 2, 1, 2] = this.ComboBox0212;
            m_aaaaComboBox[0, 2, 2, 0] = this.ComboBox0220;
            m_aaaaComboBox[0, 2, 2, 1] = this.ComboBox0221;
            m_aaaaComboBox[0, 2, 2, 2] = this.ComboBox0222;
            m_aaaaComboBox[1, 0, 0, 0] = this.ComboBox1000;
            m_aaaaComboBox[1, 0, 0, 1] = this.ComboBox1001;
            m_aaaaComboBox[1, 0, 0, 2] = this.ComboBox1002;
            m_aaaaComboBox[1, 0, 1, 0] = this.ComboBox1010;
            m_aaaaComboBox[1, 0, 1, 1] = this.ComboBox1011;
            m_aaaaComboBox[1, 0, 1, 2] = this.ComboBox1012;
            m_aaaaComboBox[1, 0, 2, 0] = this.ComboBox1020;
            m_aaaaComboBox[1, 0, 2, 1] = this.ComboBox1021;
            m_aaaaComboBox[1, 0, 2, 2] = this.ComboBox1022;
            m_aaaaComboBox[1, 1, 0, 0] = this.ComboBox1100;
            m_aaaaComboBox[1, 1, 0, 1] = this.ComboBox1101;
            m_aaaaComboBox[1, 1, 0, 2] = this.ComboBox1102;
            m_aaaaComboBox[1, 1, 1, 0] = this.ComboBox1110;
            m_aaaaComboBox[1, 1, 1, 1] = this.ComboBox1111;
            m_aaaaComboBox[1, 1, 1, 2] = this.ComboBox1112;
            m_aaaaComboBox[1, 1, 2, 0] = this.ComboBox1120;
            m_aaaaComboBox[1, 1, 2, 1] = this.ComboBox1121;
            m_aaaaComboBox[1, 1, 2, 2] = this.ComboBox1122;
            m_aaaaComboBox[1, 2, 0, 0] = this.ComboBox1200;
            m_aaaaComboBox[1, 2, 0, 1] = this.ComboBox1201;
            m_aaaaComboBox[1, 2, 0, 2] = this.ComboBox1202;
            m_aaaaComboBox[1, 2, 1, 0] = this.ComboBox1210;
            m_aaaaComboBox[1, 2, 1, 1] = this.ComboBox1211;
            m_aaaaComboBox[1, 2, 1, 2] = this.ComboBox1212;
            m_aaaaComboBox[1, 2, 2, 0] = this.ComboBox1220;
            m_aaaaComboBox[1, 2, 2, 1] = this.ComboBox1221;
            m_aaaaComboBox[1, 2, 2, 2] = this.ComboBox1222;
            m_aaaaComboBox[2, 0, 0, 0] = this.ComboBox2000;
            m_aaaaComboBox[2, 0, 0, 1] = this.ComboBox2001;
            m_aaaaComboBox[2, 0, 0, 2] = this.ComboBox2002;
            m_aaaaComboBox[2, 0, 1, 0] = this.ComboBox2010;
            m_aaaaComboBox[2, 0, 1, 1] = this.ComboBox2011;
            m_aaaaComboBox[2, 0, 1, 2] = this.ComboBox2012;
            m_aaaaComboBox[2, 0, 2, 0] = this.ComboBox2020;
            m_aaaaComboBox[2, 0, 2, 1] = this.ComboBox2021;
            m_aaaaComboBox[2, 0, 2, 2] = this.ComboBox2022;
            m_aaaaComboBox[2, 1, 0, 0] = this.ComboBox2100;
            m_aaaaComboBox[2, 1, 0, 1] = this.ComboBox2101;
            m_aaaaComboBox[2, 1, 0, 2] = this.ComboBox2102;
            m_aaaaComboBox[2, 1, 1, 0] = this.ComboBox2110;
            m_aaaaComboBox[2, 1, 1, 1] = this.ComboBox2111;
            m_aaaaComboBox[2, 1, 1, 2] = this.ComboBox2112;
            m_aaaaComboBox[2, 1, 2, 0] = this.ComboBox2120;
            m_aaaaComboBox[2, 1, 2, 1] = this.ComboBox2121;
            m_aaaaComboBox[2, 1, 2, 2] = this.ComboBox2122;
            m_aaaaComboBox[2, 2, 0, 0] = this.ComboBox2200;
            m_aaaaComboBox[2, 2, 0, 1] = this.ComboBox2201;
            m_aaaaComboBox[2, 2, 0, 2] = this.ComboBox2202;
            m_aaaaComboBox[2, 2, 1, 0] = this.ComboBox2210;
            m_aaaaComboBox[2, 2, 1, 1] = this.ComboBox2211;
            m_aaaaComboBox[2, 2, 1, 2] = this.ComboBox2212;
            m_aaaaComboBox[2, 2, 2, 0] = this.ComboBox2220;
            m_aaaaComboBox[2, 2, 2, 1] = this.ComboBox2221;
            m_aaaaComboBox[2, 2, 2, 2] = this.ComboBox2222;

            this.DataContext = new Sudoku(this.m_aaaaComboBox);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (int nNum in e.AddedItems)
            {
                (this.DataContext as Sudoku).SetNumber((sender as ComboBox).Tag as SudokuCell, nNum);
            }
            (this.DataContext as Sudoku).Update();
        }
    }
}
