
namespace OrderManager
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.personSaveButton = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.stockAmountTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderSaveButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.personComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 26);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(12, 44);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 26);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(12, 76);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 28);
            this.genderComboBox.TabIndex = 2;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Location = new System.Drawing.Point(139, 12);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.RowHeadersWidth = 62;
            this.personsDataGridView.RowTemplate.Height = 28;
            this.personsDataGridView.Size = new System.Drawing.Size(649, 426);
            this.personsDataGridView.TabIndex = 3;
            this.personsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsDataGridView_CellContentClick);
            this.personsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsDataGridView_CellValueChanged);
            // 
            // personSaveButton
            // 
            this.personSaveButton.Location = new System.Drawing.Point(12, 110);
            this.personSaveButton.Name = "personSaveButton";
            this.personSaveButton.Size = new System.Drawing.Size(121, 38);
            this.personSaveButton.TabIndex = 4;
            this.personSaveButton.Text = "Save";
            this.personSaveButton.UseVisualStyleBackColor = true;
            this.personSaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(794, 110);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(121, 38);
            this.productSaveButton.TabIndex = 8;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(794, 44);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(121, 26);
            this.unitPriceTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(794, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // stockAmountTextBox
            // 
            this.stockAmountTextBox.Location = new System.Drawing.Point(794, 78);
            this.stockAmountTextBox.Name = "stockAmountTextBox";
            this.stockAmountTextBox.Size = new System.Drawing.Size(121, 26);
            this.stockAmountTextBox.TabIndex = 9;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(921, 12);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(665, 426);
            this.productsDataGridView.TabIndex = 10;
            // 
            // orderSaveButton
            // 
            this.orderSaveButton.Location = new System.Drawing.Point(12, 579);
            this.orderSaveButton.Name = "orderSaveButton";
            this.orderSaveButton.Size = new System.Drawing.Size(121, 38);
            this.orderSaveButton.TabIndex = 15;
            this.orderSaveButton.Text = "Save";
            this.orderSaveButton.UseVisualStyleBackColor = true;
            this.orderSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(139, 481);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 62;
            this.ordersDataGridView.RowTemplate.Height = 28;
            this.ordersDataGridView.Size = new System.Drawing.Size(649, 426);
            this.ordersDataGridView.TabIndex = 14;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(12, 545);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 28);
            this.productComboBox.TabIndex = 13;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(12, 481);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 26);
            this.amountTextBox.TabIndex = 11;
            // 
            // personComboBox
            // 
            this.personComboBox.FormattingEnabled = true;
            this.personComboBox.Location = new System.Drawing.Point(12, 511);
            this.personComboBox.Name = "personComboBox";
            this.personComboBox.Size = new System.Drawing.Size(121, 28);
            this.personComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 981);
            this.Controls.Add(this.personComboBox);
            this.Controls.Add(this.orderSaveButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.stockAmountTextBox);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.personSaveButton);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.Button personSaveButton;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox stockAmountTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button orderSaveButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox personComboBox;
    }
}

