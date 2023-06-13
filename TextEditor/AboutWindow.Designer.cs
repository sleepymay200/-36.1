using System.Reflection.Metadata;

namespace CustomTextEditor
{
    public partial class AboutWindow
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
            asamblyProd = new Label();
            desc = new Label();
            SuspendLayout();
            // 
            // asamblyProd
            // 
            asamblyProd.AutoSize = true;
            asamblyProd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            asamblyProd.Location = new Point(21, 20);
            asamblyProd.Name = "asamblyProd";
            asamblyProd.Size = new Size(60, 22);
            asamblyProd.TabIndex = 0;
            asamblyProd.Text = "Автор";
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            desc.Location = new Point(21, 62);
            desc.Name = "desc";
            desc.Size = new Size(90, 22);
            desc.TabIndex = 1;
            desc.Text = "Описание";
            // 
            // AboutWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(desc);
            Controls.Add(asamblyProd);
            Name = "AboutWindow";
            Text = "AboutWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label asamblyProd;
        private Label desc;
    }
}