Public Class Frmmain
    Dim Kailash As New DataAccessLayer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PartyMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyMasterToolStripMenuItem.Click
        'FrmPartyMaster.Show(Me)
        Dim frm As New FrmPartyMaster
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim FrmInvoice As New FrmInvop
        FrmInvoice.Text = "Invoice"
        FrmInvoice.MdiParent = Me
        FrmInvop.isQuatation = False
        FrmInvoice.Show()
    End Sub

    Private Sub QuatationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuatationToolStripMenuItem.Click
        Dim FrmQuat As New FrmInvop
        FrmQuat.Text = "Quatation"
        FrmQuat.MdiParent = Me
        FrmQuat.isQuatation = True
        FrmQuat.lblCpoyQNo.Visible = False
        FrmQuat.txtCopyQ.Visible = False
        FrmQuat.BtnCopyQuatattion.Visible = False
        FrmQuat.Show()
    End Sub

    Private Sub InvoiceGSTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceGSTToolStripMenuItem.Click
        Dim FrmInvoice As New FrmInvoiceGST
        FrmInvoice.Text = "Invoice"
        FrmInvoice.MdiParent = Me
        FrmInvoice.StartPosition = FormStartPosition.CenterScreen
        FrmInvoice.WindowState = FormWindowState.Maximized
        FrmInvop.isQuatation = False
        FrmInvoice.Show()
    End Sub

    Private Sub QuatationGSTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuatationGSTToolStripMenuItem.Click
        Dim FrmQuat As New FrmInvoiceGST
        FrmQuat.Text = "Quatation"
        FrmQuat.MdiParent = Me
        FrmQuat.StartPosition = FormStartPosition.CenterScreen
        FrmQuat.WindowState = FormWindowState.Maximized
        FrmQuat.isQuatation = True
        FrmQuat.lblQNoCopy.Visible = False
        FrmQuat.txtQNoCopy.Visible = False
        FrmQuat.btnCopy.Visible = False
        FrmQuat.Show()
    End Sub

    Private Sub Frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kailash.BuildConnString()
        'SalesBillToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub QuatationTermsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuatationTermsToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\Quatation.docx")
    End Sub

    Private Sub SupplyInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplyInvoiceToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\Supply.docx")
    End Sub

    Private Sub LabourInvioceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabourInvioceToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\Labour.docx")
    End Sub

    Private Sub SalesBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesBillToolStripMenuItem.Click
        Dim FrmRetailSell As New frmRetailSell
        FrmRetailSell.MdiParent = Me
        FrmRetailSell.StartPosition = FormStartPosition.CenterScreen
        FrmRetailSell.WindowState = FormWindowState.Maximized
        FrmRetailSell.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim FrmCustomer As New FrmCustomer
        FrmCustomer.MdiParent = Me
        FrmCustomer.StartPosition = FormStartPosition.CenterScreen
        FrmCustomer.WindowState = FormWindowState.Maximized
        FrmCustomer.Show()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        Dim FrmProductAdd As New FrmProductAdd
        FrmProductAdd.MdiParent = Me
        FrmProductAdd.StartPosition = FormStartPosition.CenterScreen
        FrmProductAdd.WindowState = FormWindowState.Maximized
        FrmProductAdd.Show()
    End Sub

    Private Sub SaleBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleBillToolStripMenuItem.Click
        Dim FrmSalesBillReport As New FrmSalesBillReport
        FrmSalesBillReport.MdiParent = Me
        FrmSalesBillReport.StartPosition = FormStartPosition.CenterScreen
        FrmSalesBillReport.WindowState = FormWindowState.Maximized
        FrmSalesBillReport.Show()
    End Sub

    Private Sub Frmmain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.C Then
            CustomerToolStripMenuItem_Click(Nothing, Nothing)
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            SalesBillToolStripMenuItem_Click(Nothing, Nothing)
        ElseIf e.Control AndAlso e.KeyCode = Keys.I Then
            ItemToolStripMenuItem_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerListToolStripMenuItem.Click
        Dim frm As New FrmCustomer
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub SupplierListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierListToolStripMenuItem.Click
        Dim frm As New frmSupplierList
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub ItemListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemListToolStripMenuItem.Click
        Dim frm As New FrmProductAdd
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        Dim frm As New frmProducts
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub ProductTypeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductTypeListToolStripMenuItem.Click
        Dim frm As New frmProductTypes
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub ColorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorListToolStripMenuItem.Click
        Dim frm As New frmColors
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub MfgListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MfgListToolStripMenuItem.Click
        Dim frm As New frmManufaturers
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub BrandListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandListToolStripMenuItem.Click
        Dim frm As New frmBrands
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim frm As New frmSupplier
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub
End Class
