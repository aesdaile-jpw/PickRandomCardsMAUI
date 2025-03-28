using PickRandomCards;

namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsButton_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberOfCards.Text, out int numberOfCards))
            {
                if (numberOfCards > 52)
                {
                    DisplayAlert("Too many cards", "Sorry, please pick 10 cards or fewer", "OK");
                    return;
                }
                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                PickedCards.Text = String.Empty;
                foreach (string card in cards)
                {
                    PickedCards.Text += card + Environment.NewLine;

                }
                PickedCards.Text += Environment.NewLine + "You picked " + numberOfCards + " cards";
            }
            else
            {
                // PickedCards.Text = "Please enter a valid number";
                DisplayAlert("Invalid input", "Sorry, use a number from 1 to 52", "OK");
                return;
            }
        }

        private void NumberOfCards_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }

}
