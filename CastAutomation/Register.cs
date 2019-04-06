﻿using CastAutomation.MODEL.ORM.Context;
using CastAutomation.MODEL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastAutomation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        public void TextBoxEraser()
        {

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in groupBox5.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
           

      private void BtnRegister_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.FirstName = TxtFirstNameRegister.Text;
            appUser.LastName = TxtLastNameRegister.Text;
            appUser.DateOfBirth = DateTimeDateOfBirthRegister.Value;
            appUser.job = TxtJopRegister.Text;
            appUser.Size = TxtSizeRegister.Text;
            appUser.Weight = TxtWeightRegister.Text;
            appUser.Biography = TxtBiography.Text;
            appUser.MobilPhone = MtextBoxMobilPhoneRegister.Text;
            appUser.HomePhone = MtextBoxHomePhoneRegister.Text;
            appUser.jobPhone = MTextBoxjopPhoneRegister.Text;
            appUser.Address = TxtBoxAddressRegister.Text;
            appUser.Email = TxtEmailRegister.Text;
            appUser.Facebook = TxtFacebookRegister.Text;
            appUser.Twitter = TxtTwitterRegister.Text;
            appUser.instagram = TxtinstagramRegister.Text;
            appUser.Website = TxtWebSitesiRegister.Text;
            db.appUsers.Add(appUser);
            db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti");
            TextBoxEraser();
            
        }
    }
}
