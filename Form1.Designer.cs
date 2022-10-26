
namespace Calculadora
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.botaoSomar = new System.Windows.Forms.Button();
            this.botaoSubtrair = new System.Windows.Forms.Button();
            this.botaoMultiplicar = new System.Windows.Forms.Button();
            this.botaoDividir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoMinimizar = new System.Windows.Forms.Button();
            this.botaoMaximizar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.botaoDividir);
            this.panelMenu.Controls.Add(this.botaoMultiplicar);
            this.panelMenu.Controls.Add(this.botaoSubtrair);
            this.panelMenu.Controls.Add(this.botaoSomar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // botaoSomar
            // 
            this.botaoSomar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoSomar.FlatAppearance.BorderSize = 0;
            this.botaoSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSomar.ForeColor = System.Drawing.Color.Gainsboro;
            this.botaoSomar.Location = new System.Drawing.Point(0, 100);
            this.botaoSomar.Name = "botaoSomar";
            this.botaoSomar.Size = new System.Drawing.Size(220, 60);
            this.botaoSomar.TabIndex = 2;
            this.botaoSomar.Text = "Somar";
            this.botaoSomar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSomar.UseVisualStyleBackColor = true;
            // 
            // botaoSubtrair
            // 
            this.botaoSubtrair.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoSubtrair.FlatAppearance.BorderSize = 0;
            this.botaoSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSubtrair.ForeColor = System.Drawing.Color.Gainsboro;
            this.botaoSubtrair.Location = new System.Drawing.Point(0, 160);
            this.botaoSubtrair.Name = "botaoSubtrair";
            this.botaoSubtrair.Size = new System.Drawing.Size(220, 60);
            this.botaoSubtrair.TabIndex = 3;
            this.botaoSubtrair.Text = "Subtrair";
            this.botaoSubtrair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSubtrair.UseVisualStyleBackColor = true;
            // 
            // botaoMultiplicar
            // 
            this.botaoMultiplicar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoMultiplicar.FlatAppearance.BorderSize = 0;
            this.botaoMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMultiplicar.ForeColor = System.Drawing.Color.Gainsboro;
            this.botaoMultiplicar.Location = new System.Drawing.Point(0, 220);
            this.botaoMultiplicar.Name = "botaoMultiplicar";
            this.botaoMultiplicar.Size = new System.Drawing.Size(220, 60);
            this.botaoMultiplicar.TabIndex = 4;
            this.botaoMultiplicar.Text = "Multiplicar";
            this.botaoMultiplicar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // botaoDividir
            // 
            this.botaoDividir.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoDividir.FlatAppearance.BorderSize = 0;
            this.botaoDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDividir.ForeColor = System.Drawing.Color.Gainsboro;
            this.botaoDividir.Location = new System.Drawing.Point(0, 280);
            this.botaoDividir.Name = "botaoDividir";
            this.botaoDividir.Size = new System.Drawing.Size(220, 60);
            this.botaoDividir.TabIndex = 5;
            this.botaoDividir.Text = "Dividir";
            this.botaoDividir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoDividir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.botaoMaximizar);
            this.panel1.Controls.Add(this.botaoMinimizar);
            this.panel1.Controls.Add(this.botaoFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calculadora";
            // 
            // botaoFechar
            // 
            this.botaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFechar.ForeColor = System.Drawing.Color.White;
            this.botaoFechar.Location = new System.Drawing.Point(550, 0);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(30, 30);
            this.botaoFechar.TabIndex = 1;
            this.botaoFechar.Text = "O";
            this.botaoFechar.UseVisualStyleBackColor = true;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoMinimizar.FlatAppearance.BorderSize = 0;
            this.botaoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMinimizar.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMinimizar.ForeColor = System.Drawing.Color.White;
            this.botaoMinimizar.Location = new System.Drawing.Point(478, 0);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(30, 30);
            this.botaoMinimizar.TabIndex = 2;
            this.botaoMinimizar.Text = "O";
            this.botaoMinimizar.UseVisualStyleBackColor = true;
            this.botaoMinimizar.Click += new System.EventHandler(this.botaoMinimizar_Click);
            // 
            // botaoMaximizar
            // 
            this.botaoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoMaximizar.FlatAppearance.BorderSize = 0;
            this.botaoMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMaximizar.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMaximizar.ForeColor = System.Drawing.Color.White;
            this.botaoMaximizar.Location = new System.Drawing.Point(514, 0);
            this.botaoMaximizar.Name = "botaoMaximizar";
            this.botaoMaximizar.Size = new System.Drawing.Size(30, 30);
            this.botaoMaximizar.TabIndex = 3;
            this.botaoMaximizar.Text = "O";
            this.botaoMaximizar.UseVisualStyleBackColor = true;
            this.botaoMaximizar.Click += new System.EventHandler(this.botaoMaximizar_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button botaoSomar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button botaoDividir;
        private System.Windows.Forms.Button botaoMultiplicar;
        private System.Windows.Forms.Button botaoSubtrair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoMaximizar;
        private System.Windows.Forms.Button botaoMinimizar;
        private System.Windows.Forms.Button botaoFechar;
    }
}

