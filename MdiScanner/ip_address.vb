Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ip_address

    Dim ipList As New List(Of ip_address)

    Private Sub ip_address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        Dim ipAddressColumn As New DataGridViewTextBoxColumn()
        ipAddressColumn.DataPropertyName = "ip_address"
        ipAddressColumn.HeaderText = "IP ADDRESS"
        ipAddressColumn.Width = 100
        DataGridView1.Columns.Add(ipAddressColumn)
        Dim nameColumn As New DataGridViewTextBoxColumn()
        nameColumn.DataPropertyName = "name"
        nameColumn.HeaderText = "NAME"
        nameColumn.Width = 252
        DataGridView1.Columns.Add(nameColumn)
        Dim deleteColumn As New DataGridViewButtonColumn()
        deleteColumn.HeaderText = "Delete"
        deleteColumn.Width = 65
        deleteColumn.Text = "DELETE"
        deleteColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(deleteColumn)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Form1.ipList.OrderBy(Function(item) item.name).ToList()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the delete column
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim clickedRowData As ip_addresses = DirectCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, ip_addresses)
            Form1.ipList.RemoveAll(Function(item) item.ip_address = clickedRowData.ip_address)
            Form1.WriteDataToFile()
            Form1.LoadDataFromFile()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Form1.ipList.OrderBy(Function(item) item.name).ToList()
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrWhiteSpace(txtIp_address.Text) AndAlso Not String.IsNullOrWhiteSpace(txtName.Text) Then
            Form1.ipList.Add(New ip_addresses(txtIp_address.Text, txtName.Text))
            txtIp_address.Clear()
            txtName.Clear()
            Form1.WriteDataToFile()
            Form1.LoadDataFromFile()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Form1.ipList.OrderBy(Function(item) item.name).ToList()
        Else
            MessageBox.Show("Please enter both IP Address and Name.")
        End If
    End Sub

    Private Sub ip_address_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class