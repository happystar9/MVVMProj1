using Microsoft.Maui.Controls.Shapes;
using MVVMProj.Models;
using MVVMProj.PageModels;

namespace MVVMProj.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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

                    if (row == 1)
                    {
                        Add_Chess_Piece("black_pawn.jpg", row, col);
                    }
                    else if (row == 6)
                    {
                        Add_Chess_Piece("white_pawn.jpg", row, col);
                    }
                    else if (row == 0)
                    {
                        Add_Chess_Piece(Get_Black_Piece(col), row, col);
                    }
                    else if (row == 7)
                    {
                        Add_Chess_Piece(Get_White_Piece(col), row, col);
                    }
                }
            }
        }

        private string Get_Black_Piece(int col)
        {
            return col switch
            {
                0 => "black_rook.jpg",
                1 => "black_horse.png",
                2 => "black_bishop.jpg",
                3 => "black_queen.jpg",
                4 => "black_king.jpg",
                5 => "black_bishop.jpg",
                6 => "black_horse.png",
                7 => "black_rook.jpg",
                _ => string.Empty,
            };
        }

        private string Get_White_Piece(int col)
        {
            return col switch
            {
                0 => "white_rook.jpg",
                1 => "white_horse.jpg",
                2 => "white_bishop.jpg",
                3 => "white_queen.png",
                4 => "white_king.jpg",
                5 => "white_bishop.jpg",
                6 => "white_horse.jpg",
                7 => "white_rook.jpg",
                _ => string.Empty,
            };
        }

        private void Add_Chess_Piece(string pieceImage, int row, int col)
        {
            if (string.IsNullOrEmpty(pieceImage)) return;

            var chessPiece = new Image
            {
                Source = pieceImage,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Grid.SetRow(chessPiece, row);
            Grid.SetColumn(chessPiece, col);
            chessGrid.Children.Add(chessPiece);
        }
    }
}