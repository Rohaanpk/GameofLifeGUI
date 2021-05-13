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
using System.Windows.Interop;
using System.Diagnostics;

namespace Version5
{
    public partial class MainWindow : Window
    {
        // Grid Height and Width (Number of cells)
        public int column = 20;
        public int row = 20;

        // Setting Living Cells & Generation number to 0, will be increased/decreased as values increase/decrease
        public int LIVING = 0;
        public int GENERATION = 0;

        // Setting Button array to fill Grid
        Button[,] btnArr;

        // Setting Grid size to size of Column * Row
        public int[,] grid;
        public int[,] updateGrid;

        public int rowi;
        public int columni;

        // Sets directory to look for .csv files (importing)
        public string curDir = Directory.GetCurrentDirectory();

        // Window Creator
        public MainWindow(int row, int column)
        { 
            this.row = row;
            this.column = column;

            this.btnArr = new Button[row, column];

            this.grid = new int[row, column];
            this.updateGrid = new int[row, column];

            InitializeComponent();
            Generations.Content = $"Generation: {GENERATION}";
            AliveCells.Content = $"Alive: {LIVING}";

            // For loop (and nested for loop) setting button array to fill grid
            for (int columni = 0; columni < column; columni++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                RowDefinition rowDef = new RowDefinition();

                for (int rowi = 0; rowi < row; rowi++)
                {
                    btnArr[columni, rowi] = new Button();
                    int y = Grid.GetRow(btnArr[columni, rowi]);
                    int x = Grid.GetColumn(btnArr[columni, rowi]);
                    btnArr[columni, rowi].Tag = 0;
                    btnArr[columni, rowi].Tag = btnArr[columni, rowi].Tag;

                    btnArr[columni, rowi].Background = Brushes.Silver;
                    btnArr[columni, rowi].BorderBrush = Brushes.Black;
                    btnArr[columni, rowi].BorderThickness = new Thickness(0);

                    btnArr[columni, rowi].Margin = new Thickness(0.3);
                    btnArr[columni, rowi].Name = "Button" + rowi.ToString() + columni.ToString();

                    Grid.SetColumn(btnArr[columni, rowi], rowi + 1);
                    Grid.SetRow(btnArr[columni, rowi], columni + 1);
                    MainGrid.Children.Add(btnArr[columni, rowi]);

                    btnArr[columni, rowi].Click += BTNClick;

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
        
        // Single generation progress function
        public void Generation(object sender, RoutedEventArgs e)
        {
            reset.Content = "Reset";


            if (GENERATION == 0)
            {
                var curDir = Directory.GetCurrentDirectory();
                File.WriteAllLines($"{curDir}/data.csv",
                    ToCsv(grid));
            }


            for (int ri = 0; ri < row; ri++)
            {
                for (int ci = 0; ci < column; ci++)
                {
                    updateGrid[ri, ci] = grid[ri, ci];
                }
            }

            GOLrules.check(this);

            GOLrules.Iteration(this);
            CheckIf(grid);


            if (LIVING != 0)
            {
                this.generator.IsEnabled = true;
                this.autoGenerator.IsEnabled = true;
            }
            else
            {
                this.generator.IsEnabled = false;
                this.autoGenerator.IsEnabled = false;
                this.autoGenerator.Content = "Start";
                val = false;
            }

            GENERATION++;
            Generations.Content = $"Generation: {GENERATION}";




            for (int i = 0; i < row; i++)
            {
                for (int c = 0; c < column; c++)
                {
                    btnArr[i, c].Tag = grid[i, c];
                    //btnArr[i, c].Tag = btnArr[i, c].Tag;
                    updateGrid[i, c] = grid[i, c];
                    if (Convert.ToInt32(btnArr[i, c].Tag) >= 1)
                    {
                        btnArr[i, c].Background = Brushes.Violet;
                    }
                    if (Convert.ToInt32(btnArr[i, c].Tag) == 0)
                    {
                        btnArr[i, c].Background = Brushes.Silver;
                    }
                }
            }
        }

        // Automatic generation progresser
        private async void Autogenerate(object sender, RoutedEventArgs e)
        {

            val = !val;


            if (GENERATION == 0)
            {
                var curDir = Directory.GetCurrentDirectory();
                File.WriteAllLines($"{curDir}/data.csv",
                    ToCsv(grid));
            }



            while (val)
            {
                reset.Content = "Reset";

                autoGenerator.Background = Brushes.Orange;
                autoGenerator.Content = "Stop";

                Generation(this, e);


                int Delay = Convert.ToInt32(SpeedSlider.Value);


                await Task.Delay(Delay);



            }
            autoGenerator.Background = Brushes.Silver;
            autoGenerator.Content = "Start";


        }

        // Reset grid function
        private void Reset(object sender, RoutedEventArgs e)
        {
            for (columni = 0; columni < column; columni++)
            {
                for (rowi = 0; rowi < row; rowi++)
                {
                    btnArr[rowi, columni].Tag = 0;
                    btnArr[rowi, columni].Background = Brushes.Silver;
                    updateGrid[rowi, columni] = 0;
                    grid[rowi, columni] = 0;
                }
            }

            if (GENERATION > 0)
            {
                //CheckIf(grid);
                GENERATION = 0;
                Loader(this, e, $"{curDir}/data.csv");
                reset.Content = "Clear";
                //Generations.Content = $"Generation: {GENERATION}";
            }
            CheckIf(grid);
            Generations.Content = $"Generation: {GENERATION}";

            if (LIVING != 0)
            {
                this.generator.IsEnabled = true;
                this.autoGenerator.IsEnabled = true;
            }
            else
            {
                this.generator.IsEnabled = false;
                this.autoGenerator.IsEnabled = false;
                this.autoGenerator.Content = "Start";
                val = false;
            }
        }

        
        // Save grid Layout function
        private void Savegrid(object sender, RoutedEventArgs e)
        {
            string message = "Grid Saving (Grid is saved to the current directory of the .exe)";
            string title = "Saving...";
            MessageBox.Show(message, title);
            var curDir = Directory.GetCurrentDirectory();
            File.WriteAllLines($"{curDir}/data.csv",
                ToCsv(grid));

        }

        // Borrowed from stack overflow function (writes to csv)
        public static IEnumerable<String> ToCsv<T>(T[,] data, string separator = ",")
        {
            for (int i = 0; i < data.GetLength(0); ++i)
                yield return string.Join(separator, Enumerable
                  .Range(0, data.GetLength(1))
                  .Select(j => data[i, j]));
        }

        // Forgot what it does but code breaks without it function (I think it converts either to, or from an array)
        public static T[,] To2D<T>(T[][] source)
        {
            try
            {
                int FirstDim = source.Length;
                int SecondDim = source.GroupBy(row => row.Length).Single().Key; // throws InvalidOperationException if source is not rectangular

                var result = new T[FirstDim, SecondDim];
                for (int i = 0; i < FirstDim; ++i)
                    for (int j = 0; j < SecondDim; ++j)
                        result[i, j] = source[i][j];

                return result;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("The given jagged array is not rectangular.");
            }
        }

        //Randomise Grid Function
        public void Randomise(object sender, RoutedEventArgs e)
        {
            Reset(this, e);
            Random rnd = new Random();

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    int RANDOM = rnd.Next(2);

                    if (RANDOM == 1)
                    {
                        if (grid[x , y] == 1)
                        {
                            btnArr[x, y].Background = Brushes.Silver;
                            btnArr[x, y].Tag = 0;
                        }
                        else
                        {
                            btnArr[x, y].Background = Brushes.Violet;
                            btnArr[x, y].Tag = 1;

                            grid[x, y] = 1;
                            btnArr[x, y].Tag = grid[x , y];
                        }
                    }

                }
            }
            GOLrules.check(this);

            GOLrules.Iteration(this);
            CheckIf(grid);

            if (LIVING != 0)
            {
                this.generator.IsEnabled = true;
                this.autoGenerator.IsEnabled = true;
            }
            else
            {
                this.generator.IsEnabled = false;
                this.autoGenerator.IsEnabled = false;
                val = false;
            }
        }

        //Show rules Function
        private void Showrules(object sender, RoutedEventArgs e) 
        {
            Rules nW = new Rules();
            nW.Show();
        }

        //Change GridSize Function
        private void GridSize_Click(object sender, RoutedEventArgs e)
        {
            Griddef sW = new Griddef();
            sW.Show();
            this.Close();
        }

        //Close app function
        private void Close(object sender, RoutedEventArgs e)
        {
            string exitMessage = "Application is closing, please press OK.";
            string exitTitle = "Application Closing";
            MessageBox.Show(exitMessage, exitTitle);
            this.Close();
        }

        // CSV Loader function
        public void Loader(object sender, RoutedEventArgs e, string filePath)
        {
            var curDir = Directory.GetCurrentDirectory();
            //var filePath = $"{curDir}/data.csv";
            string[][] temp = File.ReadLines(filePath)
                          .Select(line => line.Split(','))
                          .ToArray();
            var temp1 = To2D(temp);
            int[,] second = new int[temp1.GetLength(0), temp1.GetLength(1)];

            for (int j = 0; j < temp1.GetLength(0); j++)
            {
                for (int i = 0; i < temp1.GetLength(1); i++)
                {
                    int number;
                    bool ok = int.TryParse(temp1[j, i], out number);
                    if (ok)
                    {
                        second[j, i] = number;
                    }
                    else
                    {
                        second[j, i] = 0;
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int c = 0; c < column; c++)
                {
                    grid[i, c] = second[i, c];
                    btnArr[i, c].Tag = grid[i, c];

                    if (Convert.ToInt32(btnArr[i, c].Tag) >= 1)
                    {
                        btnArr[i, c].Background = Brushes.Violet;
                    }
                }
            }
            GOLrules.check(this);
            CheckIf(grid);
        }

        // Change button state function (0 = Dead and 1 = Alive)
        private void BTNClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int x = (int)btn.GetValue(Grid.RowProperty);
            int y = (int)btn.GetValue(Grid.ColumnProperty);
            if (grid[x - 1, y - 1] == 1)
            {
                btnArr[x - 1, y - 1].Background = Brushes.Silver;
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
            CheckIf(grid);

            if (LIVING != 0)
            {
                this.generator.IsEnabled = true;
                this.autoGenerator.IsEnabled = true;
            }
            else
            {
                this.generator.IsEnabled = false;
                this.autoGenerator.IsEnabled = false;
                val = false;
            }
        }

        // Check number of living cells function
        public void CheckIf(int[,] array)
        {
            LIVING = 0;
            for (int i = 0; i < row; i++)
            {
                for (int c = 0; c < column; c++)
                {
                    if (array[i, c] == 1)
                    {
                        LIVING++;

                    }
                    AliveCells.Content = $"Alive: {LIVING}";

                }
            }
        }

        public static bool val = false;

    }

    // Game of life Grid rules
    public class GOLrules
        {
            public GOLrules() { }

            // Check for Dead/Living cells (check surrounding cells/Game of Life Logic)
            public static void check(MainWindow mainWindow)
            {
                for (int ri = 0; ri < mainWindow.row; ri++)
                {
                    for (int ci = 0; ci < mainWindow.column; ci++)
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
                        if (ri == mainWindow.row - 1)
                        {
                            i2 = 0;
                        }
                        if (ci == mainWindow.column - 1)
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

                                if (mainWindow.grid[ri + i, ci + c] >= 1)
                                {
                                    mainWindow.updateGrid[ri, ci]++;

                                }
                            }
                        }
                    }
                }

            }

            // Check Version Number
            public static void Iteration(MainWindow mainWindow)
            {
                int previous;
                for (int ci = 0; ci < mainWindow.column; ci++)
                {
                    for (int ri = 0; ri < mainWindow.row; ri++)
                    {
                        previous = mainWindow.grid[ri, ci];
                        if (mainWindow.updateGrid[ri, ci] == 3)
                        {
                            mainWindow.grid[ri, ci] = 1;
                        }
                        else if (mainWindow.updateGrid[ri, ci] == 4 && previous >= 1)
                        {
                            mainWindow.grid[ri, ci] = 1;
                        }
                        else
                        {
                            mainWindow.grid[ri, ci] = 0;
                        }
                    }
                }
            }

            // Print/Update Grid function
            public static void PrintGrid(int[,] array, MainWindow mainWindow)
            {
                for (int ci = 0; ci < mainWindow.column; ci++)
                {
                    for (int ri = 0; ri < mainWindow.row; ri++)
                    {
                        Console.Write(array[ri, ci]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
    }
}