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

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class SplitPage
        Inherits Global.Windows.UI.Xaml.Controls.Page

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageRoot As Global.Windows.UI.Xaml.Controls.Page
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemsViewSource As Global.Windows.UI.Xaml.Data.CollectionViewSource
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents primaryColumn As Global.Windows.UI.Xaml.Controls.ColumnDefinition
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents secondaryColumn As Global.Windows.UI.Xaml.Controls.ColumnDefinition
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents titlePanel As Global.Windows.UI.Xaml.Controls.Grid
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemListView As Global.Windows.UI.Xaml.Controls.ListView
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemDetail As Global.Windows.UI.Xaml.Controls.ScrollViewer
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemDetailGrid As Global.Windows.UI.Xaml.Controls.Grid
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemDetailTitlePanel As Global.Windows.UI.Xaml.Controls.StackPanel
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemTitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemSubtitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents backButton As Global.Windows.UI.Xaml.Controls.Button
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageTitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents ViewStates As Global.Windows.UI.Xaml.VisualStateGroup
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents PrimaryView As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents SinglePane As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents SinglePane_Detail As Global.Windows.UI.Xaml.VisualState

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///SplitPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            pageRoot = CType(Me.FindName("pageRoot"), Global.Windows.UI.Xaml.Controls.Page)
            itemsViewSource = CType(Me.FindName("itemsViewSource"), Global.Windows.UI.Xaml.Data.CollectionViewSource)
            primaryColumn = CType(Me.FindName("primaryColumn"), Global.Windows.UI.Xaml.Controls.ColumnDefinition)
            secondaryColumn = CType(Me.FindName("secondaryColumn"), Global.Windows.UI.Xaml.Controls.ColumnDefinition)
            titlePanel = CType(Me.FindName("titlePanel"), Global.Windows.UI.Xaml.Controls.Grid)
            itemListView = CType(Me.FindName("itemListView"), Global.Windows.UI.Xaml.Controls.ListView)
            itemDetail = CType(Me.FindName("itemDetail"), Global.Windows.UI.Xaml.Controls.ScrollViewer)
            itemDetailGrid = CType(Me.FindName("itemDetailGrid"), Global.Windows.UI.Xaml.Controls.Grid)
            itemDetailTitlePanel = CType(Me.FindName("itemDetailTitlePanel"), Global.Windows.UI.Xaml.Controls.StackPanel)
            itemTitle = CType(Me.FindName("itemTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            itemSubtitle = CType(Me.FindName("itemSubtitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            backButton = CType(Me.FindName("backButton"), Global.Windows.UI.Xaml.Controls.Button)
            pageTitle = CType(Me.FindName("pageTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            ViewStates = CType(Me.FindName("ViewStates"), Global.Windows.UI.Xaml.VisualStateGroup)
            PrimaryView = CType(Me.FindName("PrimaryView"), Global.Windows.UI.Xaml.VisualState)
            SinglePane = CType(Me.FindName("SinglePane"), Global.Windows.UI.Xaml.VisualState)
            SinglePane_Detail = CType(Me.FindName("SinglePane_Detail"), Global.Windows.UI.Xaml.VisualState)
        End Sub
    End Class

End Namespace


