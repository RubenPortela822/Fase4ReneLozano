namespace Fase4ReneLozano
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            password = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 119);
            label1.Name = "label1";
            label1.Size = new Size(251, 24);
            label1.TabIndex = 0;
            label1.Text = "Arbol binario de busqueda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 39);
            label2.Name = "label2";
            label2.Size = new Size(280, 32);
            label2.TabIndex = 1;
            label2.Text = "Yefeson Rene Lozano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(317, 373);
            label3.Name = "label3";
            label3.Size = new Size(165, 16);
            label3.TabIndex = 2;
            label3.Text = "Martes 7 de mayo del 2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 186);
            label4.Name = "label4";
            label4.Size = new Size(131, 16);
            label4.TabIndex = 3;
            label4.Text = "Ingrese la contraseña";
            // 
            // password
            // 
            password.Location = new Point(382, 243);
            password.Name = "password";
            password.Size = new Size(141, 23);
            password.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 250);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 5;
            label5.Text = "Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(356, 307);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inicio de sesion ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox password;
        private Label label5;
        private Button button1;
    }
}
