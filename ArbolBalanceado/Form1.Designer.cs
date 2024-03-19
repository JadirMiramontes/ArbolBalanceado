namespace ArbolBalanceado
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
            textBoxValue = new TextBox();
            btnInsert = new Button();
            listBoxTraversal = new ListBox();
            labelInstruction = new Label();
            SuspendLayout();
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(132, 87);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(141, 138);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 55);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Generar Arbol";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // listBoxTraversal
            // 
            listBoxTraversal.FormattingEnabled = true;
            listBoxTraversal.ItemHeight = 15;
            listBoxTraversal.Location = new Point(382, 12);
            listBoxTraversal.Name = "listBoxTraversal";
            listBoxTraversal.Size = new Size(406, 319);
            listBoxTraversal.TabIndex = 2;
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Location = new Point(84, 47);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(205, 15);
            labelInstruction.TabIndex = 3;
            labelInstruction.Text = "Ingrese los datos que desea balancear";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInstruction);
            Controls.Add(listBoxTraversal);
            Controls.Add(btnInsert);
            Controls.Add(textBoxValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValue;
        private Button btnInsert;
        private ListBox listBoxTraversal;
        private Label labelInstruction;
    }
}
