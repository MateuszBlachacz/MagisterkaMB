
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
            this.ITvalue = new System.Windows.Forms.TextBox();
            this.ITvalueLabel = new System.Windows.Forms.Label();
            this.lTArmorLabel = new System.Windows.Forms.Label();
            this.ITArmorBox = new System.Windows.Forms.ComboBox();
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
            // ITvalue
            // 
            this.ITvalue.Location = new System.Drawing.Point(693, 39);
            this.ITvalue.Name = "ITvalue";
            this.ITvalue.Size = new System.Drawing.Size(164, 22);
            this.ITvalue.TabIndex = 2;
            this.ITvalue.TextChanged += new System.EventHandler(this.ITvalue_TextChanged);
            // 
            // ITvalueLabel
            // 
            this.ITvalueLabel.AutoSize = true;
            this.ITvalueLabel.Location = new System.Drawing.Point(579, 40);
            this.ITvalueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITvalueLabel.Name = "ITvalueLabel";
            this.ITvalueLabel.Size = new System.Drawing.Size(82, 17);
            this.ITvalueLabel.TabIndex = 3;
            this.ITvalueLabel.Text = "WARTOŚĆ:";
            // 
            // lTArmorLabel
            // 
            this.lTArmorLabel.AutoSize = true;
            this.lTArmorLabel.Location = new System.Drawing.Point(39, 106);
            this.lTArmorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTArmorLabel.Name = "lTArmorLabel";
            this.lTArmorLabel.Size = new System.Drawing.Size(63, 17);
            this.lTArmorLabel.TabIndex = 4;
            this.lTArmorLabel.Text = "ZBROJE";
            // 
            // ITArmorBox
            // 
            this.ITArmorBox.FormattingEnabled = true;
            this.ITArmorBox.Location = new System.Drawing.Point(184, 103);
            this.ITArmorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ITArmorBox.Name = "ITArmorBox";
            this.ITArmorBox.Size = new System.Drawing.Size(367, 24);
            this.ITArmorBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ITArmorBox);
            this.Controls.Add(this.lTArmorLabel);
            this.Controls.Add(this.ITvalueLabel);
            this.Controls.Add(this.ITvalue);
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
        private System.Windows.Forms.TextBox ITvalue;
        private System.Windows.Forms.Label ITvalueLabel;
        private System.Windows.Forms.Label lTArmorLabel;
        private System.Windows.Forms.ComboBox ITArmorBox;
    }
}