using System;

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
            
        }
        #endregion

    }
}
