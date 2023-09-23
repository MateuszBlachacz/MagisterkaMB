
namespace MagisterkaMB
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.TestBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Controls.Add(this.lPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPath, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.016394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.9836F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lPath
            // 
            this.lPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(19, 9);
            this.lPath.Margin = new System.Windows.Forms.Padding(9, 9, 2, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(68, 13);
            this.lPath.TabIndex = 0;
            this.lPath.Text = "Wybierz Plik:";
            this.lPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Gothic Files (*.d)|*.d";
            this.openFileDialog1.InitialDirectory = "D:\\Gry\\GOG Galaxy\\Games\\Gothic 2 Gold\\_Work\\Data\\Scripts\\Content";
            // 
            // tbPath
            // 
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPath.Location = new System.Drawing.Point(91, 6);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(388, 20);
            this.tbPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(483, 6);
            this.btnPath.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(23, 19);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(92, 36);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(386, 182);
            this.TestBox.TabIndex = 3;
            this.TestBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gothic || - Noc Kruka Mod Helper (Praca Magisterska)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.RichTextBox TestBox;
    }
}

