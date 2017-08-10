<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ELibraryDataSet2 = New eLibraryManagementSystem.eLibraryDataSet2()
        Me.BooksInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksInfoTableAdapter = New eLibraryManagementSystem.eLibraryDataSet2TableAdapters.BooksInfoTableAdapter()
        Me.IsbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibraryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Books Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsbnDataGridViewTextBoxColumn, Me.BooknameDataGridViewTextBoxColumn, Me.AuthornameDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksInfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(124, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ELibraryDataSet2
        '
        Me.ELibraryDataSet2.DataSetName = "eLibraryDataSet2"
        Me.ELibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksInfoBindingSource
        '
        Me.BooksInfoBindingSource.DataMember = "BooksInfo"
        Me.BooksInfoBindingSource.DataSource = Me.ELibraryDataSet2
        '
        'BooksInfoTableAdapter
        '
        Me.BooksInfoTableAdapter.ClearBeforeFill = True
        '
        'IsbnDataGridViewTextBoxColumn
        '
        Me.IsbnDataGridViewTextBoxColumn.DataPropertyName = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.HeaderText = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.Name = "IsbnDataGridViewTextBoxColumn"
        '
        'BooknameDataGridViewTextBoxColumn
        '
        Me.BooknameDataGridViewTextBoxColumn.DataPropertyName = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.HeaderText = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.Name = "BooknameDataGridViewTextBoxColumn"
        '
        'AuthornameDataGridViewTextBoxColumn
        '
        Me.AuthornameDataGridViewTextBoxColumn.DataPropertyName = "author_name"
        Me.AuthornameDataGridViewTextBoxColumn.HeaderText = "author_name"
        Me.AuthornameDataGridViewTextBoxColumn.Name = "AuthornameDataGridViewTextBoxColumn"
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'AdminBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 331)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminBooks"
        Me.Text = "Books"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibraryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ELibraryDataSet2 As eLibraryManagementSystem.eLibraryDataSet2
    Friend WithEvents BooksInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksInfoTableAdapter As eLibraryManagementSystem.eLibraryDataSet2TableAdapters.BooksInfoTableAdapter
    Friend WithEvents IsbnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
