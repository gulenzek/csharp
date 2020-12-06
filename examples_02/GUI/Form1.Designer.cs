
namespace GUI
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
            this.personsListView = new System.Windows.Forms.ListView();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.gendersComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.stockAmountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderSaveButton = new System.Windows.Forms.Button();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.personsComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPersonButton = new System.Windows.Forms.Button();
            this.searchedPersonKeyTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.HideSelection = false;
            this.personsListView.Location = new System.Drawing.Point(6, 6);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(310, 332);
            this.personsListView.TabIndex = 0;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(322, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(322, 71);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // gendersComboBox
            // 
            this.gendersComboBox.FormattingEnabled = true;
            this.gendersComboBox.Location = new System.Drawing.Point(322, 116);
            this.gendersComboBox.Name = "gendersComboBox";
            this.gendersComboBox.Size = new System.Drawing.Size(121, 24);
            this.gendersComboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(322, 144);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(121, 30);
            this.productSaveButton.TabIndex = 9;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // stockAmountTextBox
            // 
            this.stockAmountTextBox.Location = new System.Drawing.Point(322, 71);
            this.stockAmountTextBox.Name = "stockAmountTextBox";
            this.stockAmountTextBox.Size = new System.Drawing.Size(121, 22);
            this.stockAmountTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(322, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(6, 6);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(310, 332);
            this.productsListView.TabIndex = 5;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(322, 116);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(121, 22);
            this.unitPriceTextBox.TabIndex = 10;
            // 
            // orderSaveButton
            // 
            this.orderSaveButton.Location = new System.Drawing.Point(322, 148);
            this.orderSaveButton.Name = "orderSaveButton";
            this.orderSaveButton.Size = new System.Drawing.Size(121, 30);
            this.orderSaveButton.TabIndex = 14;
            this.orderSaveButton.Text = "Save";
            this.orderSaveButton.UseVisualStyleBackColor = true;
            this.orderSaveButton.Click += new System.EventHandler(this.orderSaveButton_Click);
            // 
            // ordersListView
            // 
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(6, 6);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(310, 332);
            this.ordersListView.TabIndex = 11;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            // 
            // productsComboBox
            // 
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(322, 26);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(121, 24);
            this.productsComboBox.TabIndex = 15;
            // 
            // personsComboBox
            // 
            this.personsComboBox.FormattingEnabled = true;
            this.personsComboBox.Location = new System.Drawing.Point(322, 73);
            this.personsComboBox.Name = "personsComboBox";
            this.personsComboBox.Size = new System.Drawing.Size(121, 24);
            this.personsComboBox.TabIndex = 16;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(322, 120);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 22);
            this.amountTextBox.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 374);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchPersonButton);
            this.tabPage1.Controls.Add(this.searchedPersonKeyTextBox);
            this.tabPage1.Controls.Add(this.personsListView);
            this.tabPage1.Controls.Add(this.firstNameTextBox);
            this.tabPage1.Controls.Add(this.lastNameTextBox);
            this.tabPage1.Controls.Add(this.gendersComboBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Searched Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // searchPersonButton
            // 
            this.searchPersonButton.Location = new System.Drawing.Point(322, 227);
            this.searchPersonButton.Name = "searchPersonButton";
            this.searchPersonButton.Size = new System.Drawing.Size(121, 30);
            this.searchPersonButton.TabIndex = 6;
            this.searchPersonButton.Text = "Search";
            this.searchPersonButton.UseVisualStyleBackColor = true;
            this.searchPersonButton.Click += new System.EventHandler(this.searchPersonButton_Click);
            // 
            // searchedPersonKeyTextBox
            // 
            this.searchedPersonKeyTextBox.Location = new System.Drawing.Point(322, 199);
            this.searchedPersonKeyTextBox.Name = "searchedPersonKeyTextBox";
            this.searchedPersonKeyTextBox.Size = new System.Drawing.Size(121, 22);
            this.searchedPersonKeyTextBox.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.productsListView);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(this.stockAmountTextBox);
            this.tabPage2.Controls.Add(this.productSaveButton);
            this.tabPage2.Controls.Add(this.unitPriceTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.ordersListView);
            this.tabPage3.Controls.Add(this.amountTextBox);
            this.tabPage3.Controls.Add(this.orderSaveButton);
            this.tabPage3.Controls.Add(this.personsComboBox);
            this.tabPage3.Controls.Add(this.productsComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(452, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Person";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 395);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Order Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox gendersComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.TextBox stockAmountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Button orderSaveButton;
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.ComboBox personsComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button searchPersonButton;
        private System.Windows.Forms.TextBox searchedPersonKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

