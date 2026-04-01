namespace Exer02_ListView_LargeIcon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvActeurs = new ListView();
            SuspendLayout();
            // 
            // lsvActeurs
            // 
            lsvActeurs.Location = new Point(-2, 0);
            lsvActeurs.Margin = new Padding(3, 2, 3, 2);
            lsvActeurs.Name = "lsvActeurs";
            lsvActeurs.Size = new Size(703, 342);
            lsvActeurs.TabIndex = 0;
            lsvActeurs.UseCompatibleStateImageBehavior = false;
            lsvActeurs.SelectedIndexChanged += lsvActeurs_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lsvActeurs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvActeurs;
    }
}
