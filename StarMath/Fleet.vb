﻿Public Class Fleet


    'Dim i As Integer
    'Dim i2 As Integer

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    Me.Text = fleet1type

    'End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    Try
    '        i = Integer.Parse(TextBox1.Text, Globalization.NumberStyles.Any)
    '    Catch ex As Exception
    '        Dim ToolTip1 As New ToolTip
    '        ToolTip1.IsBalloon = True
    '        ToolTip1.UseFading = True
    '        ToolTip1.ToolTipIcon = ToolTipIcon.Error
    '        ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
    '        ToolTip1.Show("Style is not an Integer value", TextBox1, New Point(0, -80), 2500)
    '        TextBox1.Text = ""
    '    End Try
    '    If i >= 1 AndAlso i <= 1500 Then
    '        fleet1count = i
    '        Me.Text = fleet1count.ToString
    '    Else
    '        Dim ToolTip1 As New ToolTip
    '        ToolTip1.IsBalloon = True
    '        ToolTip1.UseFading = True
    '        ToolTip1.ToolTipIcon = ToolTipIcon.Error
    '        ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
    '        ToolTip1.Show("Value was out of range", TextBox1, New Point(0, -80), 2500)
    '        TextBox1.Text = ""
    '    End If
    'End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
    '    Me.Text = fleet1hard
    'End Sub

    'Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
    '    Me.Text = fleet1hull
    'End Sub

    'Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
    '    Me.Text = fleet1card
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Me.Hide()
    '    BC1.Show()

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Me.Hide()
    '    DefFleet.Show()
    'End Sub

    'Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
    '    Me.Text = fleet2type
    'End Sub

    'Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
    '    Me.Text = fleet2hull

    'End Sub

    'Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
    '    Me.Text = fleet2hard

    'End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    '    Try
    '        i2 = Integer.Parse(TextBox2.Text, Globalization.NumberStyles.Any)
    '    Catch ex As Exception
    '        Dim ToolTip1 As New ToolTip
    '        ToolTip1.IsBalloon = True
    '        ToolTip1.UseFading = True
    '        ToolTip1.ToolTipIcon = ToolTipIcon.Error
    '        ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
    '        ToolTip1.Show("Style is not an Integer value", TextBox1, New Point(0, -80), 2500)
    '        TextBox2.Text = ""
    '    End Try
    '    If i2 >= 1 AndAlso i2 <= 1500 Then
    '        fleet2count = i2
    '        Me.Text = fleet2count.ToString
    '    Else
    '        Dim ToolTip1 As New ToolTip
    '        ToolTip1.IsBalloon = True
    '        ToolTip1.UseFading = True
    '        ToolTip1.ToolTipIcon = ToolTipIcon.Error
    '        ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
    '        ToolTip1.Show("Value was out of range", TextBox1, New Point(0, -80), 2500)
    '        TextBox2.Text = ""
    '    End If
    'End Sub

    'Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
    '    Me.Text = fleet2card

    'End Sub
End Class