namespace BankCredit
{
    partial class OrdinaryUser
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
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.idb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customeridb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusb = new System.Windows.Forms.TextBox();
            this.dateb = new System.Windows.Forms.DateTimePicker();
            this.addressb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.create2 = new System.Windows.Forms.Button();
            this.update2 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.view2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.name2b = new System.Windows.Forms.TextBox();
            this.description2b = new System.Windows.Forms.TextBox();
            this.color2b = new System.Windows.Forms.TextBox();
            this.size2b = new System.Windows.Forms.TextBox();
            this.price2b = new System.Windows.Forms.TextBox();
            this.stock2b = new System.Windows.Forms.TextBox();
            this.id2b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apld = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cantitateb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getpb = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(23, 318);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 56);
            this.add.TabIndex = 0;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(137, 318);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 56);
            this.update.TabIndex = 1;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(261, 317);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 57);
            this.view.TabIndex = 2;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            // 
            // idb
            // 
            this.idb.Location = new System.Drawing.Point(23, 48);
            this.idb.Name = "idb";
            this.idb.Size = new System.Drawing.Size(100, 26);
            this.idb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // customeridb
            // 
            this.customeridb.Location = new System.Drawing.Point(23, 120);
            this.customeridb.Name = "customeridb";
            this.customeridb.Size = new System.Drawing.Size(100, 26);
            this.customeridb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "customerId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // statusb
            // 
            this.statusb.Location = new System.Drawing.Point(27, 276);
            this.statusb.Name = "statusb";
            this.statusb.Size = new System.Drawing.Size(100, 26);
            this.statusb.TabIndex = 8;
            // 
            // dateb
            // 
            this.dateb.Location = new System.Drawing.Point(23, 200);
            this.dateb.Name = "dateb";
            this.dateb.Size = new System.Drawing.Size(313, 26);
            this.dateb.TabIndex = 9;
            // 
            // addressb
            // 
            this.addressb.Location = new System.Drawing.Point(147, 48);
            this.addressb.Name = "addressb";
            this.addressb.Size = new System.Drawing.Size(215, 26);
            this.addressb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1071, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "product";
            // 
            // create2
            // 
            this.create2.Location = new System.Drawing.Point(604, 332);
            this.create2.Name = "create2";
            this.create2.Size = new System.Drawing.Size(75, 48);
            this.create2.TabIndex = 13;
            this.create2.Text = "create2";
            this.create2.UseVisualStyleBackColor = true;
            this.create2.Click += new System.EventHandler(this.create2_Click);
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(702, 332);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(94, 48);
            this.update2.TabIndex = 13;
            this.update2.Text = "update2";
            this.update2.UseVisualStyleBackColor = true;
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(802, 332);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(75, 54);
            this.delete2.TabIndex = 13;
            this.delete2.Text = "delete2";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // view2
            // 
            this.view2.Location = new System.Drawing.Point(905, 332);
            this.view2.Name = "view2";
            this.view2.Size = new System.Drawing.Size(75, 54);
            this.view2.TabIndex = 13;
            this.view2.Text = "view2";
            this.view2.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(611, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(798, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(86, 20);
            this.description.TabIndex = 4;
            this.description.Text = "description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(611, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(798, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "stock";
            // 
            // name2b
            // 
            this.name2b.Location = new System.Drawing.Point(602, 48);
            this.name2b.Name = "name2b";
            this.name2b.Size = new System.Drawing.Size(100, 26);
            this.name2b.TabIndex = 3;
            // 
            // description2b
            // 
            this.description2b.Location = new System.Drawing.Point(788, 48);
            this.description2b.Name = "description2b";
            this.description2b.Size = new System.Drawing.Size(346, 26);
            this.description2b.TabIndex = 3;
            // 
            // color2b
            // 
            this.color2b.Location = new System.Drawing.Point(604, 155);
            this.color2b.Name = "color2b";
            this.color2b.Size = new System.Drawing.Size(98, 26);
            this.color2b.TabIndex = 3;
            // 
            // size2b
            // 
            this.size2b.Location = new System.Drawing.Point(790, 155);
            this.size2b.Name = "size2b";
            this.size2b.Size = new System.Drawing.Size(156, 26);
            this.size2b.TabIndex = 3;
            // 
            // price2b
            // 
            this.price2b.Location = new System.Drawing.Point(604, 250);
            this.price2b.Name = "price2b";
            this.price2b.Size = new System.Drawing.Size(98, 26);
            this.price2b.TabIndex = 3;
            // 
            // stock2b
            // 
            this.stock2b.Location = new System.Drawing.Point(790, 250);
            this.stock2b.Name = "stock2b";
            this.stock2b.Size = new System.Drawing.Size(156, 26);
            this.stock2b.TabIndex = 3;
            // 
            // id2b
            // 
            this.id2b.Location = new System.Drawing.Point(1027, 155);
            this.id2b.Name = "id2b";
            this.id2b.Size = new System.Drawing.Size(98, 26);
            this.id2b.TabIndex = 3;
            this.id2b.TextChanged += new System.EventHandler(this.id2b_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1023, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "id";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // apld
            // 
            this.apld.Location = new System.Drawing.Point(604, 414);
            this.apld.Name = "apld";
            this.apld.Size = new System.Drawing.Size(214, 41);
            this.apld.TabIndex = 14;
            this.apld.Text = "Adauga produs la comanda";
            this.apld.UseVisualStyleBackColor = true;
            this.apld.Click += new System.EventHandler(this.apld_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "cantitate";
            // 
            // cantitateb
            // 
            this.cantitateb.Location = new System.Drawing.Point(393, 414);
            this.cantitateb.Name = "cantitateb";
            this.cantitateb.Size = new System.Drawing.Size(156, 26);
            this.cantitateb.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAMEE,
            this.D2,
            this.COLOR,
            this.SIZEE,
            this.PRICE,
            this.STOCK});
            this.dataGridView1.Location = new System.Drawing.Point(249, 504);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(863, 143);
            this.dataGridView1.TabIndex = 16;
            // 
            // getpb
            // 
            this.getpb.Location = new System.Drawing.Point(27, 598);
            this.getpb.Name = "getpb";
            this.getpb.Size = new System.Drawing.Size(185, 58);
            this.getpb.TabIndex = 17;
            this.getpb.Text = "Get Products";
            this.getpb.UseVisualStyleBackColor = true;
            this.getpb.Click += new System.EventHandler(this.getpb_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NAMEE
            // 
            this.NAMEE.HeaderText = "NAME";
            this.NAMEE.Name = "NAMEE";
            // 
            // D2
            // 
            this.D2.HeaderText = "DESCRIPTION";
            this.D2.Name = "D2";
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            // 
            // SIZEE
            // 
            this.SIZEE.HeaderText = "SIZE";
            this.SIZEE.Name = "SIZEE";
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // STOCK
            // 
            this.STOCK.HeaderText = "STOCK";
            this.STOCK.Name = "STOCK";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 693);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // OrdinaryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 693);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.getpb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.apld);
            this.Controls.Add(this.view2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.create2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressb);
            this.Controls.Add(this.dateb);
            this.Controls.Add(this.statusb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customeridb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantitateb);
            this.Controls.Add(this.stock2b);
            this.Controls.Add(this.price2b);
            this.Controls.Add(this.size2b);
            this.Controls.Add(this.id2b);
            this.Controls.Add(this.color2b);
            this.Controls.Add(this.description2b);
            this.Controls.Add(this.name2b);
            this.Controls.Add(this.idb);
            this.Controls.Add(this.view);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Name = "OrdinaryUser";
            this.Text = "Ordinary User";
            this.Load += new System.EventHandler(this.OrdinaryUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox idb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customeridb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusb;
        private System.Windows.Forms.DateTimePicker dateb;
        private System.Windows.Forms.TextBox addressb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button create2;
        private System.Windows.Forms.Button update2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button view2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox name2b;
        private System.Windows.Forms.TextBox description2b;
        private System.Windows.Forms.TextBox color2b;
        private System.Windows.Forms.TextBox size2b;
        private System.Windows.Forms.TextBox price2b;
        private System.Windows.Forms.TextBox stock2b;
        private System.Windows.Forms.TextBox id2b;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button apld;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cantitateb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
        private System.Windows.Forms.Splitter splitter1;
    }
}