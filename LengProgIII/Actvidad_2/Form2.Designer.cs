namespace Actvidad_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            saludoToolStripMenuItem = new ToolStripMenuItem();
            datosPersonalesToolStripMenuItem = new ToolStripMenuItem();
            operacionesBàsicasToolStripMenuItem = new ToolStripMenuItem();
            saludoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, saludoToolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saludoToolStripMenuItem, datosPersonalesToolStripMenuItem, operacionesBàsicasToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            resources.ApplyResources(opcionesToolStripMenuItem, "opcionesToolStripMenuItem");
            // 
            // saludoToolStripMenuItem
            // 
            saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            resources.ApplyResources(saludoToolStripMenuItem, "saludoToolStripMenuItem");
            saludoToolStripMenuItem.Click += saludoToolStripMenuItem_Click;
            // 
            // datosPersonalesToolStripMenuItem
            // 
            datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            resources.ApplyResources(datosPersonalesToolStripMenuItem, "datosPersonalesToolStripMenuItem");
            datosPersonalesToolStripMenuItem.Click += datosPersonalesToolStripMenuItem_Click;
            // 
            // operacionesBàsicasToolStripMenuItem
            // 
            operacionesBàsicasToolStripMenuItem.Name = "operacionesBàsicasToolStripMenuItem";
            resources.ApplyResources(operacionesBàsicasToolStripMenuItem, "operacionesBàsicasToolStripMenuItem");
            operacionesBàsicasToolStripMenuItem.Click += operacionesBàsicasToolStripMenuItem_Click;
            // 
            // saludoToolStripMenuItem1
            // 
            saludoToolStripMenuItem1.Name = "saludoToolStripMenuItem1";
            resources.ApplyResources(saludoToolStripMenuItem1, "saludoToolStripMenuItem1");
            saludoToolStripMenuItem1.Click += saludoToolStripMenuItem1_Click;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem saludoToolStripMenuItem;
        private ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private ToolStripMenuItem operacionesBàsicasToolStripMenuItem;
        private ToolStripMenuItem saludoToolStripMenuItem1;
    }
}