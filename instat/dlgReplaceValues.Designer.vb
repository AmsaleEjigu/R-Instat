﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgReplaceValues
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpOld = New System.Windows.Forms.GroupBox()
        Me.rdoOldValue = New System.Windows.Forms.RadioButton()
        Me.lblRangeMax = New System.Windows.Forms.Label()
        Me.rdoOldMissing = New System.Windows.Forms.RadioButton()
        Me.rdoOldInterval = New System.Windows.Forms.RadioButton()
        Me.lblRangeMin = New System.Windows.Forms.Label()
        Me.ucrChkMax = New instat.ucrCheck()
        Me.ucrInputRangeTo = New instat.ucrInputTextBox()
        Me.ucrChkMin = New instat.ucrCheck()
        Me.ucrInputRangeFrom = New instat.ucrInputTextBox()
        Me.ucrInputOldValue = New instat.ucrInputTextBox()
        Me.ucrPnlOld = New instat.UcrPanel()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.rdoNewFromAbove = New System.Windows.Forms.RadioButton()
        Me.rdoNewFromBelow = New System.Windows.Forms.RadioButton()
        Me.ucrInputNewValue = New instat.ucrInputTextBox()
        Me.rdoNewMissing = New System.Windows.Forms.RadioButton()
        Me.rdoNewValue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlNew = New instat.UcrPanel()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverReplace = New instat.ucrReceiverMultiple()
        Me.ucrSelectorReplace = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOld.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOld
        '
        Me.grpOld.Controls.Add(Me.rdoOldValue)
        Me.grpOld.Controls.Add(Me.lblRangeMax)
        Me.grpOld.Controls.Add(Me.rdoOldMissing)
        Me.grpOld.Controls.Add(Me.rdoOldInterval)
        Me.grpOld.Controls.Add(Me.lblRangeMin)
        Me.grpOld.Controls.Add(Me.ucrChkMax)
        Me.grpOld.Controls.Add(Me.ucrInputRangeTo)
        Me.grpOld.Controls.Add(Me.ucrChkMin)
        Me.grpOld.Controls.Add(Me.ucrInputRangeFrom)
        Me.grpOld.Controls.Add(Me.ucrInputOldValue)
        Me.grpOld.Controls.Add(Me.ucrPnlOld)
        Me.grpOld.Location = New System.Drawing.Point(10, 194)
        Me.grpOld.Name = "grpOld"
        Me.grpOld.Size = New System.Drawing.Size(217, 148)
        Me.grpOld.TabIndex = 3
        Me.grpOld.TabStop = False
        Me.grpOld.Tag = "Old"
        Me.grpOld.Text = "Old"
        '
        'rdoOldValue
        '
        Me.rdoOldValue.AutoSize = True
        Me.rdoOldValue.Location = New System.Drawing.Point(9, 27)
        Me.rdoOldValue.Name = "rdoOldValue"
        Me.rdoOldValue.Size = New System.Drawing.Size(52, 17)
        Me.rdoOldValue.TabIndex = 1
        Me.rdoOldValue.TabStop = True
        Me.rdoOldValue.Text = "Value"
        Me.rdoOldValue.UseVisualStyleBackColor = True
        '
        'lblRangeMax
        '
        Me.lblRangeMax.AutoSize = True
        Me.lblRangeMax.Location = New System.Drawing.Point(8, 117)
        Me.lblRangeMax.Name = "lblRangeMax"
        Me.lblRangeMax.Size = New System.Drawing.Size(54, 13)
        Me.lblRangeMax.TabIndex = 9
        Me.lblRangeMax.Tag = "Maximum"
        Me.lblRangeMax.Text = "Maximum:"
        '
        'rdoOldMissing
        '
        Me.rdoOldMissing.AutoSize = True
        Me.rdoOldMissing.Location = New System.Drawing.Point(9, 50)
        Me.rdoOldMissing.Name = "rdoOldMissing"
        Me.rdoOldMissing.Size = New System.Drawing.Size(90, 17)
        Me.rdoOldMissing.TabIndex = 3
        Me.rdoOldMissing.TabStop = True
        Me.rdoOldMissing.Text = "Missing Value"
        Me.rdoOldMissing.UseVisualStyleBackColor = True
        '
        'rdoOldInterval
        '
        Me.rdoOldInterval.AutoSize = True
        Me.rdoOldInterval.Location = New System.Drawing.Point(9, 73)
        Me.rdoOldInterval.Name = "rdoOldInterval"
        Me.rdoOldInterval.Size = New System.Drawing.Size(60, 17)
        Me.rdoOldInterval.TabIndex = 4
        Me.rdoOldInterval.TabStop = True
        Me.rdoOldInterval.Text = "Interval"
        Me.rdoOldInterval.UseVisualStyleBackColor = True
        '
        'lblRangeMin
        '
        Me.lblRangeMin.AutoSize = True
        Me.lblRangeMin.Location = New System.Drawing.Point(8, 96)
        Me.lblRangeMin.Name = "lblRangeMin"
        Me.lblRangeMin.Size = New System.Drawing.Size(51, 13)
        Me.lblRangeMin.TabIndex = 6
        Me.lblRangeMin.Tag = "Minimum"
        Me.lblRangeMin.Text = "Minimum:"
        '
        'ucrChkMax
        '
        Me.ucrChkMax.AutoSize = True
        Me.ucrChkMax.Checked = False
        Me.ucrChkMax.Location = New System.Drawing.Point(143, 116)
        Me.ucrChkMax.Name = "ucrChkMax"
        Me.ucrChkMax.Size = New System.Drawing.Size(70, 23)
        Me.ucrChkMax.TabIndex = 0
        '
        'ucrInputRangeTo
        '
        Me.ucrInputRangeTo.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeTo.AutoSize = True
        Me.ucrInputRangeTo.IsMultiline = False
        Me.ucrInputRangeTo.IsReadOnly = False
        Me.ucrInputRangeTo.Location = New System.Drawing.Point(64, 114)
        Me.ucrInputRangeTo.Name = "ucrInputRangeTo"
        Me.ucrInputRangeTo.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputRangeTo.TabIndex = 10
        '
        'ucrChkMin
        '
        Me.ucrChkMin.AutoSize = True
        Me.ucrChkMin.Checked = False
        Me.ucrChkMin.Location = New System.Drawing.Point(143, 93)
        Me.ucrChkMin.Name = "ucrChkMin"
        Me.ucrChkMin.Size = New System.Drawing.Size(70, 23)
        Me.ucrChkMin.TabIndex = 8
        '
        'ucrInputRangeFrom
        '
        Me.ucrInputRangeFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeFrom.AutoSize = True
        Me.ucrInputRangeFrom.IsMultiline = False
        Me.ucrInputRangeFrom.IsReadOnly = False
        Me.ucrInputRangeFrom.Location = New System.Drawing.Point(64, 93)
        Me.ucrInputRangeFrom.Name = "ucrInputRangeFrom"
        Me.ucrInputRangeFrom.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputRangeFrom.TabIndex = 7
        '
        'ucrInputOldValue
        '
        Me.ucrInputOldValue.AddQuotesIfUnrecognised = True
        Me.ucrInputOldValue.AutoSize = True
        Me.ucrInputOldValue.IsMultiline = False
        Me.ucrInputOldValue.IsReadOnly = False
        Me.ucrInputOldValue.Location = New System.Drawing.Point(70, 25)
        Me.ucrInputOldValue.Name = "ucrInputOldValue"
        Me.ucrInputOldValue.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputOldValue.TabIndex = 2
        '
        'ucrPnlOld
        '
        Me.ucrPnlOld.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOld.Location = New System.Drawing.Point(3, 17)
        Me.ucrPnlOld.Name = "ucrPnlOld"
        Me.ucrPnlOld.Size = New System.Drawing.Size(207, 125)
        Me.ucrPnlOld.TabIndex = 0
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.rdoNewFromAbove)
        Me.grpNew.Controls.Add(Me.rdoNewFromBelow)
        Me.grpNew.Controls.Add(Me.ucrInputNewValue)
        Me.grpNew.Controls.Add(Me.rdoNewMissing)
        Me.grpNew.Controls.Add(Me.rdoNewValue)
        Me.grpNew.Controls.Add(Me.ucrPnlNew)
        Me.grpNew.Location = New System.Drawing.Point(235, 194)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(167, 148)
        Me.grpNew.TabIndex = 4
        Me.grpNew.TabStop = False
        Me.grpNew.Tag = "New"
        Me.grpNew.Text = "New"
        '
        'rdoNewFromAbove
        '
        Me.rdoNewFromAbove.AutoSize = True
        Me.rdoNewFromAbove.Location = New System.Drawing.Point(10, 73)
        Me.rdoNewFromAbove.Name = "rdoNewFromAbove"
        Me.rdoNewFromAbove.Size = New System.Drawing.Size(112, 17)
        Me.rdoNewFromAbove.TabIndex = 4
        Me.rdoNewFromAbove.TabStop = True
        Me.rdoNewFromAbove.Text = "Value From Above"
        Me.rdoNewFromAbove.UseVisualStyleBackColor = True
        '
        'rdoNewFromBelow
        '
        Me.rdoNewFromBelow.AutoSize = True
        Me.rdoNewFromBelow.Location = New System.Drawing.Point(10, 96)
        Me.rdoNewFromBelow.Name = "rdoNewFromBelow"
        Me.rdoNewFromBelow.Size = New System.Drawing.Size(110, 17)
        Me.rdoNewFromBelow.TabIndex = 5
        Me.rdoNewFromBelow.TabStop = True
        Me.rdoNewFromBelow.Text = "Value From Below"
        Me.rdoNewFromBelow.UseVisualStyleBackColor = True
        '
        'ucrInputNewValue
        '
        Me.ucrInputNewValue.AddQuotesIfUnrecognised = True
        Me.ucrInputNewValue.AutoSize = True
        Me.ucrInputNewValue.IsMultiline = False
        Me.ucrInputNewValue.IsReadOnly = False
        Me.ucrInputNewValue.Location = New System.Drawing.Point(70, 25)
        Me.ucrInputNewValue.Name = "ucrInputNewValue"
        Me.ucrInputNewValue.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputNewValue.TabIndex = 2
        '
        'rdoNewMissing
        '
        Me.rdoNewMissing.AutoSize = True
        Me.rdoNewMissing.Location = New System.Drawing.Point(10, 50)
        Me.rdoNewMissing.Name = "rdoNewMissing"
        Me.rdoNewMissing.Size = New System.Drawing.Size(90, 17)
        Me.rdoNewMissing.TabIndex = 3
        Me.rdoNewMissing.TabStop = True
        Me.rdoNewMissing.Text = "Missing Value"
        Me.rdoNewMissing.UseVisualStyleBackColor = True
        '
        'rdoNewValue
        '
        Me.rdoNewValue.AutoSize = True
        Me.rdoNewValue.Location = New System.Drawing.Point(10, 27)
        Me.rdoNewValue.Name = "rdoNewValue"
        Me.rdoNewValue.Size = New System.Drawing.Size(52, 17)
        Me.rdoNewValue.TabIndex = 1
        Me.rdoNewValue.TabStop = True
        Me.rdoNewValue.Text = "Value"
        Me.rdoNewValue.UseVisualStyleBackColor = True
        '
        'ucrPnlNew
        '
        Me.ucrPnlNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlNew.Location = New System.Drawing.Point(2, 19)
        Me.ucrPnlNew.Name = "ucrPnlNew"
        Me.ucrPnlNew.Size = New System.Drawing.Size(159, 111)
        Me.ucrPnlNew.TabIndex = 0
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(249, 46)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(101, 13)
        Me.lblSelectedColumns.TabIndex = 1
        Me.lblSelectedColumns.Tag = "Selected_Column(s)"
        Me.lblSelectedColumns.Text = "Selected Column(s):"
        '
        'ucrReceiverReplace
        '
        Me.ucrReceiverReplace.AutoSize = True
        Me.ucrReceiverReplace.frmParent = Me
        Me.ucrReceiverReplace.Location = New System.Drawing.Point(249, 60)
        Me.ucrReceiverReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReplace.Name = "ucrReceiverReplace"
        Me.ucrReceiverReplace.Selector = Nothing
        Me.ucrReceiverReplace.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverReplace.strNcFilePath = ""
        Me.ucrReceiverReplace.TabIndex = 2
        Me.ucrReceiverReplace.ucrSelector = Nothing
        '
        'ucrSelectorReplace
        '
        Me.ucrSelectorReplace.AutoSize = True
        Me.ucrSelectorReplace.bDropUnusedFilterLevels = False
        Me.ucrSelectorReplace.bShowHiddenColumns = False
        Me.ucrSelectorReplace.bUseCurrentFilter = True
        Me.ucrSelectorReplace.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorReplace.Name = "ucrSelectorReplace"
        Me.ucrSelectorReplace.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorReplace.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 350)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'dlgReplaceValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(410, 407)
        Me.Controls.Add(Me.grpOld)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.ucrReceiverReplace)
        Me.Controls.Add(Me.ucrSelectorReplace)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReplaceValues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Replace"
        Me.Text = "Replace Values"
        Me.grpOld.ResumeLayout(False)
        Me.grpOld.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorReplace As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReplace As ucrReceiverMultiple
    Friend WithEvents grpOld As GroupBox
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents lblRangeMax As Label
    Friend WithEvents lblRangeMin As Label
    Friend WithEvents rdoOldValue As RadioButton
    Friend WithEvents rdoOldMissing As RadioButton
    Friend WithEvents rdoOldInterval As RadioButton
    Friend WithEvents ucrChkMax As ucrCheck
    Friend WithEvents ucrInputRangeTo As ucrInputTextBox
    Friend WithEvents ucrChkMin As ucrCheck
    Friend WithEvents ucrInputRangeFrom As ucrInputTextBox
    Friend WithEvents ucrInputOldValue As ucrInputTextBox
    Friend WithEvents ucrPnlOld As UcrPanel
    Friend WithEvents ucrInputNewValue As ucrInputTextBox
    Friend WithEvents rdoNewMissing As RadioButton
    Friend WithEvents rdoNewValue As RadioButton
    Friend WithEvents ucrPnlNew As UcrPanel
    Friend WithEvents rdoNewFromBelow As RadioButton
    Friend WithEvents rdoNewFromAbove As RadioButton
End Class
