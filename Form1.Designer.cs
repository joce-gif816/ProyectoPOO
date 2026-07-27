namespace Ricarte_POO_
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
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            pictureBox1 = new PictureBox();
            btnRegistrarUsuario = new Button();
            label5 = new Label();
            button1 = new Button();
            texContrasena = new HartUI.Controls.cuiTextBox();
            texUsuario = new HartUI.Controls.cuiTextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.White;
            cuiPanel2.Controls.Add(pictureBox1);
            cuiPanel2.Controls.Add(btnRegistrarUsuario);
            cuiPanel2.Controls.Add(label5);
            cuiPanel2.Controls.Add(button1);
            cuiPanel2.Controls.Add(texContrasena);
            cuiPanel2.Controls.Add(texUsuario);
            cuiPanel2.Controls.Add(label3);
            cuiPanel2.Controls.Add(label1);
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Location = new Point(1099, 145);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(30);
            cuiPanel2.Size = new Size(604, 743);
            cuiPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.user3;
            pictureBox1.Location = new Point(213, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.FromArgb(94, 167, 239);
            btnRegistrarUsuario.ForeColor = Color.White;
            btnRegistrarUsuario.Location = new Point(222, 636);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(195, 56);
            btnRegistrarUsuario.TabIndex = 7;
            btnRegistrarUsuario.Text = "Registrarse";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(213, 603);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 6;
            label5.Text = "¿No tienes cuenta?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 68);
            button1.ForeColor = Color.White;
            button1.Location = new Point(198, 511);
            button1.Name = "button1";
            button1.Size = new Size(219, 50);
            button1.TabIndex = 5;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // texContrasena
            // 
            texContrasena.BackColor = Color.White;
            texContrasena.BackgroundColor = Color.FromArgb(99, 149, 219);
            texContrasena.Content = "";
            texContrasena.FocusBackgroundColor = Color.White;
            texContrasena.FocusImageTint = Color.White;
            texContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texContrasena.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texContrasena.ForeColor = Color.Gray;
            texContrasena.Image = null;
            texContrasena.ImageExpand = new Point(0, 0);
            texContrasena.ImageOffset = new Point(0, 0);
            texContrasena.Location = new Point(98, 423);
            texContrasena.Margin = new Padding(4);
            texContrasena.Multiline = false;
            texContrasena.Name = "texContrasena";
            texContrasena.NormalImageTint = Color.White;
            texContrasena.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texContrasena.Padding = new Padding(23, 15, 23, 0);
            texContrasena.PasswordChar = false;
            texContrasena.PlaceholderColor = Color.White;
            texContrasena.PlaceholderText = "Ingresa contraseña....";
            texContrasena.Rounding = new Padding(8);
            texContrasena.Size = new Size(414, 53);
            texContrasena.TabIndex = 4;
            texContrasena.TextOffset = new Size(0, 0);
            texContrasena.UnderlinedStyle = true;
            // 
            // texUsuario
            // 
            texUsuario.BackColor = Color.White;
            texUsuario.BackgroundColor = Color.FromArgb(99, 149, 219);
            texUsuario.Content = "";
            texUsuario.FocusBackgroundColor = Color.White;
            texUsuario.FocusImageTint = Color.White;
            texUsuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texUsuario.ForeColor = Color.Gray;
            texUsuario.Image = null;
            texUsuario.ImageExpand = new Point(0, 0);
            texUsuario.ImageOffset = new Point(0, 0);
            texUsuario.Location = new Point(98, 285);
            texUsuario.Margin = new Padding(4);
            texUsuario.Multiline = false;
            texUsuario.Name = "texUsuario";
            texUsuario.NormalImageTint = Color.White;
            texUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texUsuario.Padding = new Padding(23, 15, 23, 0);
            texUsuario.PasswordChar = false;
            texUsuario.PlaceholderColor = Color.White;
            texUsuario.PlaceholderText = "Ingresa usuario....";
            texUsuario.Rounding = new Padding(8);
            texUsuario.Size = new Size(414, 52);
            texUsuario.TabIndex = 3;
            texUsuario.TextOffset = new Size(0, 0);
            texUsuario.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 71, 161);
            label3.Location = new Point(98, 367);
            label3.Name = "label3";
            label3.Size = new Size(175, 38);
            label3.TabIndex = 2;
            label3.Text = "Contraseña ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Symbol", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 6, 158);
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(436, 74);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 71, 161);
            label2.Location = new Point(98, 229);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(cuiPanel2);
            Name = "Form1";
            Text = "Form1";
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private HartUI.Controls.cuiTextBox texContrasena;
        private HartUI.Controls.cuiTextBox texUsuario;
        private Button button1;
        private Button btnRegistrarUsuario;
        private Label label5;
        private PictureBox pictureBox1;
    }
}