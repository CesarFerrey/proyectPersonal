Public Class Form1
    Private Sub DatosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DatosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DatosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatosDbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDbDataSet.datos' Puede moverla o quitarla según sea necesario.
        Me.DatosTableAdapter.Fill(Me.DatosDbDataSet.datos)

    End Sub

    Private Sub DatosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
End Class
