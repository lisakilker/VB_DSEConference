Public Class frmDevelopersSkillsConference

    Private Sub frmDevelopersSkillsConference_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumberAttending.Focus()
        txtNumberAttending.Text = ""
        radYes.Checked = False
        radNo.Checked = True
        lblTotalCostForAttendees.Text = ""
        lblTotalCost.Text = ""
        btnCalculate.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberAttending.Focus()
        txtNumberAttending.Text = ""
        radYes.Checked = False
        radNo.Checked = True
        lblTotalCostForAttendees.Text = ""
        lblTotalCost.Text = ""
        btnCalculate.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAttendeeCount As Decimal
        Dim decCostPerPerson As Decimal
        Dim decCostTotal As Decimal


        If IsNumeric(txtNumberAttending.Text) Then
            decAttendeeCount = Convert.ToDecimal(txtNumberAttending.Text)

            Select Case decAttendeeCount
                Case 1
                    decCostPerPerson = 895D
                    lblTotalCostForAttendees.Visible = True
                    lblTotalCost.Visible = True
                Case 2 To 4
                    decCostPerPerson = 645D
                    lblTotalCostForAttendees.Visible = True
                    lblTotalCost.Visible = True
                Case 5 To 8
                    decCostPerPerson = 480D
                    lblTotalCostForAttendees.Visible = True
                    lblTotalCost.Visible = True
                Case 9 To 16
                    decCostPerPerson = 395D
                    lblTotalCostForAttendees.Visible = True
                    lblTotalCost.Visible = True
                Case Else
                    MsgBox("Please enter a numeric value between 1 and 16", 32, "Entry Error")
                    txtNumberAttending.Focus()
                    txtNumberAttending.Text = ""
                    radYes.Checked = False
                    radNo.Checked = True
                    lblTotalCostForAttendees.Visible = False
                    lblTotalCost.Visible = False
                    btnCalculate.Enabled = False
                    
            End Select

            If radYes.Checked = True Then
                decCostTotal = (decAttendeeCount * decCostPerPerson) * 0.85

            Else
                decCostTotal = decAttendeeCount * decCostPerPerson
            End If
            lblTotalCostForAttendees.Text = "Total cost for all attendees:"
            lblTotalCost.Text = decCostTotal.ToString("C")
        End If

    End Sub

    Private Sub txtNumberAttending_TextChanged(sender As Object, e As EventArgs) Handles txtNumberAttending.TextChanged
        btnCalculate.Enabled = True
    End Sub
End Class




