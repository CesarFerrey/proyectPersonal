Public Class Form1
    Public conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=datosDb.accdb")
    ' Por medio de este objeto voy a enviar todos los comandos de SQL a la tabla por medio de la conexión
    Public comm As New OleDb.OleDbCommand
    ' Declaro una variable para armar la instrucción SQL
    Dim sql As String
    Private Sub DatosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DatosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DatosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatosDbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DatosTableAdapter.Fill(Me.DatosDbDataSet.datos)
        Try
            ' Trato de abrir la conexión
            conex.Open()
            ' Inicializo el objeto Command
            comm.Connection = conex
            comm.CommandType = CommandType.Text
            ' MsgBox("Se encontro la Base de datos")

        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("No se pudo encontrar el archivo de la base de datos", MsgBoxStyle.Exclamation, "Biblioteca")
                End
            Else
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "DatosDb")
            End If
        End Try
    End Sub

    Private Sub DatosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String
        Dim dni As Integer
        Dim domicilio As String
        Dim sexo As String
        Dim estado_civil As String

        nombre = NombreTextBox.Text
        dni = DniTextBox.Text
        domicilio = DomicilioTextBox.Text
        sexo = SexoTextBox.Text

        estado_civil = Estado_civilTextBox.Text







        If IdTextBox.Text = "" Then
            'MsgBox("Debe incluir un codigo o id")

            'IdTextBox.Select()



        Else
            'sql = "INSERT INTO datos ( nombre, dni, domicilio, sexo, estado_civil) VALUES ('" & nombre & "','" & dni & "','" &
            '  domicilio & "'," & sexo & ",'" & estado_civil & "')"
            sql = "INSERT INTO datos ( nombre, dni, domicilio, sexo, estado_civil) VALUES ('ce','123','io','ma','ad')"

            comm.CommandText = sql


            Try
                comm.ExecuteNonQuery()
                MsgBox("SE ingreso el dato")


            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "DatosDb")
            End Try
        End If
    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub DniTextBox_TextChanged(sender As Object, e As EventArgs) Handles DniTextBox.TextChanged

    End Sub

    Private Sub DomicilioTextBox_TextChanged(sender As Object, e As EventArgs) Handles DomicilioTextBox.TextChanged

    End Sub

    Private Sub SexoTextBox_TextChanged(sender As Object, e As EventArgs) Handles SexoTextBox.TextChanged

    End Sub

    Private Sub Estado_civilTextBox_TextChanged(sender As Object, e As EventArgs) Handles Estado_civilTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class
