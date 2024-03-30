namespace Troll_Button
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
            Da = new Button();
            Net = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Da
            // 
            Da.BackColor = SystemColors.ActiveCaptionText;
            Da.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Da.ForeColor = SystemColors.ControlLight;
            Da.Location = new Point(124, 221);
            Da.Name = "Da";
            Da.Size = new Size(101, 49);
            Da.TabIndex = 0;
            Da.TabStop = false;
            Da.Text = "Da";
            Da.UseVisualStyleBackColor = false;
            Da.Click += Da_Click;
            // 
            // Net
            // 
            Net.BackColor = SystemColors.ActiveCaptionText;
            Net.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Net.ForeColor = SystemColors.Control;
            Net.Location = new Point(390, 221);
            Net.Name = "Net";
            Net.Size = new Size(101, 49);
            Net.TabIndex = 0;
            Net.TabStop = false;
            Net.Text = "Net";
            Net.UseVisualStyleBackColor = false;
            Net.Click += Net_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(588, 32);
            label1.TabIndex = 1;
            label1.Text = "Vi xotite ispravit mne ocenku na ekzamene do 12?";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 330);
            Controls.Add(label1);
            Controls.Add(Net);
            Controls.Add(Da);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Da;
        private Button Net;
        private Label label1;
    }
}