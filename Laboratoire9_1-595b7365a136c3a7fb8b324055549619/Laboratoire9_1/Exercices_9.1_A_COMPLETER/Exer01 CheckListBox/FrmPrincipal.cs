using System;
using System.Windows.Forms;

namespace Exemple_CheckListBox
{
    
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        //----------------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 01 : Ajouter 10 légumes dans votre CheckListBox

            
        }
        private void BtnCocherTout_Click(object sender, EventArgs e)
        {
            // TODO 02 : Cocher tous les items

            AfficherLeNombreDItemsCochés();
        }
        //------------------------------------------------------------------------------------------
        private void BtnDécocherTout_Click(object sender, EventArgs e)
        {
            // TODO 03 : Décocher tous les items

            AfficherLeNombreDItemsCochés();
        }
        //------------------------------------------------------------------------------------------
        private void BtnCocherIndexPair_Click(object sender, EventArgs e)
        {
            // TODO 04 : Cocher uniquement les items ayant un index pair


            AfficherLeNombreDItemsCochés();
        }

        //------------------------------------------------------------------------------------------
        private void AfficherLeNombreDItemsCochés()
        {
            // TODO 05 : Afficher dans txtValeur le nombre d'items cochés dans le CheckListBox 


        }

        //------------------------------------------------------------------------------------------
  
        
        private void ClbFruitsEtLegumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherLeNombreDItemsCochés();
        }



        //------------------------------------------------------------------------------------------
        /// <summary>
        ///  TODO 06 : Construire une chaine de caractères contenant le texte des items cochés. Un item par ligne.
        /// </summary>
        /// <returns>Retourne une liste des items cochés sous la forme d'une chaine séparée par des
        /// caratères de fin de ligne</returns>
        private string ListeDesItemsCochés()
        {
            string listeDesItemsCochés = string.Empty;

            // À COMPLÉTER...

            return listeDesItemsCochés;
        }
        //------------------------------------------------------------------------------------------
        private void BtnVisualiserItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListeDesItemsCochés());
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            // TODO 07 : Supprimer les items cochés en utilisant la propriété CheckedItems
            
            AfficherLeNombreDItemsCochés();
        }
        //------------------------------------------------------------------------------------------

    }
}