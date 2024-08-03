using FordBellmanClient.ServiceFordBellman;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.ServiceModel;

namespace FordBellmanClient
{
    public partial class MainWindow : Window, IService1Callback
    {
        Service1Client client;
        public MainWindow()
        {
            InitializeComponent();
            Panel_result.Visibility = Visibility.Hidden;
            client = new Service1Client(new InstanceContext(this));
            RichTextBox_edges.Document.Blocks.Clear();
        }
        string ConvertRichTextBoxContentsToString(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart,
                rtb.Document.ContentEnd);
            return textRange.Text;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int VerticesCount = Convert.ToInt32(TextBox_verticesCount.Text);
            int EdgesCount = Convert.ToInt32(TextBox_EdgesCount.Text);
            int source = Convert.ToInt32(TextBox_source.Text) - 1;
            string rtb = ConvertRichTextBoxContentsToString(RichTextBox_edges);
            
            Panel_result.Visibility = Visibility.Visible;
            client.BellmanFord(VerticesCount, EdgesCount, source, rtb);
           
        }

        private void RichTextBox_edges_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void sendAnswer(string answer)
        {
            TextBlock_result.Text = answer;
        }
    }
}
