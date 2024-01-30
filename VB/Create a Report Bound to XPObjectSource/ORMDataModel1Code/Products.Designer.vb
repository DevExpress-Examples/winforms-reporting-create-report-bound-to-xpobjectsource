'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection

Namespace Create_a_Report_Bound_to_XPObjectSource.nwind

    Public Partial Class Products
        Inherits DevExpress.Xpo.XPLiteObject

        Private fCategoryID As Create_a_Report_Bound_to_XPObjectSource.nwind.Categories

        <DevExpress.Xpo.AssociationAttribute("ProductsReferencesCategories")>
        Public Property CategoryID As Categories
            Get
                Return Me.fCategoryID
            End Get

            Set(ByVal value As Categories)
                Call SetPropertyValue(Of Create_a_Report_Bound_to_XPObjectSource.nwind.Categories)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.CategoryID), Me.fCategoryID, value)
            End Set
        End Property

        Private fDiscontinued As Boolean

        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("=No")>
        Public Property Discontinued As Boolean
            Get
                Return Me.fDiscontinued
            End Get

            Set(ByVal value As Boolean)
                Call SetPropertyValue(Of Boolean)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.Discontinued), Me.fDiscontinued, value)
            End Set
        End Property

        Private fEAN13 As String

        <DevExpress.Xpo.SizeAttribute(12)>
        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("0")>
        Public Property EAN13 As String
            Get
                Return Me.fEAN13
            End Get

            Set(ByVal value As String)
                Call SetPropertyValue(Of String)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.EAN13), Me.fEAN13, value)
            End Set
        End Property

        Private fProductID As Integer

        <DevExpress.Xpo.KeyAttribute(True)>
        Public Property ProductID As Integer
            Get
                Return Me.fProductID
            End Get

            Set(ByVal value As Integer)
                Call SetPropertyValue(Of Integer)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.ProductID), Me.fProductID, value)
            End Set
        End Property

        Private fProductName As String

        <DevExpress.Xpo.IndexedAttribute(Name:="ProductName")>
        <DevExpress.Xpo.SizeAttribute(40)>
        Public Property ProductName As String
            Get
                Return Me.fProductName
            End Get

            Set(ByVal value As String)
                Call SetPropertyValue(Of String)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.ProductName), Me.fProductName, value)
            End Set
        End Property

        Private fQuantityPerUnit As String

        <DevExpress.Xpo.SizeAttribute(20)>
        Public Property QuantityPerUnit As String
            Get
                Return Me.fQuantityPerUnit
            End Get

            Set(ByVal value As String)
                Call SetPropertyValue(Of String)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.QuantityPerUnit), Me.fQuantityPerUnit, value)
            End Set
        End Property

        Private fReorderLevel As Short

        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("0")>
        Public Property ReorderLevel As Short
            Get
                Return Me.fReorderLevel
            End Get

            Set(ByVal value As Short)
                Call SetPropertyValue(Of Short)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.ReorderLevel), Me.fReorderLevel, value)
            End Set
        End Property

        Private fSupplierID As Integer

        <DevExpress.Xpo.IndexedAttribute(Name:="SupplierID")>
        Public Property SupplierID As Integer
            Get
                Return Me.fSupplierID
            End Get

            Set(ByVal value As Integer)
                Call SetPropertyValue(Of Integer)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.SupplierID), Me.fSupplierID, value)
            End Set
        End Property

        Private fUnitPrice As Decimal

        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("0")>
        Public Property UnitPrice As Decimal
            Get
                Return Me.fUnitPrice
            End Get

            Set(ByVal value As Decimal)
                Call SetPropertyValue(Of Decimal)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.UnitPrice), Me.fUnitPrice, value)
            End Set
        End Property

        Private fUnitsInStock As Short

        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("0")>
        Public Property UnitsInStock As Short
            Get
                Return Me.fUnitsInStock
            End Get

            Set(ByVal value As Short)
                Call SetPropertyValue(Of Short)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.UnitsInStock), Me.fUnitsInStock, value)
            End Set
        End Property

        Private fUnitsOnOrder As Short

        <DevExpress.Xpo.ColumnDbDefaultValueAttribute("0")>
        Public Property UnitsOnOrder As Short
            Get
                Return Me.fUnitsOnOrder
            End Get

            Set(ByVal value As Short)
                Call SetPropertyValue(Of Short)(NameOf(Create_a_Report_Bound_to_XPObjectSource.nwind.Products.UnitsOnOrder), Me.fUnitsOnOrder, value)
            End Set
        End Property
    End Class
End Namespace