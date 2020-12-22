using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XRest;
using XRest.Authentication;

namespace XRestDemo
{
    public partial class frmDemo : Form
    {
        HttpClient _httpClient = new HttpClient();

        public frmDemo()
        {
            InitializeComponent();
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            cboMethod.SelectedIndex = 0;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(txtBaseUrl.Text, _httpClient);
            string result = string.Empty;

            switch ((string)cboMethod.SelectedItem)
            {
                case "GET":
                    result = await client.Get(txtSubUri.Text);
                    txtResult.Text = result;
                    break;
                case "POST":
                    result = await client.Post(txtSubUri.Text, txtInput.Text);
                    txtResult.Text = result;
                    break;
                case "PUT":
                    result = await client.Put(txtSubUri.Text, txtInput.Text);
                    txtResult.Text = result;
                    break;
                case "DELETE":
                    result = await client.Delete(txtSubUri.Text);
                    txtResult.Text = result;
                    break;
                default:
                    txtResult.Text = $"(Invalid method selected - {cboMethod.SelectedItem}.)";
                    break;
            }
        }

        private void btnTokenTest_Click(object sender, EventArgs e)
        {
            OAuth2Options opts = new OAuth2Options
            {
                TokenUrl = new Uri(txtTokenUrl.Text),
                ClientId = txtClientId.Text,
                ClientSecret = txtClientSecret.Text,
                Resource = txtClientResource.Text
            };
            DefaultOAuth2Authenticator auth = new DefaultOAuth2Authenticator(opts);

            try
            {
                auth.RefreshToken().Wait();
                txtResult.Text = auth.Token.AccessToken;
            }
            catch (Exception exc)
            {
                txtResult.Text = $"ERROR: {exc.Message}";
            }
        }

    }
}

