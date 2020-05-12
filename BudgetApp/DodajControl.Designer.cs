using System.Data.SQLite;

namespace BudgetApp
{
    partial class DodajControl
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
        

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajControl));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Income = new System.Windows.Forms.Button();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtIncomeTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaStalychWydatkow = new System.Windows.Forms.ListView();
            this.listaWydatkow = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listaPrzychodow = new System.Windows.Forms.ListView();
            this.txtFixedExpenseTitle = new System.Windows.Forms.TextBox();
            this.txtFixedExpenseAmount = new System.Windows.Forms.TextBox();
            this.btn_FixedExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(615, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Wydatki stałe";
            // 
            // btn_Expense
            // 
            this.btn_Expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Expense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Expense.Image = ((System.Drawing.Image)(resources.GetObject("btn_Expense.Image")));
            this.btn_Expense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Expense.Location = new System.Drawing.Point(360, 355);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(101, 46);
            this.btn_Expense.TabIndex = 21;
            this.btn_Expense.Text = "Dodaj";
            this.btn_Expense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Expense.UseVisualStyleBackColor = true;
            this.btn_Expense.Click += new System.EventHandler(this.btn_Expense_Click);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpenseAmount.Location = new System.Drawing.Point(393, 151);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(110, 20);
            this.txtExpenseAmount.TabIndex = 20;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpenseTitle.Location = new System.Drawing.Point(393, 94);
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(110, 20);
            this.txtExpenseTitle.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(312, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kwota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(312, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tytuł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(356, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Wydatki";
            // 
            // btn_Income
            // 
            this.btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Income.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Income.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Income.Image = ((System.Drawing.Image)(resources.GetObject("btn_Income.Image")));
            this.btn_Income.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Income.Location = new System.Drawing.Point(82, 355);
            this.btn_Income.Name = "btn_Income";
            this.btn_Income.Size = new System.Drawing.Size(101, 46);
            this.btn_Income.TabIndex = 31;
            this.btn_Income.Text = "Dodaj";
            this.btn_Income.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Income.UseVisualStyleBackColor = true;
            this.btn_Income.Click += new System.EventHandler(this.btn_Income_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtIncomeAmount.Location = new System.Drawing.Point(107, 151);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(110, 20);
            this.txtIncomeAmount.TabIndex = 30;
            // 
            // txtIncomeTitle
            // 
            this.txtIncomeTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtIncomeTitle.Location = new System.Drawing.Point(107, 95);
            this.txtIncomeTitle.Name = "txtIncomeTitle";
            this.txtIncomeTitle.Size = new System.Drawing.Size(110, 20);
            this.txtIncomeTitle.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(35, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kwota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tytuł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Przychody";
            // 
            // listaStalychWydatkow
            // 
            this.listaStalychWydatkow.Location = new System.Drawing.Point(586, 233);
            this.listaStalychWydatkow.Name = "listaStalychWydatkow";
            this.listaStalychWydatkow.Size = new System.Drawing.Size(190, 97);
            this.listaStalychWydatkow.TabIndex = 32;
            this.listaStalychWydatkow.UseCompatibleStateImageBehavior = false;
            // 
            // listaWydatkow
            // 
            this.listaWydatkow.Location = new System.Drawing.Point(316, 233);
            this.listaWydatkow.Name = "listaWydatkow";
            this.listaWydatkow.Size = new System.Drawing.Size(187, 97);
            this.listaWydatkow.TabIndex = 33;
            this.listaWydatkow.UseCompatibleStateImageBehavior = false;
            this.listaWydatkow.SelectedIndexChanged += new System.EventHandler(this.listaWydatkow_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(582, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tytuł";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(582, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Kwota";
            // 
            // listaPrzychodow
            // 
            this.listaPrzychodow.Location = new System.Drawing.Point(39, 233);
            this.listaPrzychodow.Name = "listaPrzychodow";
            this.listaPrzychodow.Size = new System.Drawing.Size(187, 97);
            this.listaPrzychodow.TabIndex = 36;
            this.listaPrzychodow.UseCompatibleStateImageBehavior = false;
            // 
            // txtFixedExpenseTitle
            // 
            this.txtFixedExpenseTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtFixedExpenseTitle.Location = new System.Drawing.Point(649, 96);
            this.txtFixedExpenseTitle.Name = "txtFixedExpenseTitle";
            this.txtFixedExpenseTitle.Size = new System.Drawing.Size(110, 20);
            this.txtFixedExpenseTitle.TabIndex = 37;
            // 
            // txtFixedExpenseAmount
            // 
            this.txtFixedExpenseAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtFixedExpenseAmount.Location = new System.Drawing.Point(649, 149);
            this.txtFixedExpenseAmount.Name = "txtFixedExpenseAmount";
            this.txtFixedExpenseAmount.Size = new System.Drawing.Size(110, 20);
            this.txtFixedExpenseAmount.TabIndex = 38;
            // 
            // btn_FixedExpense
            // 
            this.btn_FixedExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FixedExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_FixedExpense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_FixedExpense.Image = ((System.Drawing.Image)(resources.GetObject("btn_FixedExpense.Image")));
            this.btn_FixedExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FixedExpense.Location = new System.Drawing.Point(637, 355);
            this.btn_FixedExpense.Name = "btn_FixedExpense";
            this.btn_FixedExpense.Size = new System.Drawing.Size(101, 46);
            this.btn_FixedExpense.TabIndex = 39;
            this.btn_FixedExpense.Text = "Dodaj";
            this.btn_FixedExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FixedExpense.UseVisualStyleBackColor = true;
            this.btn_FixedExpense.Click += new System.EventHandler(this.btn_FixedExpense_Click);
            // 
            // DodajControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_FixedExpense);
            this.Controls.Add(this.txtFixedExpenseAmount);
            this.Controls.Add(this.txtFixedExpenseTitle);
            this.Controls.Add(this.listaPrzychodow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listaWydatkow);
            this.Controls.Add(this.listaStalychWydatkow);
            this.Controls.Add(this.btn_Income);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.txtIncomeTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Expense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExpenseTitle);
            this.Name = "DodajControl";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.DodajControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Expense;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Income;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtIncomeTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaStalychWydatkow;
        private System.Windows.Forms.ListView listaWydatkow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listaPrzychodow;
        private System.Windows.Forms.TextBox txtFixedExpenseTitle;
        private System.Windows.Forms.TextBox txtFixedExpenseAmount;
        private System.Windows.Forms.Button btn_FixedExpense;
    }
}
