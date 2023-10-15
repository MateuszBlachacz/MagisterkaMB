
namespace MagisterkaMB
{
    partial class Armor
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
            this.ITconstBox = new System.Windows.Forms.ComboBox();
            this.ITconstLabel = new System.Windows.Forms.Label();
            this.ITvalueConst = new System.Windows.Forms.TextBox();
            this.ITvalueConstLabel = new System.Windows.Forms.Label();
            this.lTArmorLabel = new System.Windows.Forms.Label();
            this.ITArmorBox = new System.Windows.Forms.ComboBox();
            this.ITnameLabel = new System.Windows.Forms.Label();
            this.ITname = new System.Windows.Forms.TextBox();
            this.ITmainflagLabel = new System.Windows.Forms.Label();
            this.ITmainflagBox = new System.Windows.Forms.ComboBox();
            this.ITflagBox = new System.Windows.Forms.ComboBox();
            this.ITflagsLabel = new System.Windows.Forms.Label();
            this.ITProtectionLabel = new System.Windows.Forms.Label();
            this.ITswordLabel = new System.Windows.Forms.Label();
            this.ITsword = new System.Windows.Forms.TextBox();
            this.ITpoint = new System.Windows.Forms.TextBox();
            this.ITpointLabel = new System.Windows.Forms.Label();
            this.ITfire = new System.Windows.Forms.TextBox();
            this.ITfireLabel = new System.Windows.Forms.Label();
            this.ITmagic = new System.Windows.Forms.TextBox();
            this.ITmagicLabel = new System.Windows.Forms.Label();
            this.ITvalueLabel = new System.Windows.Forms.Label();
            this.ITvalue = new System.Windows.Forms.TextBox();
            this.ITvisualChangeLabel = new System.Windows.Forms.Label();
            this.ITvisualLabelds = new System.Windows.Forms.Label();
            this.ITvisualLabel = new System.Windows.Forms.Label();
            this.ITvisualChangeBox = new System.Windows.Forms.ComboBox();
            this.ITvisualBox = new System.Windows.Forms.ComboBox();
            this.ITmaterialBox = new System.Windows.Forms.ComboBox();
            this.ITmaterialLabel = new System.Windows.Forms.Label();
            this.ITsaveButton = new System.Windows.Forms.Button();
            this.ITCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ITconstBox
            // 
            this.ITconstBox.FormattingEnabled = true;
            this.ITconstBox.Location = new System.Drawing.Point(184, 37);
            this.ITconstBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITconstBox.Name = "ITconstBox";
            this.ITconstBox.Size = new System.Drawing.Size(367, 24);
            this.ITconstBox.TabIndex = 0;
            this.ITconstBox.SelectedIndexChanged += new System.EventHandler(this.ITconstBox_SelectedIndexChanged);
            // 
            // ITconstLabel
            // 
            this.ITconstLabel.AutoSize = true;
            this.ITconstLabel.Location = new System.Drawing.Point(39, 40);
            this.ITconstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITconstLabel.Name = "ITconstLabel";
            this.ITconstLabel.Size = new System.Drawing.Size(56, 17);
            this.ITconstLabel.TabIndex = 1;
            this.ITconstLabel.Text = "STAŁE:";
            // 
            // ITvalueConst
            // 
            this.ITvalueConst.Location = new System.Drawing.Point(693, 39);
            this.ITvalueConst.Name = "ITvalueConst";
            this.ITvalueConst.Size = new System.Drawing.Size(164, 22);
            this.ITvalueConst.TabIndex = 2;
            this.ITvalueConst.TextChanged += new System.EventHandler(this.ITvalueConst_TextChanged);
            // 
            // ITvalueConstLabel
            // 
            this.ITvalueConstLabel.AutoSize = true;
            this.ITvalueConstLabel.Location = new System.Drawing.Point(579, 40);
            this.ITvalueConstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvalueConstLabel.Name = "ITvalueConstLabel";
            this.ITvalueConstLabel.Size = new System.Drawing.Size(82, 17);
            this.ITvalueConstLabel.TabIndex = 3;
            this.ITvalueConstLabel.Text = "WARTOŚĆ:";
            // 
            // lTArmorLabel
            // 
            this.lTArmorLabel.AutoSize = true;
            this.lTArmorLabel.Location = new System.Drawing.Point(39, 106);
            this.lTArmorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTArmorLabel.Name = "lTArmorLabel";
            this.lTArmorLabel.Size = new System.Drawing.Size(67, 17);
            this.lTArmorLabel.TabIndex = 4;
            this.lTArmorLabel.Text = "ZBROJE:";
            // 
            // ITArmorBox
            // 
            this.ITArmorBox.FormattingEnabled = true;
            this.ITArmorBox.Location = new System.Drawing.Point(184, 103);
            this.ITArmorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITArmorBox.Name = "ITArmorBox";
            this.ITArmorBox.Size = new System.Drawing.Size(367, 24);
            this.ITArmorBox.TabIndex = 5;
            this.ITArmorBox.SelectedIndexChanged += new System.EventHandler(this.ITArmorBox_SelectedIndexChanged);
            // 
            // ITnameLabel
            // 
            this.ITnameLabel.AutoSize = true;
            this.ITnameLabel.Location = new System.Drawing.Point(39, 181);
            this.ITnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITnameLabel.Name = "ITnameLabel";
            this.ITnameLabel.Size = new System.Drawing.Size(54, 17);
            this.ITnameLabel.TabIndex = 6;
            this.ITnameLabel.Text = "Nazwa:";
            // 
            // ITname
            // 
            this.ITname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ITname.Location = new System.Drawing.Point(114, 181);
            this.ITname.Name = "ITname";
            this.ITname.Size = new System.Drawing.Size(182, 22);
            this.ITname.TabIndex = 7;
            this.ITname.Text = "Święta ąęćżź";
            // 
            // ITmainflagLabel
            // 
            this.ITmainflagLabel.AutoSize = true;
            this.ITmainflagLabel.Location = new System.Drawing.Point(12, 218);
            this.ITmainflagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITmainflagLabel.Name = "ITmainflagLabel";
            this.ITmainflagLabel.Size = new System.Drawing.Size(94, 17);
            this.ITmainflagLabel.TabIndex = 8;
            this.ITmainflagLabel.Text = "GłównaFlaga:";
            // 
            // ITmainflagBox
            // 
            this.ITmainflagBox.FormattingEnabled = true;
            this.ITmainflagBox.Location = new System.Drawing.Point(114, 215);
            this.ITmainflagBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITmainflagBox.Name = "ITmainflagBox";
            this.ITmainflagBox.Size = new System.Drawing.Size(182, 24);
            this.ITmainflagBox.TabIndex = 9;
            // 
            // ITflagBox
            // 
            this.ITflagBox.FormattingEnabled = true;
            this.ITflagBox.Location = new System.Drawing.Point(114, 247);
            this.ITflagBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITflagBox.Name = "ITflagBox";
            this.ITflagBox.Size = new System.Drawing.Size(182, 24);
            this.ITflagBox.TabIndex = 11;
            // 
            // ITflagsLabel
            // 
            this.ITflagsLabel.AutoSize = true;
            this.ITflagsLabel.Location = new System.Drawing.Point(39, 247);
            this.ITflagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITflagsLabel.Name = "ITflagsLabel";
            this.ITflagsLabel.Size = new System.Drawing.Size(47, 17);
            this.ITflagsLabel.TabIndex = 10;
            this.ITflagsLabel.Text = "Flaga:";
            // 
            // ITProtectionLabel
            // 
            this.ITProtectionLabel.AutoSize = true;
            this.ITProtectionLabel.Location = new System.Drawing.Point(159, 275);
            this.ITProtectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITProtectionLabel.Name = "ITProtectionLabel";
            this.ITProtectionLabel.Size = new System.Drawing.Size(67, 17);
            this.ITProtectionLabel.TabIndex = 12;
            this.ITProtectionLabel.Text = "Ochrona:";
            // 
            // ITswordLabel
            // 
            this.ITswordLabel.AutoSize = true;
            this.ITswordLabel.Location = new System.Drawing.Point(28, 301);
            this.ITswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITswordLabel.Name = "ITswordLabel";
            this.ITswordLabel.Size = new System.Drawing.Size(53, 17);
            this.ITswordLabel.TabIndex = 13;
            this.ITswordLabel.Text = "Bronią:";
            // 
            // ITsword
            // 
            this.ITsword.Location = new System.Drawing.Point(151, 301);
            this.ITsword.Name = "ITsword";
            this.ITsword.Size = new System.Drawing.Size(75, 22);
            this.ITsword.TabIndex = 14;
            // 
            // ITpoint
            // 
            this.ITpoint.Location = new System.Drawing.Point(151, 331);
            this.ITpoint.Name = "ITpoint";
            this.ITpoint.Size = new System.Drawing.Size(75, 22);
            this.ITpoint.TabIndex = 16;
            // 
            // ITpointLabel
            // 
            this.ITpointLabel.AutoSize = true;
            this.ITpointLabel.Location = new System.Drawing.Point(28, 331);
            this.ITpointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITpointLabel.Name = "ITpointLabel";
            this.ITpointLabel.Size = new System.Drawing.Size(75, 17);
            this.ITpointLabel.TabIndex = 15;
            this.ITpointLabel.Text = "Pociskami:";
            // 
            // ITfire
            // 
            this.ITfire.Location = new System.Drawing.Point(151, 364);
            this.ITfire.Name = "ITfire";
            this.ITfire.Size = new System.Drawing.Size(75, 22);
            this.ITfire.TabIndex = 18;
            // 
            // ITfireLabel
            // 
            this.ITfireLabel.AutoSize = true;
            this.ITfireLabel.Location = new System.Drawing.Point(28, 364);
            this.ITfireLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITfireLabel.Name = "ITfireLabel";
            this.ITfireLabel.Size = new System.Drawing.Size(61, 17);
            this.ITfireLabel.TabIndex = 17;
            this.ITfireLabel.Text = "Ogniem:";
            // 
            // ITmagic
            // 
            this.ITmagic.Location = new System.Drawing.Point(151, 395);
            this.ITmagic.Name = "ITmagic";
            this.ITmagic.Size = new System.Drawing.Size(75, 22);
            this.ITmagic.TabIndex = 20;
            // 
            // ITmagicLabel
            // 
            this.ITmagicLabel.AutoSize = true;
            this.ITmagicLabel.Location = new System.Drawing.Point(28, 395);
            this.ITmagicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITmagicLabel.Name = "ITmagicLabel";
            this.ITmagicLabel.Size = new System.Drawing.Size(50, 17);
            this.ITmagicLabel.TabIndex = 19;
            this.ITmagicLabel.Text = "Magią:";
            // 
            // ITvalueLabel
            // 
            this.ITvalueLabel.AutoSize = true;
            this.ITvalueLabel.Location = new System.Drawing.Point(352, 186);
            this.ITvalueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvalueLabel.Name = "ITvalueLabel";
            this.ITvalueLabel.Size = new System.Drawing.Size(45, 17);
            this.ITvalueLabel.TabIndex = 21;
            this.ITvalueLabel.Text = "Cena:";
            // 
            // ITvalue
            // 
            this.ITvalue.Location = new System.Drawing.Point(414, 186);
            this.ITvalue.Name = "ITvalue";
            this.ITvalue.Size = new System.Drawing.Size(92, 22);
            this.ITvalue.TabIndex = 22;
            // 
            // ITvisualChangeLabel
            // 
            this.ITvisualChangeLabel.AutoSize = true;
            this.ITvisualChangeLabel.Location = new System.Drawing.Point(265, 331);
            this.ITvisualChangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvisualChangeLabel.Name = "ITvisualChangeLabel";
            this.ITvisualChangeLabel.Size = new System.Drawing.Size(56, 17);
            this.ITvisualChangeLabel.TabIndex = 26;
            this.ITvisualChangeLabel.Text = "asc file:";
            // 
            // ITvisualLabelds
            // 
            this.ITvisualLabelds.AutoSize = true;
            this.ITvisualLabelds.Location = new System.Drawing.Point(265, 301);
            this.ITvisualLabelds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvisualLabelds.Name = "ITvisualLabelds";
            this.ITvisualLabelds.Size = new System.Drawing.Size(57, 17);
            this.ITvisualLabelds.TabIndex = 24;
            this.ITvisualLabelds.Text = "3ds file:";
            // 
            // ITvisualLabel
            // 
            this.ITvisualLabel.AutoSize = true;
            this.ITvisualLabel.Location = new System.Drawing.Point(463, 275);
            this.ITvisualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvisualLabel.Name = "ITvisualLabel";
            this.ITvisualLabel.Size = new System.Drawing.Size(59, 17);
            this.ITvisualLabel.TabIndex = 23;
            this.ITvisualLabel.Text = "Wygląd:";
            // 
            // ITvisualChangeBox
            // 
            this.ITvisualChangeBox.FormattingEnabled = true;
            this.ITvisualChangeBox.Location = new System.Drawing.Point(399, 333);
            this.ITvisualChangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITvisualChangeBox.Name = "ITvisualChangeBox";
            this.ITvisualChangeBox.Size = new System.Drawing.Size(182, 24);
            this.ITvisualChangeBox.TabIndex = 28;
            // 
            // ITvisualBox
            // 
            this.ITvisualBox.FormattingEnabled = true;
            this.ITvisualBox.Location = new System.Drawing.Point(399, 301);
            this.ITvisualBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITvisualBox.Name = "ITvisualBox";
            this.ITvisualBox.Size = new System.Drawing.Size(182, 24);
            this.ITvisualBox.TabIndex = 27;
            // 
            // ITmaterialBox
            // 
            this.ITmaterialBox.FormattingEnabled = true;
            this.ITmaterialBox.Location = new System.Drawing.Point(399, 365);
            this.ITmaterialBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITmaterialBox.Name = "ITmaterialBox";
            this.ITmaterialBox.Size = new System.Drawing.Size(182, 24);
            this.ITmaterialBox.TabIndex = 30;
            // 
            // ITmaterialLabel
            // 
            this.ITmaterialLabel.AutoSize = true;
            this.ITmaterialLabel.Location = new System.Drawing.Point(265, 363);
            this.ITmaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITmaterialLabel.Name = "ITmaterialLabel";
            this.ITmaterialLabel.Size = new System.Drawing.Size(62, 17);
            this.ITmaterialLabel.TabIndex = 29;
            this.ITmaterialLabel.Text = "Materiał:";
            // 
            // ITsaveButton
            // 
            this.ITsaveButton.Location = new System.Drawing.Point(784, 488);
            this.ITsaveButton.Name = "ITsaveButton";
            this.ITsaveButton.Size = new System.Drawing.Size(86, 33);
            this.ITsaveButton.TabIndex = 31;
            this.ITsaveButton.Text = "Zapisz";
            this.ITsaveButton.UseVisualStyleBackColor = true;
            this.ITsaveButton.Click += new System.EventHandler(this.ITsaveButton_Click);
            // 
            // ITCancelButton
            // 
            this.ITCancelButton.Location = new System.Drawing.Point(910, 488);
            this.ITCancelButton.Name = "ITCancelButton";
            this.ITCancelButton.Size = new System.Drawing.Size(86, 33);
            this.ITCancelButton.TabIndex = 32;
            this.ITCancelButton.Text = "Anuluj";
            this.ITCancelButton.UseVisualStyleBackColor = true;
            this.ITCancelButton.Click += new System.EventHandler(this.ITCancelButton_Click);
            // 
            // Armor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ITCancelButton);
            this.Controls.Add(this.ITsaveButton);
            this.Controls.Add(this.ITmaterialBox);
            this.Controls.Add(this.ITmaterialLabel);
            this.Controls.Add(this.ITvisualChangeBox);
            this.Controls.Add(this.ITvisualBox);
            this.Controls.Add(this.ITvisualChangeLabel);
            this.Controls.Add(this.ITvisualLabelds);
            this.Controls.Add(this.ITvisualLabel);
            this.Controls.Add(this.ITvalue);
            this.Controls.Add(this.ITvalueLabel);
            this.Controls.Add(this.ITmagic);
            this.Controls.Add(this.ITmagicLabel);
            this.Controls.Add(this.ITfire);
            this.Controls.Add(this.ITfireLabel);
            this.Controls.Add(this.ITpoint);
            this.Controls.Add(this.ITpointLabel);
            this.Controls.Add(this.ITsword);
            this.Controls.Add(this.ITswordLabel);
            this.Controls.Add(this.ITProtectionLabel);
            this.Controls.Add(this.ITflagBox);
            this.Controls.Add(this.ITflagsLabel);
            this.Controls.Add(this.ITmainflagBox);
            this.Controls.Add(this.ITmainflagLabel);
            this.Controls.Add(this.ITname);
            this.Controls.Add(this.ITnameLabel);
            this.Controls.Add(this.ITArmorBox);
            this.Controls.Add(this.lTArmorLabel);
            this.Controls.Add(this.ITvalueConstLabel);
            this.Controls.Add(this.ITvalueConst);
            this.Controls.Add(this.ITconstLabel);
            this.Controls.Add(this.ITconstBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Armor";
            this.Text = "Wartość";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ITconstBox;
        private System.Windows.Forms.Label ITconstLabel;
        private System.Windows.Forms.TextBox ITvalueConst;
        private System.Windows.Forms.Label ITvalueConstLabel;
        private System.Windows.Forms.Label lTArmorLabel;
        private System.Windows.Forms.ComboBox ITArmorBox;
        private System.Windows.Forms.Label ITnameLabel;
        private System.Windows.Forms.TextBox ITname;
        private System.Windows.Forms.Label ITmainflagLabel;
        private System.Windows.Forms.ComboBox ITmainflagBox;
        private System.Windows.Forms.ComboBox ITflagBox;
        private System.Windows.Forms.Label ITflagsLabel;
        private System.Windows.Forms.Label ITProtectionLabel;
        private System.Windows.Forms.Label ITswordLabel;
        private System.Windows.Forms.TextBox ITsword;
        private System.Windows.Forms.TextBox ITpoint;
        private System.Windows.Forms.Label ITpointLabel;
        private System.Windows.Forms.TextBox ITfire;
        private System.Windows.Forms.Label ITfireLabel;
        private System.Windows.Forms.TextBox ITmagic;
        private System.Windows.Forms.Label ITmagicLabel;
        private System.Windows.Forms.Label ITvalueLabel;
        private System.Windows.Forms.TextBox ITvalue;
        private System.Windows.Forms.Label ITvisualChangeLabel;
        private System.Windows.Forms.Label ITvisualLabelds;
        private System.Windows.Forms.Label ITvisualLabel;
        private System.Windows.Forms.ComboBox ITvisualChangeBox;
        private System.Windows.Forms.ComboBox ITvisualBox;
        private System.Windows.Forms.ComboBox ITmaterialBox;
        private System.Windows.Forms.Label ITmaterialLabel;
        private System.Windows.Forms.Button ITsaveButton;
        private System.Windows.Forms.Button ITCancelButton;
    }
}