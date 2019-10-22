using ServiceDLL.Concrete;
using ServiceDLL.Interfaces;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        public LoginForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = new LoginModel
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            try
            {
                //var token = _accountService.Login(loginModel);
                string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiYm9tYmFAZ21haWwuY29tIiwicm9sZXMiOiJBZG1pbiIsImV4cCI6MTU3MTczMTIzOH0.fBYWsK4Hd5_QtGRLDEbMYXogAnDQo4quHYEk0q8lIco";
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = handler.ReadToken(token) as JwtSecurityToken;
                foreach (var item in tokenS.Claims)
                {
                    MessageBox.Show("---", item.Value);
                } 
                //Debug.WriteLine("token {0}", token);
                MessageBox.Show(token);
                //foreach (var item in jsonToken.c)
                //{

                //}
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd();
                            MessageBox.Show(error);
                            //TODO: use JSON.net to parse this string and look at the error message
                        }
                    }
                }
                MessageBox.Show("Гюстон у нас проблеми");
            }
        }
    }
}
