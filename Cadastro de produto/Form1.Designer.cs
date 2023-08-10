namespace Cadastro_de_produto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            codigo = new TextBox();
            descricao = new TextBox();
            porcetagem = new TextBox();
            precoA = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lista = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(396, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 201);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 3;
            label4.Text = "Preço de Aquisição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 21);
            label5.TabIndex = 4;
            label5.Text = "Porcentagem de Venda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 257);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 5;
            label6.Text = "Valor de Venda:";
            // 
            // codigo
            // 
            codigo.BorderStyle = BorderStyle.FixedSingle;
            codigo.Location = new Point(203, 144);
            codigo.Name = "codigo";
            codigo.Size = new Size(309, 29);
            codigo.TabIndex = 6;
            // 
            // descricao
            // 
            descricao.BorderStyle = BorderStyle.FixedSingle;
            descricao.Location = new Point(203, 199);
            descricao.Name = "descricao";
            descricao.Size = new Size(309, 29);
            descricao.TabIndex = 7;
            // 
            // porcetagem
            // 
            porcetagem.BorderStyle = BorderStyle.FixedSingle;
            porcetagem.Location = new Point(743, 188);
            porcetagem.Name = "porcetagem";
            porcetagem.Size = new Size(135, 29);
            porcetagem.TabIndex = 8;
            // 
            // precoA
            // 
            precoA.BorderStyle = BorderStyle.FixedSingle;
            precoA.Location = new Point(743, 122);
            precoA.Name = "precoA";
            precoA.Size = new Size(135, 29);
            precoA.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(222, 267);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(396, 267);
            button2.Name = "button2";
            button2.Size = new Size(105, 34);
            button2.TabIndex = 12;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lista
            // 
            lista.BackgroundColor = SystemColors.ControlLight;
            lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lista.Location = new Point(57, 337);
            lista.Name = "lista";
            lista.RowTemplate.Height = 25;
            lista.Size = new Size(928, 267);
            lista.TabIndex = 13;
            lista.CellContentClick += lista_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(743, 257);
            label7.Name = "label7";
            label7.Size = new Size(29, 21);
            label7.TabIndex = 14;
            label7.Text = "R$";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(label7);
            Controls.Add(lista);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(precoA);
            Controls.Add(porcetagem);
            Controls.Add(descricao);
            Controls.Add(codigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox codigo;
        private TextBox descricao;
        private TextBox porcetagem;
        private TextBox precoA;
        private Button button1;
        private Button button2;
        private DataGridView lista;
        private Label label7;
    }
}