using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Exer02_ListView_LargeIcon
{
    public partial class Form1 : Form
    {

        private List<string> acteurs = new List<string>();
        public Form1()
        {
            InitializeComponent();


            ChargerListeActeurs();


            AfficherListeActeurs();


        }

        #region ChargerListeActeurs (À COMPLÉTER...)
        //=====================================================================================
        /// <summary>
        /// TODO 01 : Charge la liste des acteurs à partir du fichier "Acteurs.txt".
        /// Utiliser un point d'arrêt afin de vérifier le fonctionnement du chargement
        /// </summary>
        private void ChargerListeActeurs()
        {
            
            if (!File.Exists("acteurs.txt"))
            {
                MessageBox.Show("noooooooooooooon");

            }
            using (StreamReader fichier = new StreamReader("acteurs.txt"))
            {
                while (fichier.EndOfStream)
                {
                    string ligne = fichier.ReadLine();
                    acteurs.Add(ligne);
                }
            }
        }
        #endregion

        #region AfficherListeActeurs (À COMPLÉTER...)
        //=====================================================================================
        /// <summary>
        /// TODO 02 :Crée une ImageList dynamiquement qui contiendra les photos des acteurs (voir dossier Images)
        /// Affiche chaque acteur de la liste dans une ListeView utilisant l'option LargeIcon pour la propriété View. 
        /// Assigne à la propriété LargeImageList de la ListeView l'ImageList contenant les photos des acteurs.
        /// </summary>
        private void AfficherListeActeurs()
        {
            lsvActeurs.View = View.LargeIcon;

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(120, 120); 
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            foreach (string acteur in acteurs)
            {
                imageList.Images.Add("text", Image.FromFile($"./Images/Aaron Eckhart.jpg"));

            }
            lsvActeurs.LargeImageList = imageList;

            for (int i = 0; i < 5; i++)
            {
                ListViewItem personne = new ListViewItem("asdasd", "grande planet");

                lsvActeurs.Items.Add(personne);
            }
                
            
        }
        #endregion

        private void lsvActeurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
