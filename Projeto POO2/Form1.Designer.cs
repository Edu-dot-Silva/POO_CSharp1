namespace Projeto_POO2
{
    partial class Frm_Mercadorias
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
            this.Lbl_Produto1 = new System.Windows.Forms.Label();
            this.Lbl_Produto2 = new System.Windows.Forms.Label();
            this.Lbl_Produto3 = new System.Windows.Forms.Label();
            this.Lbl_Valor1 = new System.Windows.Forms.Label();
            this.Lbl_Valor2 = new System.Windows.Forms.Label();
            this.Lbl_Valor3 = new System.Windows.Forms.Label();
            this.Txt_Produto1 = new System.Windows.Forms.TextBox();
            this.Txt_Produto2 = new System.Windows.Forms.TextBox();
            this.Txt_Produto3 = new System.Windows.Forms.TextBox();
            this.Txt_Valor1 = new System.Windows.Forms.TextBox();
            this.Txt_Valor2 = new System.Windows.Forms.TextBox();
            this.Txt_Valor3 = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Porcentagem_Reajuste = new System.Windows.Forms.Label();
            this.txt_Valor_Reajuste = new System.Windows.Forms.TextBox();
            this.lbl_Quantindade1 = new System.Windows.Forms.Label();
            this.lbl_Quantindade2 = new System.Windows.Forms.Label();
            this.lbl_Quantindade3 = new System.Windows.Forms.Label();
            this.txt_Quant1 = new System.Windows.Forms.TextBox();
            this.txt_Quant2 = new System.Windows.Forms.TextBox();
            this.txt_Quant3 = new System.Windows.Forms.TextBox();
            this.lbl_total_produto1 = new System.Windows.Forms.Label();
            this.lbl_total_produto3 = new System.Windows.Forms.Label();
            this.lbl_total_produto2 = new System.Windows.Forms.Label();
            this.txt_Total1 = new System.Windows.Forms.TextBox();
            this.txt_Total2 = new System.Windows.Forms.TextBox();
            this.txt_Total3 = new System.Windows.Forms.TextBox();
            this.btn_fecharPedido = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Reajuste = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_precoFinal = new System.Windows.Forms.Label();
            this.txt_valorFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Produto1
            // 
            this.Lbl_Produto1.AutoSize = true;
            this.Lbl_Produto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produto1.Location = new System.Drawing.Point(21, 107);
            this.Lbl_Produto1.Name = "Lbl_Produto1";
            this.Lbl_Produto1.Size = new System.Drawing.Size(111, 25);
            this.Lbl_Produto1.TabIndex = 1;
            this.Lbl_Produto1.Text = "Produto 1:";
            // 
            // Lbl_Produto2
            // 
            this.Lbl_Produto2.AutoSize = true;
            this.Lbl_Produto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produto2.Location = new System.Drawing.Point(21, 162);
            this.Lbl_Produto2.Name = "Lbl_Produto2";
            this.Lbl_Produto2.Size = new System.Drawing.Size(111, 25);
            this.Lbl_Produto2.TabIndex = 2;
            this.Lbl_Produto2.Text = "Produto 2:";
            this.Lbl_Produto2.Click += new System.EventHandler(this.Lbl_Produto2_Click);
            // 
            // Lbl_Produto3
            // 
            this.Lbl_Produto3.AutoSize = true;
            this.Lbl_Produto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produto3.Location = new System.Drawing.Point(21, 213);
            this.Lbl_Produto3.Name = "Lbl_Produto3";
            this.Lbl_Produto3.Size = new System.Drawing.Size(111, 25);
            this.Lbl_Produto3.TabIndex = 3;
            this.Lbl_Produto3.Text = "Produto 3:";
            // 
            // Lbl_Valor1
            // 
            this.Lbl_Valor1.AutoSize = true;
            this.Lbl_Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor1.Location = new System.Drawing.Point(413, 107);
            this.Lbl_Valor1.Name = "Lbl_Valor1";
            this.Lbl_Valor1.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Valor1.TabIndex = 6;
            this.Lbl_Valor1.Text = "Valor:";
            // 
            // Lbl_Valor2
            // 
            this.Lbl_Valor2.AutoSize = true;
            this.Lbl_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor2.Location = new System.Drawing.Point(413, 162);
            this.Lbl_Valor2.Name = "Lbl_Valor2";
            this.Lbl_Valor2.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Valor2.TabIndex = 5;
            this.Lbl_Valor2.Text = "Valor:";
            this.Lbl_Valor2.Click += new System.EventHandler(this.Lbl_Valor2_Click);
            // 
            // Lbl_Valor3
            // 
            this.Lbl_Valor3.AutoSize = true;
            this.Lbl_Valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor3.Location = new System.Drawing.Point(413, 213);
            this.Lbl_Valor3.Name = "Lbl_Valor3";
            this.Lbl_Valor3.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Valor3.TabIndex = 4;
            this.Lbl_Valor3.Text = "Valor:";
            // 
            // Txt_Produto1
            // 
            this.Txt_Produto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Produto1.Location = new System.Drawing.Point(138, 101);
            this.Txt_Produto1.Name = "Txt_Produto1";
            this.Txt_Produto1.Size = new System.Drawing.Size(247, 31);
            this.Txt_Produto1.TabIndex = 7;
            this.Txt_Produto1.TextChanged += new System.EventHandler(this.Txt_Produto1_TextChanged);
            // 
            // Txt_Produto2
            // 
            this.Txt_Produto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Produto2.Location = new System.Drawing.Point(138, 156);
            this.Txt_Produto2.Name = "Txt_Produto2";
            this.Txt_Produto2.Size = new System.Drawing.Size(247, 31);
            this.Txt_Produto2.TabIndex = 8;
            // 
            // Txt_Produto3
            // 
            this.Txt_Produto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Produto3.Location = new System.Drawing.Point(138, 207);
            this.Txt_Produto3.Name = "Txt_Produto3";
            this.Txt_Produto3.Size = new System.Drawing.Size(247, 31);
            this.Txt_Produto3.TabIndex = 9;
            // 
            // Txt_Valor1
            // 
            this.Txt_Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor1.Location = new System.Drawing.Point(487, 101);
            this.Txt_Valor1.Name = "Txt_Valor1";
            this.Txt_Valor1.Size = new System.Drawing.Size(121, 31);
            this.Txt_Valor1.TabIndex = 12;
            // 
            // Txt_Valor2
            // 
            this.Txt_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor2.Location = new System.Drawing.Point(487, 156);
            this.Txt_Valor2.Name = "Txt_Valor2";
            this.Txt_Valor2.Size = new System.Drawing.Size(121, 31);
            this.Txt_Valor2.TabIndex = 11;
            // 
            // Txt_Valor3
            // 
            this.Txt_Valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor3.Location = new System.Drawing.Point(487, 207);
            this.Txt_Valor3.Name = "Txt_Valor3";
            this.Txt_Valor3.Size = new System.Drawing.Size(121, 31);
            this.Txt_Valor3.TabIndex = 10;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(208, 457);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(681, 278);
            this.Lbl_Resultado.TabIndex = 16;
            this.Lbl_Resultado.Text = "Lista de Produtos";
            this.Lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Porcentagem_Reajuste
            // 
            this.lbl_Porcentagem_Reajuste.AutoSize = true;
            this.lbl_Porcentagem_Reajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentagem_Reajuste.Location = new System.Drawing.Point(590, 323);
            this.lbl_Porcentagem_Reajuste.Name = "lbl_Porcentagem_Reajuste";
            this.lbl_Porcentagem_Reajuste.Size = new System.Drawing.Size(266, 25);
            this.lbl_Porcentagem_Reajuste.TabIndex = 17;
            this.lbl_Porcentagem_Reajuste.Text = "Porcentagem de Reajuste:";
            this.lbl_Porcentagem_Reajuste.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Valor_Reajuste
            // 
            this.txt_Valor_Reajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor_Reajuste.Location = new System.Drawing.Point(862, 317);
            this.txt_Valor_Reajuste.Name = "txt_Valor_Reajuste";
            this.txt_Valor_Reajuste.Size = new System.Drawing.Size(105, 31);
            this.txt_Valor_Reajuste.TabIndex = 18;
            this.txt_Valor_Reajuste.TextChanged += new System.EventHandler(this.txt_Valor_Reajuste_TextChanged);
            // 
            // lbl_Quantindade1
            // 
            this.lbl_Quantindade1.AutoSize = true;
            this.lbl_Quantindade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantindade1.Location = new System.Drawing.Point(634, 107);
            this.lbl_Quantindade1.Name = "lbl_Quantindade1";
            this.lbl_Quantindade1.Size = new System.Drawing.Size(58, 25);
            this.lbl_Quantindade1.TabIndex = 19;
            this.lbl_Quantindade1.Text = "Qtd.:";
            // 
            // lbl_Quantindade2
            // 
            this.lbl_Quantindade2.AutoSize = true;
            this.lbl_Quantindade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantindade2.Location = new System.Drawing.Point(634, 162);
            this.lbl_Quantindade2.Name = "lbl_Quantindade2";
            this.lbl_Quantindade2.Size = new System.Drawing.Size(58, 25);
            this.lbl_Quantindade2.TabIndex = 20;
            this.lbl_Quantindade2.Text = "Qtd.:";
            // 
            // lbl_Quantindade3
            // 
            this.lbl_Quantindade3.AutoSize = true;
            this.lbl_Quantindade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantindade3.Location = new System.Drawing.Point(634, 213);
            this.lbl_Quantindade3.Name = "lbl_Quantindade3";
            this.lbl_Quantindade3.Size = new System.Drawing.Size(58, 25);
            this.lbl_Quantindade3.TabIndex = 21;
            this.lbl_Quantindade3.Text = "Qtd.:";
            // 
            // txt_Quant1
            // 
            this.txt_Quant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quant1.Location = new System.Drawing.Point(698, 101);
            this.txt_Quant1.Name = "txt_Quant1";
            this.txt_Quant1.Size = new System.Drawing.Size(61, 31);
            this.txt_Quant1.TabIndex = 22;
            // 
            // txt_Quant2
            // 
            this.txt_Quant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quant2.Location = new System.Drawing.Point(698, 156);
            this.txt_Quant2.Name = "txt_Quant2";
            this.txt_Quant2.Size = new System.Drawing.Size(61, 31);
            this.txt_Quant2.TabIndex = 23;
            // 
            // txt_Quant3
            // 
            this.txt_Quant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quant3.Location = new System.Drawing.Point(698, 207);
            this.txt_Quant3.Name = "txt_Quant3";
            this.txt_Quant3.Size = new System.Drawing.Size(61, 31);
            this.txt_Quant3.TabIndex = 24;
            // 
            // lbl_total_produto1
            // 
            this.lbl_total_produto1.AutoSize = true;
            this.lbl_total_produto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_produto1.Location = new System.Drawing.Point(790, 107);
            this.lbl_total_produto1.Name = "lbl_total_produto1";
            this.lbl_total_produto1.Size = new System.Drawing.Size(66, 25);
            this.lbl_total_produto1.TabIndex = 25;
            this.lbl_total_produto1.Text = "Total:";
            // 
            // lbl_total_produto3
            // 
            this.lbl_total_produto3.AutoSize = true;
            this.lbl_total_produto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_produto3.Location = new System.Drawing.Point(790, 213);
            this.lbl_total_produto3.Name = "lbl_total_produto3";
            this.lbl_total_produto3.Size = new System.Drawing.Size(66, 25);
            this.lbl_total_produto3.TabIndex = 26;
            this.lbl_total_produto3.Text = "Total:";
            // 
            // lbl_total_produto2
            // 
            this.lbl_total_produto2.AutoSize = true;
            this.lbl_total_produto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_produto2.Location = new System.Drawing.Point(790, 159);
            this.lbl_total_produto2.Name = "lbl_total_produto2";
            this.lbl_total_produto2.Size = new System.Drawing.Size(66, 25);
            this.lbl_total_produto2.TabIndex = 27;
            this.lbl_total_produto2.Text = "Total:";
            // 
            // txt_Total1
            // 
            this.txt_Total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total1.Location = new System.Drawing.Point(862, 101);
            this.txt_Total1.Name = "txt_Total1";
            this.txt_Total1.Size = new System.Drawing.Size(105, 31);
            this.txt_Total1.TabIndex = 28;
            // 
            // txt_Total2
            // 
            this.txt_Total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total2.Location = new System.Drawing.Point(862, 156);
            this.txt_Total2.Name = "txt_Total2";
            this.txt_Total2.Size = new System.Drawing.Size(105, 31);
            this.txt_Total2.TabIndex = 29;
            // 
            // txt_Total3
            // 
            this.txt_Total3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total3.Location = new System.Drawing.Point(862, 207);
            this.txt_Total3.Name = "txt_Total3";
            this.txt_Total3.Size = new System.Drawing.Size(105, 31);
            this.txt_Total3.TabIndex = 30;
            // 
            // btn_fecharPedido
            // 
            this.btn_fecharPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fecharPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharPedido.Image = global::Projeto_POO2.Properties.Resources.order_fulfillment;
            this.btn_fecharPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fecharPedido.Location = new System.Drawing.Point(208, 370);
            this.btn_fecharPedido.Name = "btn_fecharPedido";
            this.btn_fecharPedido.Size = new System.Drawing.Size(196, 59);
            this.btn_fecharPedido.TabIndex = 31;
            this.btn_fecharPedido.Text = "Fechar Pedido";
            this.btn_fecharPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fecharPedido.UseVisualStyleBackColor = true;
            this.btn_fecharPedido.Click += new System.EventHandler(this.btn_fecharPedido_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.Image = global::Projeto_POO2.Properties.Resources.sair;
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(979, 734);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(94, 59);
            this.Btn_Sair.TabIndex = 15;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Image = global::Projeto_POO2.Properties.Resources.delete;
            this.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpar.Location = new System.Drawing.Point(769, 370);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(120, 59);
            this.Btn_Limpar.TabIndex = 14;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Reajuste
            // 
            this.Btn_Reajuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Reajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reajuste.Image = global::Projeto_POO2.Properties.Resources.adicionar_ficheiro;
            this.Btn_Reajuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reajuste.Location = new System.Drawing.Point(510, 370);
            this.Btn_Reajuste.Name = "Btn_Reajuste";
            this.Btn_Reajuste.Size = new System.Drawing.Size(144, 59);
            this.Btn_Reajuste.TabIndex = 13;
            this.Btn_Reajuste.Text = "Adicionar";
            this.Btn_Reajuste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Reajuste.UseVisualStyleBackColor = true;
            this.Btn_Reajuste.Click += new System.EventHandler(this.Btn_Reajuste_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Titulo.Image = global::Projeto_POO2.Properties.Resources.features;
            this.Lbl_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Titulo.Location = new System.Drawing.Point(412, 12);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_Titulo.MaximumSize = new System.Drawing.Size(120, 120);
            this.Lbl_Titulo.MinimumSize = new System.Drawing.Size(280, 80);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(280, 80);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Cadastro de Produtos";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_Titulo_Click);
            // 
            // lbl_precoFinal
            // 
            this.lbl_precoFinal.AutoSize = true;
            this.lbl_precoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoFinal.Location = new System.Drawing.Point(735, 267);
            this.lbl_precoFinal.Name = "lbl_precoFinal";
            this.lbl_precoFinal.Size = new System.Drawing.Size(121, 25);
            this.lbl_precoFinal.TabIndex = 32;
            this.lbl_precoFinal.Text = "Valor Final:";
            // 
            // txt_valorFinal
            // 
            this.txt_valorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorFinal.Location = new System.Drawing.Point(862, 261);
            this.txt_valorFinal.Name = "txt_valorFinal";
            this.txt_valorFinal.Size = new System.Drawing.Size(105, 31);
            this.txt_valorFinal.TabIndex = 33;
            // 
            // Frm_Mercadorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 805);
            this.Controls.Add(this.txt_valorFinal);
            this.Controls.Add(this.lbl_precoFinal);
            this.Controls.Add(this.btn_fecharPedido);
            this.Controls.Add(this.txt_Total3);
            this.Controls.Add(this.txt_Total2);
            this.Controls.Add(this.txt_Total1);
            this.Controls.Add(this.lbl_total_produto2);
            this.Controls.Add(this.lbl_total_produto3);
            this.Controls.Add(this.lbl_total_produto1);
            this.Controls.Add(this.txt_Quant3);
            this.Controls.Add(this.txt_Quant2);
            this.Controls.Add(this.txt_Quant1);
            this.Controls.Add(this.lbl_Quantindade3);
            this.Controls.Add(this.lbl_Quantindade2);
            this.Controls.Add(this.lbl_Quantindade1);
            this.Controls.Add(this.txt_Valor_Reajuste);
            this.Controls.Add(this.lbl_Porcentagem_Reajuste);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Reajuste);
            this.Controls.Add(this.Txt_Valor1);
            this.Controls.Add(this.Txt_Valor2);
            this.Controls.Add(this.Txt_Valor3);
            this.Controls.Add(this.Txt_Produto3);
            this.Controls.Add(this.Txt_Produto2);
            this.Controls.Add(this.Txt_Produto1);
            this.Controls.Add(this.Lbl_Valor1);
            this.Controls.Add(this.Lbl_Valor2);
            this.Controls.Add(this.Lbl_Valor3);
            this.Controls.Add(this.Lbl_Produto3);
            this.Controls.Add(this.Lbl_Produto2);
            this.Controls.Add(this.Lbl_Produto1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Mercadorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Produto1;
        private System.Windows.Forms.Label Lbl_Produto2;
        private System.Windows.Forms.Label Lbl_Produto3;
        private System.Windows.Forms.Label Lbl_Valor1;
        private System.Windows.Forms.Label Lbl_Valor2;
        private System.Windows.Forms.Label Lbl_Valor3;
        private System.Windows.Forms.TextBox Txt_Produto1;
        private System.Windows.Forms.TextBox Txt_Produto2;
        private System.Windows.Forms.TextBox Txt_Produto3;
        private System.Windows.Forms.TextBox Txt_Valor1;
        private System.Windows.Forms.TextBox Txt_Valor2;
        private System.Windows.Forms.TextBox Txt_Valor3;
        private System.Windows.Forms.Button Btn_Reajuste;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Label lbl_Porcentagem_Reajuste;
        private System.Windows.Forms.TextBox txt_Valor_Reajuste;
        private System.Windows.Forms.Label lbl_Quantindade1;
        private System.Windows.Forms.Label lbl_Quantindade2;
        private System.Windows.Forms.Label lbl_Quantindade3;
        private System.Windows.Forms.TextBox txt_Quant1;
        private System.Windows.Forms.TextBox txt_Quant2;
        private System.Windows.Forms.TextBox txt_Quant3;
        private System.Windows.Forms.Label lbl_total_produto1;
        private System.Windows.Forms.Label lbl_total_produto3;
        private System.Windows.Forms.Label lbl_total_produto2;
        private System.Windows.Forms.TextBox txt_Total1;
        private System.Windows.Forms.TextBox txt_Total2;
        private System.Windows.Forms.TextBox txt_Total3;
        private System.Windows.Forms.Button btn_fecharPedido;
        private System.Windows.Forms.Label lbl_precoFinal;
        private System.Windows.Forms.TextBox txt_valorFinal;
    }
}

