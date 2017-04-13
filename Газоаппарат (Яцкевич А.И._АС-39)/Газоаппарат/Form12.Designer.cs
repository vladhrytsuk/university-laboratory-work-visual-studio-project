namespace Газоаппарат
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.брестГазDataSet = new Газоаппарат.БрестГазDataSet();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журнал_учета_заявок_на_ремонт_оборудованияTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.Журнал_учета_заявок_на_ремонт_оборудованияTableAdapter();
            this.tableAdapterManager = new Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator)).BeginInit();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // брестГазDataSet
            // 
            this.брестГазDataSet.DataSetName = "БрестГазDataSet";
            this.брестГазDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журнал_учета_заявок_на_ремонт_оборудованияBindingSource
            // 
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource.DataMember = "Журнал_учета_заявок_на_ремонт_оборудования";
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource.DataSource = this.брестГазDataSet;
            // 
            // журнал_учета_заявок_на_ремонт_оборудованияTableAdapter
            // 
            this.журнал_учета_заявок_на_ремонт_оборудованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_работTableAdapter = null;
            this.tableAdapterManager.Выполнение_работTableAdapter = null;
            this.tableAdapterManager.Журнал_учета_заявок_на_ремонт_оборудованияTableAdapter = this.журнал_учета_заявок_на_ремонт_оборудованияTableAdapter;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Карточка_складского_учетаTableAdapter = null;
            this.tableAdapterManager.Накладная_на_внутреннее_перемещение_оборудованияTableAdapter = null;
            this.tableAdapterManager.Наряд_заданиеTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Поставщик_оборудованияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_работTableAdapter = null;
            // 
            // журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator
            // 
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.BindingSource = this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem});
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.Name = "журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator";
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.TabIndex = 0;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // журнал_учета_заявок_на_ремонт_оборудованияDataGridView
            // 
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.AutoGenerateColumns = false;
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.DataSource = this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource;
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.Location = new System.Drawing.Point(22, 55);
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.Name = "журнал_учета_заявок_на_ремонт_оборудованияDataGridView";
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.Size = new System.Drawing.Size(345, 136);
            this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_документа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_документа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_начала_ведения_журнала";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_начала_ведения_журнала";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_заявки";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_заявки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem
            // 
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Image")));
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Name = "журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem";
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem.Click += new System.EventHandler(this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Журнал учета заявок на ремонт оборудования";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView);
            this.Controls.Add(this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator);
            this.Name = "Form12";
            this.Text = "Журнал учета заявок на ремонт оборудования";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator)).EndInit();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.ResumeLayout(false);
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_учета_заявок_на_ремонт_оборудованияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БрестГазDataSet брестГазDataSet;
        private System.Windows.Forms.BindingSource журнал_учета_заявок_на_ремонт_оборудованияBindingSource;
        private БрестГазDataSetTableAdapters.Журнал_учета_заявок_на_ремонт_оборудованияTableAdapter журнал_учета_заявок_на_ремонт_оборудованияTableAdapter;
        private БрестГазDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator журнал_учета_заявок_на_ремонт_оборудованияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView журнал_учета_заявок_на_ремонт_оборудованияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}