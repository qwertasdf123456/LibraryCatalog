using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryCatalog
{
    partial class InstructionForm
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

        private void InitializeComponent()
        {
            okButton = new Button();
            instructionsRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Location = new Point(162, 344);
            okButton.Margin = new Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(135, 27);
            okButton.TabIndex = 0;
            okButton.Text = "CLOSE";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // instructionsRichTextBox
            // 
            instructionsRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            instructionsRichTextBox.BackColor = Color.SandyBrown;
            instructionsRichTextBox.ForeColor = SystemColors.WindowText;
            instructionsRichTextBox.Location = new Point(14, 14);
            instructionsRichTextBox.Margin = new Padding(4, 3, 4, 3);
            instructionsRichTextBox.Name = "instructionsRichTextBox";
            instructionsRichTextBox.ReadOnly = true;
            instructionsRichTextBox.Size = new Size(434, 321);
            instructionsRichTextBox.TabIndex = 1;
            instructionsRichTextBox.Text = "";
            // 
            // InstructionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(461, 383);
            Controls.Add(instructionsRichTextBox);
            Controls.Add(okButton);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "InstructionForm";
            Text = "Instruction";
            TransparencyKey = Color.SpringGreen;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RichTextBox instructionsRichTextBox;
    }
}
