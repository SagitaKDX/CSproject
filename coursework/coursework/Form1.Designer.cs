namespace coursework
{
    partial class Form1
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
            this.Instruction = new System.Windows.Forms.Label();
            this.stringInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.EncodeResult = new System.Windows.Forms.Label();
            this.print1Button = new System.Windows.Forms.Button();
            this.print2Button = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.PrintEncryptedbutton = new System.Windows.Forms.Button();
            this.PrintDecryptedbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Location = new System.Drawing.Point(96, 26);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(140, 16);
            this.Instruction.TabIndex = 0;
            this.Instruction.Text = "Please input the string:";
            this.Instruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Instruction.Click += new System.EventHandler(this.label1_Click);
            // 
            // stringInput
            // 
            this.stringInput.Location = new System.Drawing.Point(99, 45);
            this.stringInput.Name = "stringInput";
            this.stringInput.Size = new System.Drawing.Size(345, 22);
            this.stringInput.TabIndex = 1;
            this.stringInput.TextChanged += new System.EventHandler(this.stringInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please input number N:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(99, 100);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(345, 22);
            this.numberInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Location = new System.Drawing.Point(99, 129);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(19, 16);
            this.notification.TabIndex = 5;
            this.notification.Text = "    ";
            this.notification.Click += new System.EventHandler(this.notification_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(180, 148);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 7;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // EncodeResult
            // 
            this.EncodeResult.AutoSize = true;
            this.EncodeResult.Location = new System.Drawing.Point(99, 224);
            this.EncodeResult.Name = "EncodeResult";
            this.EncodeResult.Size = new System.Drawing.Size(51, 16);
            this.EncodeResult.TabIndex = 8;
            this.EncodeResult.Text = "Result :";
            this.EncodeResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // print1Button
            // 
            this.print1Button.Location = new System.Drawing.Point(262, 147);
            this.print1Button.Name = "print1Button";
            this.print1Button.Size = new System.Drawing.Size(127, 23);
            this.print1Button.TabIndex = 9;
            this.print1Button.Text = "Print InputCode";
            this.print1Button.UseVisualStyleBackColor = true;
            this.print1Button.Click += new System.EventHandler(this.print1Button_Click);
            // 
            // print2Button
            // 
            this.print2Button.Location = new System.Drawing.Point(410, 147);
            this.print2Button.Name = "print2Button";
            this.print2Button.Size = new System.Drawing.Size(149, 23);
            this.print2Button.TabIndex = 10;
            this.print2Button.Text = "Print OutputCode";
            this.print2Button.UseVisualStyleBackColor = true;
            this.print2Button.Click += new System.EventHandler(this.print2Button_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(566, 147);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(142, 23);
            this.SortButton.TabIndex = 11;
            this.SortButton.Text = "Print Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // PrintEncryptedbutton
            // 
            this.PrintEncryptedbutton.Location = new System.Drawing.Point(99, 187);
            this.PrintEncryptedbutton.Name = "PrintEncryptedbutton";
            this.PrintEncryptedbutton.Size = new System.Drawing.Size(158, 23);
            this.PrintEncryptedbutton.TabIndex = 12;
            this.PrintEncryptedbutton.Text = "Print EncryptedCode";
            this.PrintEncryptedbutton.UseVisualStyleBackColor = true;
            this.PrintEncryptedbutton.Click += new System.EventHandler(this.PrintEncryptedbutton_Click);
            // 
            // PrintDecryptedbutton
            // 
            this.PrintDecryptedbutton.Location = new System.Drawing.Point(99, 338);
            this.PrintDecryptedbutton.Name = "PrintDecryptedbutton";
            this.PrintDecryptedbutton.Size = new System.Drawing.Size(166, 23);
            this.PrintDecryptedbutton.TabIndex = 13;
            this.PrintDecryptedbutton.Text = "Print DecryptedCode";
            this.PrintDecryptedbutton.UseVisualStyleBackColor = true;
            this.PrintDecryptedbutton.Click += new System.EventHandler(this.PrintDecryptedbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Input EncryptedCode here:";
            // 
            // Result_2
            // 
            this.Result_2.AutoSize = true;
            this.Result_2.Location = new System.Drawing.Point(102, 368);
            this.Result_2.Name = "Result_2";
            this.Result_2.Size = new System.Drawing.Size(48, 16);
            this.Result_2.TabIndex = 16;
            this.Result_2.Text = "Result:";
            this.Result_2.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 524);
            this.Controls.Add(this.Result_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrintDecryptedbutton);
            this.Controls.Add(this.PrintEncryptedbutton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.print2Button);
            this.Controls.Add(this.print1Button);
            this.Controls.Add(this.EncodeResult);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stringInput);
            this.Controls.Add(this.Instruction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.TextBox stringInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Label EncodeResult;
        private System.Windows.Forms.Button print1Button;
        private System.Windows.Forms.Button print2Button;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button PrintEncryptedbutton;
        private System.Windows.Forms.Button PrintDecryptedbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result_2;
    }
}

