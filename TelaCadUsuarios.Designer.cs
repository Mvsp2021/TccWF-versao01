
namespace TccWF_versao01
{
    partial class TelaCadUsuarios
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
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUsuariosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(27, 69);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(98, 24);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuariosNovo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUsuariosNovo
            // 
            this.MenuUsuariosNovo.Name = "MenuUsuariosNovo";
            this.MenuUsuariosNovo.Size = new System.Drawing.Size(60, 25);
            this.MenuUsuariosNovo.Text = "Novo";
            this.MenuUsuariosNovo.Click += new System.EventHandler(this.MenuUsuariosNovo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(475, 66);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 34);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.FilialCol,
            this.CargoCol});
            this.dgUsuarios.Location = new System.Drawing.Point(31, 136);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(515, 150);
            this.dgUsuarios.TabIndex = 8;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            // 
            // FilialCol
            // 
            this.FilialCol.HeaderText = "Filial";
            this.FilialCol.Name = "FilialCol";
            this.FilialCol.ReadOnly = true;
            // 
            // CargoCol
            // 
            this.CargoCol.HeaderText = "Cargo";
            this.CargoCol.Name = "CargoCol";
            this.CargoCol.ReadOnly = true;
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(140, 66);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 29);
            this.txtPesquisaUsuario.TabIndex = 9;
            // 
            // TelaCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(593, 324);
            this.Controls.Add(this.txtPesquisaUsuario);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadUsuarios_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuariosNovo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoCol;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
    }
}