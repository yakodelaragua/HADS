﻿Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = accesoDatosSQL.Conectar()
        Label1.Text = result
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bRegister.Click

    End Sub
End Class