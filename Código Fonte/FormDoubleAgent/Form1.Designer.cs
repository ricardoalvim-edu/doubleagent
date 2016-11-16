namespace FormDoubleAgent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTextNomeCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbPersonStateCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.cbVendedores = new System.Windows.Forms.ComboBox();
            this.btLimparCampos = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.controlAgent = new AxDoubleAgentCtl.AxDaControl();
            this.lbTextProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProdutos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeProduto,
            this.quantidadeProduto,
            this.precoProduto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProdutos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProdutos.Location = new System.Drawing.Point(20, 261);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.RowTemplate.Height = 40;
            this.dgProdutos.Size = new System.Drawing.Size(505, 168);
            this.dgProdutos.TabIndex = 1;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            this.dgProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_FimEdicao);
            this.dgProdutos.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgProdutos_Adicionado);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Produto";
            this.nomeProduto.Name = "nomeProduto";
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "Quantidade";
            this.quantidadeProduto.Name = "quantidadeProduto";
            // 
            // precoProduto
            // 
            this.precoProduto.HeaderText = "Preço";
            this.precoProduto.Name = "precoProduto";
            // 
            // lbTextNomeCli
            // 
            this.lbTextNomeCli.AutoSize = true;
            this.lbTextNomeCli.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextNomeCli.Location = new System.Drawing.Point(16, 71);
            this.lbTextNomeCli.Name = "lbTextNomeCli";
            this.lbTextNomeCli.Size = new System.Drawing.Size(130, 21);
            this.lbTextNomeCli.TabIndex = 2;
            this.lbTextNomeCli.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendedor:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCliente.Location = new System.Drawing.Point(20, 95);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(505, 25);
            this.tbNomeCliente.TabIndex = 5;
            this.tbNomeCliente.TextChanged += new System.EventHandler(this.tbNomeCliente_TextChanged);
            this.tbNomeCliente.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // tbPersonStateCode
            // 
            this.tbPersonStateCode.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonStateCode.Location = new System.Drawing.Point(20, 147);
            this.tbPersonStateCode.Name = "tbPersonStateCode";
            this.tbPersonStateCode.Size = new System.Drawing.Size(505, 25);
            this.tbPersonStateCode.TabIndex = 6;
            this.tbPersonStateCode.TextChanged += new System.EventHandler(this.tbPersonStateCode_TextChanged);
            this.tbPersonStateCode.MouseHover += new System.EventHandler(this.tbPersonStateCode_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbTotal.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(467, 442);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(58, 21);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "VALOR";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(12, 435);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(228, 32);
            this.btFinalizar.TabIndex = 9;
            this.btFinalizar.Text = "Finalizar compra!";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            this.btFinalizar.MouseLeave += new System.EventHandler(this.btFinalizar_MouseLeave);
            this.btFinalizar.MouseHover += new System.EventHandler(this.btFinalizar_MouseHover);
            // 
            // cbVendedores
            // 
            this.cbVendedores.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(20, 199);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(505, 25);
            this.cbVendedores.TabIndex = 10;
            this.cbVendedores.SelectedIndexChanged += new System.EventHandler(this.cbVendedores_SelectedIndexChanged);
            this.cbVendedores.MouseHover += new System.EventHandler(this.cbVendedores_MouseHover);
            // 
            // btLimparCampos
            // 
            this.btLimparCampos.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCampos.Location = new System.Drawing.Point(416, 19);
            this.btLimparCampos.Name = "btLimparCampos";
            this.btLimparCampos.Size = new System.Drawing.Size(112, 31);
            this.btLimparCampos.TabIndex = 11;
            this.btLimparCampos.Text = "Limpar Campos!";
            this.btLimparCampos.UseVisualStyleBackColor = true;
            this.btLimparCampos.Click += new System.EventHandler(this.btLimparCampos_Click);
            this.btLimparCampos.MouseLeave += new System.EventHandler(this.btLimparCampos_MouseLeave);
            this.btLimparCampos.MouseHover += new System.EventHandler(this.btLimparCampos_MouseHover);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe WP", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(195, 32);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Emissor de notas";
            // 
            // controlAgent
            // 
            this.controlAgent.Enabled = true;
            this.controlAgent.Location = new System.Drawing.Point(12, 435);
            this.controlAgent.Name = "controlAgent";
            this.controlAgent.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("controlAgent.OcxState")));
            this.controlAgent.Size = new System.Drawing.Size(32, 32);
            this.controlAgent.TabIndex = 13;
            // 
            // lbTextProdutos
            // 
            this.lbTextProdutos.AutoSize = true;
            this.lbTextProdutos.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextProdutos.Location = new System.Drawing.Point(16, 237);
            this.lbTextProdutos.Name = "lbTextProdutos";
            this.lbTextProdutos.Size = new System.Drawing.Size(76, 21);
            this.lbTextProdutos.TabIndex = 14;
            this.lbTextProdutos.Text = "Produtos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 479);
            this.Controls.Add(this.lbTextProdutos);
            this.Controls.Add(this.controlAgent);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btLimparCampos);
            this.Controls.Add(this.cbVendedores);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPersonStateCode);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTextNomeCli);
            this.Controls.Add(this.dgProdutos);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.CarregarFormulario_Home);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Formulario_Home_MudancaMouse);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbPersonStateCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTextNomeCli;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.ComboBox cbVendedores;
        private System.Windows.Forms.Button btLimparCampos;
        private System.Windows.Forms.Label lbTitle;
        private AxDoubleAgentCtl.AxDaControl controlAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProduto;
        private System.Windows.Forms.Label lbTextProdutos;
    }
}

