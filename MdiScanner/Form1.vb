Imports System.IO
Imports System.Runtime.CompilerServices
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.NetworkInformation

Public Class Form1

    Public ipList As New List(Of ip_addresses)
    Dim timer As New Timer()

    Public Sub LoadDataFromFile()
        Dim filepath As String = Path.Combine(Environment.CurrentDirectory, "MdiScanner_ip_addresses_list.txt")

        If File.Exists(filepath) Then
            Try
                ipList.Clear()
                Dim inputFile As StreamReader
                inputFile = File.OpenText(filepath)
                Do While inputFile.Peek() >= 0
                    Dim inputLine = inputFile.ReadLine()
                    Dim parts() As String = inputLine.Split(";"c)
                    Dim ip_address = parts(0)
                    Dim name = parts(1)

                    Dim data_ip_address As New ip_addresses(ip_address, name)
                    ipList.Add(data_ip_address)
                Loop
                inputFile.Close()
            Catch ex As Exception

            End Try

        End If
    End Sub
    Public Sub WriteDataToFile()
        Dim filepath As String = Path.Combine(Environment.CurrentDirectory, "MdiScanner_ip_addresses_list.txt")
        Try
            Dim outputFile As StreamWriter
            outputFile = File.CreateText(filepath)
            For Each item As ip_addresses In ipList
                outputFile.WriteLine($"{item.ip_address};{item.name}")
            Next
            outputFile.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckDeviceStatus(ipAddress As String) As String
        Try
            Dim ping As New Ping()
            Dim reply As PingReply = ping.Send(ipAddress, 2000)

            If reply.Status = IPStatus.Success Then
                Return "Up"
            Else
                Return "Down"
            End If
        Catch ex As Exception
            Return "Down"
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFromFile()
        SetupDataGridView()
    End Sub

    Private Sub SetupDataGridView()
        DataGridView1.AutoGenerateColumns = False
        Dim ipAddressColumn As New DataGridViewTextBoxColumn()
        ipAddressColumn.DataPropertyName = "ip_address"
        ipAddressColumn.HeaderText = "IP ADDRESS"
        ipAddressColumn.Width = 200
        DataGridView1.Columns.Add(ipAddressColumn)
        Dim nameColumn As New DataGridViewTextBoxColumn()
        nameColumn.DataPropertyName = "name"
        nameColumn.HeaderText = "NAME"
        nameColumn.Width = 450
        DataGridView1.Columns.Add(nameColumn)
        Dim statusColumn As New DataGridViewTextBoxColumn()
        statusColumn.DataPropertyName = "status"
        statusColumn.HeaderText = "STATUS"
        statusColumn.Width = 83
        DataGridView1.Columns.Add(statusColumn)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Me.ipList.OrderBy(Function(item) item.name).ToList()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        For Each item As ip_addresses In ipList
            Dim status As String = CheckDeviceStatus(item.ip_address)
            item.status = status
        Next
        UpdateDataGridView()
    End Sub

    Private Sub UpdateDataGridView()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Me.ipList.OrderBy(Function(item) item.name).ToList()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        timer.Stop()
        ip_address.Show()
        Me.Hide()
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Dim intervalMinutes As Double
        If Double.TryParse(txtInterval.Text, intervalMinutes) AndAlso intervalMinutes > 0 Then
            timer.Interval = TimeSpan.FromMinutes(intervalMinutes).TotalMilliseconds
            AddHandler timer.Tick, AddressOf Timer_Tick
            timer.Start()
        Else
            MessageBox.Show("Please enter a valid positive number for the interval.")
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timer.Stop()
    End Sub
End Class
