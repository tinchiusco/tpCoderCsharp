namespace EjercicioDiccionario
{
    partial class Menu
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
            lstMenu = new ListBox();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 15;
            lstMenu.Location = new Point(125, 103);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(1077, 409);
            lstMenu.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 602);
            Controls.Add(lstMenu);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMenu;
    }
}
