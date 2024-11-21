namespace Anticafe
{
    partial class Home
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
            this.Date = new System.Windows.Forms.TextBox();
            this.SearchTable = new System.Windows.Forms.Button();
            this.AddTable = new System.Windows.Forms.Button();
            this.ChangeMenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_Do = new System.Windows.Forms.Label();
            this.delete_Order = new System.Windows.Forms.Button();
            this.resultOrder = new System.Windows.Forms.Button();
            this.changeOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Table = new System.Windows.Forms.TextBox();
            this.DeleteTable = new System.Windows.Forms.Button();
            this.FreeTable = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.countTable4 = new System.Windows.Forms.Label();
            this.countTable3 = new System.Windows.Forms.Label();
            this.countTable2 = new System.Windows.Forms.Label();
            this.countTable1 = new System.Windows.Forms.Label();
            this.count4 = new System.Windows.Forms.Label();
            this.Count3 = new System.Windows.Forms.Label();
            this.Count2 = new System.Windows.Forms.Label();
            this.Count1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(18, 38);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(254, 22);
            this.Date.TabIndex = 0;
            // 
            // SearchTable
            // 
            this.SearchTable.Location = new System.Drawing.Point(140, 81);
            this.SearchTable.Name = "SearchTable";
            this.SearchTable.Size = new System.Drawing.Size(116, 60);
            this.SearchTable.TabIndex = 1;
            this.SearchTable.Text = "Какие столы свободны?";
            this.SearchTable.UseVisualStyleBackColor = true;
            this.SearchTable.Click += new System.EventHandler(this.SearchTable_Click);
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(18, 81);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(116, 60);
            this.AddTable.TabIndex = 2;
            this.AddTable.Text = "Добавить стол";
            this.AddTable.UseVisualStyleBackColor = true;
            this.AddTable.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Location = new System.Drawing.Point(262, 81);
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(116, 60);
            this.ChangeMenu.TabIndex = 3;
            this.ChangeMenu.Text = "Изменить ассортимент";
            this.ChangeMenu.UseVisualStyleBackColor = true;
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.check_Do);
            this.groupBox1.Controls.Add(this.delete_Order);
            this.groupBox1.Controls.Add(this.resultOrder);
            this.groupBox1.Controls.Add(this.changeOrder);
            this.groupBox1.Controls.Add(this.addOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // check_Do
            // 
            this.check_Do.AutoSize = true;
            this.check_Do.Location = new System.Drawing.Point(99, 275);
            this.check_Do.Name = "check_Do";
            this.check_Do.Size = new System.Drawing.Size(44, 16);
            this.check_Do.TabIndex = 4;
            this.check_Do.Text = "label2";
            // 
            // delete_Order
            // 
            this.delete_Order.Location = new System.Drawing.Point(433, 21);
            this.delete_Order.Name = "delete_Order";
            this.delete_Order.Size = new System.Drawing.Size(136, 60);
            this.delete_Order.TabIndex = 3;
            this.delete_Order.Text = "Удалить все заказы";
            this.delete_Order.UseVisualStyleBackColor = true;
            this.delete_Order.Click += new System.EventHandler(this.delete_Order_Click);
            // 
            // resultOrder
            // 
            this.resultOrder.Location = new System.Drawing.Point(291, 21);
            this.resultOrder.Name = "resultOrder";
            this.resultOrder.Size = new System.Drawing.Size(136, 60);
            this.resultOrder.TabIndex = 2;
            this.resultOrder.Text = "Рассчитать посетителей";
            this.resultOrder.UseVisualStyleBackColor = true;
            this.resultOrder.Click += new System.EventHandler(this.resultOrder_Click);
            // 
            // changeOrder
            // 
            this.changeOrder.Location = new System.Drawing.Point(149, 21);
            this.changeOrder.Name = "changeOrder";
            this.changeOrder.Size = new System.Drawing.Size(136, 60);
            this.changeOrder.TabIndex = 1;
            this.changeOrder.Text = "Изменить игру";
            this.changeOrder.UseVisualStyleBackColor = true;
            this.changeOrder.Click += new System.EventHandler(this.changeOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(7, 21);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(136, 60);
            this.addOrder.TabIndex = 0;
            this.addOrder.Text = "Заказать игру";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Delete_Table);
            this.groupBox2.Controls.Add(this.DeleteTable);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Удалить стол по его номеру:";
            // 
            // Delete_Table
            // 
            this.Delete_Table.Location = new System.Drawing.Point(160, 59);
            this.Delete_Table.Name = "Delete_Table";
            this.Delete_Table.Size = new System.Drawing.Size(125, 22);
            this.Delete_Table.TabIndex = 6;
            // 
            // DeleteTable
            // 
            this.DeleteTable.Location = new System.Drawing.Point(6, 26);
            this.DeleteTable.Name = "DeleteTable";
            this.DeleteTable.Size = new System.Drawing.Size(95, 60);
            this.DeleteTable.TabIndex = 5;
            this.DeleteTable.Text = "Удалить стол";
            this.DeleteTable.UseVisualStyleBackColor = true;
            this.DeleteTable.Click += new System.EventHandler(this.DeleteTable_Click);
            // 
            // FreeTable
            // 
            this.FreeTable.AutoSize = true;
            this.FreeTable.Location = new System.Drawing.Point(12, 154);
            this.FreeTable.Name = "FreeTable";
            this.FreeTable.Size = new System.Drawing.Size(44, 16);
            this.FreeTable.TabIndex = 0;
            this.FreeTable.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.countTable4);
            this.groupBox3.Controls.Add(this.countTable3);
            this.groupBox3.Controls.Add(this.countTable2);
            this.groupBox3.Controls.Add(this.countTable1);
            this.groupBox3.Controls.Add(this.count4);
            this.groupBox3.Controls.Add(this.Count3);
            this.groupBox3.Controls.Add(this.Count2);
            this.groupBox3.Controls.Add(this.Count1);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о количестве столиков и гостей";
            // 
            // countTable4
            // 
            this.countTable4.AutoSize = true;
            this.countTable4.Location = new System.Drawing.Point(162, 122);
            this.countTable4.Name = "countTable4";
            this.countTable4.Size = new System.Drawing.Size(44, 16);
            this.countTable4.TabIndex = 13;
            this.countTable4.Text = "label9";
            // 
            // countTable3
            // 
            this.countTable3.AutoSize = true;
            this.countTable3.Location = new System.Drawing.Point(162, 92);
            this.countTable3.Name = "countTable3";
            this.countTable3.Size = new System.Drawing.Size(44, 16);
            this.countTable3.TabIndex = 12;
            this.countTable3.Text = "label8";
            // 
            // countTable2
            // 
            this.countTable2.AutoSize = true;
            this.countTable2.Location = new System.Drawing.Point(162, 60);
            this.countTable2.Name = "countTable2";
            this.countTable2.Size = new System.Drawing.Size(44, 16);
            this.countTable2.TabIndex = 11;
            this.countTable2.Text = "label7";
            // 
            // countTable1
            // 
            this.countTable1.AutoSize = true;
            this.countTable1.Location = new System.Drawing.Point(162, 30);
            this.countTable1.Name = "countTable1";
            this.countTable1.Size = new System.Drawing.Size(44, 16);
            this.countTable1.TabIndex = 10;
            this.countTable1.Text = "label6";
            // 
            // count4
            // 
            this.count4.AutoSize = true;
            this.count4.Location = new System.Drawing.Point(6, 122);
            this.count4.Name = "count4";
            this.count4.Size = new System.Drawing.Size(135, 16);
            this.count4.TabIndex = 9;
            this.count4.Text = "Количество гостей:";
            // 
            // Count3
            // 
            this.Count3.AutoSize = true;
            this.Count3.Location = new System.Drawing.Point(6, 92);
            this.Count3.Name = "Count3";
            this.Count3.Size = new System.Drawing.Size(57, 16);
            this.Count3.TabIndex = 8;
            this.Count3.Text = "Занято:";
            // 
            // Count2
            // 
            this.Count2.AutoSize = true;
            this.Count2.Location = new System.Drawing.Point(6, 60);
            this.Count2.Name = "Count2";
            this.Count2.Size = new System.Drawing.Size(146, 16);
            this.Count2.TabIndex = 7;
            this.Count2.Text = "Свободных столиков:";
            // 
            // Count1
            // 
            this.Count1.AutoSize = true;
            this.Count1.Location = new System.Drawing.Point(8, 30);
            this.Count1.Name = "Count1";
            this.Count1.Size = new System.Drawing.Size(137, 16);
            this.Count1.TabIndex = 6;
            this.Count1.Text = "Количество столов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Состояние столов\r\n";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(474, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 243);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(451, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 38);
            this.name.TabIndex = 8;
            this.name.Text = "ИС Антикафе";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 813);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FreeTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeMenu);
            this.Controls.Add(this.AddTable);
            this.Controls.Add(this.SearchTable);
            this.Controls.Add(this.Date);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Button SearchTable;
        private System.Windows.Forms.Button AddTable;
        private System.Windows.Forms.Button ChangeMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_Order;
        private System.Windows.Forms.Button resultOrder;
        private System.Windows.Forms.Button changeOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Delete_Table;
        private System.Windows.Forms.Button DeleteTable;
        private System.Windows.Forms.Label FreeTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label countTable4;
        private System.Windows.Forms.Label countTable3;
        private System.Windows.Forms.Label countTable2;
        private System.Windows.Forms.Label countTable1;
        private System.Windows.Forms.Label count4;
        private System.Windows.Forms.Label Count3;
        private System.Windows.Forms.Label Count2;
        private System.Windows.Forms.Label Count1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label check_Do;
    }
}