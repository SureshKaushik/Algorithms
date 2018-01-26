Imports System.Threading
Imports System.Globalization

Public Class Form1


    Private Sub Bututon1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As CultureInfo
        c = CultureInfo.CreateSpecificCulture("sv-SE")
        Thread.CurrentThread.CurrentCulture = c
        Thread.CurrentThread.CurrentUICulture = c

        Label1.Text = My.Resources.Hello

    End Sub
End Class
