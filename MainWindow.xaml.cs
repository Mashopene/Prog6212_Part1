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

namespace CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for submitting a claim
        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement claim submission logic
            MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event handler for approving a claim
        private void ApproveClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement claim approval logic
            MessageBox.Show("Claim approved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event handler for rejecting a claim
        private void RejectClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement claim rejection logic
            MessageBox.Show("Claim rejected!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event handler for selecting a file
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement file selection logic
            MessageBox.Show("File selected!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}