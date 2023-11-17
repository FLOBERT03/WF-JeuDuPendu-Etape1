namespace WF_JeuDuPendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rempli le combo avec les lettres de l'alphabet
        /// </summary>
        private void RemplirCboLettres()
        {
            // vide le combo
            cboLettre.Items.Clear();
            // remplir le combo avec les lettres de l'alphabet
            for (int l = 0; l < 26; l++)
            {
                cboLettre.Items.Add((char)('A' + l));
            }
            cboLettre.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Remplir le combo avec les lettres
            RemplirCboLettres();
        }
    }
}