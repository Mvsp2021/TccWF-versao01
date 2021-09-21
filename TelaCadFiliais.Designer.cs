
namespace TccWF_versao01
{
    partial class TelaCadFiliais
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
            this.dgFiliais = new System.Windows.Forms.DataGridView();
            this.FiliaisbtnOk = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFiliaisNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.FilialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaFilial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiliais)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiliais
            // 
            this.dgFiliais.AllowUserToAddRows = false;
            this.dgFiliais.AllowUserToDeleteRows = false;
            this.dgFiliais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiliais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilialCol});
            this.dgFiliais.Location = new System.Drawing.Point(30, 102);
            this.dgFiliais.Name = "dgFiliais";
            this.dgFiliais.ReadOnly = true;
            this.dgFiliais.Size = new System.Drawing.Size(515, 150);
            this.dgFiliais.TabIndex = 13;
            // 
            // FiliaisbtnOk
            // 
            this.FiliaisbtnOk.Location = new System.Drawing.Point(465, 57);
            this.FiliaisbtnOk.Name = "FiliaisbtnOk";
            this.FiliaisbtnOk.Size = new System.Drawing.Size(53, 29);
            this.FiliaisbtnOk.TabIndex = 12;
            this.FiliaisbtnOk.Text = "OK";
            this.FiliaisbtnOk.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(26, 56);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(98, 24);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFiliaisNovo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFiliaisNovo
            // 
            this.MenuFiliaisNovo.Name = "MenuFiliaisNovo";
            this.MenuFiliaisNovo.Size = new System.Drawing.Size(60, 25);
            this.MenuFiliaisNovo.Text = "Novo";
            this.MenuFiliaisNovo.Click += new System.EventHandler(this.MenuFiliaisNovo_Click);
            // 
            // FilialCol
            // 
            this.FilialCol.HeaderText = "Filial";
            this.FilialCol.Name = "FilialCol";
            this.FilialCol.ReadOnly = true;
            // 
            // txtPesquisaFilial
            // 
            this.txtPesquisaFilial.Location = new System.Drawing.Point(131, 56);
            this.txtPesquisaFilial.Name = "txtPesquisaFilial";
            this.txtPesquisaFilial.Size = new System.Drawing.Size(318, 29);
            this.txtPesquisaFilial.TabIndex = 14;
            // 
            // TelaCadFiliais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(581, 268);
            this.Controls.Add(this.txtPesquisaFilial);
            this.Controls.Add(this.dgFiliais);
            this.Controls.Add(this.FiliaisbtnOk);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadFiliais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filiais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadFiliais_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiliais)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFiliais;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilialCol;
        private System.Windows.Forms.Button FiliaisbtnOk;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFiliaisNovo;
        private System.Windows.Forms.TextBox txtPesquisaFilial;
    }
}