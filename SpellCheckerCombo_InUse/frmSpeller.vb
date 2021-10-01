Imports SpellCheckerCombo

Public Class frmSpeller

    '------------------------------------------------------------
    '-                File Name : frmSpeller.vb                 -
    '-                Part of Project: Assignment10             -
    '------------------------------------------------------------
    '-                Written By: Benjamin Neeb                 -
    '-                Written On: April 7, 2021                 -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the form for using the spellchecker   -
    '- DLL.                                                     -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- This program illustrates how to import a DLL and use it  -
    '- as both a new instance and a GUI.                        -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- (None)                                                   -
    '------------------------------------------------------------

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        '------------------------------------------------------------
        '-              Subprogram Name: btnCheck_Click             -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: April 4, 2021                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine uses the DLL to check for spelling       -
        '- errors using the form's controls.                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- aCheckRef:   Instance of DLL clsWordChecker Sub.         -
        '------------------------------------------------------------

        Dim aCheckRef As New clsWordChecker

        If aCheckRef.CheckWord(txtWord.Text) Then
            lblResult.Text = "OK - Spelled correctly!"
        Else
            lblResult.Text = "NOPE - Spelled incorrectly!"
        End If
    End Sub

    Private Sub btnGUI_Click(sender As Object, e As EventArgs) Handles btnGUI.Click
        '------------------------------------------------------------
        '-              Subprogram Name: btnGUI_Click               -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: April 4, 2021                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine uses the DLL to check for spelling       -
        '- errors using the DLL's GUI.                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control that raised -
        '-          the click event                                 - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- aGUIfromDLL: Instance of DLL frmSpellCheck Form.         -
        '------------------------------------------------------------

        Dim aGUIfromDLL As New frmSpellCheck
        aGUIfromDLL.ShowDialog()
    End Sub
End Class
