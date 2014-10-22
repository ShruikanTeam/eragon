namespace LoginChooseHero.GameForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (Validation.IsCorrectLogin(this.txtUserName.Text.ToString(), this.txtPassword.Text.ToString()).Length > 1)
            //{
            //    this.lblErrorMessage.Text = Validation.IsCorrectLogin(this.txtUserName.Text.ToString(), this.txtPassword.Text.ToString());
            //    return;
            //}

            //if (Files.ReadUsersFromFile(this.txtUserName.Text, this.txtPassword.Text) == false)
            //{
            //    this.lblErrorMessage.Text = "User name or Password are incorrect!";
            //}
            //else if (Files.ReadUsersFromFile(this.txtUserName.Text, this.txtPassword.Text))
            //{
            //    if (Files.HaveAHero(this.txtUserName.Text.Trim()))
            //    {
            //        BaseForm form = new BaseForm();
            //        form.Show();
            //    }
            //    else
            //    {
                    HeroChoice form = new HeroChoice(); 
            //(this.txtUserName.Text.ToString().Trim());
                    form.Show();
               // }


                this.Hide();

            }


        }

        //private void btnRegister_Click(object sender, EventArgs e)
        //{
        //    if (Files.ReadUsersFromFile(this.txtUserName.Text, this.txtPassword.Text))
        //    {
        //        this.lblErrorMessage.Text = "This user already exists";
        //    }
        //    else
        //    {
        //        this.lblErrorMessage.Text = Validation.IsCorrectLogin(this.txtUserName.Text.ToString(), this.txtPassword.Text.ToString());
        //        if (this.lblErrorMessage.Text.Trim() == "")
        //        {
        //            Files.CreateUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());
        //            this.lblErrorMessage.Text = "You have been registered! You may login !";
        //        }

        //    }

            //Registration registration = new Registration();
            //registration.Show();
            //this.Hide();
       // }
   // }
}
