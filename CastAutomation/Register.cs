﻿using CastAutomation.MODEL.ORM.Context;
using CastAutomation.MODEL.ORM.Entity;
using CastAutomation.MODEL.ORM.Enum;
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
 

    
        private void Register_Load(object sender, EventArgs e)
        {
            CmbBoxPleaceOfBirthRegister.DataSource = Enum.GetValues(typeof(MODEL.ORM.Enum.City));
            CmbxEyeColorRegister.DataSource = Enum.GetValues(typeof(EyeColor));
            CmboxHairColurRegister.DataSource = Enum.GetValues(typeof(HairColour));


            TxtBiography.MaxLength = 260;


        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtFirstNameRegister.Text == "" || TxtLastNameRegister.Text == "" || TxtJopRegister.Text == ""
              || TxtSizeRegister.Text == "" || TxtWeightRegister.Text == "" || TxtBiography.Text == ""
              || MtextBoxMobilPhoneRegister.Text == "" || MtextBoxHomePhoneRegister.Text == ""
              || TxtBoxAddressRegister.Text == "" || TxtEmailRegister.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }

            else
            {
                AppUser appUser = new AppUser();
                appUser.FirstName = TxtFirstNameRegister.Text;
                appUser.LastName = TxtLastNameRegister.Text;
                appUser.DateOfBirth = DateTimeDateOfBirthRegister.Value;

                if (radioButtonErkek.Checked)
                {
                    appUser.Gender = radioButtonErkek.Text;
                }

                else if (radioButtonKadin.Checked)
                {
                    appUser.Gender = radioButtonKadin.Text;
                }



                appUser.City = (City)Enum.Parse(typeof(City), CmbBoxPleaceOfBirthRegister.Text);


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






            private void BtnCleanRegister_Click(object sender, EventArgs e)
        {
            DialogResult DeleteWarning = new DialogResult();
            DeleteWarning = MessageBox.Show("Do you agree to delete all content?", "!WARNİNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

           

            if (DeleteWarning == DialogResult.Yes)
            {
                TextBoxEraser();
            }

        }

        private void TxtBiography_TextChanged(object sender, EventArgs e)
        {
            int u = TxtBiography.TextLength;
            LblKarakterSayisi.Text = "Karakter Sayısı: " + TxtBiography.TextLength.ToString();

            if (u == 260)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!");
            }
        }
    }
    }







