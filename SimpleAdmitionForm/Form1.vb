Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbfac.Items.Clear()
        cmbfac.Items.Add("Hardware/Networking")
        cmbfac.Items.Add("Software programming")
        cmbfac.Items.Add("Animation")
        lisAct.Items.Add("English Speaking")
        lisAct.Items.Add("Personality Devlopement")
        lisAct.Items.Add("MS-CIT")
    End Sub

    Private Sub cmbfac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfac.SelectedIndexChanged
        If cmbfac.Text = "Hardware/Networking" Then
            cmbcourse.Items.Clear()

            cmbcourse.Items.Add("Computer hardware")
            cmbcourse.Items.Add("Laptop")
            cmbcourse.Items.Add("Lan connection")
        End If
        If cmbfac.Text = "Software programming" Then
            cmbcourse.Items.Clear()

            cmbcourse.Items.Add("C")
            cmbcourse.Items.Add("C++")
            cmbcourse.Items.Add("JAVA")
        End If
        If cmbfac.Text = "Animation" Then


            cmbcourse.Items.Clear()

            cmbcourse.Items.Add("2D")
            cmbcourse.Items.Add("3D")

        End If
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcourse.SelectedIndexChanged
           End Sub

    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClear.Click
        lisSelected.Items.Clear()
    End Sub

    Private Sub butSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSubmit.Click
        ListBox1.Items.Add("name:" + TextBox1.Text)
        ListBox1.Items.Add("faculty:" + cmbfac.Text)

        ListBox1.Items.Add("Course:" + cmbcourse.Text)

        If RadioButton1.Checked Then
            ListBox1.Items.Add("Gender:Male")
        Else
            ListBox1.Items.Add("Gender:Female")
        End If
        If CheckBox1.Checked Then
            ListBox1.Items.Add("Education: ssc")
        End If
        If CheckBox1.Checked Then
            ListBox1.Items.Add("Education: HSC")
        End If
        If CheckBox1.Checked Then
            ListBox1.Items.Add("Education: Graduation")
        End If
        If CheckBox1.Checked Then
            ListBox1.Items.Add("Education: Pg")
        End If

        ListBox1.Items.Add("Activity:" + lisSelected.Text)

    End Sub

    Private Sub butAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdd.Click
        lisSelected.Items.Add(lisAct.SelectedItem)
    End Sub
End Class
