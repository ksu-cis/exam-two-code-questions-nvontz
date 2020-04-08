using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            PeachButton.Click += FruitChange;
            CherryButton.Click += FruitChange;
            BlueBerryButton.Click += FruitChange;
        }

        private void FruitChange(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler cobbler)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Peach":
                            cobbler.Fruit = FruitFilling.Peach;
                            break;
                        case "Cherry":
                            cobbler.Fruit = FruitFilling.Cherry;
                            break;
                        case "Blueberry":
                            cobbler.Fruit = FruitFilling.Blueberry;
                            break;
                    }
                }
            }
        }
    }
}
