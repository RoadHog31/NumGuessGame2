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

namespace NumGuessGame2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Public Variables to apply a range between 1 & 10 to a button click event.
        int _guess = 5;
        int _btnMysNum;
        int x = 1;
        int y = 10;          

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_MysNum_Click(object sender, RoutedEventArgs e)
        {
            //Generates a random number between 1 and 10.
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            _btnMysNum = random;

            if ( _btnMysNum.ToString() == _guess.ToString())

                {
                    lbl_Answer.Content =  "Congratulations, your guess of " + lbl_PlayerGuess.Content +  " was correct!";
                }
           
            else
                {
                    lbl_Answer.Content = "Your guess of " + lbl_PlayerGuess.Content +  " was incorrect. Please try again!";            
                }                  
        }

        private void btn_Lower_Click(object sender, RoutedEventArgs e)
        {           
            if ( _guess > x )

                {
                    //Decrease the counter from 5.
                    _guess = _guess-1;
                    lbl_PlayerGuess.Content = _guess.ToString();
                    Console.Beep();              
                }           
        }   

        private void btn_HideHelp_Click(object sender, RoutedEventArgs e)
        {
            btn_Ellipsis.Visibility = Visibility.Visible;
            numGuessGame.Width = 366;
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        private void btn_Ellipsis_Click(object sender, RoutedEventArgs e)
        {
            btn_Ellipsis.Visibility = Visibility.Hidden;
            numGuessGame.Width = 700;
            Console.Beep();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( _guess < y)
                
                {
                    //Decrease the counter from 5.
                    _guess = _guess + 1;
                    lbl_PlayerGuess.Content = _guess.ToString();
                    Console.Beep();
                }           
           }    
    }
}
