Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class WatermarkTextbox
    Inherits TextBox

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As UInteger, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As IntPtr
    End Function

    Private _ShowHide As WatermarkOpt = WatermarkOpt.Show
    <Category("Watermark"), Description("Get or Set Watermark Show or Hide."), DefaultValue(WatermarkOpt.Show)>
    Public Property WatermarkShowHide As WatermarkOpt
        Get
            Return _ShowHide
        End Get
        Set(ByVal value As WatermarkOpt)
            _ShowHide = value
            SetWatermark(m_watermarkText)
        End Set
    End Property

    Private m_watermarkText As String
    Public Property WatermarkText() As String
        Get
            Return m_watermarkText
        End Get
        Set(value As String)
            m_watermarkText = value
            SetWatermark(m_watermarkText)
        End Set
    End Property

    Private Sub SetWatermark(watermarkText As String)
        SendMessage(Handle, EM_SETCUEBANNER, _ShowHide, watermarkText)
    End Sub

    Private Sub WatermarkTextbox_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        BackColor = Color.LemonChiffon
    End Sub

    Private Sub WatermarkTextbox_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        BackColor = SystemColors.Window
    End Sub

End Class
Public Enum WatermarkOpt
    Show = 1
    Hide = 0
End Enum