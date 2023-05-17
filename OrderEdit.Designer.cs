namespace ELMA
{
    partial class OrderEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createdAtTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.orderDetailsView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vesselNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(248, 18);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ReadOnly = true;
            this.orderIdTextBox.Size = new System.Drawing.Size(121, 22);
            this.orderIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата создания";
            // 
            // createdAtTextBox
            // 
            this.createdAtTextBox.Enabled = false;
            this.createdAtTextBox.Location = new System.Drawing.Point(228, 55);
            this.createdAtTextBox.Name = "createdAtTextBox";
            this.createdAtTextBox.Size = new System.Drawing.Size(156, 22);
            this.createdAtTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(228, 94);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(156, 24);
            this.statusComboBox.TabIndex = 5;
            // 
            // orderDetailsView
            // 
            this.orderDetailsView.AllowUserToAddRows = false;
            this.orderDetailsView.AllowUserToDeleteRows = false;
            this.orderDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsView.Location = new System.Drawing.Point(12, 372);
            this.orderDetailsView.Name = "orderDetailsView";
            this.orderDetailsView.ReadOnly = true;
            this.orderDetailsView.RowHeadersWidth = 51;
            this.orderDetailsView.RowTemplate.Height = 24;
            this.orderDetailsView.Size = new System.Drawing.Size(576, 245);
            this.orderDetailsView.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Состав заказа";
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(262, 643);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(92, 31);
            this.saveOrderButton.TabIndex = 8;
            this.saveOrderButton.Text = "Сохранить";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(228, 139);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(281, 86);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DisplayMember = "personName";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(228, 242);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(203, 24);
            this.clientComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Клиент";
            // 
            // vesselNumberTextBox
            // 
            this.vesselNumberTextBox.Location = new System.Drawing.Point(228, 285);
            this.vesselNumberTextBox.Name = "vesselNumberTextBox";
            this.vesselNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.vesselNumberTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер сосуда";
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 686);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vesselNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderDetailsView);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createdAtTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderEdit";
            this.Text = "ЭЛМА: Редактирование заказа";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createdAtTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView orderDetailsView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vesselNumberTextBox;
        private System.Windows.Forms.Label label7;
    }
}