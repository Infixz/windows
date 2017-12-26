﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("037f8de0-b3ef-4738-aee1-a379c88c1c40")>

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class ComplexTypeEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new ComplexTypeEntities object using the connection string found in the 'ComplexTypeEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=ComplexTypeEntities", "ComplexTypeEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new ComplexTypeEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "ComplexTypeEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new ComplexTypeEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "ComplexTypeEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property People() As ObjectSet(Of Person)
        Get
            If (_People Is Nothing) Then
                _People = MyBase.CreateObjectSet(Of Person)("People")
            End If
            Return _People
        End Get
    End Property

    Private _People As ObjectSet(Of Person)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToPeople(ByVal person As Person)
        MyBase.AddObject("People", person)
    End Sub

    #End Region
    #Region "Function Imports"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    ''' <param name="personID">No Metadata Documentation available.</param>
    Public Function GetPersonNameByPersonID(personID As Nullable(Of Global.System.Int32)) As ObjectResult(Of PersonName)
        Dim personIDParameter As ObjectParameter
        If (personID.HasValue)
            personIDParameter = New ObjectParameter("PersonID", personID)
        Else
            personIDParameter = New ObjectParameter("PersonID", GetType(Global.System.Int32))
        End If

        Return MyBase.ExecuteFunction(Of PersonName)("GetPersonNameByPersonID", personIDParameter)

    End Function

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="ComplexTypeModel", Name:="Person")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Person
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Person object.
    ''' </summary>
    ''' <param name="personID">Initial value of the PersonID property.</param>
    ''' <param name="lastName">Initial value of the LastName property.</param>
    ''' <param name="firstName">Initial value of the FirstName property.</param>
    ''' <param name="personCategory">Initial value of the PersonCategory property.</param>
    ''' <param name="personDate">Initial value of the PersonDate property.</param>
    ''' <param name="personAddress">Initial value of the PersonAddress property.</param>
    Public Shared Function CreatePerson(personID As Global.System.Int32, lastName As Global.System.String, firstName As Global.System.String, personCategory As Global.System.Int16, personDate As PersonDate, personAddress As PersonAddress) As Person
        Dim person as Person = New Person
        person.PersonID = personID
        person.LastName = lastName
        person.FirstName = firstName
        person.PersonCategory = personCategory
        person.PersonDate = StructuralObject.VerifyComplexObjectIsNotNull(personDate, "PersonDate")
        person.PersonAddress = StructuralObject.VerifyComplexObjectIsNotNull(personAddress, "PersonAddress")
        Return person
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property PersonID() As Global.System.Int32
        Get
            Return _PersonID
        End Get
        Set
            If (_PersonID <> Value) Then
                OnPersonIDChanging(value)
                ReportPropertyChanging("PersonID")
                _PersonID = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("PersonID")
                OnPersonIDChanged()
            End If
        End Set
    End Property

    Private _PersonID As Global.System.Int32
    Private Partial Sub OnPersonIDChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnPersonIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property LastName() As Global.System.String
        Get
            Return _LastName
        End Get
        Set
            OnLastNameChanging(value)
            ReportPropertyChanging("LastName")
            _LastName = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("LastName")
            OnLastNameChanged()
        End Set
    End Property

    Private _LastName As Global.System.String
    Private Partial Sub OnLastNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnLastNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property FirstName() As Global.System.String
        Get
            Return _FirstName
        End Get
        Set
            OnFirstNameChanging(value)
            ReportPropertyChanging("FirstName")
            _FirstName = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("FirstName")
            OnFirstNameChanged()
        End Set
    End Property

    Private _FirstName As Global.System.String
    Private Partial Sub OnFirstNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnFirstNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property PersonCategory() As Global.System.Int16
        Get
            Return _PersonCategory
        End Get
        Set
            OnPersonCategoryChanging(value)
            ReportPropertyChanging("PersonCategory")
            _PersonCategory = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("PersonCategory")
            OnPersonCategoryChanged()
        End Set
    End Property

    Private _PersonCategory As Global.System.Int16
    Private Partial Sub OnPersonCategoryChanging(value As Global.System.Int16)
    End Sub

    Private Partial Sub OnPersonCategoryChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Picture() As Global.System.Byte()
        Get
                Return StructuralObject.GetValidValue(_Picture)
        End Get
        Set
            OnPictureChanging(value)
            ReportPropertyChanging("Picture")
            _Picture = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Picture")
            OnPictureChanged()
        End Set
    End Property

    Private _Picture As Global.System.Byte()
    Private Partial Sub OnPictureChanging(value As Global.System.Byte())
    End Sub

    Private Partial Sub OnPictureChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property BusinessCredits() As Global.System.String
        Get
            Return _BusinessCredits
        End Get
        Set
            OnBusinessCreditsChanging(value)
            ReportPropertyChanging("BusinessCredits")
            _BusinessCredits = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("BusinessCredits")
            OnBusinessCreditsChanged()
        End Set
    End Property

    Private _BusinessCredits As Global.System.String
    Private Partial Sub OnBusinessCreditsChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnBusinessCreditsChanged()
    End Sub

    #End Region
    #Region "Complex Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmComplexPropertyAttribute()>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <XmlElement(IsNullable:=True)>
    <SoapElement(IsNullable:=True)>
    <DataMemberAttribute()>
    Public Property PersonDate() As PersonDate
        Get
            _PersonDate = GetValidValue(_PersonDate, "PersonDate", False, _PersonDateInitialized)
            _PersonDateInitialized = True
            Return _PersonDate
        End Get
        Set
            OnPersonDateChanging(value)
            ReportPropertyChanging("PersonDate")
            _PersonDate = SetValidValue(_PersonDate, value, "PersonDate")
            _PersonDateInitialized = True
            ReportPropertyChanged("PersonDate")
            OnPersonDateChanged()
        End Set
    End Property

    Private _PersonDate As PersonDate

    Private _PersonDateInitialized As Boolean

    Private Partial Sub OnPersonDateChanging(value As PersonDate)
    End Sub

    Private Partial Sub OnPersonDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmComplexPropertyAttribute()>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <XmlElement(IsNullable:=True)>
    <SoapElement(IsNullable:=True)>
    <DataMemberAttribute()>
    Public Property PersonAddress() As PersonAddress
        Get
            _PersonAddress = GetValidValue(_PersonAddress, "PersonAddress", False, _PersonAddressInitialized)
            _PersonAddressInitialized = True
            Return _PersonAddress
        End Get
        Set
            OnPersonAddressChanging(value)
            ReportPropertyChanging("PersonAddress")
            _PersonAddress = SetValidValue(_PersonAddress, value, "PersonAddress")
            _PersonAddressInitialized = True
            ReportPropertyChanged("PersonAddress")
            OnPersonAddressChanged()
        End Set
    End Property

    Private _PersonAddress As PersonAddress

    Private _PersonAddressInitialized As Boolean

    Private Partial Sub OnPersonAddressChanging(value As PersonAddress)
    End Sub

    Private Partial Sub OnPersonAddressChanged()
    End Sub

    #End Region
End Class

#End Region
#Region "ComplexTypes"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmComplexTypeAttribute(NamespaceName:="ComplexTypeModel", Name:="PersonAddress")>
<DataContractAttribute(IsReference:=True)>
<Serializable()>
Public Partial Class PersonAddress
    Inherits ComplexObject
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Address() As Global.System.String
        Get
            Return _Address
        End Get
        Set
            OnAddressChanging(value)
            ReportPropertyChanging("Address")
            _Address = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Address")
            OnAddressChanged()
        End Set
    End Property

    Private _Address As Global.System.String
    Private Partial Sub OnAddressChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnAddressChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Postcode() As Global.System.String
        Get
            Return _Postcode
        End Get
        Set
            OnPostcodeChanging(value)
            ReportPropertyChanging("Postcode")
            _Postcode = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Postcode")
            OnPostcodeChanged()
        End Set
    End Property

    Private _Postcode As Global.System.String
    Private Partial Sub OnPostcodeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnPostcodeChanged()
    End Sub

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmComplexTypeAttribute(NamespaceName:="ComplexTypeModel", Name:="PersonDate")>
<DataContractAttribute(IsReference:=True)>
<Serializable()>
Public Partial Class PersonDate
    Inherits ComplexObject
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property HireDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _HireDate
        End Get
        Set
            OnHireDateChanging(value)
            ReportPropertyChanging("HireDate")
            _HireDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("HireDate")
            OnHireDateChanged()
        End Set
    End Property

    Private _HireDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnHireDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnHireDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property EnrollmentDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _EnrollmentDate
        End Get
        Set
            OnEnrollmentDateChanging(value)
            ReportPropertyChanging("EnrollmentDate")
            _EnrollmentDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("EnrollmentDate")
            OnEnrollmentDateChanged()
        End Set
    End Property

    Private _EnrollmentDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnEnrollmentDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnEnrollmentDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property AdminDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _AdminDate
        End Get
        Set
            OnAdminDateChanging(value)
            ReportPropertyChanging("AdminDate")
            _AdminDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("AdminDate")
            OnAdminDateChanged()
        End Set
    End Property

    Private _AdminDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnAdminDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnAdminDateChanged()
    End Sub

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmComplexTypeAttribute(NamespaceName:="ComplexTypeModel", Name:="PersonName")>
<DataContractAttribute(IsReference:=True)>
<Serializable()>
Public Partial Class PersonName
    Inherits ComplexObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new PersonName object.
    ''' </summary>
    ''' <param name="firstName">Initial value of the FirstName property.</param>
    ''' <param name="lastName">Initial value of the LastName property.</param>
    Public Shared Function CreatePersonName(firstName As Global.System.String, lastName As Global.System.String) As PersonName
        Dim personName as PersonName = New PersonName
        personName.FirstName = firstName
        personName.LastName = lastName
        Return personName
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property FirstName() As Global.System.String
        Get
            Return _FirstName
        End Get
        Set
            OnFirstNameChanging(value)
            ReportPropertyChanging("FirstName")
            _FirstName = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("FirstName")
            OnFirstNameChanged()
        End Set
    End Property

    Private _FirstName As Global.System.String
    Private Partial Sub OnFirstNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnFirstNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property LastName() As Global.System.String
        Get
            Return _LastName
        End Get
        Set
            OnLastNameChanging(value)
            ReportPropertyChanging("LastName")
            _LastName = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("LastName")
            OnLastNameChanged()
        End Set
    End Property

    Private _LastName As Global.System.String
    Private Partial Sub OnLastNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnLastNameChanged()
    End Sub

    #End Region
End Class

#End Region
