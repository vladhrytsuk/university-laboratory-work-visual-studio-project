﻿namespace Admin_Cosmetic
{
    partial class KOTV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KOTV));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_CosmeticDataSet = new Admin_Cosmetic.Admin_CosmeticDataSet();
            this.kOTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kOTVTableAdapter = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.KOTVTableAdapter();
            this.tableAdapterManager = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager();
            this.kOTVBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kOTVBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kOTVDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVBindingNavigator)).BeginInit();
            this.kOTVBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Квитанция об оплате услуг";
            // 
            // admin_CosmeticDataSet
            // 
            this.admin_CosmeticDataSet.DataSetName = "Admin_CosmeticDataSet";
            this.admin_CosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kOTVBindingSource
            // 
            this.kOTVBindingSource.DataMember = "KOTV";
            this.kOTVBindingSource.DataSource = this.admin_CosmeticDataSet;
            // 
            // kOTVTableAdapter
            // 
            this.kOTVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CosmeticTableAdapter = null;
            this.tableAdapterManager.CotalogTableAdapter = null;
            this.tableAdapterManager.DPRCTableAdapter = null;
            this.tableAdapterManager.KOTVTableAdapter = this.kOTVTableAdapter;
            this.tableAdapterManager.TariphsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ZNOYTableAdapter = null;
            // 
            // kOTVBindingNavigator
            // 
            this.kOTVBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kOTVBindingNavigator.BindingSource = this.kOTVBindingSource;
            this.kOTVBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kOTVBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kOTVBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kOTVBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kOTVBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kOTVBindingNavigatorSaveItem});
            this.kOTVBindingNavigator.Location = new System.Drawing.Point(0, 324);
            this.kOTVBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kOTVBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kOTVBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kOTVBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kOTVBindingNavigator.Name = "kOTVBindingNavigator";
            this.kOTVBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kOTVBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.kOTVBindingNavigator.TabIndex = 2;
            this.kOTVBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // kOTVBindingNavigatorSaveItem
            // 
            this.kOTVBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kOTVBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kOTVBindingNavigatorSaveItem.Image")));
            this.kOTVBindingNavigatorSaveItem.Name = "kOTVBindingNavigatorSaveItem";
            this.kOTVBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kOTVBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kOTVBindingNavigatorSaveItem.Click += new System.EventHandler(this.kOTVBindingNavigatorSaveItem_Click);
            // 
            // kOTVDataGridView
            // 
            this.kOTVDataGridView.AutoGenerateColumns = false;
            this.kOTVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kOTVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kOTVDataGridView.DataSource = this.kOTVBindingSource;
            this.kOTVDataGridView.Location = new System.Drawing.Point(0, 34);
            this.kOTVDataGridView.Name = "kOTVDataGridView";
            this.kOTVDataGridView.Size = new System.Drawing.Size(544, 287);
            this.kOTVDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_квитанции";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_квитанции";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_специалиста";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_специалиста";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_заказа";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_заказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_оплаты";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_оплаты";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Общая_стоимость_заказа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Общая_стоимость_заказа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // KOTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 349);
            this.Controls.Add(this.kOTVDataGridView);
            this.Controls.Add(this.kOTVBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "KOTV";
            this.Text = "Квитанция об оплате услуг";
            this.Load += new System.EventHandler(this.KOTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVBindingNavigator)).EndInit();
            this.kOTVBindingNavigator.ResumeLayout(false);
            this.kOTVBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kOTVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Admin_CosmeticDataSet admin_CosmeticDataSet;
        private System.Windows.Forms.BindingSource kOTVBindingSource;
        private Admin_CosmeticDataSetTableAdapters.KOTVTableAdapter kOTVTableAdapter;
        private Admin_CosmeticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kOTVBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kOTVBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kOTVDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}