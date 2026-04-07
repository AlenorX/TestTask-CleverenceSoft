namespace CompressString
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
            CompressFunction = new RadioButton();
            DecompressFunction = new RadioButton();
            label1 = new Label();
            textBox = new TextBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // CompressFunction
            // 
            CompressFunction.AutoSize = true;
            CompressFunction.Location = new Point(196, 220);
            CompressFunction.Name = "CompressFunction";
            CompressFunction.Size = new Size(136, 29);
            CompressFunction.TabIndex = 0;
            CompressFunction.TabStop = true;
            CompressFunction.Text = "Компрессия";
            CompressFunction.UseVisualStyleBackColor = true;
            // 
            // DecompressFunction
            // 
            DecompressFunction.AutoSize = true;
            DecompressFunction.Location = new Point(415, 220);
            DecompressFunction.Name = "DecompressFunction";
            DecompressFunction.Size = new Size(156, 29);
            DecompressFunction.TabIndex = 1;
            DecompressFunction.TabStop = true;
            DecompressFunction.Text = "Декомпрессия";
            DecompressFunction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 352);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // textBox
            // 
            textBox.Location = new Point(100, 153);
            textBox.Name = "textBox";
            textBox.Size = new Size(490, 31);
            textBox.TabIndex = 3;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(607, 150);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(120, 34);
            SendButton.TabIndex = 4;
            SendButton.Text = "Обработать";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendButton);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(DecompressFunction);
            Controls.Add(CompressFunction);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton CompressFunction;
        private RadioButton DecompressFunction;
        private Label label1;
        private TextBox textBox;
        private Button SendButton;
    }
}
