﻿namespace Sales_System
{
    partial class frm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cad_produtos.ForeColor = System.Drawing.Color.White;
            this.btn_cad_produtos.Image = global::Sales_System.Properties.Resources.cadastro_produtos_40_x_40;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(12, 37);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(97, 80);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadastrar Produto";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.btn_cad_produtos_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cad_categorias.ForeColor = System.Drawing.Color.White;
            this.btn_cad_categorias.Image = global::Sales_System.Properties.Resources.relatorios_40_x_40;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(132, 37);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(97, 80);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar Categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sales_System.Properties.Resources.fundo_sistema_azul;
            this.ClientSize = new System.Drawing.Size(569, 312);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categorias;
    }
}

