using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Näyttöpaja
{
    public partial class Main : Form
    {
        List<TextBox> signupTextBoxes = new List<TextBox>();
        bool loggedIn = false;
        string loggedinUser = "";
        public Main()
        {
            InitializeComponent();
            etusivuPanel.BringToFront();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createPanel.BringToFront();  //tuo tunnuksen luonti paneelin eteen
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            etusivuPanel.BringToFront(); //tuo etusivu paneelin eteen
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text.ToLower();
            if (name == "niklas vuorio" && PassBox.Text == "testi123")
            {
                loggedIn = true;
                string[] names = NameBox.Text.Split(' ');
                loggedinUser = names[0];
                WelcomeText.Text = "Tervetuloa " + loggedinUser;
                welcomePanel.BringToFront();
            }
            else if (NameBox.Text == "" || PassBox.Text == "") //tarkistaa ettei kirjautumis kentät ole tyhjiä jos ovat niin kertoo siitä käyttäjälle
            {
                MessageBox.Show("Sinun pitää syöttää salasana ja nimesi", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Kertoo käyttäjälle jos salasana tai nimi on väärin
            {
                MessageBox.Show("Väärä nimi tai salasana", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
        }

        private void signupReadyButton_Click(object sender, EventArgs e)
        {
            if(!InputErrorChecks())
            {
                MessageBox.Show("Tunnusten luonti onnistui voit kirjautua nyt sisään", "Tunnukset luotu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var today = DateTime.Today;
                var age = today.Year - signupDatePicker.Value.Year;

                if (signupDatePicker.Value.Date > today.AddYears(-age)) age--;

                string firstname3letters = signupNameBox.Text.Substring(0, 3);
                string lastname5letters = signupLastnameBox.Text.Substring(0, 5);

                //Laita tunnusten luonti tiedot talteen
                string sUsername = firstname3letters + lastname5letters;
                string sFirstName = signupNameBox.Text;
                string sLastName = signupLastnameBox.Text;
                string sPassword = signupPasswordBox.Text;
                string sEmail = signupEmailBox.Text;
                int sAge = age;
                string sTenttiAika;

                if (signupTentti1.Checked) sTenttiAika = signupTentti1.Text;
                else if (signupTentti2.Checked) sTenttiAika = signupTentti2.Text;
                else sTenttiAika = signupTentti3.Text;

                List<string> sCourses = new List<string>();

                for(int i = 0; i < signupCourseSelection.CheckedItems.Count; i++)
                {
                    sCourses.Add(signupCourseSelection.CheckedItems[i].ToString());
                }

                string sLanguage = signupLanguageCombo.Text;

                etusivuPanel.BringToFront();
            }
        }

        private bool InputErrorChecks() //Tarkistaa virheitä tunnusten luomisessa
        {
            foreach(TextBox i in signupTextBoxes) //Tarkistaa ettei ole tyhjiä teksti kenttiä
            {
                TextBox tekstiBoxi = i as TextBox;
                if(tekstiBoxi.Text == string.Empty)
                {
                    MessageBox.Show("Sinun on vastattava jokaiseen kenttään", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            if(signupPasswordBox.Text != signupRepeatPassBox.Text)
            {
                MessageBox.Show("Salasanat eivät ole samoja", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            //Tarkistaa että nimissä ei ole muuta kuin aakkosia
            if (!System.Text.RegularExpressions.Regex.IsMatch(signupNameBox.Text, "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(signupLastnameBox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Nimessä voi olla vain kirjaimia", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if(!IsEmailValid())
            {
                MessageBox.Show("Sähköposti on virheellinen", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if(!AgeCheck())
            {
                MessageBox.Show("Sinun pitää olla täyttänyt ainakin 16 luodaksesi tunnukset", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if(signupCourseSelection.CheckedItems.Count == 0)
            {
                MessageBox.Show("Sinun on valittava ainakin yksi kurssi", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if(signupLanguageCombo.Text == string.Empty)
            {
                MessageBox.Show("Sinun pitää valita ohjelmointikieli", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private bool AgeCheck()
        {
            var today = DateTime.Today;

            var age = today.Year - signupDatePicker.Value.Year;

            if (signupDatePicker.Value.Date > today.AddYears(-age)) age--;

            if (age >= 16) return true;
            else return false;
        }
        private bool IsEmailValid() //Tarkistaa onko sähköposti oikeassa muodossa
        {
            var trimmedEmail = signupEmailBox.Text.Trim();

            if(trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                MailAddress m = new MailAddress(signupEmailBox.Text);

                return m.Address == trimmedEmail;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            signupTextBoxes.Add(signupNameBox);
            signupTextBoxes.Add(signupLastnameBox);
            signupTextBoxes.Add(signupRepeatPassBox);
            signupTextBoxes.Add(signupPasswordBox);
            signupTextBoxes.Add(signupEmailBox);
        }

        private void sendPalaute_Click(object sender, EventArgs e)
        {
            if(PalauteBox.Text == string.Empty)
            {
                MessageBox.Show("Palaute kenttä on tyhjä", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
