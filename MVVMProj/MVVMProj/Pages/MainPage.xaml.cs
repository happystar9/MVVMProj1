using Microsoft.Maui.Controls.Shapes;
using MVVMProj.Models;
using MVVMProj.PageModels;

namespace MVVMProj.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            GenerateChessBoard();
        }

        private void GenerateChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                chessGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
                chessGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50) });
            }

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var isBlack = (row + col) % 2 == 0;
                    var boxView = new BoxView
                    {
                        Color = isBlack ? Colors.Black : Colors.White
                    };

                    Grid.SetRow(boxView, row);
                    Grid.SetColumn(boxView, col);

                    chessGrid.Children.Add(boxView);
                }
            }
        }
        
    }
}