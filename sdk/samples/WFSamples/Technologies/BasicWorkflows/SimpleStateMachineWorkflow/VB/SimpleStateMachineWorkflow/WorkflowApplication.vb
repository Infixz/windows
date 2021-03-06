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
Imports System.Threading
Imports System.Workflow.Runtime

Class WorkflowApplication
    'A workflow is always run asychronously; the main thread waits on this event so the program
    ' doesn't exit before the workflow completes
    Shared WaitHandle As New AutoResetEvent(False)

    Shared Sub Main()
        ' Create the WorkflowRuntime
        Using currentWorkflowRuntime As WorkflowRuntime = New WorkflowRuntime()
            Try
                currentWorkflowRuntime.StartRuntime()

                ' Listen for the workflow events
                AddHandler currentWorkflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
                AddHandler currentWorkflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

                ' Load the workflow type
                Dim type As System.Type = GetType(StateMachineWorkflow)
                ' Create an instance of the workflow
                currentWorkflowRuntime.CreateWorkflow(type).Start()

                Console.WriteLine("Running the workflow. Waiting for the timer events...")

                ' Wait for the event to be signaled
                WaitHandle.WaitOne()
            Catch e As Exception
                Console.WriteLine("Encountered an exception. Exception Source: {0}, Exception Message: {1} ", e.Source, e.Message)
            Finally
                If currentWorkflowRuntime IsNot Nothing Then
                    currentWorkflowRuntime.StopRuntime()
                End If
                Console.WriteLine("Done running the workflow.")
            End Try
        End Using
    End Sub

    Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
        WaitHandle.Set()
    End Sub

    Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
        Console.WriteLine(e.Exception.Message)
        WaitHandle.Set()
    End Sub
End Class

