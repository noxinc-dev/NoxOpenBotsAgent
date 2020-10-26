﻿using System.Windows;

namespace OpenBots.Agent.Client
{
    /// <summary>
    /// Interaction logic for ErrorDialog.xaml
    /// </summary>
    public partial class ErrorDialog : Window
    {
        public ErrorDialog(string generalError, string statusCode, string detailedErrorMessage)
        {
            InitializeComponent();
            txtBlock_GeneralErrorMsg.Text = generalError;
            lbl_StatusCodeValue.Content = statusCode;
            txtBlock_ErrorMessage.Text = detailedErrorMessage;
        }

        private void OnClick_OKBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Label_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {

        }
    }
}
