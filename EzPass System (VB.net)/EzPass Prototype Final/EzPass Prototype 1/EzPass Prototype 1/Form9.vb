Imports System.ComponentModel

Public Class Form9

    'Class-level Variables.

    Dim AcctFieldisFull As Boolean = False

    Dim EzPassFareDiscount As Double = 32 / 100

    'Fare Effective date of all current Toll Price.

    Dim EzPassEffectiveDate As String

    'Trip Taken Incrementation.

    Dim CurrentTrips As Integer

    Dim TripIncrement As Integer = 1

    Dim TripTaken As Boolean = False

    Dim TollAndEntrySelected As Boolean = False


    ''
    Dim AccountWriting As Boolean = False

    Dim TagWriting As Boolean = False

    ''
    Dim AccountFocus As Boolean = False

    Dim TagFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersToll' table. You can move, or remove it, as needed.
        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

    End Sub

    Private Sub Form9_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form1.Show()
        Me.Close()

    End Sub

    Sub FormDateTime()

        Dim FormDate As String = Date.Today.ToString("MM/dd/yyyy")

        Dim FormTime As String = Now.ToShortTimeString

        txtDate.Text = FormDate

        txtTime.Text = FormTime

    End Sub

    Sub LoginFocusReset()

        txtAcctSearch.BackColor = Color.White
        txtTagSearch.BackColor = Color.White

        txtAcctSearch.Clear()
        txtTagSearch.Clear()

    End Sub

    Sub CheckforEmptyField()

        Dim EmptyFieldMsg As Integer

        If txtAcctSearch.Text = String.Empty Or txtTagSearch.Text = String.Empty Then

            AcctFieldisFull = False
            EmptyFieldMsg = MessageBox.Show("There are empty fields! Please try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            AcctFieldisFull = True

        End If

    End Sub

    'Subroutine that displays a dialog box to the Customer/Employee that the account they are trying to reach,
    'does not exist. And that they should try again with a valid Account Number.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("Either that Tag does not exist OR that Account does not exist. Please try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            LoginFocusReset()

        End If

    End Sub

    Sub TagAndPlateSwitch()

        Dim TagSwitch As String

        Dim PlateSwitch As String

        TagSwitch = txtTagPlaceholder.Text

        PlateSwitch = txtPlatePlaceholder.Text

        txtTagNbr.Text = TagSwitch

        txtPlateNbr.Text = PlateSwitch

    End Sub

    Sub NoTripsTakenDefault()

        Dim ZeroTrips As String

        Dim NumeralZero As Integer

        ZeroTrips = ""

        NumeralZero = 0

        If lblTrips.Text = ZeroTrips Then

            lblTrips.Text = NumeralZero.ToString

        End If

    End Sub

    Sub TripsIntParsing()

        If TripTaken = True Then

            Integer.TryParse(lblTrips.Text, CurrentTrips)

            lblTrips.Text = CurrentTrips + TripIncrement

        End If

    End Sub

    Sub TextBoxFocusColor()

        If AccountFocus = True Then

            txtAcctSearch.BackColor = Color.LemonChiffon

        Else

            AccountFocus = False
            txtAcctSearch.BackColor = Color.White

        End If

        If TagFocus = True Then

            txtTagSearch.BackColor = Color.LemonChiffon

        Else

            TagFocus = False
            txtTagSearch.BackColor = Color.White

        End If

    End Sub

    Sub NoFocusColor()

        AccountFocus = False
        TagFocus = False

        txtAcctSearch.Clear()
        txtTagSearch.Clear()

        txtAcctSearch.BackColor = Color.White
        txtTagSearch.BackColor = Color.White

    End Sub

    Private Sub txtAcctSearch_GotFocus(sender As Object, e As EventArgs) Handles txtAcctSearch.GotFocus

        AccountFocus = True
        TagFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtTagSearch_GotFocus(sender As Object, e As EventArgs) Handles txtTagSearch.GotFocus

        AccountFocus = False
        TagFocus = True

        TextBoxFocusColor()

    End Sub

    Sub AcctStatusCheck()

        Dim BalanceChecker As Double

        Dim LowBalanceThreshold As Double = 25

        Dim LowBalanceMsg As Integer

        Dim GoodBalanceStatus As String = "Good Standing"

        Dim LowBalanceStatus As String = "Bad Standing"

        Double.TryParse(txtAcctBal.Text, BalanceChecker)

        If LowBalanceThreshold >= BalanceChecker Then

            lblAcctStatus.ForeColor = Color.Red
            lblAcctStatus.Text = LowBalanceStatus
            LowBalanceMsg = MessageBox.Show("Account Funds are too low. You currently cannot take any Tolls. Please add more Funds.", "More Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnProcess.Enabled = False
            btnProcess.BackColor = Color.OrangeRed

        End If

        If BalanceChecker > LowBalanceThreshold Then

            lblAcctStatus.ForeColor = Color.Green
            lblAcctStatus.Text = GoodBalanceStatus
            btnProcess.Enabled = True
            btnProcess.BackColor = Color.AntiqueWhite

        End If

    End Sub

    ' Describe the sub here later.
    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If DetectMsg = DialogResult.OK And AccountWriting = True Then

            txtAcctSearch.Clear()

        End If

        If DetectMsg = DialogResult.OK And TagWriting = True Then

            txtTagSearch.Clear()

        End If

    End Sub

    Private Sub txtTagSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTagSearch.KeyPress

        AccountWriting = False
        TagWriting = True

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    Private Sub txtAcctSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctSearch.KeyPress

        AccountWriting = True
        TagWriting = False

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    Sub TollPlaceholderTransfer()

        txtTollCode.Text = txtTollPlaceholder.Text

        txtEffectiveDate.Text = txtFareDatePlaceholder.Text

        grpEntryPoints.Enabled = True

    End Sub

    Private Sub DatTolls_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatTolls.CellClick

        TollPlaceholderTransfer()

    End Sub

    Sub RadioButtonsReset()

        grpEntryPoints.Enabled = False
        RadFirstEntry.Checked = False
        RadSecondEntry.Checked = False

        txtDeducted.BackColor = Color.White

        TollAndEntrySelected = False

    End Sub

    Private Sub BtnEnterToll_Click(sender As Object, e As EventArgs) Handles btnEnterToll.Click

        CheckforEmptyField()

        Me.CustomersTollBindingSource.AddNew()

        Dim SearchAcctRecord As String

        Dim SearchTagRecord As String

        If AcctFieldisFull = True Then

            RadioButtonsReset()

            TripTaken = True

            SearchAcctRecord = txtAcctSearch.Text

            SearchTagRecord = txtTagSearch.Text

            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAcctRecord)

            Me.CustomersInfoTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagRecord)

            FormDateTime()
            TagAndPlateSwitch()
            NoTripsTakenDefault()

            PanTollUI.Enabled = True

            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAcctRecord) = Nothing Or Me.CustomersInfoTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagRecord) = Nothing Then

                AccountNotExist()

                grpVerifyAcct.Enabled = True
                grpVerifyAcct.Visible = True

                AcctFieldisFull = False

            Else

                grpVerifyAcct.Enabled = False
                grpVerifyAcct.Visible = False
                AcctStatusCheck()

            End If

        End If

    End Sub

    Sub FareDeductedBalance()

        Dim EzFare As Double

        Dim CurrentBal As Double

        Double.TryParse(txtAcctBal.Text, CurrentBal)

        Double.TryParse(txtEzFare.Text, EzFare)

        txtAcctBal.Text = CurrentBal - EzFare

    End Sub


    Private Sub RadFirstEntry_Click(sender As Object, e As EventArgs) Handles RadFirstEntry.Click

        txtEntryPoint.Text = RadFirstEntry.Text

        txtDeducted.Text = txtEzFare.Text
        txtDeducted.BackColor = Color.LightGreen
        btnProcess.BackColor = Color.LightGreen

        TollAndEntrySelected = True

    End Sub

    Private Sub RadSecondEntry_Click(sender As Object, e As EventArgs) Handles RadSecondEntry.Click

        txtEntryPoint.Text = RadSecondEntry.Text

        txtDeducted.Text = txtEzFare.Text
        txtDeducted.BackColor = Color.LightGreen
        btnProcess.BackColor = Color.LightGreen

        TollAndEntrySelected = True

    End Sub

    Sub EzPassDiscounts()

        Dim OrigFare As Double

        Dim EzPassDiscount As Double

        Double.TryParse(txtOrigFare.Text, OrigFare)

        EzPassDiscount = OrigFare * EzPassFareDiscount

        txtEzFare.Text = OrigFare - EzPassDiscount

        txtSavedAmt.Text = EzPassDiscount

    End Sub

    Private Sub txtOrigFare_TextChanged(sender As Object, e As EventArgs) Handles txtOrigFare.TextChanged

        EzPassDiscounts()

    End Sub

    Private Sub txtEzFare_TextChanged(sender As Object, e As EventArgs) Handles txtEzFare.TextChanged

        txtDeducted.Text = txtEzFare.Text

    End Sub

    Sub TollBackDeletion()

        Dim TollBackMsg As Integer

        TollBackMsg = MessageBox.Show("Going back deletes your current Toll Transaction. Do you wish to proceed?", "Toll Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If TollBackMsg = DialogResult.Yes Then

            Me.CustomersTollBindingSource.RemoveCurrent()

            NoFocusColor()
            grpVerifyAcct.Enabled = True
            grpVerifyAcct.Visible = True

        End If

    End Sub

    Private Sub BtnTollBack_Click(sender As Object, e As EventArgs) Handles btnTollBack.Click

        TollBackDeletion()

        txtAcctSearch.Clear()
        txtTagSearch.Clear()
        txtOrigFare.Clear()
        txtEzFare.Clear()
        txtSavedAmt.Clear()
        txtDeducted.Clear()
        txtTollCode.Clear()

        TollAndEntrySelected = False

    End Sub

    Private Sub BtnTagHelp_Click(sender As Object, e As EventArgs) Handles btnTagHelp.Click

        grpVerifyAcct.Enabled = False
        Form10.Show()

    End Sub

    Sub TollsOrEntryNotChecked()

        Dim TollsMsg As Integer

        TollsMsg = MessageBox.Show("You have not selected any Toll Destinations or Entry Points. Please choose them.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Sub RevenueIncrement()

        ''
        Dim ClientRevenue As Double

        Dim TollRevenue As Double
        ''

        ''
        Dim EzFareToRevenue As Double

        Dim OrigFareToRevenue As Double
        ''

        ''
        Dim IncrementedClient As Double

        Dim IncrementedToll As Double
        ''

        ''
        Double.TryParse(txtDeducted.Text, EzFareToRevenue)

        Double.TryParse(txtClientRevenue.Text, ClientRevenue)

        Double.TryParse(txtTollRevenue.Text, TollRevenue)

        Double.TryParse(txtOrigFare.Text, OrigFareToRevenue)
        ''

        ''
        IncrementedClient = EzFareToRevenue + ClientRevenue

        IncrementedToll = OrigFareToRevenue + TollRevenue
        ''

        ''
        txtClientRevenue.Text = IncrementedClient

        txtTollRevenue.Text = IncrementedToll
        ''

    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        If TollAndEntrySelected = True Then

            PanTollUI.Enabled = False

            FareDeductedBalance()
            TripsIntParsing()
            RevenueIncrement()
            Form13.Show()

        Else

            TollsOrEntryNotChecked()

        End If

    End Sub


End Class