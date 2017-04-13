namespace Газоаппарат
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.брестГазDataSet = new Газоаппарат.БрестГазDataSet();
            this.поставщик_оборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщик_оборудованияTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.Поставщик_оборудованияTableAdapter();
            this.tableAdapterManager = new Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager();
            this.поставщик_оборудованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставщик_оборудованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.поставщик_оборудованияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияBindingNavigator)).BeginInit();
            this.поставщик_оборудованияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочник по поставщикам оборудования";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // брестГазDataSet
            // 
            this.брестГазDataSet.DataSetName = "БрестГазDataSet";
            this.брестГазDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщик_оборудованияBindingSource
            // 
            this.поставщик_оборудованияBindingSource.DataMember = "Поставщик_оборудования";
            this.поставщик_оборудованияBindingSource.DataSource = this.брестГазDataSet;
            // 
            // поставщик_оборудованияTableAdapter
            // 
            this.поставщик_оборудованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_работTableAdapter = null;
            this.tableAdapterManager.Выполнение_работTableAdapter = null;
            this.tableAdapterManager.Журнал_учета_заявок_на_ремонт_оборудованияTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Карточка_складского_учетаTableAdapter = null;
            this.tableAdapterManager.Накладная_на_внутреннее_перемещение_оборудованияTableAdapter = null;
            this.tableAdapterManager.Наряд_заданиеTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Поставщик_оборудованияTableAdapter = this.поставщик_оборудованияTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_работTableAdapter = null;
            // 
            // поставщик_оборудованияBindingNavigator
            // 
            this.поставщик_оборудованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщик_оборудованияBindingNavigator.BindingSource = this.поставщик_оборудованияBindingSource;
            this.поставщик_оборудованияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщик_оборудованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщик_оборудованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщик_оборудованияBindingNavigatorSaveItem});
            this.поставщик_оборудованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщик_оборудованияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщик_оборудованияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщик_оборудованияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщик_оборудованияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщик_оборудованияBindingNavigator.Name = "поставщик_оборудованияBindingNavigator";
            this.поставщик_оборудованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщик_оборудованияBindingNavigator.Size = new System.Drawing.Size(364, 25);
            this.поставщик_оборудованияBindingNavigator.TabIndex = 2;
            this.поставщик_оборудованияBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // поставщик_оборудованияBindingNavigatorSaveItem
            // 
            this.поставщик_оборудованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщик_оборудованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщик_оборудованияBindingNavigatorSaveItem.Image")));
            this.поставщик_оборудованияBindingNavigatorSaveItem.Name = "поставщик_оборудованияBindingNavigatorSaveItem";
            this.поставщик_оборудованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.поставщик_оборудованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщик_оборудованияBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщик_оборудованияBindingNavigatorSaveItem_Click);
            // 
            // поставщик_оборудованияDataGridView
            // 
            this.поставщик_оборудованияDataGridView.AutoGenerateColumns = false;
            this.поставщик_оборудованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставщик_оборудованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.поставщик_оборудованияDataGridView.DataSource = this.поставщик_оборудованияBindingSource;
            this.поставщик_оборудованияDataGridView.Location = new System.Drawing.Point(12, 62);
            this.поставщик_оборудованияDataGridView.Name = "поставщик_оборудованияDataGridView";
            this.поставщик_оборудованияDataGridView.Size = new System.Drawing.Size(345, 171);
            this.поставщик_оборудованияDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn1.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_поставки";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_поставки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_поставки";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_поставки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 309);
            this.Controls.Add(this.поставщик_оборудованияDataGridView);
            this.Controls.Add(this.поставщик_оборудованияBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Поставщики оборудования";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияBindingNavigator)).EndInit();
            this.поставщик_оборудованияBindingNavigator.ResumeLayout(false);
            this.поставщик_оборудованияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщик_оборудованияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private БрестГазDataSet брестГазDataSet;
        private System.Windows.Forms.BindingSource поставщик_оборудованияBindingSource;
        private БрестГазDataSetTableAdapters.Поставщик_оборудованияTableAdapter поставщик_оборудованияTableAdapter;
        private БрестГазDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщик_оборудованияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщик_оборудованияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView поставщик_оборудованияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}