namespace CompressString
{
    partial class MainForm
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
            CompressFunction.Location = new Point(137, 132);
            CompressFunction.Margin = new Padding(2);
            CompressFunction.Name = "CompressFunction";
            CompressFunction.Size = new Size(93, 19);
            CompressFunction.TabIndex = 0;
            CompressFunction.TabStop = true;
            CompressFunction.Text = "Компрессия";
            CompressFunction.UseVisualStyleBackColor = true;
            // 
            // DecompressFunction
            // 
            DecompressFunction.AutoSize = true;
            DecompressFunction.Location = new Point(290, 132);
            DecompressFunction.Margin = new Padding(2);
            DecompressFunction.Name = "DecompressFunction";
            DecompressFunction.Size = new Size(106, 19);
            DecompressFunction.TabIndex = 1;
            DecompressFunction.TabStop = true;
            DecompressFunction.Text = "Декомпрессия";
            DecompressFunction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 2;
            label1.Text = "Тут будут отображаться результаты";
            // 
            // textBox
            // 
            textBox.Location = new Point(70, 92);
            textBox.Margin = new Padding(2);
            textBox.Name = "textBox";
            textBox.Size = new Size(344, 23);
            textBox.TabIndex = 3;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(425, 90);
            SendButton.Margin = new Padding(2);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(84, 20);
            SendButton.TabIndex = 4;
            SendButton.Text = "Обработать";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(SendButton);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(DecompressFunction);
            Controls.Add(CompressFunction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Compressor";
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
