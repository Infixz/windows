'---------------------------------------------------------------------
'  This file is part of the Windows Workflow Foundation SDK Code Samples.
' 
'  Copyright (C) Microsoft Corporation.  All rights reserved.
' 
'This source code is intended only as a supplement to Microsoft
'Development Tools and/or on-line documentation.  See these other
'materials for detailed information regarding Microsoft code samples.
' 
'THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
'KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'PARTICULAR PURPOSE.
'---------------------------------------------------------------------

Imports System
Imports System.Workflow.Activities

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SimpleReplicatorWorkflow

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activityBind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Me.replicator1 = New System.Workflow.Activities.ReplicatorActivity
        Me.sampleReplicatorChildActivity1 = New SampleReplicatorChildActivity
        '
        'replicator1
        '
        Me.replicator1.Activities.Add(Me.sampleReplicatorChildActivity1)
        Me.replicator1.Name = "replicator1"
        Me.replicator1.UntilCondition = Nothing
        AddHandler Me.replicator1.ChildInitialized, AddressOf Me.ChildInitializer
        Me.replicator1.SetBinding(System.Workflow.Activities.ReplicatorActivity.InitialChildDataProperty, CType(activityBind1, System.Workflow.ComponentModel.ActivityBind))
        '
        'sampleReplicatorChildActivity1
        '
        Me.sampleReplicatorChildActivity1.Name = "sampleReplicatorChildActivity1"
        Me.sampleReplicatorChildActivity1.InstanceData = Nothing
        activityBind1.Name = "SimpleReplicatorWorkflow"
        activityBind1.Path = "ChildData"
        '
        'SimpleReplicatorWorkflow
        '
        Me.Activities.Add(Me.replicator1)
        Me.Name = "SimpleReplicatorWorkflow"
        Me.CanModifyActivities = False
    End Sub
    Private WithEvents sampleReplicatorChildActivity1 As SampleReplicatorChildActivity
    Private WithEvents replicator1 As System.Workflow.Activities.ReplicatorActivity

End Class