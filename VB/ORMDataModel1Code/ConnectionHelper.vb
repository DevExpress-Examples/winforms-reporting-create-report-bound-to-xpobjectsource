﻿'------------------------------------------------------------------------------
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
	Public Module ConnectionHelper
		Private persistentTypes() As Type = { GetType(Categories), GetType(Products) }
		Public Function GetPersistentTypes() As Type()
			Dim copy(persistentTypes.Length - 1) As Type
			Array.Copy(persistentTypes, copy, persistentTypes.Length)
			Return copy
		End Function
		Public ReadOnly Property ConnectionString() As String
			Get
				Return System.Configuration.ConfigurationManager.ConnectionStrings("nwind").ConnectionString
			End Get
		End Property
		Public Sub Connect(ByVal autoCreateOption As DevExpress.Xpo.DB.AutoCreateOption, Optional ByVal threadSafe As Boolean = False)
			If threadSafe Then
				Dim provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption)
				Dim dictionary = New DevExpress.Xpo.Metadata.ReflectionDictionary()
				dictionary.GetDataStoreSchema(persistentTypes)
				XpoDefault.DataLayer = New ThreadSafeDataLayer(dictionary, provider)
			Else
				XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption)
			End If
			XpoDefault.Session = Nothing
		End Sub
		Public Function GetConnectionProvider(ByVal autoCreateOption As DevExpress.Xpo.DB.AutoCreateOption) As DevExpress.Xpo.DB.IDataStore
			Return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption)
		End Function
		Public Function GetConnectionProvider(ByVal autoCreateOption As DevExpress.Xpo.DB.AutoCreateOption, <System.Runtime.InteropServices.Out()> ByRef objectsToDisposeOnDisconnect() As IDisposable) As DevExpress.Xpo.DB.IDataStore
			Return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, objectsToDisposeOnDisconnect)
		End Function
		Public Function GetDataLayer(ByVal autoCreateOption As DevExpress.Xpo.DB.AutoCreateOption) As IDataLayer
			Return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption)
		End Function
	End Module

End Namespace
