﻿

#ExternalChecksum("c:\users\ltdesigns\documents\visual studio 2015\Projects\CIS160BeachCondoTake2\CIS160BeachCondoTake2\SplitPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "D4FBEE3A862D69F929E531EDA25A5926")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.CIS160BeachCondoTake2

    Partial Class SplitPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            If(connectionId = 1) Then
                #ExternalSource("..\..\SplitPage.xaml",72)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.Selector).SelectionChanged, AddressOf Me.ItemListView_SelectionChanged
                #End ExternalSource
            End If
            Me._contentLoaded = true
        End Sub
    End Class

End Namespace


