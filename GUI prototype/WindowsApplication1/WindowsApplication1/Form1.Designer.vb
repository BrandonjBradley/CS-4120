<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.component = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeTacPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tierPlayback = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ideRes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ideSelect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nextLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pref2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pref1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ideWin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearTosDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vmlDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.das = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t3Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateT2Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tier2Loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateT1Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tier1Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tier1Loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearsSinceGrad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.callSign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WONumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(915, 597)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Map View"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(915, 597)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Result"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(915, 597)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Import "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(6, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 567)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WONumber, Me.p_class, Me.rank, Me.callSign, Me.yearGroup, Me.yearsSinceGrad, Me.tier1Loc, Me.tier1Comp, Me.dateT1Comp, Me.tier2Loc, Me.dateT2Comp, Me.t3Comp, Me.currLoc, Me.unit, Me.das, Me.vmlDate, Me.yearTosDate, Me.deros, Me.ideWin, Me.pref1, Me.pref2, Me.nextLoc, Me.movDate, Me.ideSelect, Me.ideRes, Me.asg, Me.tierPlayback, Me.timeTacPos, Me.component})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(908, 567)
        Me.DataGridView1.TabIndex = 1
        '
        'component
        '
        Me.component.HeaderText = "Component"
        Me.component.Name = "component"
        Me.component.ReadOnly = True
        '
        'timeTacPos
        '
        Me.timeTacPos.HeaderText = "Time Tactics Position"
        Me.timeTacPos.Name = "timeTacPos"
        Me.timeTacPos.ReadOnly = True
        '
        'tierPlayback
        '
        Me.tierPlayback.HeaderText = "Tier I/ II Payback"
        Me.tierPlayback.Name = "tierPlayback"
        Me.tierPlayback.ReadOnly = True
        '
        'asg
        '
        Me.asg.HeaderText = "ASG"
        Me.asg.Name = "asg"
        Me.asg.ReadOnly = True
        '
        'ideRes
        '
        Me.ideRes.HeaderText = "IDE Res"
        Me.ideRes.Name = "ideRes"
        Me.ideRes.ReadOnly = True
        '
        'ideSelect
        '
        Me.ideSelect.HeaderText = "IDE Select?"
        Me.ideSelect.Name = "ideSelect"
        Me.ideSelect.ReadOnly = True
        '
        'movDate
        '
        Me.movDate.HeaderText = "Move Date"
        Me.movDate.Name = "movDate"
        Me.movDate.ReadOnly = True
        '
        'nextLoc
        '
        Me.nextLoc.HeaderText = "Next Location"
        Me.nextLoc.Name = "nextLoc"
        Me.nextLoc.ReadOnly = True
        '
        'pref2
        '
        Me.pref2.HeaderText = "Perference #2"
        Me.pref2.Name = "pref2"
        Me.pref2.ReadOnly = True
        '
        'pref1
        '
        Me.pref1.HeaderText = "Preference #1"
        Me.pref1.Name = "pref1"
        Me.pref1.ReadOnly = True
        '
        'ideWin
        '
        Me.ideWin.HeaderText = "IDE Window"
        Me.ideWin.Name = "ideWin"
        Me.ideWin.ReadOnly = True
        '
        'deros
        '
        Me.deros.HeaderText = "DEROS?"
        Me.deros.Name = "deros"
        Me.deros.ReadOnly = True
        '
        'yearTosDate
        '
        Me.yearTosDate.HeaderText = "2 year TOS Date"
        Me.yearTosDate.Name = "yearTosDate"
        Me.yearTosDate.ReadOnly = True
        '
        'vmlDate
        '
        Me.vmlDate.HeaderText = "VML Date"
        Me.vmlDate.Name = "vmlDate"
        Me.vmlDate.ReadOnly = True
        '
        'das
        '
        Me.das.HeaderText = "DAS"
        Me.das.Name = "das"
        Me.das.ReadOnly = True
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'currLoc
        '
        Me.currLoc.HeaderText = "Current Location"
        Me.currLoc.Name = "currLoc"
        Me.currLoc.ReadOnly = True
        '
        't3Comp
        '
        Me.t3Comp.HeaderText = "Tier 3 Complete"
        Me.t3Comp.Name = "t3Comp"
        Me.t3Comp.ReadOnly = True
        '
        'dateT2Comp
        '
        Me.dateT2Comp.HeaderText = "Date Tier 2 Complete"
        Me.dateT2Comp.Name = "dateT2Comp"
        Me.dateT2Comp.ReadOnly = True
        '
        'tier2Loc
        '
        Me.tier2Loc.HeaderText = "Tier 2 Location"
        Me.tier2Loc.Name = "tier2Loc"
        Me.tier2Loc.ReadOnly = True
        '
        'dateT1Comp
        '
        Me.dateT1Comp.HeaderText = "Date Tier 1 Complete"
        Me.dateT1Comp.Name = "dateT1Comp"
        Me.dateT1Comp.ReadOnly = True
        '
        'tier1Comp
        '
        Me.tier1Comp.HeaderText = "Tier 1 Complete"
        Me.tier1Comp.Name = "tier1Comp"
        Me.tier1Comp.ReadOnly = True
        '
        'tier1Loc
        '
        Me.tier1Loc.HeaderText = "Tier 1 Location"
        Me.tier1Loc.Name = "tier1Loc"
        Me.tier1Loc.ReadOnly = True
        '
        'yearsSinceGrad
        '
        Me.yearsSinceGrad.HeaderText = "Years Since Graduation"
        Me.yearsSinceGrad.Name = "yearsSinceGrad"
        Me.yearsSinceGrad.ReadOnly = True
        '
        'yearGroup
        '
        Me.yearGroup.HeaderText = "Year Group"
        Me.yearGroup.Name = "yearGroup"
        Me.yearGroup.ReadOnly = True
        '
        'callSign
        '
        Me.callSign.HeaderText = "Call Sign"
        Me.callSign.Name = "callSign"
        Me.callSign.ReadOnly = True
        '
        'rank
        '
        Me.rank.HeaderText = "Rank"
        Me.rank.Name = "rank"
        Me.rank.ReadOnly = True
        '
        'p_class
        '
        Me.p_class.HeaderText = "Closs"
        Me.p_class.Name = "p_class"
        Me.p_class.ReadOnly = True
        '
        'WONumber
        '
        Me.WONumber.HeaderText = "WO#"
        Me.WONumber.Name = "WONumber"
        Me.WONumber.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Run (Assign)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 623)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 623)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Job Assigning Tool Prototype"
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents WONumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_class As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents callSign As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearsSinceGrad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tier1Loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tier1Comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateT1Comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tier2Loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateT2Comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t3Comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currLoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents das As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vmlDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearTosDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ideWin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pref1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pref2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nextLoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents movDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ideSelect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ideRes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tierPlayback As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timeTacPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents component As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

End Class
