Public Class Reports
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim crpt As New TestReport1()
        crvTest.ReportSource = crpt

    End Sub

End Class