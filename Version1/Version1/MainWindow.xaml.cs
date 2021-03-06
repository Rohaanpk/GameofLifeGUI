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
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Version1
{
    public partial class MainWindow : Window
    {

        // Grid Height and Width (Number of cells)
        public static int COLUMN = 20;
        public static int ROW = 20;

        // Setting Button array to fill Grid
        Button[,] btnArr = new Button[ROW, COLUMN];

        // Setting Grid size to size of Column * Row
        public static int[,] grid = new int[ROW, COLUMN];
        public static int[,] updateGrid = new int[ROW, COLUMN];

        public static int rowi;
        public static int columni;

        public MainWindow()
        {


            InitializeComponent();

            // For loop (and nested for loop) setting button array to fill grid
            for (int columni = 0; columni < COLUMN; columni++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                RowDefinition rowDef = new RowDefinition();

                for (int rowi = 0; rowi < ROW; rowi++)
                {
                    btnArr[columni, rowi] = new Button();
                    int y = Grid.GetRow(btnArr[columni, rowi]);
                    int x = Grid.GetColumn(btnArr[columni, rowi]);
                    btnArr[columni, rowi].Tag = 0;
                    btnArr[columni, rowi].Tag = btnArr[columni, rowi].Tag;

                    btnArr[columni, rowi].Background = Brushes.DimGray;
                    btnArr[columni, rowi].BorderBrush = Brushes.Black;
                    btnArr[columni, rowi].BorderThickness = new Thickness(1);

                    btnArr[columni, rowi].Margin = new Thickness(0.3);
                    btnArr[columni, rowi].Name = "Button" + rowi.ToString() + columni.ToString();

                    Grid.SetColumn(btnArr[columni, rowi], rowi + 1);
                    Grid.SetRow(btnArr[columni, rowi], columni + 1);
                    MainGrid.Children.Add(btnArr[columni, rowi]);

                    btnArr[columni, rowi].Click += btnClick;
                }
                colDef.Width = new GridLength(2, GridUnitType.Star);
                rowDef.Height = new GridLength(2, GridUnitType.Star);
                MainGrid.RowDefinitions.Add(rowDef);
                MainGrid.ColumnDefinitions.Add(colDef);
            }
            RowDefinition rowDef2 = new RowDefinition();
            rowDef2.Height = new GridLength(2, GridUnitType.Star);
            MainGrid.RowDefinitions.Add(rowDef2);
            ColumnDefinition colDef2 = new ColumnDefinition();
            colDef2.Width = new GridLength(2, GridUnitType.Star);
            MainGrid.ColumnDefinitions.Add(colDef2);
        }

        //Close app function
        private void closeWindow(object sender, RoutedEventArgs e)
        {
            string exitMessage = "Application is closing, please press OK.";
            string exitTitle = "Application Closing";
            MessageBox.Show(exitMessage, exitTitle);
            this.Close();
        }


        // Change button state function (0 = Dead and 1 = Alive)
        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int x = (int)btn.GetValue(Grid.RowProperty);
            int y = (int)btn.GetValue(Grid.ColumnProperty);
            if (grid[x - 1, y - 1] == 1)
            {
                btnArr[x - 1, y - 1].Background = Brushes.DimGray;
                btnArr[x - 1, y - 1].Tag = 0;



                grid[x - 1, y - 1] = 0;
                btnArr[x - 1, y - 1].Tag = grid[x - 1, y - 1];
            }
            else
            {
                btnArr[x - 1, y - 1].Background = Brushes.Violet;
                btnArr[x - 1, y - 1].Tag = 1;

                grid[x - 1, y - 1] = 1;
                btnArr[x - 1, y - 1].Tag = grid[x - 1, y - 1];
            }
        }

        // Single generation progress function
        public void generation(object sender, RoutedEventArgs e)
        {
            for (int ri = 0; ri < ROW; ri++)
            {
                for (int ci = 0; ci < COLUMN; ci++)
                {
                    updateGrid[ri, ci] = grid[ri, ci];
                }
            }

            GOLrules.check();

            GOLrules.Iteration();


            for (int i = 0; i < ROW; i++)
            {
                for (int c = 0; c < COLUMN; c++)
                {

                    btnArr[i, c].Tag = grid[i, c];
                    updateGrid[i, c] = grid[i, c];
                    if (Convert.ToInt32(btnArr[i, c].Tag) >= 1)
                    {
                        btnArr[i, c].Background = Brushes.Violet;
                    }
                    if (Convert.ToInt32(btnArr[i, c].Tag) == 0)
                    {
                        btnArr[i, c].Background = Brushes.DimGray;
                    }
                }
            }
        }

        // Reset grid function
        private void reset(object sender, RoutedEventArgs e)
        {
            for (columni = 0; columni < COLUMN; columni++)
            {
                for (rowi = 0; rowi < ROW; rowi++)
                {
                    btnArr[rowi, columni].Tag = 0;
                    btnArr[rowi, columni].Background = Brushes.DimGray;
                    updateGrid[rowi, columni] = 0;
                    grid[rowi, columni] = 0;
                }
            }
        }

        public static bool val = false;

        // Automatic generation progresser 
        private async void auto(object sender, RoutedEventArgs e)
        {

            val = !val;
            while (val)
            {
                autoGenerator.Background = Brushes.Orange;

                generation(this, e);




                await Task.Delay(200);

            }
            autoGenerator.Background = Brushes.LightGray;


        }
    }

    // Game of life Generation rules
    public class GOLrules
    {
        public GOLrules() { }

        // Check for Dead/Living cells (check surrounding cells/Game of Life Logic)
        public static void check()
        {
            for (int ri = 0; ri < MainWindow.ROW; ri++)
            {
                for (int ci = 0; ci < MainWindow.COLUMN; ci++)
                {
                    int i1 = -1;
                    int c1 = -1;
                    int i2 = 1;
                    int c2 = 1;
                    if (ri == 0)
                    {
                        i1 = 0;
                    }
                    if (ci == 0)
                    {
                        c1 = 0;
                    }
                    if (ri == MainWindow.ROW - 1)
                    {
                        i2 = 0;
                    }
                    if (ci == MainWindow.COLUMN - 1)
                    {
                        c2 = 0;
                    }
                    for (int i = i1; i <= i2; i++)
                    {
                        for (int c = c1; c <= c2; c++)
                        {
                            if (c == 0 && i == 0)
                            {
                                continue;
                            }

                            if (MainWindow.grid[ri + i, ci + c] >= 1)
                            {
                                MainWindow.updateGrid[ri, ci]++;

                            }
                        }
                    }
                }
            }

        }

        // Check Version Number
        public static void Iteration()
        {
            int previous;
            for (int ci = 0; ci < MainWindow.COLUMN; ci++)
            {
                for (int ri = 0; ri < MainWindow.ROW; ri++)
                {
                    previous = MainWindow.grid[ri, ci];
                    if (MainWindow.updateGrid[ri, ci] == 3)
                    {
                        MainWindow.grid[ri, ci] = 1;
                    }
                    else if (MainWindow.updateGrid[ri, ci] == 4 && previous >= 1)
                    {
                        MainWindow.grid[ri, ci] = 1;
                    }
                    else
                    {
                        MainWindow.grid[ri, ci] = 0;
                    }
                }
            }
        }

        // Print/Update Grid function
        public static void PrintGrid(int[,] array)
        {
            for (int ci = 0; ci < MainWindow.COLUMN; ci++)
            {
                for (int ri = 0; ri < MainWindow.ROW; ri++)
                {
                    Console.Write(array[ri, ci]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
